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

namespace BTL_BookStoreApp.AccountView
{
    public partial class EmployeeMainUI : Form
    {
        public Employee _selectedAEmployee = null;
        CabinetService<Employee> _service = new();
        CabinetService<UserAccount> _uService = new();
        public EmployeeMainUI()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            dgvEmployeeList.DataSource = null;
            dgvEmployeeList.DataSource = _service.GetAll();
        }

        private void EmployeeMainUI_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeForm_hadMistakes f = new();
            f.ShowDialog();
        }

        private void dgvEmployeeList_SelectionChanged(object sender, EventArgs e)
        {
            _selectedAEmployee = null;

            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                _selectedAEmployee = (Employee)dgvEmployeeList.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAEmployee == null)
            {
                MessageBox.Show("Please select a certain employee to delete!!", "Select one employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult answer = MessageBox.Show("Do you really want to delete this employee", "Delete confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
                return;
            UserAccount userAccount = _uService.GetAll().FirstOrDefault(a => a.EmployeeId == _selectedAEmployee.EmployeeId);
            _uService.Remove(userAccount);
            _service.Remove(_selectedAEmployee);
            FillDataGridView();
            _selectedAEmployee = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
