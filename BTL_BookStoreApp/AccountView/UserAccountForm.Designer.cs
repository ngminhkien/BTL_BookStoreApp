namespace BTL_BookStoreApp.AccountView
{
    partial class UserAccountForm
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
            grbUserAccountInfo = new GroupBox();
            lblRule = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblIdName = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            lblMemberID = new Label();
            lblEmail = new Label();
            btnSaveAndLogin = new Button();
            btnCancel = new Button();
            label1 = new Label();
            grbUserAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(366, 34);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(62, 60);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "2.";
            // 
            // grbUserAccountInfo
            // 
            grbUserAccountInfo.Controls.Add(lblRule);
            grbUserAccountInfo.Controls.Add(txtConfirmPassword);
            grbUserAccountInfo.Controls.Add(lblConfirmPassword);
            grbUserAccountInfo.Controls.Add(lblIdName);
            grbUserAccountInfo.Controls.Add(txtPassword);
            grbUserAccountInfo.Controls.Add(lblPassword);
            grbUserAccountInfo.Controls.Add(txtEmail);
            grbUserAccountInfo.Controls.Add(txtMemberID);
            grbUserAccountInfo.Controls.Add(lblMemberID);
            grbUserAccountInfo.Controls.Add(lblEmail);
            grbUserAccountInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbUserAccountInfo.Location = new Point(96, 119);
            grbUserAccountInfo.Name = "grbUserAccountInfo";
            grbUserAccountInfo.Size = new Size(683, 334);
            grbUserAccountInfo.TabIndex = 4;
            grbUserAccountInfo.TabStop = false;
            grbUserAccountInfo.Text = "User Account Info ";
            // 
            // lblRule
            // 
            lblRule.AutoSize = true;
            lblRule.BackColor = Color.White;
            lblRule.ForeColor = Color.Red;
            lblRule.Location = new Point(481, 219);
            lblRule.Name = "lblRule";
            lblRule.Size = new Size(107, 28);
            lblRule.TabIndex = 10;
            lblRule.Text = "Tối đa 3 kí ";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(312, 273);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(163, 34);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(86, 276);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(168, 28);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblIdName
            // 
            lblIdName.AutoSize = true;
            lblIdName.Location = new Point(252, 41);
            lblIdName.Name = "lblIdName";
            lblIdName.Size = new Size(101, 28);
            lblIdName.TabIndex = 7;
            lblIdName.Text = "ID - Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(312, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '!';
            txtPassword.Size = new Size(163, 34);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(86, 216);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 34);
            txtEmail.TabIndex = 1;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(312, 99);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(163, 34);
            txtMemberID.TabIndex = 0;
            // 
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemberID.Location = new Point(86, 102);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(110, 28);
            lblMemberID.TabIndex = 3;
            lblMemberID.Text = "Member ID";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(86, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // btnSaveAndLogin
            // 
            btnSaveAndLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveAndLogin.Location = new Point(168, 480);
            btnSaveAndLogin.Margin = new Padding(4);
            btnSaveAndLogin.Name = "btnSaveAndLogin";
            btnSaveAndLogin.Size = new Size(201, 53);
            btnSaveAndLogin.TabIndex = 8;
            btnSaveAndLogin.Text = "Save";
            btnSaveAndLogin.UseVisualStyleBackColor = true;
            btnSaveAndLogin.Click += btnSaveAndLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(435, 480);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(201, 53);
            btnCancel.TabIndex = 9;
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
            label1.Location = new Point(0, 540);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 14;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // UserAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveAndLogin);
            Controls.Add(grbUserAccountInfo);
            Controls.Add(lblHeader);
            Name = "UserAccountForm";
            Text = "UserAccountForm";
            Load += UserAccountForm_Load;
            grbUserAccountInfo.ResumeLayout(false);
            grbUserAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbUserAccountInfo;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private Label lblMemberID;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblIdName;
        private Button btnSaveAndLogin;
        private Button btnCancel;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Label label1;
        private Label lblRule;
    }
}