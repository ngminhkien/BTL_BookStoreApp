using System.Windows.Forms;
using BTL_BookStoreApp.Book;
using Repositories.Entities;
using Services;

namespace BTL_BookStoreApp
{
    public partial class BookManagerMainUI : Form
    {
        public Repositories.Entities.Book? _selectedABook = null;
        CabinetService<Repositories.Entities.Book> _service = new();
        //biến flag dùng cho invoice
        public int flag = 0;

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
            if (flag == 1)
            {
                btnCreate.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                lblReport.Text = "Double Click để chọn";
            }
            if (flag == 2)
            {
                btnDelete.Visible = false;
                lblReport.Text = "Double Click để chọn";
            }
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

                if (f.ShowDialog() == DialogResult.OK)  // kiểm tra nếu đã lưu
                {
                    FillDataGridView(); // Chỉ làm mới khi thực sự có cập nhật
                }
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit!!", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
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

            //khóa trong hóa đơn nhập
            bool inUse1 = BoxHelper.IsForeignKeyInUse<PurchaseInvoiceDetail>(b => b.BookId == _selectedABook.BookId);
            if (inUse1)
            {
                MessageBox.Show("This book is a foreign key, Can not bt deleted!");
                return;
            }

            bool inUse2 = BoxHelper.IsForeignKeyInUse<SalesInvoiceDetail>(b => b.BookId == _selectedABook.BookId);
            if (inUse2)
            {
                MessageBox.Show("This book is a foreign key, Can not bt deleted!");
                return;
            }


            _service.Remove(_selectedABook);
            FillDataGridView();
            _selectedABook = null;
        }

        private void dgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy book từ dòng được chọn
            if (e.RowIndex >= 0)
            {
                _selectedABook = (Repositories.Entities.Book)dgvBookList.Rows[e.RowIndex].DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close(); // đóng form sau khi chọn
            }
        }

    }
}
