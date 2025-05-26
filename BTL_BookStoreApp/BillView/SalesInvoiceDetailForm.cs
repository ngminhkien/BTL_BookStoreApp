using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;



namespace BTL_BookStoreApp.BillView
{
    public partial class SalesInvoiceDetailForm : Form
    {
        public SalesInvoice? SelectedSalesInvoice { get; set; } = null;
        private SalesInvoiceDetail? _selectedSalesInvoiceDetail = null;
        CabinetService<SalesInvoiceDetail> _service = new();
        CabinetService<SalesInvoice> _sService = new();
        CabinetService<Customer> _cService = new();
        public int flag = 0;
        //tạo list để chứa các cuốn sách dùng để thêm vào dgv, BindlingList là list giúp lưu trữ 2 chiều với dgv
        BindingList<SalesInvoiceDetail> arr = new BindingList<SalesInvoiceDetail>();

        public SalesInvoiceDetailForm()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvBooksInfoDetails.DataSource = null;
            if (arr.Any()) // chỉ gán nếu có dữ liệu
            {
                dgvBooksInfoDetails.DataSource = arr;
                //để cho dgv ko tự động thêm dòng trống
                dgvBooksInfoDetails.AllowUserToAddRows = false;
                // Đặt toàn bộ các cột là chỉ đọc
                foreach (DataGridViewColumn col in dgvBooksInfoDetails.Columns)
                {
                    col.ReadOnly = true;
                }
                if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                {
                    dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = false;
                }
            }
        }

        private void SalesInvoiceDetailForm_Load(object sender, EventArgs e)
        {
            BoxHelper comboBox = new();
            txtInvoiceId.Enabled = false;
            mtbInvoiceDate.Enabled = false;
            //đổ dữ liệu vào comboBox
            cboEmployeeID.DataSource = new CabinetService<Employee>().GetAll();
            cboEmployeeID.DisplayMember = "EmployeeId"; // hoặc e => e.EmployeeName nếu muốn hiển thị tên
            cboEmployeeID.ValueMember = "EmployeeId";
            cboEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList;

            cboEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList;
            FillDataGridView();
            if (flag == 0)
            {
                lblHeader.Text = "Create a Sales Invoice...";
                lblReport.Text = "Nhập vào ô Quantity để chỉnh số lượng";
                lblTotal.Visible = false;
                txtTotal.Visible = false;
                if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                    dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = false;
                //tạo khóa tự động
                Mytoys mytoys = new Mytoys();
                List<int> list = new CabinetService<SalesInvoice>().GetAll().Select(a => a.InvoiceId).ToList();
                txtInvoiceId.Text = mytoys.GenerateNextInteger(list, false).ToString();
                //lấy ngày tự động
                mtbInvoiceDate.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                return;
            }

            // ~ flag = 2
            lblHeader.Text = "Update a Sales Invoice...";
            lblReport.Text = "Nhập vào ô Quantity để chỉnh số lượng, mỗi loại mua tồi đa 10 cuốn";
            if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = false;

            cboEmployeeID.SelectedValue = SelectedSalesInvoice?.EmployeeId;
            txtInvoiceId.Text = SelectedSalesInvoice?.InvoiceId.ToString();
            txtNote.Text = SelectedSalesInvoice?.Note;
            txtTotal.Text = SelectedSalesInvoice?.TotalAmount.ToString();
            mtbInvoiceDate.Text = SelectedSalesInvoice?.InvoiceDate?.ToString("MM/dd/yyyy HH:mm") ?? "";
            //xử lí 
            Customer customer = new Customer();
            customer = _cService.GetAll().FirstOrDefault(a => a.CustomerId == SelectedSalesInvoice?.CustomerId) ?? new Customer();
            mtbPhone.Text = customer.Phone;
            //đổ dữ liệu vào arr trc để đồng bộ tránh gặp phải khi update
            //int id = SelectedSalesInvoice.InvoiceId;
            arr = new BindingList<SalesInvoiceDetail>(_service.GetAll().Where(a => a.InvoiceId == SelectedSalesInvoice?.InvoiceId).ToList());
            FillDataGridView(); // Gán lại dgvBooksInfoDetails.DataSource = arr;
            if (flag == 1)
            {
                //đổ dữ liệu vào các ô text
                lblHeader.Text = "Info a Sales Invoice...";
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                cboEmployeeID.Enabled = false;
                txtInvoiceId.ReadOnly = true;
                mtbPhone.ReadOnly = true;
                mtbInvoiceDate.ReadOnly = true;
                txtNote.ReadOnly = true;

                if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                {
                    dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = true;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookManagerMainUI f = new BookManagerMainUI();
            SalesInvoiceDetail i = new();
            // Mở form dạng hộp thoại để chờ chọn xong
            f.flag = 1;
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Repositories.Entities.Book selectedBook = f._selectedABook;
                i.BookId = f._selectedABook.BookId;
                i.Quantity = 1;
                i.InvoiceId = int.Parse(txtInvoiceId.Text);
                // TODO: dùng selectedBook theo nhu cầu (thêm vào danh sách, gán vào textbox...)
                arr.Add(i);
            }
            FillDataGridView();
        }

        private void dgvBooksInfoDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvBooksInfoDetails.Columns[e.ColumnIndex].Name == "Quantity")
            {
                //e.FormattedValue là lấy ra giá trị người dụng nhập vào
                if (!int.TryParse(e.FormattedValue.ToString(), out int inputQuantity))
                {
                    MessageBox.Show("Input a integer!!");
                    e.Cancel = true;
                    return;
                }

                if (inputQuantity < 1)
                {
                    MessageBox.Show("Input a number > 0, please!");
                    e.Cancel = true;
                    return;
                }
                // Lấy BookId từ dòng hiện tại
                var bookIdObj = dgvBooksInfoDetails.Rows[e.RowIndex].Cells["BookId"].Value;
                if (bookIdObj == null)
                {
                    MessageBox.Show("Don't find book id!");
                    e.Cancel = true;
                    return;
                }

                string bookId = bookIdObj.ToString();

                // Tìm số lượng hiện có của sách từ danh sách books
                var book = new CabinetService<Repositories.Entities.Book>().GetAll().FirstOrDefault(b => b.BookId == bookId);
                if (book == null)
                {
                    MessageBox.Show("The book having this id is not found in system");
                    e.Cancel = true;
                    return;
                }

                if (inputQuantity > book.Quantity)
                {
                    MessageBox.Show($"Quantity > quantity in stock which is ({book.Quantity})!");
                    e.Cancel = true;
                }

            }
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (!BoxHelper.ValidatePhone(mtbPhone))
            {
                return;
            }
            //tìm xem đã tồn tại số điện thoại này hay chưa
            var filteredCustomers = _cService.GetAll().Where(c => !string.IsNullOrEmpty(c.Phone) && c.Phone.Contains(mtbPhone.Text.Replace(".", ""))).ToList();

