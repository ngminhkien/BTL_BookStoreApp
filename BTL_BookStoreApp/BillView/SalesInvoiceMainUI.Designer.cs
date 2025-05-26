namespace BTL_BookStoreApp.BillView
{
    partial class SalesInvoiceMainUI
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
            lblHeader = new Label();
            btnSearch = new Button();
            dgvSalesInvoiceList = new DataGridView();
            lblSalesInvoiceList = new Label();
            btnShow = new Button();
            btnCRUD = new Button();
            btnExit = new Button();
            grbSearchCriteria = new GroupBox();
            lblDate = new Label();
            cboEmployeeName = new ComboBox();
            mtbPhone = new MaskedTextBox();
            mtbInvoiceDate = new MaskedTextBox();
            lblEmployeeName = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceId = new TextBox();
            lblPhone = new Label();
            lblInvoiceId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalesInvoiceList).BeginInit();
            grbSearchCriteria.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(-2, -4);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(662, 81);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Sales Invoice Manager";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1059, 139);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 53);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSalesInvoiceList
            // 
            dgvSalesInvoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSalesInvoiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesInvoiceList.Location = new Point(16, 400);
            dgvSalesInvoiceList.Margin = new Padding(4);
            dgvSalesInvoiceList.Name = "dgvSalesInvoiceList";
            dgvSalesInvoiceList.RowHeadersWidth = 51;
            dgvSalesInvoiceList.Size = new Size(969, 364);
            dgvSalesInvoiceList.TabIndex = 4;
            dgvSalesInvoiceList.SelectionChanged += dgvSalesInvoiceList_SelectionChanged;
            // 
            // lblSalesInvoiceList
            // 
            lblSalesInvoiceList.AutoSize = true;
            lblSalesInvoiceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesInvoiceList.Location = new Point(16, 346);
            lblSalesInvoiceList.Margin = new Padding(4, 0, 4, 0);
            lblSalesInvoiceList.Name = "lblSalesInvoiceList";
            lblSalesInvoiceList.Size = new Size(157, 28);
            lblSalesInvoiceList.TabIndex = 5;
            lblSalesInvoiceList.Text = "Sales Invoice List";
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(1075, 400);
            btnShow.Margin = new Padding(4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(173, 53);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnCRUD
            // 
            btnCRUD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCRUD.Location = new Point(1075, 486);
            btnCRUD.Margin = new Padding(4);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(173, 53);
            btnCRUD.TabIndex = 2;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = true;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1075, 711);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 53);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(lblDate);
            grbSearchCriteria.Controls.Add(cboEmployeeName);
            grbSearchCriteria.Controls.Add(mtbPhone);
            grbSearchCriteria.Controls.Add(mtbInvoiceDate);
            grbSearchCriteria.Controls.Add(lblEmployeeName);
            grbSearchCriteria.Controls.Add(lblInvoiceDate);
            grbSearchCriteria.Controls.Add(txtInvoiceId);
            grbSearchCriteria.Controls.Add(lblPhone);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(lblInvoiceId);
            grbSearchCriteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbSearchCriteria.Location = new Point(16, 119);
            grbSearchCriteria.Margin = new Padding(4);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(4);
            grbSearchCriteria.Size = new Size(1261, 223);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = SystemColors.Control;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Red;
            lblDate.Location = new Point(188, 179);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(206, 28);
            lblDate.TabIndex = 27;
            lblDate.Text = "(MM/dd/yyyy HH:mm)";
            // 
            // cboEmployeeName
            // 
            cboEmployeeName.FormattingEnabled = true;
            cboEmployeeName.Location = new Point(714, 141);
            cboEmployeeName.Name = "cboEmployeeName";
            cboEmployeeName.Size = new Size(255, 36);
            cboEmployeeName.TabIndex = 3;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(714, 61);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(255, 34);
            mtbPhone.TabIndex = 1;
            // 
            // mtbInvoiceDate
            // 
            mtbInvoiceDate.Location = new Point(188, 141);
            mtbInvoiceDate.Margin = new Padding(4);
            mtbInvoiceDate.Mask = "00/00/0000 90:00";
            mtbInvoiceDate.Name = "mtbInvoiceDate";
            mtbInvoiceDate.Size = new Size(254, 34);
            mtbInvoiceDate.TabIndex = 2;
            mtbInvoiceDate.ValidatingType = typeof(DateTime);
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(535, 146);
            lblEmployeeName.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(99, 28);
            lblEmployeeName.TabIndex = 13;
            lblEmployeeName.Text = "EPL Name";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceDate.Location = new Point(8, 146);
            lblInvoiceDate.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(120, 28);
            lblInvoiceDate.TabIndex = 11;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvoiceId.Location = new Point(188, 60);
            txtInvoiceId.Margin = new Padding(4);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.Size = new Size(254, 34);
            txtInvoiceId.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(535, 64);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceId.Location = new Point(8, 64);
            lblInvoiceId.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(98, 28);
            lblInvoiceId.TabIndex = 9;
            lblInvoiceId.Text = "Invoice ID";
            // 
            // SalesInvoiceMainUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(grbSearchCriteria);
            Controls.Add(btnExit);
            Controls.Add(btnCRUD);
            Controls.Add(btnShow);
            Controls.Add(lblSalesInvoiceList);
            Controls.Add(dgvSalesInvoiceList);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SalesInvoiceMainUI";
            Text = "SalesInvoiceMainUI";
            Load += SalesInvoiceMainUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesInvoiceList).EndInit();
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnSearch;
        private DataGridView dgvSalesInvoiceList;
        private Label lblSalesInvoiceList;
        private Button btnShow;
        private Button btnCRUD;
        private Button btnExit;
        private GroupBox grbSearchCriteria;
        private Label lblEmployeeName;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceId;
        private Label lblPhone;
        private Label lblInvoiceId;
        private MaskedTextBox mtbInvoiceDate;
        private MaskedTextBox mtbPhone;
        private ComboBox cboEmployeeName;
        private Label lblDate;
    }
}