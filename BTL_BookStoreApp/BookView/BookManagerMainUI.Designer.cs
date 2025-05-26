using Repositories;

namespace BTL_BookStoreApp
{
    partial class BookManagerMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private readonly DbdesignQlchBansachContext _context;

        //public BookManagerMainUI(DbdesignQlchBansachContext context)
        //{
        //    _context = context;
        //    InitializeComponent();
        //}

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
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblDecription = new Label();
            lblBookName = new Label();
            btnSearch = new Button();
            lblBookList = new Label();
            dgvBookList = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            lblReport = new Label();
            label1 = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblBookManager
            // 
            lblBookManager.AutoSize = true;
            lblBookManager.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookManager.Location = new Point(-8, -4);
            lblBookManager.Margin = new Padding(4, 0, 4, 0);
            lblBookManager.Name = "lblBookManager";
            lblBookManager.Size = new Size(445, 81);
            lblBookManager.TabIndex = 0;
            lblBookManager.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblDecription);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbSearchCriteria.Location = new Point(16, 113);
            grbSearchCriteria.Margin = new Padding(4);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Padding = new Padding(4);
            grbSearchCriteria.Size = new Size(1261, 153);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(718, 67);
            txtDescription.Margin = new Padding(4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 34);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(188, 67);
            txtBookName.Margin = new Padding(4);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(254, 34);
            txtBookName.TabIndex = 0;
            // 
            // lblDecription
            // 
            lblDecription.AutoSize = true;
            lblDecription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecription.Location = new Point(535, 69);
            lblDecription.Margin = new Padding(4, 0, 4, 0);
            lblDecription.Name = "lblDecription";
            lblDecription.Size = new Size(112, 28);
            lblDecription.TabIndex = 10;
            lblDecription.Text = "Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(0, 69);
            lblBookName.Margin = new Padding(4, 0, 4, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(114, 28);
            lblBookName.TabIndex = 9;
            lblBookName.Text = "Book Name";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1059, 69);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 53);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.Location = new Point(16, 270);
            lblBookList.Margin = new Padding(4, 0, 4, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(91, 28);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(16, 326);
            dgvBookList.Margin = new Padding(4);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(969, 431);
            dgvBookList.TabIndex = 3;
            dgvBookList.CellDoubleClick += dgvBookList_CellDoubleClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(1075, 326);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(173, 53);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(1075, 426);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 53);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1075, 529);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 53);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1075, 704);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 53);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.ForeColor = Color.Red;
            lblReport.ImageAlign = ContentAlignment.MiddleRight;
            lblReport.Location = new Point(291, 270);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(16, 28);
            lblReport.TabIndex = 5;
            lblReport.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(3, 768);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 13;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(label1);
            Controls.Add(lblReport);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(lblBookManager);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "BookManagerMainUI";
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
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
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblDecription;
        private Label lblBookName;
        private Label lblReport;
        private Label label1;
    }
}
