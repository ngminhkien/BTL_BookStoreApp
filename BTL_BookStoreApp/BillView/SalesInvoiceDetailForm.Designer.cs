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
            txtEmployeeID = new TextBox();
            lblEmployeeID = new Label();
            lblInvoiceDate = new Label();
            txtInvoiceId = new TextBox();
            lblPhone = new Label();
            lblInvoiceId = new Label();
            lblHeader = new Label();
            dgvBooksInfoDetails = new DataGridView();
            lblBooksInfoDetails = new Label();
            btnSave = new Button();
            btnAdd = new Button();
            btnPrint = new Button();
            btnCancel = new Button();
            btnDelete = new Button();
            mtbNote = new TextBox();
            mtbInvoiceDate = new MaskedTextBox();
            mtbPhone = new MaskedTextBox();
            grbInvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).BeginInit();
            SuspendLayout();
            // 
            // grbInvoiceInfo
            // 
            grbInvoiceInfo.Controls.Add(mtbNote);
            grbInvoiceInfo.Controls.Add(mtbPhone);
            grbInvoiceInfo.Controls.Add(mtbInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtEmployeeID);
            grbInvoiceInfo.Controls.Add(lblEmployeeID);
            grbInvoiceInfo.Controls.Add(lblInvoiceDate);
            grbInvoiceInfo.Controls.Add(txtInvoiceId);
            grbInvoiceInfo.Controls.Add(lblPhone);
            grbInvoiceInfo.Controls.Add(lblInvoiceId);
            grbInvoiceInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInvoiceInfo.Location = new Point(16, 109);
            grbInvoiceInfo.Margin = new Padding(4, 4, 4, 4);
            grbInvoiceInfo.Name = "grbInvoiceInfo";
            grbInvoiceInfo.Padding = new Padding(4, 4, 4, 4);
            grbInvoiceInfo.Size = new Size(1261, 223);
            grbInvoiceInfo.TabIndex = 3;
            grbInvoiceInfo.TabStop = false;
            grbInvoiceInfo.Text = "  Invoice Info ";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeID.Location = new Point(151, 146);
            txtEmployeeID.Margin = new Padding(4, 4, 4, 4);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(157, 34);
            txtEmployeeID.TabIndex = 12;
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
            lblInvoiceDate.Location = new Point(344, 146);
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
            txtInvoiceId.Margin = new Padding(4, 4, 4, 4);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.Size = new Size(157, 34);
            txtInvoiceId.TabIndex = 0;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(344, 66);
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
            dgvBooksInfoDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooksInfoDetails.Location = new Point(16, 379);
            dgvBooksInfoDetails.Margin = new Padding(4, 4, 4, 4);
            dgvBooksInfoDetails.Name = "dgvBooksInfoDetails";
            dgvBooksInfoDetails.RowHeadersWidth = 51;
            dgvBooksInfoDetails.Size = new Size(969, 388);
            dgvBooksInfoDetails.TabIndex = 16;
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
            btnSave.Location = new Point(1068, 550);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(173, 53);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1068, 379);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 53);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.FlatStyle = FlatStyle.System;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1068, 612);
            btnPrint.Margin = new Padding(4, 4, 4, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(173, 53);
            btnPrint.TabIndex = 20;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(1068, 714);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1068, 441);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // mtbNote
            // 
            mtbNote.Location = new Point(824, 43);
            mtbNote.Margin = new Padding(6, 6, 6, 6);
            mtbNote.Multiline = true;
            mtbNote.Name = "mtbNote";
            mtbNote.ScrollBars = ScrollBars.Vertical;
            mtbNote.Size = new Size(426, 148);
            mtbNote.TabIndex = 23;
            mtbNote.Text = "Note here: ";
            // 
            // mtbInvoiceDate
            // 
            mtbInvoiceDate.Location = new Point(513, 146);
            mtbInvoiceDate.Margin = new Padding(4, 4, 4, 4);
            mtbInvoiceDate.Mask = "00/00/0000 90:00";
            mtbInvoiceDate.Name = "mtbInvoiceDate";
            mtbInvoiceDate.Size = new Size(254, 34);
            mtbInvoiceDate.TabIndex = 24;
            mtbInvoiceDate.ValidatingType = typeof(DateTime);
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(513, 57);
            mtbPhone.Margin = new Padding(4, 4, 4, 4);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(254, 34);
            mtbPhone.TabIndex = 25;
            // 
            // SalesInvoiceDetailForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(btnPrint);
            Controls.Add(btnAdd);
            Controls.Add(btnSave);
            Controls.Add(lblBooksInfoDetails);
            Controls.Add(dgvBooksInfoDetails);
            Controls.Add(lblHeader);
            Controls.Add(grbInvoiceInfo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SalesInvoiceDetailForm";
            grbInvoiceInfo.ResumeLayout(false);
            grbInvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooksInfoDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbInvoiceInfo;
        private TextBox txtEmployeeID;
        private Label lblEmployeeID;
        private Label lblInvoiceDate;
        private TextBox txtInvoiceId;
        private Label lblPhone;
        private Label lblInvoiceId;
        private Label lblHeader;
        private DataGridView dgvBooksInfoDetails;
        private Label lblBooksInfoDetails;
        private Button btnSave;
        private Button btnAdd;
        private Button btnPrint;
        private Button btnCancel;
        private Button btnDelete;
        private TextBox mtbNote;
        private MaskedTextBox mtbInvoiceDate;
        private MaskedTextBox mtbPhone;
    }
}