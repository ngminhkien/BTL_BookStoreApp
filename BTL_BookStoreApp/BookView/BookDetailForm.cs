using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_BookStoreApp.BookView;
using Repositories;
using Repositories.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_BookStoreApp.Book
{
    public partial class BookDetailForm : Form
    {
        public Repositories.Entities.Book? SelectedBook { get; set; } = null;
        CabinetService<Repositories.Entities.Book> service = new();

        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            BoxHelper comboBox = new();

            comboBox.LoadToComboBox<Author>(cboAuthor, new CabinetService<Author>().GetAll(), a => a.AuthorId, a => a.AuthorName ?? "N");
            comboBox.LoadToComboBox<Publisher>(cboPublisher, new CabinetService<Publisher>().GetAll(), a => a.PublisherId, a => a.PublisherName ?? "N");
            comboBox.LoadToComboBox<BookCategory>(cboBookCategory, new CabinetService<BookCategory>().GetAll(), a => a.BookCategoryId.ToString(), a => a.BookGenreType ?? "N");

            txtBookId.Enabled = false;
            txtSellPrince.Enabled = false;
            //để người dùng chỉ chọn từ drop list
            cboAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBookCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            if (SelectedBook != null)
            {
                lblHeader.Text = "Update selected book...";

                txtBookId.Text = SelectedBook.BookId.ToString();

                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                //dtpPublicationDate.Text = SelectedBook.PublicationDate.ToString();
                dtpPubDate.Value = SelectedBook.PublicationDate;
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtImportPrince.Text = SelectedBook.ImportPrince.ToString();
                txtSellPrince.Text = SelectedBook.SelltPrince.ToString();
                cboAuthor.SelectedValue = SelectedBook.AuthorId;
                cboBookCategory.SelectedValue = SelectedBook.BookCategoryId.ToString();
                cboPublisher.SelectedValue = SelectedBook.PublisherId;
            }
            else
            {
                lblHeader.Text = "Create a new book...";
                Mytoys mytoys = new Mytoys();
                List<string> list = new CabinetService<Repositories.Entities.Book>().GetAll().Select(a => a.BookId).ToList();
                txtBookId.Text = mytoys.GenerateNextIdFromStrings(list, "B");
            }

        }

        private void cboAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthor.SelectedItem is SpecialItem selectedItem)
            {
                if (selectedItem.Id == "-1")
                {
                    using (var form = new AuthorDetailForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            new BoxHelper().LoadToComboBox<Author>(cboAuthor, new CabinetService<Author>().GetAll(), a => a.AuthorId, a => a.AuthorName ?? "N");

                            string newAuthorId = form.NewAuthorId;
                            cboAuthor.SelectedValue = newAuthorId;
                        }
                        else
                        {
                            cboAuthor.SelectedIndex = 0;
                        }
                    }
                }
            }

        }

        private void cboPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPublisher.SelectedItem is SpecialItem selectedItem)
            {
                if (selectedItem.Id == "-1")
                {
                    using (var form = new PublisherDetailForm_Ngu())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            new BoxHelper().LoadToComboBox<Publisher>(cboAuthor, new CabinetService<Publisher>().GetAll(), a => a.PublisherId, a => a.PublisherName ?? "N");

                            string newPublisherId = form.NewPublisherId;
                            cboAuthor.SelectedValue = newPublisherId;
                        }
                        else
                        {
                            cboPublisher.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void cboBookCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBookCategory.SelectedItem is SpecialItem selectedItem)
            {
                if (selectedItem.Id == "-1")
                {
                    using (var form = new BookCategoryDetailForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            new BoxHelper().LoadToComboBox<BookCategory>(cboBookCategory, new CabinetService<BookCategory>().GetAll(), a => a.BookCategoryId.ToString(), a => a.BookGenreType);

                            string newBookCategoryId = form.NewBookCategoryId.ToString();
                            cboAuthor.SelectedValue = newBookCategoryId;
                        }
                        else
                        {
                            cboBookCategory.SelectedIndex = 0;
                        }
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtBookName, txtDescription, txtImportPrince, txtQuantity)) return;

            Repositories.Entities.Book book = new Repositories.Entities.Book()
            {
                BookId = txtBookId.Text,
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPubDate.Value,
                Quantity = int.Parse((string)txtQuantity.Text),
                SelltPrince = double.Parse(txtSellPrince.Text),
                ImportPrince = double.Parse(txtImportPrince.Text),
                AuthorId = cboAuthor?.SelectedValue?.ToString(),
                PublisherId = cboPublisher?.SelectedValue?.ToString(),
                BookCategoryId = int.Parse(cboBookCategory?.SelectedValue?.ToString() ?? "N"),
            };
            
            if (SelectedBook != null)
                service.Update(book);
            else
                service.Add(book);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void txtImportPrince_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImportPrince.Text))
                txtImportPrince.Text = "0";
            int tmp = int.Parse(txtImportPrince.Text);
            txtSellPrince.Text = (tmp * 1.2).ToString();
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtImportPrince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
