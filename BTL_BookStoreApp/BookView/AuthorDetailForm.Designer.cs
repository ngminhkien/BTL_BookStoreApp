namespace BTL_BookStoreApp.BookView
{
    partial class AuthorDetailForm
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
            grbAuthorInfo = new GroupBox();
            dtpBirthOfDate = new DateTimePicker();
            cboGender = new ComboBox();
            txtAddress = new TextBox();
            txtAuthorName = new TextBox();
            txtAuthorId = new TextBox();
            lblAuthorId = new Label();
            lblAuthorName = new Label();
            txtDateOfBirth = new Label();
            lblGender = new Label();
            lblAddress = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            grbAuthorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(30, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(413, 81);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Add a Author";
            // 
            // grbAuthorInfo
            // 
            grbAuthorInfo.Controls.Add(dtpBirthOfDate);
            grbAuthorInfo.Controls.Add(cboGender);
            grbAuthorInfo.Controls.Add(txtAddress);
            grbAuthorInfo.Controls.Add(txtAuthorName);
            grbAuthorInfo.Controls.Add(txtAuthorId);
            grbAuthorInfo.Controls.Add(lblAuthorId);
            grbAuthorInfo.Controls.Add(lblAuthorName);
            grbAuthorInfo.Controls.Add(txtDateOfBirth);
            grbAuthorInfo.Controls.Add(lblGender);
            grbAuthorInfo.Controls.Add(lblAddress);
            grbAuthorInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbAuthorInfo.Location = new Point(30, 108);
            grbAuthorInfo.Name = "grbAuthorInfo";
            grbAuthorInfo.Size = new Size(683, 433);
            grbAuthorInfo.TabIndex = 2;
            grbAuthorInfo.TabStop = false;
            grbAuthorInfo.Text = " Author Info ";
            // 
            // dtpBirthOfDate
            // 
            dtpBirthOfDate.Format = DateTimePickerFormat.Short;
            dtpBirthOfDate.Location = new Point(210, 191);
            dtpBirthOfDate.Name = "dtpBirthOfDate";
            dtpBirthOfDate.Size = new Size(204, 34);
            dtpBirthOfDate.TabIndex = 13;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(210, 268);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(111, 36);
            cboGender.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(210, 338);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(215, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(210, 123);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(215, 34);
            txtAuthorName.TabIndex = 1;
            // 
            // txtAuthorId
            // 
            txtAuthorId.Location = new Point(210, 54);
            txtAuthorId.Name = "txtAuthorId";
            txtAuthorId.Size = new Size(215, 34);
            txtAuthorId.TabIndex = 0;
            // 
            // lblAuthorId
            // 
            lblAuthorId.AutoSize = true;
            lblAuthorId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorId.Location = new Point(16, 60);
            lblAuthorId.Name = "lblAuthorId";
            lblAuthorId.Size = new Size(97, 28);
            lblAuthorId.TabIndex = 3;
            lblAuthorId.Text = "Author ID";
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorName.Location = new Point(11, 126);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(130, 28);
            lblAuthorName.TabIndex = 4;
            lblAuthorName.Text = "Author Name";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.AutoSize = true;
            txtDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDateOfBirth.Location = new Point(16, 196);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(125, 28);
            txtDateOfBirth.TabIndex = 5;
            txtDateOfBirth.Text = "Birth Of Date";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(16, 268);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
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
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(761, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(761, 208);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-1, 541);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 14;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // AuthorDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbAuthorInfo);
            Controls.Add(lblHeader);
            Name = "AuthorDetailForm";
            Text = "AuthorDetailForm";
            Load += AuthorDetailForm_Load;
            grbAuthorInfo.ResumeLayout(false);
            grbAuthorInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbAuthorInfo;
        private DateTimePicker dtpBirthOfDate;
        private ComboBox cboGender;
        private TextBox txtAddress;
        private TextBox txtAuthorName;
        private TextBox txtAuthorId;
        private Label lblAuthorId;
        private Label lblAuthorName;
        private Label txtDateOfBirth;
        private Label lblGender;
        private Label lblAddress;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
    }
}