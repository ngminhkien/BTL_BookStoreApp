using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTL_BookStoreApp.BillView
{
    public partial class PurchaseInvoiceDetailForm : Form
    {
        public PurchaseInvoice SelectedPurchaseInvoice { get; set; } = null;
        CabinetService<PurchaseInvoiceDetail> _service = new();
        CabinetService<Supplier> _sService = new();
        CabinetService<Repositories.Entities.Book> bookService = new();
        public int flag = 0;
        
        public PurchaseInvoiceDetailForm()
        {
            InitializeComponent();
        }

        private void PurchaseInvoiceDetailForm_Load(object sender, EventArgs e)
        {
            var books = bookService.GetAll();
            
            if (flag ==1)
            {
                lblHeader.Text = "Info a Purchase Invoice";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnPrint.Enabled = false;
                txtEmployeeID.ReadOnly = true;
                txtInvoiceId.ReadOnly = true;
                cboSupplierName.Enabled = false;
                mtbInvoiceDate.ReadOnly = true;
                txtNote.ReadOnly = true;

                txtEmployeeID.Text = SelectedPurchaseInvoice.EmployeeId;
                txtInvoiceId.Text = SelectedPurchaseInvoice.InvoiceId.ToString();
                txtNote.Text = SelectedPurchaseInvoice.Note;
                mtbInvoiceDate.Text = SelectedPurchaseInvoice.InvoiceDate?.ToString("MM/dd/yyyy HH:mm") ?? "";
                cboSupplierName.DataSource = _sService.GetAll();
                cboSupplierName.DisplayMember = "SupplierName";
                cboSupplierName.ValueMember = "SupplierId";
                //đổ dữ liệu vào datagrid view
                cboSupplierName.SelectedValue = SelectedPurchaseInvoice?.SupplierId;
                dgvBooksInfoDetails.DataSource = _service.GetAll().Where(a => a.InvoiceId == SelectedPurchaseInvoice.InvoiceId).ToList();

            }else if(flag ==2) {
                lblHeader.Text = "Add a Purchase Invoice";
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnPrint.Enabled = false;
                txtEmployeeID.ReadOnly = false;
                txtInvoiceId.ReadOnly = false;
                cboSupplierName.Enabled = true;
                mtbInvoiceDate.ReadOnly = false;
                txtNote.ReadOnly = false;
                //đổ dữ liệu vào combobox
                
                cboSupplierName.DataSource = _sService.GetAll();
                cboSupplierName.DisplayMember = "SupplierName";
                cboSupplierName.ValueMember = "SupplierId";
            } else
            {

                lblHeader.Text = "Edit a Purchase Invoice";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnPrint.Enabled = true;
                txtEmployeeID.ReadOnly = true;
                txtInvoiceId.ReadOnly = true;
                cboSupplierName.Enabled = true;
                mtbInvoiceDate.ReadOnly = false;
                txtNote.ReadOnly = false;
                //đổ dữ liệu vào combobox
                cboSupplierName.DataSource = _sService.GetAll();
                cboSupplierName.DisplayMember = "SupplierName";
                cboSupplierName.ValueMember = "SupplierId";
                //đổ dữ liệu vào datagrid view
                cboSupplierName.SelectedValue = SelectedPurchaseInvoice?.SupplierId;
                dgvBooksInfoDetails.DataSource = _service.GetAll().Where(a => a.InvoiceId == SelectedPurchaseInvoice.InvoiceId).ToList();

                // Xóa các cột cũ nếu cần
                dgvBooksInfoDetails.Columns.Clear();

                // Tạo cột ComboBox cho BookId
                var bookIdColumn = new DataGridViewComboBoxColumn();
                bookIdColumn.DataPropertyName = "BookId";
                bookIdColumn.HeaderText = "Mã sách";
                bookIdColumn.DataSource = books;
                bookIdColumn.DisplayMember = "BookName"; // Hiển thị tên sách
                bookIdColumn.ValueMember = "BookId";     // Giá trị là mã sách

                dgvBooksInfoDetails.Columns.Add(bookIdColumn);

                // Thêm các cột khác (ví dụ Quantity)
                var quantityColumn = new DataGridViewTextBoxColumn();
                quantityColumn.DataPropertyName = "Quantity";
                quantityColumn.HeaderText = "Số lượng";
                dgvBooksInfoDetails.Columns.Add(quantityColumn);

                // Gán DataSource cho DataGridView
                dgvBooksInfoDetails.AutoGenerateColumns = false;
                dgvBooksInfoDetails.DataSource = _service.GetAll().Where(a => a.InvoiceId == SelectedPurchaseInvoice.InvoiceId).ToList(); ; // details là danh sách PurchaseInvoiceDetails đã lấy từ database
            }
        }
    }
}
