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
    public partial class BookCategoryDetailForm : Form
    {
        public BookCategory SelectedBookCategory { get; set; } = null;
        public BookCategoryDetailForm()
        {
            InitializeComponent();
        }

        public int NewBookCategoryId { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtBookGenreType, txtDescription)) return;

            BookCategory category = new BookCategory()
            {
                BookCategoryId = int.Parse(txtBookCategoryId.Text),
                BookGenreType = txtBookGenreType.Text,
                Description = txtDescription.Text
            };
            CabinetService<BookCategory> service = new();
            if (SelectedBookCategory != null)
                service.Update(category);
            else
                service.Add(category);
            NewBookCategoryId = category.BookCategoryId; // Gán ID vừa thêm
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void BookCategoryDetailForm_Load(object sender, EventArgs e)
        {
            txtBookCategoryId.Enabled = false;
            

            if (SelectedBookCategory != null)
            {
                lblHeader.Text = "Update selected BookCategory...";

                txtBookCategoryId.Text = SelectedBookCategory.BookCategoryId.ToString();
                txtBookGenreType.Text = SelectedBookCategory.BookGenreType;
                txtDescription.Text = SelectedBookCategory.Description;

            }
            else
            {
                lblHeader.Text = "Create a new Book Category...";
                List<int> arr = new CabinetService<BookCategory>().GetAll().Select(a => a.BookCategoryId).ToList();
                txtBookCategoryId.Text = Mytoys.FindMax(arr).ToString();
            }
        }
    }
}
