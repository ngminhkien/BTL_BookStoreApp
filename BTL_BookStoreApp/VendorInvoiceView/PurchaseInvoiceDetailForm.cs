using BTL_BookStoreApp.BookView;
using BTL_BookStoreApp.VendorInvoiceView;
using Repositories;
using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_BookStoreApp.BillView
{
    public partial class PurchaseInvoiceDetailForm : Form
    {
        public PurchaseInvoice SelectedPurchaseInvoice { get; set; } = null;
        private PurchaseInvoiceDetail _selectedPurchseInvoiceDetail = null;
        CabinetService<PurchaseInvoiceDetail> _service = new();
        CabinetService<PurchaseInvoice> _pService = new();
        CabinetService<Supplier> _sService = new();
        public int flag = 0;
        //tạo list để chứa các cuốn sách dùng để thêm vào dgv, BindlingList là list giúp lưu trữ 2 chiều với dgv
        BindingList<PurchaseInvoiceDetail> arr = new BindingList<PurchaseInvoiceDetail>();


        public PurchaseInvoiceDetailForm()
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

        private void PurchaseInvoiceDetailForm_Load(object sender, EventArgs e)
        {
            BoxHelper comboBox = new();
            txtInvoiceId.Enabled = false;
            mtbInvoiceDate.Enabled = false;
            //đổ dữ liệu vào comboBox

            cboEmployeeID.DataSource = new CabinetService<Employee>().GetAll();
            cboEmployeeID.DisplayMember = "EmployeeId";
            cboEmployeeID.ValueMember = "EmployeeId";
            comboBox.LoadToComboBox<Supplier>(cboSupplierName, new CabinetService<Supplier>().GetAll(), a => a.SupplierId, a => a.SupplierName ?? "N");
            cboSupplierName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployeeID.DropDownStyle = ComboBoxStyle.DropDownList;
            FillDataGridView();
            if (flag == 0)
            {
                lblHeader.Text = "Create a Purchase Invoice...";
                lblReport.Text = "Nhập vào ô Quantity để chỉnh số lượng";
                lblTotal.Visible = false;
                txtTotal.Visible = false;
                if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                    dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = false;
                //tạo khóa tự động
                Mytoys mytoys = new Mytoys();
                List<int> list = new CabinetService<PurchaseInvoice>().GetAll().Select(a => a.InvoiceId).ToList();
                txtInvoiceId.Text = mytoys.GenerateNextInteger(list, true).ToString();
                //lấy ngày tự động
                mtbInvoiceDate.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                return;
            }

            // ~ flag = 2
            lblHeader.Text = "Update a Purchase Invoice...";
            lblReport.Text = "Nhập vào ô Quantity để chỉnh số lượng, mỗi loại mua tồi đa 10 cuốn";
            if (dgvBooksInfoDetails.Columns.Contains("Quantity"))
                dgvBooksInfoDetails.Columns["Quantity"].ReadOnly = false;

            cboEmployeeID.SelectedValue = SelectedPurchaseInvoice.EmployeeId;
            cboSupplierName.SelectedValue = SelectedPurchaseInvoice.SupplierId;

            txtInvoiceId.Text = SelectedPurchaseInvoice.InvoiceId.ToString();
            txtNote.Text = SelectedPurchaseInvoice.Note;
            txtTotal.Text = SelectedPurchaseInvoice.TotalAmount.ToString();
            mtbInvoiceDate.Text = SelectedPurchaseInvoice.InvoiceDate?.ToString("MM/dd/yyyy HH:mm") ?? "";
            //xử lí 
            Supplier supplier = new();
            supplier = _sService.GetAll().FirstOrDefault(a => a.SupplierId == SelectedPurchaseInvoice.SupplierId) ?? new();
            //đổ dữ liệu vào arr trc để đồng bộ tránh gặp phải khi update
            //int id = SelectedSalesInvoice.InvoiceId;
            arr = new BindingList<PurchaseInvoiceDetail>(_service.GetAll().Where(a => a.InvoiceId == SelectedPurchaseInvoice.InvoiceId).ToList());
            FillDataGridView(); // Gán lại dgvBooksInfoDetails.DataSource = arr;
            if (flag == 1)
            {
                //đổ dữ liệu vào các ô text
                lblHeader.Text = "Info a Purchase Invoice...";
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = false;
                cboEmployeeID.Enabled = false;
                cboSupplierName.Enabled = false;
                txtInvoiceId.ReadOnly = true;
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
            f.flag = 2;
            PurchaseInvoiceDetail i = new();
            // Mở form dạng hộp thoại để chờ chọn xong
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

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplierName.SelectedItem is SpecialItem selectedItem)
            {
                if (selectedItem.Id == "-1")
                {
                    using (var form = new SupplierDetailForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            new BoxHelper().LoadToComboBox<Supplier>(cboSupplierName, new CabinetService<Supplier>().GetAll(), a => a.SupplierId, a => a.SupplierName ?? "N");

                            string newSupplier = form.NewSupplierId;
                            cboSupplierName.SelectedValue = newSupplier;
                        }
                        else
                        {
                            cboSupplierName.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedPurchseInvoiceDetail == null)
            {
                MessageBox.Show("Please select a certain book to delete!!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult answer = MessageBox.Show("Do you really want to delete this book", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;
            arr.Remove(_selectedPurchseInvoiceDetail);
            FillDataGridView();
            _selectedPurchseInvoiceDetail = null;
        }

        private void dgvBooksInfoDetails_SelectionChanged(object sender, EventArgs e)
        {
            _selectedPurchseInvoiceDetail = null;

            if (dgvBooksInfoDetails.SelectedRows.Count > 0)
            {
                _selectedPurchseInvoiceDetail = (PurchaseInvoiceDetail)dgvBooksInfoDetails.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                    double price = book.ImportPrince;
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
            PurchaseInvoice purchaseInvoice = new PurchaseInvoice()
            {
                EmployeeId = cboEmployeeID.Text,
                SupplierId = cboSupplierName.SelectedValue.ToString(),
                InvoiceDate = BoxHelper.ParseFromMaskedTextBox(mtbInvoiceDate).Value,
                Note = txtNote.Text,
                TotalAmount = total ?? 0,
            };
            if (flag == 0)
                _pService.Add(purchaseInvoice);
            else
            {
                purchaseInvoice.InvoiceId = int.Parse(txtInvoiceId.Text); // nếu sửa thì phải gán ID cũ
                _pService.Update(purchaseInvoice);
            }
            //lưu dữ liệu từ arr (từ datadrid view)
            // Gán InvoiceId mới cho các dòng chi tiết
            foreach (var item in arr)
            {
                item.InvoiceId = purchaseInvoice.InvoiceId; // CẬP NHẬT LẠI InvoiceId từ EF
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
                    PrintToExcel(purchaseInvoice);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message +
                    "\nInner: " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //tính tổng tiền và ghi ra dialog
        }

        private void PrintToExcel(PurchaseInvoice x)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Khởi tạo Excel
                excelApp = new Excel.Application();
                excelApp.Visible = false; // Để tránh treo/hộp thoại ẩn

                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Sheets[1];
                worksheet.Name = "Purchase Invoice";

                int row = 1;

                // Tiêu đề
                worksheet.Cells[row++, 1] = "PURCHASE INVOICE";
                worksheet.Range["A1", "F1"].Merge();
                worksheet.Range["A1"].Font.Size = 16;
                worksheet.Range["A1"].Font.Bold = true;
                worksheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                row++;

                // Thông tin hóa đơn
                worksheet.Cells[row++, 1] = $"Invoice ID: {txtInvoiceId.Text}";
                worksheet.Cells[row++, 1] = $"Employee ID: {cboEmployeeID.Text}";
                worksheet.Cells[row++, 1] = $"Supplier Name: {cboSupplierName.Text}";
                worksheet.Cells[row++, 1] = $"Invoice Date: {mtbInvoiceDate.Text}";
                worksheet.Cells[row++, 1] = $"Note: {txtNote.Text}";
                worksheet.Cells[row++, 1] = $"Total Amount: {x.TotalAmount}";

                row += 2;

                // Tiêu đề bảng
                worksheet.Cells[row, 1] = "Book ID";
                worksheet.Cells[row, 2] = "Book Name";
                worksheet.Cells[row, 3] = "Quantity";
                worksheet.Cells[row, 4] = "Unit Price";
                worksheet.Cells[row, 5] = "Total Price";

                worksheet.Range[worksheet.Cells[row, 1], worksheet.Cells[row, 5]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[row, 1], worksheet.Cells[row, 5]].Interior.Color = Color.LightGray;

                row++;

                // Dữ liệu chi tiết
                var books = new CabinetService<Repositories.Entities.Book>().GetAll();
                foreach (var item in arr)
                {
                    var book = books.FirstOrDefault(b => b.BookId == item.BookId);
                    if (book != null)
                    {
                        worksheet.Cells[row, 1] = book.BookId;
                        worksheet.Cells[row, 2] = book.BookName;
                        worksheet.Cells[row, 3] = item.Quantity ?? 0;
                        worksheet.Cells[row, 4] = book.ImportPrince;
                        worksheet.Cells[row, 5] = (item.Quantity ?? 0) * book.ImportPrince;
                        row++;
                    }
                }

                worksheet.Columns.AutoFit();

                // Hiện Excel sau khi hoàn tất để tránh lỗi giao tiếp RPC
                excelApp.Visible = true;

                MessageBox.Show("Invoice exported to Excel successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting to Excel:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng bộ nhớ COM
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
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
                
            }
        }
    }
}
