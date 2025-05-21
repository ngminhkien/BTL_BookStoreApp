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
            cboSupplierName = new ComboBox();
            txtNote = new TextBox();
            mtbInvoiceDate = new MaskedTextBox();
            txtEmployeeID = new TextBox();
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
            btnPrint = new Button();
            btnCancel = new Button();
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
            grbInvoiceInfo.Controls.Add(cboSupplierName);
            grbInvoiceInfo.Controls.Add(txtNote);
            grbInvoiceInfo.Controls.Add(mtbInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtEmployeeID);
            grbInvoiceInfo.Controls.Add(lblEmployeeID);
            grbInvoiceInfo.Controls.Add(lblInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtInvoiceId);
            grbInvoiceInfo.Controls.Add(lblCustomerId);
            grbInvoiceInfo.Controls.Add(lblInvoiceId);
            grbInvoiceInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInvoiceInfo.Location = new Point(3, 76);
            grbInvoiceInfo.Margin = new Padding(4);
            grbInvoiceInfo.Name = "grbInvoiceInfo";
            grbInvoiceInfo.Padding = new Padding(4);
            grbInvoiceInfo.Size = new Size(1261, 223);
            grbInvoiceInfo.TabIndex = 6;
            grbInvoiceInfo.TabStop = false;
            grbInvoiceInfo.Text = "  Invoice Info ";
            // 
            // cboSupplierName
            // 
            cboSupplierName.FormattingEnabled = true;
            cboSupplierName.Location = new Point(513, 67);
            cboSupplierName.Name = "cboSupplierName";
            cboSupplierName.Size = new Size(254, 36);
            cboSupplierName.TabIndex = 25;
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
            mtbInvoiceDate.Location = new Point(513, 146);
            mtbInvoiceDate.Margin = new Padding(4);
            mtbInvoiceDate.Mask = "00/00/0000 90:00";
            mtbInvoiceDate.Name = "mtbInvoiceDate";
            mtbInvoiceDate.Size = new Size(254, 34);
            mtbInvoiceDate.TabIndex = 24;
            mtbInvoiceDate.ValidatingType = typeof(DateTime);
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(151, 146);
            txtEmployeeID.Margin = new Padding(4);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(157, 34);
            txtEmployeeID.TabIndex = 12;
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
            lblInvoiceDate.Location = new Point(345, 147);
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
            lblBooksInfoDetails.Location = new Point(3, 303);
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
            dgvBooksInfoDetails.Location = new Point(12, 335);
            dgvBooksInfoDetails.Margin = new Padding(4);
            dgvBooksInfoDetails.Name = "dgvBooksInfoDetails";
            dgvBooksInfoDetails.RowHeadersWidth = 51;
            dgvBooksInfoDetails.Size = new Size(969, 388);
            dgvBooksInfoDetails.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1057, 335);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 53);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1057, 415);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1057, 514);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 53);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1057, 587);
            btnPrint.Margin = new Padding(4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(173, 53);
            btnPrint.TabIndex = 25;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1057, 670);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // PurchaseInvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 754);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooksInfoDetails);
            Controls.Add(lblBooksInfoDetails);
            Controls.Add(grbInvoiceInfo);
            Controls.Add(lblHeader);
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
        private TextBox txtEmployeeID;
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
        private Button btnPrint;
        private Button btnCancel;
    }
}