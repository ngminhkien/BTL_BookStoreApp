using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Repositories.Entities;
using Services;

namespace BTL_BookStoreApp.BillView
{
    public partial class CustomerDetailForm : Form
    {
        public Customer SelectedPublisher { get; set; } = null;
        public CustomerDetailForm()
        {
            InitializeComponent();
        }
        public string NewPhone { get; set; } = null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtCustomerName, txtAddress)) return;
            if (string.IsNullOrWhiteSpace(mtbPhone.Text))
            {
                MessageBox.Show("Please fill in the infomation", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }

            string rawPhone = mtbPhone.Text.Replace(".", "");
            Customer publisher = new Customer()
            {
                CustomerId = txtCustomerId.Text,
                CustomerName = txtCustomerName.Text,
                Phone = rawPhone,
                Address = txtAddress.Text,
            };
            CabinetService<Customer> service = new();
            if (SelectedPublisher != null)
                service.Update(publisher);
            else
                service.Add(publisher);

            //NewPhone = rawPhone; // Gán ID vừa thêm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            txtCustomerId.Enabled = false;
            if ( NewPhone != null )
            {
                mtbPhone.Enabled = false;
                mtbPhone.Text = NewPhone;
            }
            
            Mytoys mytoys = new Mytoys();
            List<string> list = new CabinetService<Customer>().GetAll().Select(a => a.CustomerId).ToList();
            txtCustomerId.Text = mytoys.GenerateNextIdFromStrings(list, "KH");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            string rawPhone = mtbPhone.Text.Replace(".", ""); // bỏ dấu chấm
            if (rawPhone.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }

            string prefix = rawPhone.Substring(0, 2);
            if (prefix != "03" && prefix != "08" && prefix != "09")
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng 03, 08 hoặc 09.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
            }
        }
    }
}
