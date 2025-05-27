using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_BookStoreApp.Book;
using BTL_BookStoreApp.BookView;
using BTL_BookStoreApp.VendorInvoiceView;
using Repositories.Entities;
using Services;

namespace BTL_BookStoreApp
{
    public partial class SubObManagerUI : Form
    {
        public int flag = 0;

        CabinetService<Author> _aService = new();
        Author _author = null;
        CabinetService<BookCategory> _bService = new();
        BookCategory _bookCategory = null;
        CabinetService<Publisher> _pService = new();
        Publisher _publisher = null;
        CabinetService<Supplier> _sService = new();
        Supplier _supplier = null;

        public SubObManagerUI()
        {
            InitializeComponent();
        }


        private void SubObManagerUI_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                MessageBox.Show("Do not have ob", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            switch (flag)
            {
                case 1:
                    lblBookManager.Text = "Author Manager";
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _aService.GetAll();
                    break;
                case 2:
                    lblBookManager.Text = "Bookcategory Manager";
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _bService.GetAll();
                    break;
                case 3:
                    lblBookManager.Text = "Publisher Manager";
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _pService.GetAll();
                    break;
                case 4:
                    lblBookManager.Text = "Supplier Manager";
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _sService.GetAll();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    AuthorDetailForm fAuthor = new();
                    fAuthor.ShowDialog();

                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _aService.GetAll();
                    break;
                case 2:
                    BookCategoryDetailForm fBookCategory = new();
                    fBookCategory.ShowDialog();

                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _bService.GetAll();
                    break;
                case 3:
                    PublisherDetailForm_Ngu fPublisher = new();
                    fPublisher.ShowDialog();

                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _pService.GetAll();
                    break;
                case 4:
                    SupplierDetailForm fSupplier = new();
                    fSupplier.ShowDialog();

                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _sService.GetAll();
                    break;
            }
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            _author = null;
            _bookCategory = null;
            _publisher = null;
            _supplier = null;
            if (dgvBookList.SelectedRows.Count > 0)
            {
                switch (flag)
                {
                    case 1:
                        
                        _author = (Author)dgvBookList.SelectedRows[0].DataBoundItem;
                        break;
                    case 2:
                        
                        _bookCategory = (BookCategory)dgvBookList.SelectedRows[0].DataBoundItem;
                        break;
                    case 3:
                        
                        _publisher = (Publisher)dgvBookList.SelectedRows[0].DataBoundItem;
                        break;
                    case 4:
                        
                        _supplier = (Supplier)dgvBookList.SelectedRows[0].DataBoundItem;
                        break;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    if (_author != null)
                    {
                        AuthorDetailForm f = new();
                        f.SelectedAuthor = _author;
                        f.ShowDialog();

                        dgvBookList.DataSource = null;
                        dgvBookList.DataSource = _aService.GetAll();
                    }
                    else
                        MessageBox.Show("Please select a certain item to edit!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 2:
                    if (_bookCategory != null)
                    {
                        BookCategoryDetailForm f = new();
                        f.SelectedBookCategory = _bookCategory;
                        f.ShowDialog();

                        dgvBookList.DataSource = null;
                        dgvBookList.DataSource = _bService.GetAll();
                    }
                    else
                        MessageBox.Show("Please select a certain item to edit!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    if (_publisher != null)
                    {
                        PublisherDetailForm_Ngu f = new();
                        f.SelectedPublisher = _publisher;
                        f.ShowDialog();

                        dgvBookList.DataSource = null;
                        dgvBookList.DataSource = _pService.GetAll();
                    }
                    else
                        MessageBox.Show("Please select a certain item to edit!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 4:
                    if (_supplier != null)
                    {
                        SupplierDetailForm f = new();
                        f.SelectedSupplier = _supplier;
                        f.ShowDialog();

                        dgvBookList.DataSource = null;
                        dgvBookList.DataSource = _sService.GetAll();
                    }
                    else
                        MessageBox.Show("Please select a certain item to edit!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (flag)
            {
                case 1:
                    if (_author == null)
                    {
                        MessageBox.Show("Please select a certain item to delete!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    DialogResult answer1 = MessageBox.Show("Do you really want to delete this item", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer1 == DialogResult.No)
                        return;
                    //khóa ngoại
                    bool inUse1 = BoxHelper.IsForeignKeyInUse<Repositories.Entities.Book>(b => b.AuthorId == _author.AuthorId);

                    if (inUse1)
                    {
                        MessageBox.Show("This author is a foreign key, Can not bt deleted!");
                        return;
                    }

                    _aService.Remove(_author);
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _aService.GetAll();
                    _author = null;
                    break;
                case 2:
                    if (_bookCategory == null)
                    {
                        MessageBox.Show("Please select a certain item to delete!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    DialogResult answer2 = MessageBox.Show("Do you really want to delete this item", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer2 == DialogResult.No)
                        return;

                    //khóa ngoại
                    bool inUse2 = BoxHelper.IsForeignKeyInUse<Repositories.Entities.Book>(b => b.BookCategoryId == _bookCategory.BookCategoryId);

                    if (inUse2)
                    {
                        MessageBox.Show("This Book category is a foreign key, Can not bt deleted!");
                        return;
                    }

                    _bService.Remove(_bookCategory);
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _bService.GetAll();
                    _bookCategory = null;
                    break;
                case 3:
                    if (_publisher == null)
                    {
                        MessageBox.Show("Please select a certain item to delete!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    DialogResult answer3 = MessageBox.Show("Do you really want to delete this item", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer3 == DialogResult.No)
                        return;

                    bool inUse3 = BoxHelper.IsForeignKeyInUse<Repositories.Entities.Book>(b => b.PublisherId == _publisher.PublisherId);
                    if (inUse3)
                    {
                        MessageBox.Show("This Publisher is a foreign key, Can not bt deleted!");
                        return;
                    }

                    _pService.Remove(_publisher);
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _pService.GetAll();
                    _publisher = null;
                    break;
                case 4:
                    if (_supplier == null)
                    {
                        MessageBox.Show("Please select a certain item to delete!!", "Select one item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    DialogResult answer4 = MessageBox.Show("Do you really want to delete this item", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer4 == DialogResult.No)
                        return;

                    bool inUse4 = BoxHelper.IsForeignKeyInUse<PurchaseInvoice>(b => b.SupplierId == _supplier.SupplierId);
                    if (inUse4)
                    {
                        MessageBox.Show("This Supplier is a foreign key, Can not bt deleted!");
                        return;
                    }

                    _sService.Remove(_supplier);
                    dgvBookList.DataSource = null;
                    dgvBookList.DataSource = _sService.GetAll();
                    _supplier = null;
                    break;
            }
        }
    }
}
