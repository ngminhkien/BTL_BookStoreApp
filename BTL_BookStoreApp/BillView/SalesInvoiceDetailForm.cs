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

namespace BTL_BookStoreApp.BillView
{
    public partial class SalesInvoiceDetailForm : Form
    {
        public SalesInvoice SelectedSalesInvoice { get; set; } = null;
        public int flag = 0;
        public SalesInvoiceDetailForm()
        {
            InitializeComponent();
        }

        private void SalesInvoiceDetailForm_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                lblHeader.Text = "Info a Sales Invoice...";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                btnPrint.Enabled = false;
                txtEmployeeID.ReadOnly = true;
                txtInvoiceId.ReadOnly = true;
                txtCustomerId.ReadOnly = true;
                mtbInvoiceDate.ReadOnly = true;
                txtNote.ReadOnly = true;

                txtEmployeeID.Text = SelectedSalesInvoice.EmployeeId;
                txtInvoiceId.Text = SelectedSalesInvoice.InvoiceId.ToString();
                txtNote.Text = SelectedSalesInvoice.Note;
                mtbInvoiceDate.Text = SelectedSalesInvoice.InvoiceDate?.ToString("MM/dd/yyyy HH:mm") ?? "";
                txtCustomerId.Text = SelectedSalesInvoice?.CustomerId;

            }
        }
    }
}
