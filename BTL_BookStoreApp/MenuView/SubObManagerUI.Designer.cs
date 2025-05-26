namespace BTL_BookStoreApp
{
    partial class SubObManagerUI
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            dgvBookList = new DataGridView();
            lblBookManager = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(960, 648);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(173, 53);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(721, 648);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(448, 648);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 53);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(164, 648);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(173, 53);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(164, 164);
            dgvBookList.Margin = new Padding(4);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(969, 431);
            dgvBookList.TabIndex = 12;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(13, 27);
            lblBookManager.Margin = new Padding(4, 0, 4, 0);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(430, 81);
            lblBookManager.TabIndex = 6;
            lblBookManager.Text = "Item Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 768);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 14;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // SubObManagerUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(lblBookManager);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "SubObManagerUI";
            Text = "SubObManagerUI";
            Load += SubObManagerUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridView dgvBookList;
        private Label lblBookManager;
        private Label label1;
    }
}