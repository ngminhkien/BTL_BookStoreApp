namespace BTL_BookStoreApp.AccountView
{
    partial class EmployeeMainUI
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
            dgvEmployeeList = new DataGridView();
            btnCreate = new Button();
            btnDelete = new Button();
            lblBookManager = new Label();
            btnCancel = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Location = new Point(111, 118);
            dgvEmployeeList.Margin = new Padding(4);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.RowHeadersWidth = 51;
            dgvEmployeeList.Size = new Size(760, 322);
            dgvEmployeeList.TabIndex = 4;
            dgvEmployeeList.SelectionChanged += dgvEmployeeList_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(147, 481);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(173, 53);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(376, 481);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(1, -1);
            lblBookManager.Margin = new Padding(4, 0, 4, 0);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(445, 81);
            lblBookManager.TabIndex = 7;
            lblBookManager.Text = "Book Manager";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(603, 481);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 8;
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
            label1.Location = new Point(1, 539);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 14;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // EmployeeMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(lblBookManager);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvEmployeeList);
            Name = "EmployeeMainUI";
            Text = "EmployeeMainUI";
            Load += EmployeeMainUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployeeList;
        private Button btnCreate;
        private Button btnDelete;
        private Label lblBookManager;
        private Button btnCancel;
        private Label label1;
    }
}