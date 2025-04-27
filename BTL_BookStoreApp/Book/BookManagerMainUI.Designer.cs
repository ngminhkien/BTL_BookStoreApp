namespace BTL_BookStoreApp
{
    partial class BookManagerMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBookManager = new Label();
            grbSearchCriteria = new GroupBox();
            txtBookCategory = new TextBox();
            txtBookName = new TextBox();
            lblBookCategory = new Label();
            lblBookName = new Label();
            btnSearch = new Button();
            lblBookList = new Label();
            dgvBookList = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(12, -3);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(445, 81);
            lblBookManager.TabIndex = 0;
            lblBookManager.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(txtBookCategory);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookCategory);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbSearchCriteria.Location = new Point(12, 81);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(917, 109);
            grbSearchCriteria.TabIndex = 1;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // txtBookCategory
            // 
            txtBookCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookCategory.Location = new Point(580, 48);
            txtBookCategory.Name = "txtBookCategory";
            txtBookCategory.Size = new Size(125, 34);
            txtBookCategory.TabIndex = 12;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(137, 48);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(125, 34);
            txtBookName.TabIndex = 11;
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookCategory.Location = new Point(389, 49);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(142, 28);
            lblBookCategory.TabIndex = 10;
            lblBookCategory.Text = "Book Category";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(0, 49);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(114, 28);
            lblBookName.TabIndex = 9;
            lblBookName.Text = "Book Name";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(770, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(126, 38);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.Location = new Point(12, 193);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(91, 28);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(12, 233);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(705, 308);
            dgvBookList.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(782, 233);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(126, 38);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(782, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 38);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(782, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(782, 503);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(126, 38);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblBookManager);
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookManager;
        private GroupBox grbSearchCriteria;
        private Label lblBookList;
        private DataGridView dgvBookList;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private TextBox txtBookCategory;
        private TextBox txtBookName;
        private Label lblBookCategory;
        private Label lblBookName;
    }
}
