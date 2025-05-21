using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_BookStoreApp.BillView
{
    public partial class PurchaseInvoiceForm : Form
    {
        private PurchaseInvoice _selectedPurchaseInvoice = null;
        private CabinetService<PurchaseInvoice> _service = new();
        private CabinetService<Supplier> _sService = new();
        private CabinetService<PurchaseInvoiceDetail> _pService = new();
        private CabinetService<Employee> _eService = new();

        public PurchaseInvoiceForm()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvPurchaseInvoiceList.DataSource = null;
            var result = (from pi in _service.GetAll()
                          join sup in _sService.GetAll()
                          on pi.SupplierId equals sup.SupplierId
                          select new
                          {
                              pi.InvoiceId,
                              pi.InvoiceDate,
                              pi.SupplierId,
                              sup.SupplierName,
                              pi.TotalAmount
                          }).ToList();
            dgvPurchaseInvoiceList.DataSource = result;
        }

        private void PurchaseInvoiceForm_Load(object sender, EventArgs e)
        {
            ComboBoxHelper comboBoxHelper = new ComboBoxHelper();
            comboBoxHelper.LoadToComboBox(cboEmployeeName, _eService.GetAll(), a => a.EmployeeId, a => a.EmployeeName, "");
            comboBoxHelper.LoadToComboBox(cboSupplierName, _sService.GetAll(), a => a.SupplierId, a => a.SupplierName, "");
            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPurchaseInvoiceList.DataSource = null;
            string inlId = txtInvoiceId.Text;
            DateTime? invoiceDate = null;
            DateTime tempDate;
            bool isValid = DateTime.TryParseExact(
                            mtbInvoiceDate.Text,
                            "MM/dd/yyyy HH:mm",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out tempDate
             );
            if (isValid)
            {
                invoiceDate = tempDate;
            }
            var result = (from pi in _service.GetAll()
                          join sup in _sService.GetAll()
                          on pi.SupplierId equals sup.SupplierId
                          join em in _eService.GetAll()
                          on pi.EmployeeId equals em.EmployeeId
                          select new
                          {
                              pi.InvoiceId,
                              pi.InvoiceDate,
                              pi.SupplierId,
                              sup.SupplierName,
                              pi.EmployeeId,
                              em.EmployeeName,
                              pi.TotalAmount
                          }).ToList();
            dgvPurchaseInvoiceList.DataSource = result.Where(i =>
            {
                bool matchInvoiceId = string.IsNullOrEmpty(txtInvoiceId.Text) || (int.TryParse(txtInvoiceId.Text, out int invoiceId) && i.InvoiceId == invoiceId);
                bool matchDate = !mtbInvoiceDate.MaskFull || (invoiceDate.HasValue && i.InvoiceDate == invoiceDate.Value);
                bool matchSupplierName = string.IsNullOrEmpty(cboSupplierName.Text) || i.SupplierName.ToLower().Contains(cboSupplierName.Text.ToLower());
                bool matchEmName = string.IsNullOrEmpty(cboEmployeeName.Text) || i.EmployeeName.ToLower().Contains(cboEmployeeName.Text.ToLower());
                return matchInvoiceId && matchDate && matchSupplierName && matchEmName;
            }).ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (_selectedPurchaseInvoice != null)
            {
                PurchaseInvoiceDetailForm f = new();
                f.SelectedPurchaseInvoice = _selectedPurchaseInvoice;
                f.flag = 1; // view mode
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain Invoice to show!!", "Select one invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvPurchaseInvoiceList_SelectionChanged(object sender, EventArgs e)
        {
            _selectedPurchaseInvoice = null;
            if (dgvPurchaseInvoiceList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPurchaseInvoiceList.SelectedRows[0];
                string? invoiceId = selectedRow.Cells["InvoiceId"].Value.ToString();
                if (invoiceId != null)
                {
                    int id = int.Parse(invoiceId);
                    _selectedPurchaseInvoice = _service.GetAll().FirstOrDefault(a => a.InvoiceId == id) ?? new PurchaseInvoice();
                }
            }
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetailForm f = new();
            if (_selectedPurchaseInvoice != null)
            {
                f.SelectedPurchaseInvoice = _selectedPurchaseInvoice;
                f.flag = 0; // edit mode
            }
            else
            {
                f.SelectedPurchaseInvoice = new PurchaseInvoice();
                f.flag = 2; // add mode
            }
            f.ShowDialog();
        }
    }
}
