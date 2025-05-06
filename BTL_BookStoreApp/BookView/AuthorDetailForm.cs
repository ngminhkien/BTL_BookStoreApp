using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_BookStoreApp.BookView
{
    public partial class AuthorDetailForm : Form
    {

        public Author SelectedAuthor { get; set; } = null;
        public AuthorDetailForm()
        {
            InitializeComponent();
        }

        public string NewAuthorId { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                AuthorId = txtAuthorId.Text,
                AuthorName = txtBookName.Text,
                BirthOfDate = dtpBirthOfDate.Value,
                Gender = cboGender.Text,
                Address = txtAddress.Text
            };
            CabinetService<Author> service = new();
            if (SelectedAuthor != null)
                service.Update(author);
            else
                service.Add(author);


            //var newAuthor = new Author
            //{
            //    AuthorName = txtAuthorName.Text,
            //    // Gán thêm các thông tin khác
            //};
            //_context.Authors.Add(newAuthor);
            //_context.SaveChanges();

            NewAuthorId = author.AuthorId; // Gán ID vừa thêm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AuthorDetailForm_Load(object sender, EventArgs e)
        {
            txtAuthorId.Enabled = false;
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            Mytoys mytoys = new Mytoys();
            List<string> list = new CabinetService<Author>().GetAll().Select(a => a.AuthorId).ToList();
            txtAuthorId.Text = mytoys.GenerateNextIdFromStrings(list, "TG");

            List<string> genders = new List<string> { "Male", "Female" };
            cboGender.DataSource = genders;
        }
    }
}
