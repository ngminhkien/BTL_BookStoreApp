using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_BookStoreApp.AccountView;
using BTL_BookStoreApp.BillView;
using Repositories;
using Repositories.Entities;
using Services;

namespace BTL_BookStoreApp.MenuView
{
    public partial class MenuForm : Form
    {
        public string _accountInfo;
        public int flag = 1;
        private LoginForm loginForm;
        public MenuForm()
        {
            InitializeComponent();
        }


        private void MenuForm_Load(object sender, EventArgs e)
        {
            List<SpecialItem> items = new()
            {
                new SpecialItem() { Id = "1", Name = "Author" },
                new SpecialItem() { Id = "2", Name = "BookCategory" },
                new SpecialItem() { Id = "3", Name = "Publisher" },
                new SpecialItem() { Id = "4", Name = "Supplier" }
            };
            BoxHelper boxHelper = new BoxHelper();
            boxHelper.LoadToComboBox2(cboMenu, items, a => a.Id, a => a.Name, "Select to CRUD..");
            cboMenu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Tạo Panel chứa các mục menu
        private Panel CreateDropDownMenu()
        {
            Panel panel = new Panel
            {
                Size = new Size(200, 250),
                BackColor = Color.White
            };

            int y = 10;

            // Mục 1: Tài khoản Google
            Label lblAccount = new Label()
            {
                Text = "Account",
                AutoSize = false,
                Size = new Size(180, 30),
                Location = new Point(10, y),
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            lblAccount.MouseEnter += (s, e) => lblAccount.BackColor = Color.Gainsboro;
            lblAccount.MouseLeave += (s, e) => lblAccount.BackColor = Color.Transparent;
            lblAccount.Click += (s, e) => MessageBox.Show(_accountInfo);
            panel.Controls.Add(lblAccount);
            y += 40;

            // Nếu flag == 1 thì thêm 2 mục: Quản lý tài khoản và Thống kê
            if (flag == 1)
            {
                Label lblManageAccount = new Label()
                {
                    Text = "Account Managerment",
                    AutoSize = false,
                    Size = new Size(180, 30),
                    Location = new Point(10, y),
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
                };
                lblManageAccount.MouseEnter += (s, e) => lblManageAccount.BackColor = Color.Gainsboro;
                lblManageAccount.MouseLeave += (s, e) => lblManageAccount.BackColor = Color.Transparent;
                lblManageAccount.Click += (s, e) =>
                {
                    EmployeeMainUI f = new EmployeeMainUI();
                    f.ShowDialog();
                };
                panel.Controls.Add(lblManageAccount);
                y += 40;

                Label lblStatistics = new Label()
                {
                    Text = "Analytics",
                    AutoSize = false,
                    Size = new Size(180, 30),
                    Location = new Point(10, y),
                    Cursor = Cursors.Hand,
                    BackColor = Color.Transparent
                };
                lblStatistics.MouseEnter += (s, e) => lblStatistics.BackColor = Color.Gainsboro;
                lblStatistics.MouseLeave += (s, e) => lblStatistics.BackColor = Color.Transparent;
                lblStatistics.Click += (s, e) => 
                {
                    StatisticAllChartForm f = new StatisticAllChartForm();
                    f.ShowDialog();
                };
                panel.Controls.Add(lblStatistics);
                y += 40;
            }

            // Mục cuối: Đăng xuất
            Label lblLogout = new Label()
            {
                Text = "Logout",
                AutoSize = false,
                Size = new Size(180, 30),
                Location = new Point(10, y),
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            lblLogout.MouseEnter += (s, e) => lblLogout.BackColor = Color.Gainsboro;
            lblLogout.MouseLeave += (s, e) => lblLogout.BackColor = Color.Transparent;
            lblLogout.Click += (s, e) =>
            {
                if (MessageBox.Show("Do you really want to logout", "Logout confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
            };
            panel.Controls.Add(lblLogout);

            return panel;
        }

        // Hiển thị DropDown tại vị trí dưới nút gọi
        private void ShowCustomDropDown(Control parent)
        {
            Panel menuPanel = CreateDropDownMenu();

            ToolStripControlHost host = new ToolStripControlHost(menuPanel);
            ToolStripDropDown dropDown = new ToolStripDropDown
            {
                Padding = Padding.Empty,
                Margin = Padding.Empty,
                AutoClose = true
            };

            dropDown.Items.Add(host);
            var location = new Point(0, parent.Height);
            dropDown.Show(parent, location);
        }




        private void btnBook_Click(object sender, EventArgs e)
        {
            BookManagerMainUI f = new();
            f.ShowDialog();
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            SalesInvoiceMainUI f = new();
            f.ShowDialog();
        }

        private void btnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceForm f = new();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            SubObManagerUI f = new SubObManagerUI();

            switch (cboMenu.SelectedValue)
            {
                case "1":
                    f.flag = 1;
                    break;
                case "2":
                    f.flag = 2;
                    break;
                case "3":
                    f.flag = 3;
                    break;
                case "4":
                    f.flag = 4;
                    break;
            }
            f.ShowDialog();
        }


        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            ShowCustomDropDown(ptbAvatar);
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
