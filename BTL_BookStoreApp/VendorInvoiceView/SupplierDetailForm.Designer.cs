namespace BTL_BookStoreApp.VendorInvoiceView
{
    partial class SupplierDetailForm
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
            btnCancel = new Button();
            btnSave = new Button();
            grbAuthorInfo = new GroupBox();
            mtbPhone = new MaskedTextBox();
            txtSupplierId = new TextBox();
            txtAddress = new TextBox();
            lblAuthorId = new Label();
            txtSupplierName = new TextBox();
            lblPublisherName = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblHeader = new Label();
            label1 = new Label();
            grbAuthorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(773, 192);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(773, 107);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbAuthorInfo
            // 
            grbAuthorInfo.Controls.Add(mtbPhone);
            grbAuthorInfo.Controls.Add(txtSupplierId);
            grbAuthorInfo.Controls.Add(txtAddress);
            grbAuthorInfo.Controls.Add(lblAuthorId);
            grbAuthorInfo.Controls.Add(txtSupplierName);
            grbAuthorInfo.Controls.Add(lblPublisherName);
            grbAuthorInfo.Controls.Add(lblAddress);
            grbAuthorInfo.Controls.Add(lblPhone);
            grbAuthorInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbAuthorInfo.Location = new Point(42, 92);
            grbAuthorInfo.Name = "grbAuthorInfo";
            grbAuthorInfo.Size = new Size(683, 433);
            grbAuthorInfo.TabIndex = 6;
            grbAuthorInfo.TabStop = false;
            grbAuthorInfo.Text = " Supplier Info ";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(210, 244);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(215, 34);
            mtbPhone.TabIndex = 14;
            mtbPhone.Leave += mtbPhone_Leave;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(210, 54);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(215, 34);
            txtSupplierId.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(210, 343);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 34);
            txtAddress.TabIndex = 12;
            // 
            // lblAuthorId
            // 
            lblAuthorId.AutoSize = true;
            lblAuthorId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorId.Location = new Point(16, 60);
            lblAuthorId.Name = "lblAuthorId";
            lblAuthorId.Size = new Size(109, 28);
            lblAuthorId.TabIndex = 3;
            lblAuthorId.Text = "Supplier ID";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(210, 147);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(215, 34);
            txtSupplierName.TabIndex = 9;
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisherName.Location = new Point(16, 150);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(149, 28);
            lblPublisherName.TabIndex = 10;
            lblPublisherName.Text = "Publisher Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(16, 346);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(16, 247);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Phone";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(42, -3);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(450, 81);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Add a Supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(2, 539);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 13;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // SupplierDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbAuthorInfo);
            Controls.Add(lblHeader);
            Name = "SupplierDetailForm";
            Text = "SupplierDetailForm";
            Load += SupplierDetailForm_Load;
            grbAuthorInfo.ResumeLayout(false);
            grbAuthorInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private GroupBox grbAuthorInfo;
        private TextBox txtSupplierId;
        private Label lblAuthorId;
        private Label lblHeader;
        private MaskedTextBox mtbPhone;
        private TextBox txtAddress;
        private TextBox txtSupplierName;
        private Label lblPublisherName;
        private Label lblAddress;
        private Label lblPhone;
        private Label label1;
    }
}