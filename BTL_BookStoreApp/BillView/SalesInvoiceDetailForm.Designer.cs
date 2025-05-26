namespace BTL_BookStoreApp.BillView
{
    partial class SalesInvoiceDetailForm
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
            grbInvoiceInfo = new GroupBox();
            cboEmployeeID = new ComboBox();
            mtbPhone = new MaskedTextBox();
            txtNote = new TextBox();
            mtbInvoiceDate = new MaskedTextBox();
            lblEmployeeID = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceId = new TextBox();
            lblCustomerId = new Label();
            lblInvoiceId = new Label();
            lblHeader = new Label();
            dgvBooksInfoDetails = new DataGridView();
            lblBooksInfoDetails = new Label();
            btnSave = new Button();
            btnAdd = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            lblReport = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            label1 = new Label();
            grbInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).BeginInit();
            SuspendLayout();
            // 
            // grbInvoiceInfo
            // 
            grbInvoiceInfo.Controls.Add(cboEmployeeID);
            grbInvoiceInfo.Controls.Add(mtbPhone);
            grbInvoiceInfo.Controls.Add(txtNote);
            grbInvoiceInfo.Controls.Add(mtbInvoiceDate);
            grbInvoiceInfo.Controls.Add(lblEmployeeID);
            grbInvoiceInfo.Controls.Add(lblInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtInvoiceId);
            grbInvoiceInfo.Controls.Add(lblCustomerId);
            grbInvoiceInfo.Controls.Add(lblInvoiceId);
            grbInvoiceInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInvoiceInfo.Location = new Point(16, 109);
            grbInvoiceInfo.Margin = new Padding(4);
            grbInvoiceInfo.Name = "grbInvoiceInfo";
            grbInvoiceInfo.Padding = new Padding(4);
            grbInvoiceInfo.Size = new Size(1261, 223);
            grbInvoiceInfo.TabIndex = 3;
            grbInvoiceInfo.TabStop = false;
            grbInvoiceInfo.Text = "  Invoice Info ";
            // 
            // cboEmployeeID
            // 
            cboEmployeeID.FormattingEnabled = true;
            cboEmployeeID.Location = new Point(151, 147);
            cboEmployeeID.Name = "cboEmployeeID";
            cboEmployeeID.Size = new Size(157, 36);
            cboEmployeeID.TabIndex = 26;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(512, 63);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(255, 34);
            mtbPhone.TabIndex = 25;
            mtbPhone.Leave += mtbPhone_Leave;
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
            mtbInvoiceDate.Location = new Point(513, 147);
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
            lblEmployeeID.Location = new Point(8, 150);
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
            lblInvoiceDate.Location = new Point(343, 149);
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
            lblCustomerId.Location = new Point(344, 66);
            lblCustomerId.Margin = new Padding(4, 0, 4, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(67, 28);
            lblCustomerId.TabIndex = 10;
            lblCustomerId.Text = "Phone";
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvoiceId.Location = new Point(8, 66);
            lblInvoiceId.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(98, 28);
            lblInvoiceId.TabIndex = 9;
            lblInvoiceId.Text = "Invoice ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(16, -8);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(427, 81);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "A Sale Invoice";
            // 
            // dgvBooksInfoDetails
            // 
            dgvBooksInfoDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooksInfoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooksInfoDetails.Location = new Point(16, 379);
            dgvBooksInfoDetails.Margin = new Padding(4);
            dgvBooksInfoDetails.Name = "dgvBooksInfoDetails";
            dgvBooksInfoDetails.RowHeadersWidth = 51;
            dgvBooksInfoDetails.Size = new Size(969, 323);
            dgvBooksInfoDetails.TabIndex = 16;
            dgvBooksInfoDetails.CellValidating += dgvBooksInfoDetails_CellValidating;
            dgvBooksInfoDetails.SelectionChanged += dgvBooksInfoDetails_SelectionChanged;
            // 
            // lblBooksInfoDetails
            // 
            lblBooksInfoDetails.AutoSize = true;
            lblBooksInfoDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBooksInfoDetails.Location = new Point(16, 336);
            lblBooksInfoDetails.Margin = new Padding(4, 0, 4, 0);
            lblBooksInfoDetails.Name = "lblBooksInfoDetails";
            lblBooksInfoDetails.Size = new Size(168, 28);
            lblBooksInfoDetails.TabIndex = 17;
            lblBooksInfoDetails.Text = "Books Info Details";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1068, 551);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 53);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1068, 379);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 53);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1068, 649);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1068, 441);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.ForeColor = Color.Red;
            lblReport.ImageAlign = ContentAlignment.MiddleRight;
            lblReport.Location = new Point(308, 336);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(16, 28);
            lblReport.TabIndex = 23;
            lblReport.Text = ".";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(110, 720);
            txtTotal.Margin = new Padding(4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(157, 34);
            txtTotal.TabIndex = 24;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(24, 726);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 28);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 768);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 26;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // SalesInvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblReport);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(lblBooksInfoDetails);
            Controls.Add(dgvBooksInfoDetails);
            Controls.Add(lblHeader);
            Controls.Add(grbInvoiceInfo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SalesInvoiceDetailForm";
            Text = "SalesInvoiceDetailForm";
            Load += SalesInvoiceDetailForm_Load;
            grbInvoiceInfo.ResumeLayout(false);
            grbInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbInvoiceInfo;
        private Label lblEmployeeID;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceId;
        private Label lblCustomerId;
        private Label lblInvoiceId;
        private Label lblHeader;
        private DataGridView dgvBooksInfoDetails;
        private Label lblBooksInfoDetails;
        private Button btnSave;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnDelete;
        private TextBox txtNote;
        private MaskedTextBox mtbInvoiceDate;
        private MaskedTextBox mtbPhone;
        private Label lblReport;
        private ComboBox cboEmployeeID;
        private TextBox txtTotal;
        private Label lblTotal;
        private Label label1;
    }
}