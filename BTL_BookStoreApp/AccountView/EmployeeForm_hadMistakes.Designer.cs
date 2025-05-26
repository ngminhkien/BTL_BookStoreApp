namespace BTL_BookStoreApp.AccountView
{
    partial class EmployeeForm_hadMistakes
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
            grbEmployeeInfo = new GroupBox();
            txtEmployeeName = new TextBox();
            txtEmployeeId = new TextBox();
            lblEmployeeId = new Label();
            lblEmployeeName = new Label();
            btnCreateAndContinue = new Button();
            btnCancel = new Button();
            lblStep1 = new Label();
            label1 = new Label();
            grbEmployeeInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(38, 28);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(826, 60);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Register an account for new employees";
            // 
            // grbEmployeeInfo
            // 
            grbEmployeeInfo.Controls.Add(txtEmployeeName);
            grbEmployeeInfo.Controls.Add(txtEmployeeId);
            grbEmployeeInfo.Controls.Add(lblEmployeeId);
            grbEmployeeInfo.Controls.Add(lblEmployeeName);
            grbEmployeeInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbEmployeeInfo.Location = new Point(94, 176);
            grbEmployeeInfo.Name = "grbEmployeeInfo";
            grbEmployeeInfo.Size = new Size(683, 245);
            grbEmployeeInfo.TabIndex = 3;
            grbEmployeeInfo.TabStop = false;
            grbEmployeeInfo.Text = "Employee Info ";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(312, 150);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(228, 34);
            txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(312, 71);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(228, 34);
            txtEmployeeId.TabIndex = 0;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeId.Location = new Point(86, 77);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(122, 28);
            lblEmployeeId.TabIndex = 3;
            lblEmployeeId.Text = "Employee ID";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(86, 153);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(155, 28);
            lblEmployeeName.TabIndex = 4;
            lblEmployeeName.Text = "Employee Name";
            // 
            // btnCreateAndContinue
            // 
            btnCreateAndContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateAndContinue.Location = new Point(173, 465);
            btnCreateAndContinue.Margin = new Padding(4);
            btnCreateAndContinue.Name = "btnCreateAndContinue";
            btnCreateAndContinue.Size = new Size(201, 53);
            btnCreateAndContinue.TabIndex = 4;
            btnCreateAndContinue.Text = "Save and Continue";
            btnCreateAndContinue.UseVisualStyleBackColor = true;
            btnCreateAndContinue.Click += btnCreateAndContinue_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(438, 465);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStep1
            // 
            lblStep1.AutoSize = true;
            lblStep1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStep1.Location = new Point(379, 102);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(62, 60);
            lblStep1.TabIndex = 6;
            lblStep1.Text = "1.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-2, 539);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 14;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // EmployeeForm_hadMistakes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(lblStep1);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateAndContinue);
            Controls.Add(grbEmployeeInfo);
            Controls.Add(lblHeader);
            Name = "EmployeeForm_hadMistakes";
            Text = "EmployeeForm_hadMistakes";
            Load += EmployeeForm_hadMistakes_Load;
            grbEmployeeInfo.ResumeLayout(false);
            grbEmployeeInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbEmployeeInfo;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeId;
        private Label lblEmployeeId;
        private Label lblEmployeeName;
        private Button btnCreateAndContinue;
        private Button btnCancel;
        private Label lblStep1;
        private Label label1;
    }
}