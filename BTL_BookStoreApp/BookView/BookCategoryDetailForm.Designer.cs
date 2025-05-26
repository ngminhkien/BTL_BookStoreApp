namespace BTL_BookStoreApp.BookView
{
    partial class BookCategoryDetailForm
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
            grbBookCategoryInfo = new GroupBox();
            txtDescription = new TextBox();
            txtBookGenreType = new TextBox();
            txtBookCategoryId = new TextBox();
            lblBookCategoryId = new Label();
            lblBookGenreType = new Label();
            lblDecription = new Label();
            lblHeader = new Label();
            label1 = new Label();
            grbBookCategoryInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(772, 207);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(772, 139);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbBookCategoryInfo
            // 
            grbBookCategoryInfo.Controls.Add(txtDescription);
            grbBookCategoryInfo.Controls.Add(txtBookGenreType);
            grbBookCategoryInfo.Controls.Add(txtBookCategoryId);
            grbBookCategoryInfo.Controls.Add(lblBookCategoryId);
            grbBookCategoryInfo.Controls.Add(lblBookGenreType);
            grbBookCategoryInfo.Controls.Add(lblDecription);
            grbBookCategoryInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbBookCategoryInfo.Location = new Point(42, 127);
            grbBookCategoryInfo.Name = "grbBookCategoryInfo";
            grbBookCategoryInfo.Size = new Size(683, 402);
            grbBookCategoryInfo.TabIndex = 10;
            grbBookCategoryInfo.TabStop = false;
            grbBookCategoryInfo.Text = " Book Category Info ";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(210, 237);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(452, 120);
            txtDescription.TabIndex = 8;
            // 
            // txtBookGenreType
            // 
            txtBookGenreType.Location = new Point(210, 145);
            txtBookGenreType.Name = "txtBookGenreType";
            txtBookGenreType.Size = new Size(215, 34);
            txtBookGenreType.TabIndex = 1;
            // 
            // txtBookCategoryId
            // 
            txtBookCategoryId.Location = new Point(210, 54);
            txtBookCategoryId.Name = "txtBookCategoryId";
            txtBookCategoryId.Size = new Size(215, 34);
            txtBookCategoryId.TabIndex = 0;
            // 
            // lblBookCategoryId
            // 
            lblBookCategoryId.AutoSize = true;
            lblBookCategoryId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookCategoryId.Location = new Point(16, 60);
            lblBookCategoryId.Name = "lblBookCategoryId";
            lblBookCategoryId.Size = new Size(166, 28);
            lblBookCategoryId.TabIndex = 3;
            lblBookCategoryId.Text = "Book Category ID";
            // 
            // lblBookGenreType
            // 
            lblBookGenreType.AutoSize = true;
            lblBookGenreType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookGenreType.Location = new Point(16, 148);
            lblBookGenreType.Name = "lblBookGenreType";
            lblBookGenreType.Size = new Size(160, 28);
            lblBookGenreType.TabIndex = 4;
            lblBookGenreType.Text = "Book Genre Type";
            // 
            // lblDecription
            // 
            lblDecription.AutoSize = true;
            lblDecription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecription.Location = new Point(16, 240);
            lblDecription.Name = "lblDecription";
            lblDecription.Size = new Size(104, 28);
            lblDecription.TabIndex = 7;
            lblDecription.Text = "Decription";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(42, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(615, 81);
            lblHeader.TabIndex = 9;
            lblHeader.Text = "Add a BookCategory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(-1, 539);
            label1.Name = "label1";
            label1.Size = new Size(181, 30);
            label1.TabIndex = 13;
            label1.Text = "© 2025 B_C_H_K_T";
            // 
            // BookCategoryDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookCategoryInfo);
            Controls.Add(lblHeader);
            Name = "BookCategoryDetailForm";
            Text = "BookCategoryDetailForm";
            Load += BookCategoryDetailForm_Load;
            grbBookCategoryInfo.ResumeLayout(false);
            grbBookCategoryInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private GroupBox grbBookCategoryInfo;
        private TextBox txtBookGenreType;
        private TextBox txtBookCategoryId;
        private Label lblBookCategoryId;
        private Label lblBookGenreType;
        private Label lblDecription;
        private Label lblHeader;
        private TextBox txtDescription;
        private Label label1;
    }
}