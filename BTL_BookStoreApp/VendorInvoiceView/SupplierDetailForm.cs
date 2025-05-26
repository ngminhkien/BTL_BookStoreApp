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

namespace BTL_BookStoreApp.VendorInvoiceView
{
    public partial class SupplierDetailForm : Form
    {
        public Supplier SelectedSupplier { get; set; } = null;
        public string NewSupplierId { get; set; }
        public SupplierDetailForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtSupplierName, txtAddress)) return;
            if (string.IsNullOrWhiteSpace(mtbPhone.Text))
            {
                MessageBox.Show("Please fill in the infomation", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }

            string rawPhone = mtbPhone.Text.Replace(".", "");
            Supplier supplier = new Supplier()
            {
                SupplierId = txtSupplierId.Text,
                SupplierName = txtSupplierName.Text,
                Phone = rawPhone,
                Address = txtAddress.Text,
            };
            CabinetService<Supplier> service = new();
            if (SelectedSupplier != null)
                service.Update(supplier);
            else
                service.Add(supplier);

            NewSupplierId = supplier.SupplierId; // Gán ID vừa thêm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SupplierDetailForm_Load(object sender, EventArgs e)
        {
            txtSupplierId.Enabled = false;
            
            if (SelectedSupplier != null)
            {
                lblHeader.Text = "Update selected Supplier...";

                txtSupplierId.Text = SelectedSupplier.SupplierId.ToString();
                txtSupplierName.Text = SelectedSupplier.SupplierName;
                txtAddress.Text = SelectedSupplier.Address;
                mtbPhone.Text = SelectedSupplier?.Phone;

            }
            else
            {
                lblHeader.Text = "Create a new Supplier...";
                Mytoys mytoys = new Mytoys();
                List<string> list = new CabinetService<Supplier>().GetAll().Select(a => a.SupplierId).ToList();
                txtSupplierId.Text = mytoys.GenerateNextIdFromStringsV2(list, "NCC");
            }
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (!BoxHelper.ValidatePhone(mtbPhone))
            {
                return; // dừng lại nếu không hợp lệ
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
