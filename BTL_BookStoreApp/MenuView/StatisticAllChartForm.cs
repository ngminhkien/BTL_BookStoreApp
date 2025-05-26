using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;

namespace BTL_BookStoreApp.MenuView
{
    public partial class StatisticAllChartForm : Form
    {

        FuncrionAnalytics _funcChart = new();
        public StatisticAllChartForm()
        {
            InitializeComponent();
        }

        private void StatisticAllChartForm_Load(object sender, EventArgs e)
        {
            var yearItems = new List<object>
            {
                 new { Text = "Chọn năm...", Value = -1 },
                 new { Text = "2024", Value = 2024 },
                new { Text = "2025", Value = 2025 }
            };


            cboYear.DataSource = yearItems;
            cboYear.DisplayMember = "Text";
            cboYear.ValueMember = "Value";

            cboYear2.DataSource = yearItems;
            cboYear2.DisplayMember = "Text";
            cboYear2.ValueMember = "Value";

            cboYear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)cboYear.SelectedItem;
            int selectedYear = Convert.ToInt32(selectedItem.Value);

            if (selectedYear == -1)
            {
                pnlChart.Controls.Clear();
            }
            else
            {
                _funcChart.DrawRevenueByMonth(selectedYear, pnlChart);
            }

        }

        private void btnBookCategory_Click(object sender, EventArgs e)
        {
            pnlChart.Controls.Clear();

            cboYear.SelectedValue = -1;

            _funcChart.DrawBooksSoldByCategory(pnlChart);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlChart.Controls.Clear();

            _funcChart.ShowBookstoreStatistics(pnlChart);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit this form", "Exit confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void cboYear2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)cboYear2.SelectedItem;
            int selectedYear = Convert.ToInt32(selectedItem.Value);

            if (selectedYear == -1)
            {
                pnlChart.Controls.Clear();
            }
            else
            {
                _funcChart.DrawRevenueByEmployee(selectedYear, pnlChart);
            }
        }
    }
}
