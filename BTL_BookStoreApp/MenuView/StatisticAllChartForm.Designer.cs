namespace BTL_BookStoreApp.MenuView
{
    partial class StatisticAllChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChart = new Panel();
            cboYear = new ComboBox();
            btnBookCategory = new Button();
            button1 = new Button();
            btnCancel = new Button();
            label1 = new Label();
            cboYear2 = new ComboBox();
            SuspendLayout();
            // 
            // pnlChart
            // 
            pnlChart.BackColor = Color.Silver;
            pnlChart.Location = new Point(103, 100);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(1060, 504);
            pnlChart.TabIndex = 0;
            // 
            // cboYear
            // 
            cboYear.BackColor = Color.White;
            cboYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboYear.FormattingEnabled = true;
            cboYear.Location = new Point(103, 682);
            cboYear.Margin = new Padding(4);
            cboYear.Name = "cboYear";
            cboYear.Size = new Size(185, 36);
            cboYear.TabIndex = 23;
            cboYear.SelectedIndexChanged += cboMenu_SelectedIndexChanged;
            // 
            // btnBookCategory
            // 
            btnBookCategory.BackColor = Color.White;
            btnBookCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookCategory.Location = new Point(321, 673);
            btnBookCategory.Margin = new Padding(6);
            btnBookCategory.Name = "btnBookCategory";
            btnBookCategory.Size = new Size(184, 53);
            btnBookCategory.TabIndex = 24;
            btnBookCategory.Text = "BookCategory";
            btnBookCategory.UseVisualStyleBackColor = false;
            btnBookCategory.Click += btnBookCategory_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(771, 673);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(184, 53);
            button1.TabIndex = 25;
            button1.Text = "Show Info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(990, 673);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(184, 53);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1, 771);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 27;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // cboYear2
            // 
            cboYear2.BackColor = Color.White;
            cboYear2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboYear2.FormattingEnabled = true;
            cboYear2.Location = new Point(547, 682);
            cboYear2.Margin = new Padding(4);
            cboYear2.Name = "cboYear2";
            cboYear2.Size = new Size(185, 36);
            cboYear2.TabIndex = 29;
            cboYear2.SelectedIndexChanged += cboYear2_SelectedIndexChanged;
            // 
            // StatisticAllChartForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(cboYear2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(btnBookCategory);
            Controls.Add(cboYear);
            Controls.Add(pnlChart);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "StatisticAllChartForm";
            Text = "StatisticAllChartForm";
            Load += StatisticAllChartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChart;
        private ComboBox cboYear;
        private Button btnBookCategory;
        private Button button1;
        private Button btnCancel;
        private Label label1;
        private ComboBox cboYear2;
    }
}