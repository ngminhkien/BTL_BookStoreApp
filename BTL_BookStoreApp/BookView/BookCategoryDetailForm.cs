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
        private BookCategory SelectedBookCategory { get; set; } = null;
        public BookCategoryDetailForm()
        {
            InitializeComponent();
        }

        public int NewBookCategoryId { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            Close();
        }

        private void BookCategoryDetailForm_Load(object sender, EventArgs e)
        {
            txtBookCategoryId.Enabled = false;
            Mytoys mytoys = new Mytoys();
            txtBookCategoryId.Text = (new CabinetService<BookCategory>().GetAll().Count() + 1).ToString();
        }
    }
}
