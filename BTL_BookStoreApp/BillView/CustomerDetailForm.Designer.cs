namespace BTL_BookStoreApp.BillView
{
    partial class CustomerDetailForm
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
            grbCustomerInfo = new GroupBox();
            mtbPhone = new MaskedTextBox();
            txtAddress = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerId = new TextBox();
            lblPublisherId = new Label();
            lblPublisherName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblHeader = new Label();
            label1 = new Label();
            grbCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(770, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(770, 118);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbCustomerInfo
            // 
            grbCustomerInfo.Controls.Add(mtbPhone);
            grbCustomerInfo.Controls.Add(txtAddress);
            grbCustomerInfo.Controls.Add(txtCustomerName);
            grbCustomerInfo.Controls.Add(txtCustomerId);
            grbCustomerInfo.Controls.Add(lblPublisherId);
            grbCustomerInfo.Controls.Add(lblPublisherName);
            grbCustomerInfo.Controls.Add(lblPhone);
            grbCustomerInfo.Controls.Add(lblAddress);
            grbCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbCustomerInfo.Location = new Point(30, 104);
            grbCustomerInfo.Name = "grbCustomerInfo";
            grbCustomerInfo.Size = new Size(683, 433);
            grbCustomerInfo.TabIndex = 9;
            grbCustomerInfo.TabStop = false;
            grbCustomerInfo.Text = " Customer Info ";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(210, 239);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(215, 34);
            mtbPhone.TabIndex = 8;
            mtbPhone.Leave += mtbPhone_Leave;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(210, 338);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(210, 142);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(215, 34);
            txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(210, 54);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(215, 34);
            txtCustomerId.TabIndex = 0;
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisherId.Location = new Point(16, 60);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(120, 28);
            lblPublisherId.TabIndex = 3;
            lblPublisherId.Text = "Customer ID";
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisherName.Location = new Point(16, 145);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(153, 28);
            lblPublisherName.TabIndex = 4;
            lblPublisherName.Text = "Customer Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(16, 242);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(16, 341);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(30, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(485, 81);
            lblHeader.TabIndex = 8;
            lblHeader.Text = "Add a Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-3, 541);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 12;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // CustomerDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbCustomerInfo);
            Controls.Add(lblHeader);
            Name = "CustomerDetailForm";
            Text = "CustomerDetailForm";
            Load += CustomerDetailForm_Load;
            grbCustomerInfo.ResumeLayout(false);
            grbCustomerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private GroupBox grbCustomerInfo;
        private MaskedTextBox mtbPhone;
        private TextBox txtAddress;
        private TextBox txtCustomerName;
        private TextBox txtCustomerId;
        private Label lblPublisherId;
        private Label lblPublisherName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblHeader;
        private Label label1;
    }
}