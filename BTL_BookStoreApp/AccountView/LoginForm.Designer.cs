namespace BTL_BookStoreApp
{
    partial class LoginForm
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
            lblBookManager = new Label();
            grbAccountInfo = new GroupBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnCancel = new Button();
            label1 = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(231, 40);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(445, 81);
            lblBookManager.TabIndex = 2;
            lblBookManager.Text = "Book Manager";
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(txtPassword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbAccountInfo.Location = new Point(127, 173);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(677, 234);
            grbAccountInfo.TabIndex = 3;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = " Account Info ";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(210, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 38);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(288, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '$';
            txtPassword.Size = new Size(261, 34);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(288, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 34);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(155, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 28);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(153, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(391, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 2;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(grbAccountInfo);
            Controls.Add(lblBookManager);
            Name = "LoginForm";
            Text = "LoginForm";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookManager;
        private GroupBox grbAccountInfo;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnCancel;
        private Label label1;
    }
}