            if (filteredCustomers.Count == 0)
            {
                CustomerDetailForm f = new CustomerDetailForm();
                if (MessageBox.Show("Do you want add new customer??", "This phonenumber does not exits yet!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    f.NewPhone = mtbPhone.Text.Replace(".", "");
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        mtbPhone.Text = f.NewPhone;
                    }
                    mtbPhone.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //lấy id customer từ số điện thoại
            var c = _cService.GetAll().FirstOrDefault(c => c.Phone == mtbPhone.Text.Replace(".", ""));

            if (c != null)
            {
                if (SelectedSalesInvoice == null)
                    SelectedSalesInvoice = new SalesInvoice();

                SelectedSalesInvoice.CustomerId = c.CustomerId;
            }
            else
            {
                MessageBox.Show("This phonenumber does not exits yet!!!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }
            if (arr.Count == 0)
            {
                MessageBox.Show("Please add more books", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tính tổng tiền và hiển thị xác nhận
            CabinetService<Repositories.Entities.Book> _bookService = new();
            var books = _bookService.GetAll();
            double? total = 0;
            StringBuilder details = new StringBuilder();
            details.AppendLine("Chi tiết hóa đơn:");
            details.AppendLine("------------------------------------");

            foreach (var item in arr)
            {
                var book = books.FirstOrDefault(b => b.BookId == item.BookId);
                if (book != null)
                {
                    double price = book.SelltPrince;
                    int? quantity = item.Quantity;
                    double? itemTotal = price * quantity;
                    total += itemTotal;


                    details.AppendLine($"- {book.BookName} | SL: {item.Quantity} | Giá: {price:#,##0} VND | Thành tiền: {itemTotal:#,##0} VND");
                }
            }

            details.AppendLine("------------------------------------");
            details.AppendLine($"\nTổng cộng: {total:#,##0} VND");

            DialogResult result = MessageBox.Show(details.ToString(), "Confirm invoice infomation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
                return;

            //lưu hóa đơn bán trước vì đây là khóa để thêm hóa đơn chi tiết
            SalesInvoice salesInvoice = new SalesInvoice()
            {
                EmployeeId = cboEmployeeID.Text,
                CustomerId = SelectedSalesInvoice.CustomerId,
                InvoiceDate = BoxHelper.ParseFromMaskedTextBox(mtbInvoiceDate).Value,
                Note = txtNote.Text,
                TotalAmount = total ?? 0,
            };
            if (flag == 0)
                _sService.Add(salesInvoice);
            else
            {
                salesInvoice.InvoiceId = int.Parse(txtInvoiceId.Text); // nếu sửa thì phải gán ID cũ
                _sService.Update(salesInvoice);
            }
            //lưu dữ liệu từ arr (từ datadrid view)
            // Gán InvoiceId mới cho các dòng chi tiết
            foreach (var item in arr)
            {
                item.InvoiceId = salesInvoice.InvoiceId; // CẬP NHẬT LẠI InvoiceId từ EF
            }
            try
            {
                foreach (var item in arr)
                {
                    // Kiểm tra xem item đã tồn tại hay chưa, ví dụ dựa vào khóa chính
                    var exists = _service.GetAll().Any(x =>
                        x.InvoiceId == item.InvoiceId && x.BookId == item.BookId);

                    if (!exists)
                    {
                        _service.Add(item); // Nếu chưa tồn tại thì thêm mới
                    }
                    else
                    {
                        _service.Update(item); // Nếu đã có thì cập nhật lại
                    }
                }

                DialogResult print = MessageBox.Show("Print invoice to excel", "Excel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (print == DialogResult.OK)
                    PrintToExcel(salesInvoice);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message +
                    "\nInner: " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //tính tổng tiền và ghi ra dialog

        }

        private void PrintToExcel(SalesInvoice x)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // 1. Khởi tạo Excel và workbook
                excelApp = new Excel.Application();
                excelApp.Visible = false; // tránh lỗi khi chưa sẵn sàng

                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Sales Invoice";

                int row = 1;

                // 2. Tiêu đề
                worksheet.Cells[row++, 1] = "SALES INVOICE";
                Excel.Range titleRange = worksheet.Range["A1", "F1"];
                titleRange.Merge();
                titleRange.Font.Size = 16;
                titleRange.Font.Bold = true;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                row++;

                // 3. Thông tin hóa đơn
                worksheet.Cells[row++, 1] = $"Invoice ID: {txtInvoiceId.Text}";
                worksheet.Cells[row++, 1] = $"Employee ID: {cboEmployeeID.Text}";
                worksheet.Cells[row++, 1] = $"Phone: {mtbPhone.Text}";
                worksheet.Cells[row++, 1] = $"Invoice Date: {mtbInvoiceDate.Text}";
                worksheet.Cells[row++, 1] = $"Note: {txtNote.Text}";
                worksheet.Cells[row++, 1] = $"Total Amount: {x.TotalAmount:#,##0} VND";

                row += 2;

                // 4. Header bảng chi tiết
                worksheet.Cells[row, 1] = "Book ID";
                worksheet.Cells[row, 2] = "Book Name";
                worksheet.Cells[row, 3] = "Quantity";
                worksheet.Cells[row, 4] = "Unit Price";
                worksheet.Cells[row, 5] = "Total Price";

                Excel.Range headerRange = worksheet.Range[worksheet.Cells[row, 1], worksheet.Cells[row, 5]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.Color.LightGray;

                row++;

                // 5. Dữ liệu bảng chi tiết
                var books = new CabinetService<Repositories.Entities.Book>().GetAll();
                foreach (var item in arr)
                {
                    var book = books.FirstOrDefault(b => b.BookId == item.BookId);
                    if (book != null)
                    {
                        int quantity = item.Quantity ?? 0;
                        double unitPrice = book.SelltPrince;
                        worksheet.Cells[row, 1] = book.BookId;
                        worksheet.Cells[row, 2] = book.BookName;
                        worksheet.Cells[row, 3] = quantity;
                        worksheet.Cells[row, 4] = unitPrice;
                        worksheet.Cells[row, 5] = quantity * unitPrice;
                        row++;
                    }
                }

                worksheet.Columns.AutoFit();

                // 6. Hiện Excel
                excelApp.Visible = true;

                MessageBox.Show("Invoice exported to Excel successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting to Excel:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 7. Giải phóng tài nguyên COM
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null) Marshal.ReleaseComObject(workbook);
                if (excelApp != null) Marshal.ReleaseComObject(excelApp);

                worksheet = null;
                workbook = null;
                excelApp = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSalesInvoiceDetail == null)
            {
                MessageBox.Show("Please select a certain book to delete!!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult answer = MessageBox.Show("Do you really want to delete this book", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;
            arr.Remove(_selectedSalesInvoiceDetail);
            FillDataGridView();
            _selectedSalesInvoiceDetail = null;
        }

        private void dgvBooksInfoDetails_SelectionChanged(object sender, EventArgs e)
        {
            _selectedSalesInvoiceDetail = null;

            if (dgvBooksInfoDetails.SelectedRows.Count > 0)
            {
                _selectedSalesInvoiceDetail = (SalesInvoiceDetail)dgvBooksInfoDetails.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
