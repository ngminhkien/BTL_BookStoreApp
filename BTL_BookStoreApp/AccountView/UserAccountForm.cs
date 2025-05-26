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
    public partial class UserAccountForm : Form
    {
        private UserAccount _user = null;
        public Employee _employee = null;
        //public int flag = 0;
        CabinetService<Employee> _eService = new CabinetService<Employee>();
        CabinetService<UserAccount> _uService = new CabinetService<UserAccount>();
        public UserAccountForm()
        {
            InitializeComponent();
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;

            //tạo memberID
            List<int> arr = new CabinetService<UserAccount>().GetAll().Select(a => a.MemberId).ToList();
            txtMemberID.Text = (Mytoys.FindMax(arr) + 1).ToString();

            //gán label
            lblIdName.Text = _employee.EmployeeId.ToString() + " - " + _employee.EmployeeName.ToString();
            if (_employee == null)
            {
                MessageBox.Show("u do not have step1 info yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSaveAndLogin_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtEmail, txtPassword, txtConfirmPassword)) return;
            if (txtConfirmPassword.Text !=  txtPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee employee = new Employee()
            {
                EmployeeId = _employee.EmployeeId,
                EmployeeName = _employee.EmployeeName,
            };

            

            UserAccount account = new UserAccount()
            {
                MemberId = int.Parse(txtMemberID.Text),
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                EmployeeId = _employee.EmployeeId,
                Role = 3
            };
            //if (flag == 0)
            //{
                _eService.Add(employee);
                _uService.Add(account);
                MessageBox.Show("Add new a employee successfull", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
            //}
            //else
            //{
            //    _eService.Update(employee);
            //    _uService.Update(account);
            //    MessageBox.Show("Update a employee successfull", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
