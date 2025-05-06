using BTL_BookStoreApp.Book;
using Repositories.Entities;
using Services;

namespace BTL_BookStoreApp
{
    public partial class BookManagerMainUI : Form
    {
        private Repositories.Entities.Book? _selectedABook = null;
        CabinetService<Repositories.Entities.Book> _service = new();

        //hàm đổ data vào dgv
        private void FillDataGridView()
        {
            //BookService<Repositories.Entities.Book> _service = new(_context);
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetAll();
        }
        public BookManagerMainUI()
        {
            InitializeComponent();
        }

        private void BookManagerMainUI_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //BookService<Repositories.Entities.Book> _service = new(_context);
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetAll().Where(delegate (Repositories.Entities.Book x)
            {
                bool matchesName = string.IsNullOrEmpty(txtBookName.Text) || x.BookName.ToLower().Contains(txtBookName.Text.ToLower());
                bool matchesDescription = string.IsNullOrEmpty(txtDescription.Text) || x.Description.ToLower().Contains(txtDescription.Text.ToLower());

                return matchesName && matchesDescription;
            }).ToList();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetailForm f = new();
            f.ShowDialog();

            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedABook != null)
            {
                BookDetailForm f = new();
                f.SelectedBook = _selectedABook;
                f.ShowDialog();

                FillDataGridView();
            }
            else
                MessageBox.Show("Please select a certain book to edit!!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            _selectedABook = null;

            if (dgvBookList.SelectedRows.Count > 0)
            {
                _selectedABook = (Repositories.Entities.Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit application", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //BookService<Repositories.Entities.Book> _service = new(_context);
            if (_selectedABook == null)
            {
                MessageBox.Show("Please select a certain book to delete!!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult answer = MessageBox.Show("Do you really want to delete this book", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;
            _service.Remove(_selectedABook);
            FillDataGridView();
            _selectedABook = null;
        }
    }
}
