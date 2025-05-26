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

namespace BTL_BookStoreApp.BookView
{
    public partial class PublisherDetailForm_Ngu : Form
    {
        public Publisher SelectedPublisher { get; set; } = null;
        public PublisherDetailForm_Ngu()
        {
            InitializeComponent();
        }

        public string NewPublisherId { get; set; }

        private void PublisherDetailForm_Ngu_Load(object sender, EventArgs e)
        {
            txtPublisherId.Enabled = false;
            
            if (SelectedPublisher!= null)
            {
                lblHeader.Text = "Update selected Publisher...";

                txtPublisherId.Text = SelectedPublisher.PublisherId.ToString();
                txtPublisherName.Text = SelectedPublisher.PublisherName;
                txtAddress.Text = SelectedPublisher.PublisherAddress;
                mtbPhone.Text = SelectedPublisher?.Phone;

            }
            else
            {
                lblHeader.Text = "Create a new Publisher...";
                Mytoys mytoys = new Mytoys();
                List<string> list = new CabinetService<Publisher>().GetAll().Select(a => a.PublisherId).ToList();
                txtPublisherId.Text = mytoys.GenerateNextIdFromStringsV2(list, "NXB");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtPublisherName, txtAddress)) return;
            if (string.IsNullOrWhiteSpace(mtbPhone.Text))
            {
                MessageBox.Show("Please fill in the infomation", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbPhone.Focus();
                return;
            }

            string rawPhone = mtbPhone.Text.Replace(".", "");
            Publisher publisher = new Publisher()
            {
                PublisherId = txtPublisherId.Text,
                PublisherName = txtPublisherName.Text,
                Phone = rawPhone,
                PublisherAddress = txtAddress.Text,
            };
            CabinetService<Publisher> service = new();
            if (SelectedPublisher != null)
                service.Update(publisher);
            else
                service.Add(publisher);

            NewPublisherId = publisher.PublisherId; // Gán ID vừa thêm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (!BoxHelper.ValidatePhone(mtbPhone))
            {
                return; // dừng lại nếu không hợp lệ
            }

            // tiếp tục xử lý nếu hợp lệ

        }
    }
}
