using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_BookStoreApp.BillView
{
    public partial class SalesInvoiceMainUI : Form
    {
        private SalesInvoice _selectedABook = null;
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
            Employee employee = new() { EmployeeId = "", EmployeeName = "" };
            List<Employee> list = _eSevice.GetAll();
            list.Add(employee);
            cboEmployeeName.DataSource = null;
            cboEmployeeName.DataSource = list;
            cboEmployeeName.DisplayMember = "EmployeeName";
            cboEmployeeName.ValueMember = "EmployeeId";

            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSalesInvoiceList.DataSource = null;
            string rawPhone = mtbPhone.Text.Replace(".", "");


            dgvSalesInvoiceList.DataSource = _service.GetAll().Where(delegate (SalesInvoice x)
            {
                return x.InvoiceId == int.Parse(txtInvoiceId.Text) || x.EmployeeId.Contains(cboEmployeeName.SelectedValue.ToString());
            }).ToList();
        }

        
    }
}
