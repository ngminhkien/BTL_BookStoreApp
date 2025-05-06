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
    public partial class PublisherDetailForm : Form
    {

        public Publisher SelectedPublisher { get; set; } = null;
        public PublisherDetailForm()
        {
            InitializeComponent();
        }

        public string NewPublisherId { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            Close();
        }

        private void PublisherDetailForm_Load(object sender, EventArgs e)
        {
            txtPublisherId.Enabled = false;
            Mytoys mytoys = new Mytoys();
            List<string> list = new CabinetService<Publisher>().GetAll().Select(a => a.PublisherId).ToList();
            txtPublisherId.Text = mytoys.GenerateNextIdFromStringsV2(list, "NXB");
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
