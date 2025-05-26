namespace BTL_BookStoreApp.BillView
{
    partial class PurchaseInvoiceDetailForm
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
            grbInvoiceInfo = new GroupBox();
            cboEmployeeID = new ComboBox();
            cboSupplierName = new ComboBox();
            txtNote = new TextBox();
            mtbInvoiceDate = new MaskedTextBox();
            lblEmployeeID = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceId = new TextBox();
            lblCustomerId = new Label();
            lblInvoiceId = new Label();
            lblBooksInfoDetails = new Label();
            dgvBooksInfoDetails = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            lblReport = new Label();
            label1 = new Label();
            grbInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(13, -9);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(564, 81);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "A Purchase Invoice";
            // 
            // grbInvoiceInfo
            // 
            grbInvoiceInfo.Controls.Add(cboEmployeeID);
            grbInvoiceInfo.Controls.Add(cboSupplierName);
            grbInvoiceInfo.Controls.Add(txtNote);
            grbInvoiceInfo.Controls.Add(mtbInvoiceDate);
            grbInvoiceInfo.Controls.Add(lblEmployeeID);
            grbInvoiceInfo.Controls.Add(lblInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtInvoiceId);
            grbInvoiceInfo.Controls.Add(lblCustomerId);
            grbInvoiceInfo.Controls.Add(lblInvoiceId);
            grbInvoiceInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInvoiceInfo.Location = new Point(3, 92);
            grbInvoiceInfo.Margin = new Padding(4);
            grbInvoiceInfo.Name = "grbInvoiceInfo";
            grbInvoiceInfo.Padding = new Padding(4);
            grbInvoiceInfo.Size = new Size(1261, 207);
            grbInvoiceInfo.TabIndex = 6;
            grbInvoiceInfo.TabStop = false;
            grbInvoiceInfo.Text = "  Invoice Info ";
            // 
            // cboEmployeeID
            // 
            cboEmployeeID.FormattingEnabled = true;
            cboEmployeeID.Location = new Point(151, 148);
            cboEmployeeID.Name = "cboEmployeeID";
            cboEmployeeID.Size = new Size(157, 36);
            cboEmployeeID.TabIndex = 27;
            // 
            // cboSupplierName
            // 
            cboSupplierName.FormattingEnabled = true;
            cboSupplierName.Location = new Point(513, 67);
            cboSupplierName.Name = "cboSupplierName";
            cboSupplierName.Size = new Size(254, 36);
            cboSupplierName.TabIndex = 25;
            cboSupplierName.SelectedIndexChanged += cboSupplierName_SelectedIndexChanged;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(824, 43);
            txtNote.Margin = new Padding(6);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(426, 148);
            txtNote.TabIndex = 23;
            txtNote.Text = "Note here: ";
            // 
            // mtbInvoiceDate
            // 
            mtbInvoiceDate.Location = new Point(513, 148);
            mtbInvoiceDate.Margin = new Padding(4);
            mtbInvoiceDate.Mask = "00/00/0000 90:00";
            mtbInvoiceDate.Name = "mtbInvoiceDate";
            mtbInvoiceDate.Size = new Size(254, 34);
            mtbInvoiceDate.TabIndex = 24;
            mtbInvoiceDate.ValidatingType = typeof(DateTime);
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeID.Location = new Point(9, 151);
            lblEmployeeID.Margin = new Padding(4, 0, 4, 0);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new Size(66, 28);
            lblEmployeeID.TabIndex = 13;
            lblEmployeeID.Text = "EPL ID";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceDate.Location = new Point(345, 151);
            lblInvoiceDate.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(120, 28);
            lblInvoiceDate.TabIndex = 11;
            lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvoiceId.Location = new Point(151, 62);
            txtInvoiceId.Margin = new Padding(4);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.Size = new Size(157, 34);
            txtInvoiceId.TabIndex = 0;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerId.Location = new Point(345, 67);
            lblCustomerId.Margin = new Padding(4, 0, 4, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(103, 28);
            lblCustomerId.TabIndex = 10;
            lblCustomerId.Text = "Sup Name";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceId.Location = new Point(9, 67);
            lblInvoiceId.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(98, 28);
            lblInvoiceId.TabIndex = 9;
            lblInvoiceId.Text = "Invoice ID";
            // 
            // lblBooksInfoDetails
            // 
            lblBooksInfoDetails.AutoSize = true;
            lblBooksInfoDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBooksInfoDetails.Location = new Point(3, 313);
            lblBooksInfoDetails.Margin = new Padding(4, 0, 4, 0);
            lblBooksInfoDetails.Name = "lblBooksInfoDetails";
            lblBooksInfoDetails.Size = new Size(168, 28);
            lblBooksInfoDetails.TabIndex = 18;
            lblBooksInfoDetails.Text = "Books Info Details";
            // 
            // dgvBooksInfoDetails
            // 
            dgvBooksInfoDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooksInfoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooksInfoDetails.Location = new Point(12, 345);
            dgvBooksInfoDetails.Margin = new Padding(4);
            dgvBooksInfoDetails.Name = "dgvBooksInfoDetails";
            dgvBooksInfoDetails.RowHeadersWidth = 51;
            dgvBooksInfoDetails.Size = new Size(969, 323);
            dgvBooksInfoDetails.TabIndex = 19;
            dgvBooksInfoDetails.CellValidating += dgvBooksInfoDetails_CellValidating;
            dgvBooksInfoDetails.SelectionChanged += dgvBooksInfoDetails_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1057, 348);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 53);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1057, 409);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1057, 527);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 53);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1057, 618);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(103, 698);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(157, 34);
            txtTotal.TabIndex = 27;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(17, 704);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 28);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total";
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReport.ForeColor = Color.Red;
            lblReport.ImageAlign = ContentAlignment.MiddleRight;
            lblReport.Location = new Point(299, 303);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(16, 28);
            lblReport.TabIndex = 29;
            lblReport.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(2, 768);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 30;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // PurchaseInvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(label1);
            Controls.Add(lblReport);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooksInfoDetails);
            Controls.Add(lblBooksInfoDetails);
            Controls.Add(grbInvoiceInfo);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "PurchaseInvoiceDetailForm";
            Text = "PurchaseInvoiceDetailForm";
            Load += PurchaseInvoiceDetailForm_Load;
            grbInvoiceInfo.ResumeLayout(false);
            grbInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbInvoiceInfo;
        private TextBox txtNote;
        private MaskedTextBox mtbInvoiceDate;
        private Label lblEmployeeID;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceId;
        private Label lblCustomerId;
        private Label lblInvoiceId;
        private ComboBox cboSupplierName;
        private Label lblBooksInfoDetails;
        private DataGridView dgvBooksInfoDetails;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtTotal;
        private Label lblTotal;
        private ComboBox cboEmployeeID;
        private Label lblReport;
        private Label label1;
    }
}