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
using BTL_BookStoreApp.Book;
using Microsoft.IdentityModel.Tokens;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_BookStoreApp.BillView
{
    public partial class SalesInvoiceMainUI : Form
    {
        private SalesInvoice _selectedASalesInvoice = null;
        CabinetService<SalesInvoice> _service = new();
        CabinetService<Employee> _eSevice = new();
        CabinetService<Customer> _cService = new();

        public SalesInvoiceMainUI()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvSalesInvoiceList.DataSource = null;
            //dgvSalesInvoiceList.DataSource = _service.GetAll();
            var result = (from si in _service.GetAll()
                          join cus in _cService.GetAll()
                          on si.CustomerId equals cus.CustomerId
                          select new
                          {
                              si.InvoiceId,
                              si.InvoiceDate,
                              si.CustomerId,
                              si.EmployeeId,
                              cus.Phone,
                              cus.CustomerName,
                              si.TotalAmount
                          }).ToList();
            dgvSalesInvoiceList.DataSource = result;

        }

        private void SalesInvoiceMainUI_Load(object sender, EventArgs e)
        {
            BoxHelper comboBoxHelper = new BoxHelper();
            comboBoxHelper.LoadToComboBox2(cboEmployeeName, _eSevice.GetAll(), a => a.EmployeeId, a => a.EmployeeName, "");

            cboEmployeeName.DropDownStyle = ComboBoxStyle.DropDownList;

            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSalesInvoiceList.DataSource = null;
            // Lấy dữ liệu từ các ô nhập
            string inlId = txtInvoiceId.Text;

            var result = (from si in _service.GetAll()
                          join cus in _cService.GetAll()
                          on si.CustomerId equals cus.CustomerId
                          join em in _eSevice.GetAll()
                          on si.EmployeeId equals em.EmployeeId
                          select new
                          {
                              si.InvoiceId,
                              si.InvoiceDate,
                              si.CustomerId,
                              si.EmployeeId,
                              cus.Phone,
                              cus.CustomerName,
                              em.EmployeeName,
                              si.TotalAmount
                          }).ToList();

            dgvSalesInvoiceList.DataSource = result.Where(i =>
            {
                bool matchInvoiceId = string.IsNullOrEmpty(txtInvoiceId.Text) || (int.TryParse(txtInvoiceId.Text, out int invoiceId) && i.InvoiceId == invoiceId);

                bool matchPhone = !mtbPhone.MaskFull || (!string.IsNullOrEmpty(i.Phone) && i.Phone.Contains(mtbPhone.Text.Replace(".", "")));

                bool matchDate = !mtbInvoiceDate.MaskFull || (BoxHelper.ParseFromMaskedTextBox(mtbInvoiceDate).HasValue && i.InvoiceDate == BoxHelper.ParseFromMaskedTextBox(mtbInvoiceDate).Value);

                bool matchEmName = string.IsNullOrEmpty(cboEmployeeName.Text) || i.EmployeeName.ToLower().Contains(cboEmployeeName.Text.ToLower());

                return matchPhone && matchDate && matchInvoiceId && matchEmName;
            }).ToList();
        }

        private void dgvSalesInvoiceList_SelectionChanged(object sender, EventArgs e)
        {
            _selectedASalesInvoice = null;
            if (dgvSalesInvoiceList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSalesInvoiceList.SelectedRows[0];
                string? invoiceId = selectedRow.Cells["InvoiceId"].Value.ToString();

                // Hoặc nếu bạn muốn theo chỉ số cột:
                // string invoiceId = selectedRow.Cells[0].Value.ToString();

                if (invoiceId != null)
                {
                    int id = int.Parse(invoiceId);
                    _selectedASalesInvoice = _service.GetAll().FirstOrDefault(a => a.InvoiceId == id) ?? new SalesInvoice();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (_selectedASalesInvoice != null)
            {
                SalesInvoiceDetailForm f = new();
                f.SelectedSalesInvoice = _selectedASalesInvoice;
                f.flag = 1;
                f.ShowDialog();
            }
            else
                MessageBox.Show("Please select a certain Invoice to show!!", "Select one invoice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            SalesInvoiceDetailForm f = new();
            if (_selectedASalesInvoice != null)
            {
                f.SelectedSalesInvoice = _selectedASalesInvoice;
                f.flag = 2;
            }
            f.ShowDialog();
            FillDataGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
