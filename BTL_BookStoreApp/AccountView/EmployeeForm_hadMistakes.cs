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
    public partial class EmployeeForm_hadMistakes : Form
    {
        private Employee _employee = null;
        Mytoys _myytoys = new Mytoys();
        //public int flag = 0;
        public EmployeeForm_hadMistakes()
        {
            InitializeComponent();
        }

        private void EmployeeForm_hadMistakes_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = false;
            List<String> listID = new CabinetService<Employee>().GetAll().Select(a => a.EmployeeId).ToList();
            txtEmployeeId.Text = _myytoys.GenerateNextIdFromStrings(listID, "NV");
        }

        private void btnCreateAndContinue_Click(object sender, EventArgs e)
        {
            if (!BoxHelper.IsValidInput(txtEmployeeName)) return;

            _employee = new Employee()
            {
                EmployeeId = txtEmployeeId.Text,
                EmployeeName = txtEmployeeName.Text,
            };

            UserAccountForm f = new UserAccountForm();
            //if (flag == 1)
            //{
            //    f.flag = 1;
            //}
            f._employee = _employee;
            f.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
