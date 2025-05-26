namespace BTL_BookStoreApp.BillView
{
    partial class PurchaseInvoiceForm
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
            grbSearchCriteria = new GroupBox();
            cboSupplierName = new ComboBox();
            cboEmployeeName = new ComboBox();
            mtbInvoiceDate = new MaskedTextBox();
            lblEmployeeName = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceId = new TextBox();
            lblPhone = new Label();
            btnSearch = new Button();
            lblInvoiceId = new Label();
            lblSalesInvoiceList = new Label();
            dgvPurchaseInvoiceList = new DataGridView();
            btnShow = new Button();
            btnCRUD = new Button();
            btnExit = new Button();
            label1 = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseInvoiceList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(1, -8);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(773, 81);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Purchase Invoice Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(cboSupplierName);
            grbSearchCriteria.Controls.Add(cboEmployeeName);
            grbSearchCriteria.Controls.Add(mtbInvoiceDate);
            grbSearchCriteria.Controls.Add(lblEmployeeName);
            grbSearchCriteria.Controls.Add(lblInvoiceDate);
            grbSearchCriteria.Controls.Add(txtInvoiceId);
            grbSearchCriteria.Controls.Add(lblPhone);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(lblInvoiceId);
            grbSearchCriteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbSearchCriteria.Location = new Point(1, 95);
            grbSearchCriteria.Margin = new Padding(4);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(4);
            grbSearchCriteria.Size = new Size(1261, 223);
            grbSearchCriteria.TabIndex = 3;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // cboSupplierName
            // 
            cboSupplierName.FormattingEnabled = true;
            cboSupplierName.Location = new Point(714, 62);
            cboSupplierName.Name = "cboSupplierName";
            cboSupplierName.Size = new Size(255, 36);
            cboSupplierName.TabIndex = 14;
            // 
            // cboEmployeeName
            // 
            cboEmployeeName.FormattingEnabled = true;
            cboEmployeeName.Location = new Point(714, 141);
            cboEmployeeName.Name = "cboEmployeeName";
            cboEmployeeName.Size = new Size(255, 36);
            cboEmployeeName.TabIndex = 3;
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
            lblEmployeeName.Location = new Point(536, 147);
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
            lblInvoiceDate.Location = new Point(9, 147);
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
            lblPhone.Location = new Point(536, 65);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(142, 28);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Supplier Name";
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
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceId.Location = new Point(9, 65);
            lblInvoiceId.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(98, 28);
            lblInvoiceId.TabIndex = 9;
            lblInvoiceId.Text = "Invoice ID";
            // 
            // lblSalesInvoiceList
            // 
            lblSalesInvoiceList.AutoSize = true;
            lblSalesInvoiceList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesInvoiceList.Location = new Point(1, 325);
            lblSalesInvoiceList.Margin = new Padding(4, 0, 4, 0);
            lblSalesInvoiceList.Name = "lblSalesInvoiceList";
            lblSalesInvoiceList.Size = new Size(190, 28);
            lblSalesInvoiceList.TabIndex = 14;
            lblSalesInvoiceList.Text = "Purchase Invoice List";
            // 
            // dgvPurchaseInvoiceList
            // 
            dgvPurchaseInvoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseInvoiceList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseInvoiceList.Location = new Point(1, 357);
            dgvPurchaseInvoiceList.Margin = new Padding(4);
            dgvPurchaseInvoiceList.Name = "dgvPurchaseInvoiceList";
            dgvPurchaseInvoiceList.RowHeadersWidth = 51;
            dgvPurchaseInvoiceList.Size = new Size(969, 364);
            dgvPurchaseInvoiceList.TabIndex = 15;
            dgvPurchaseInvoiceList.SelectionChanged += dgvPurchaseInvoiceList_SelectionChanged;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(1060, 357);
            btnShow.Margin = new Padding(4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(173, 53);
            btnShow.TabIndex = 16;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnCRUD
            // 
            btnCRUD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCRUD.Location = new Point(1060, 448);
            btnCRUD.Margin = new Padding(4);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(173, 53);
            btnCRUD.TabIndex = 17;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = true;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1060, 668);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 53);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(1, 732);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 19;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // PurchaseInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 764);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCRUD);
            Controls.Add(btnShow);
            Controls.Add(dgvPurchaseInvoiceList);
            Controls.Add(lblSalesInvoiceList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            Name = "PurchaseInvoiceForm";
            Text = "PurchaseInvoiceForm";
            Load += PurchaseInvoiceForm_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseInvoiceList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private ComboBox cboEmployeeName;
        private MaskedTextBox mtbInvoiceDate;
        private Label lblEmployeeName;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceId;
        private Label lblPhone;
        private Button btnSearch;
        private Label lblInvoiceId;
        private Label lblSalesInvoiceList;
        private DataGridView dgvPurchaseInvoiceList;
        private Button btnShow;
        private Button btnCRUD;
        private Button btnExit;
        private ComboBox cboSupplierName;
        private Label label1;
    }
}