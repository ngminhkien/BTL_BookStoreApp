namespace BTL_BookStoreApp.BookView
{
    partial class PublisherDetailForm
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
            grbPublisherInfo = new GroupBox();
            mtbPhone = new MaskedTextBox();
            txtAddress = new TextBox();
            txtPublisherName = new TextBox();
            txtPublisherId = new TextBox();
            lblPublisherId = new Label();
            lblPublisherName = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblHeader = new Label();
            grbPublisherInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(773, 215);
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
            btnSave.Location = new Point(773, 133);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbPublisherInfo
            // 
            grbPublisherInfo.Controls.Add(mtbPhone);
            grbPublisherInfo.Controls.Add(txtAddress);
            grbPublisherInfo.Controls.Add(txtPublisherName);
            grbPublisherInfo.Controls.Add(txtPublisherId);
            grbPublisherInfo.Controls.Add(lblPublisherId);
            grbPublisherInfo.Controls.Add(lblPublisherName);
            grbPublisherInfo.Controls.Add(lblPhone);
            grbPublisherInfo.Controls.Add(lblAddress);
            grbPublisherInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbPublisherInfo.Location = new Point(43, 115);
            grbPublisherInfo.Name = "grbPublisherInfo";
            grbPublisherInfo.Size = new Size(683, 433);
            grbPublisherInfo.TabIndex = 6;
            grbPublisherInfo.TabStop = false;
            grbPublisherInfo.Text = " Publisher Info ";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(210, 212);
            mtbPhone.Mask = "0000.000.000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(215, 34);
            mtbPhone.TabIndex = 9;
            mtbPhone.Leave += mtbPhone_Leave;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(210, 297);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(210, 136);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(215, 34);
            txtPublisherName.TabIndex = 1;
            // 
            // txtPublisherId
            // 
            txtPublisherId.Location = new Point(210, 54);
            txtPublisherId.Name = "txtPublisherId";
            txtPublisherId.Size = new Size(215, 34);
            txtPublisherId.TabIndex = 0;
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisherId.Location = new Point(16, 57);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(116, 28);
            lblPublisherId.TabIndex = 3;
            lblPublisherId.Text = "Publisher ID";
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisherName.Location = new Point(16, 139);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(149, 28);
            lblPublisherName.TabIndex = 4;
            lblPublisherName.Text = "Publisher Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(16, 215);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 28);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(16, 300);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 7;
            lblAddress.Text = "Address";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(43, -1);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(482, 81);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Add a Publisher";
            // 
            // PublisherDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbPublisherInfo);
            Controls.Add(lblHeader);
            Name = "PublisherDetailForm";
            Text = "PublisherDetailForm";
            Load += PublisherDetailForm_Load;
            grbPublisherInfo.ResumeLayout(false);
            grbPublisherInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private GroupBox grbPublisherInfo;
        private TextBox txtAddress;
        private TextBox txtPublisherName;
        private TextBox txtPublisherId;
        private Label lblPublisherId;
        private Label lblPublisherName;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblHeader;
        private MaskedTextBox mtbPhone;
    }
}