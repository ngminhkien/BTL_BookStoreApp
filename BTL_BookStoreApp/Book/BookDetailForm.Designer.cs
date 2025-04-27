namespace BTL_BookStoreApp.Book
{
    partial class BookDetailForm
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
            grbBookInfo = new GroupBox();
            dtpPublicationDate = new DateTimePicker();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrince = new TextBox();
            txtImportPrince = new TextBox();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            lblBookId = new Label();
            lblBookName = new Label();
            lblDecription = new Label();
            lblPubDate = new Label();
            lblBookCategory = new Label();
            lblQuantity = new Label();
            lblSellPrince = new Label();
            lblAuthor = new Label();
            lblPublisher = new Label();
            lblImportPrince = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cboBookCategory = new ComboBox();
            cboPublisher = new ComboBox();
            cboAuthor = new ComboBox();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic);
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(617, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add | Update a Book";
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboAuthor);
            grbBookInfo.Controls.Add(cboPublisher);
            grbBookInfo.Controls.Add(cboBookCategory);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtSellPrince);
            grbBookInfo.Controls.Add(txtImportPrince);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblDecription);
            grbBookInfo.Controls.Add(lblPubDate);
            grbBookInfo.Controls.Add(lblBookCategory);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblSellPrince);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblPublisher);
            grbBookInfo.Controls.Add(lblImportPrince);
            grbBookInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbBookInfo.Location = new Point(12, 105);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(772, 433);
            grbBookInfo.TabIndex = 2;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(126, 246);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(208, 34);
            dtpPublicationDate.TabIndex = 20;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(126, 103);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(627, 120);
            txtDescription.TabIndex = 19;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(126, 314);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 34);
            txtQuantity.TabIndex = 18;
            // 
            // txtSellPrince
            // 
            txtSellPrince.Location = new Point(366, 314);
            txtSellPrince.Name = "txtSellPrince";
            txtSellPrince.Size = new Size(125, 34);
            txtSellPrince.TabIndex = 16;
            // 
            // txtImportPrince
            // 
            txtImportPrince.Location = new Point(628, 314);
            txtImportPrince.Name = "txtImportPrince";
            txtImportPrince.Size = new Size(125, 34);
            txtImportPrince.TabIndex = 15;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(572, 51);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(181, 34);
            txtBookName.TabIndex = 14;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(126, 51);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(150, 34);
            txtBookId.TabIndex = 13;
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookId.Location = new Point(11, 48);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(81, 28);
            lblBookId.TabIndex = 3;
            lblBookId.Text = "Book ID";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(418, 51);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(114, 28);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblDecription
            // 
            lblDecription.AutoSize = true;
            lblDecription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDecription.Location = new Point(11, 106);
            lblDecription.Name = "lblDecription";
            lblDecription.Size = new Size(112, 28);
            lblDecription.TabIndex = 5;
            lblDecription.Text = "Description";
            // 
            // lblPubDate
            // 
            lblPubDate.AutoSize = true;
            lblPubDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPubDate.Location = new Point(16, 252);
            lblPubDate.Name = "lblPubDate";
            lblPubDate.Size = new Size(92, 28);
            lblPubDate.TabIndex = 6;
            lblPubDate.Text = "Pub Date";
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookCategory.Location = new Point(418, 247);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(137, 28);
            lblBookCategory.TabIndex = 7;
            lblBookCategory.Text = "BookCategory";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(11, 311);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.RightToLeft = RightToLeft.No;
            lblQuantity.Size = new Size(88, 28);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // lblSellPrince
            // 
            lblSellPrince.AutoSize = true;
            lblSellPrince.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellPrince.Location = new Point(257, 314);
            lblSellPrince.Name = "lblSellPrince";
            lblSellPrince.Size = new Size(103, 28);
            lblSellPrince.TabIndex = 9;
            lblSellPrince.Text = "SelltPrince";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(16, 386);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(73, 28);
            lblAuthor.TabIndex = 11;
            lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPublisher.Location = new Point(418, 380);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(92, 28);
            lblPublisher.TabIndex = 12;
            lblPublisher.Text = "Publisher";
            // 
            // lblImportPrince
            // 
            lblImportPrince.AutoSize = true;
            lblImportPrince.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImportPrince.Location = new Point(497, 314);
            lblImportPrince.Name = "lblImportPrince";
            lblImportPrince.Size = new Size(125, 28);
            lblImportPrince.TabIndex = 10;
            lblImportPrince.Text = "ImportPrince";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(790, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(790, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(572, 247);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(185, 36);
            cboBookCategory.TabIndex = 23;
            // 
            // cboPublisher
            // 
            cboPublisher.FormattingEnabled = true;
            cboPublisher.Location = new Point(572, 378);
            cboPublisher.Name = "cboPublisher";
            cboPublisher.Size = new Size(185, 36);
            cboPublisher.TabIndex = 24;
            // 
            // cboAuthor
            // 
            cboAuthor.FormattingEnabled = true;
            cboAuthor.Location = new Point(126, 380);
            cboAuthor.Name = "cboAuthor";
            cboAuthor.Size = new Size(247, 36);
            cboAuthor.TabIndex = 25;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 572);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            MinimizeBox = false;
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbBookInfo;
        private Label lblBookId;
        private Label lblBookName;
        private Label lblDecription;
        private Label lblPubDate;
        private Label lblBookCategory;
        private Label lblQuantity;
        private Label lblSellPrince;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblImportPrince;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtQuantity;
        private TextBox txtSellPrince;
        private TextBox txtImportPrince;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private TextBox txtDescription;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategory;
        private ComboBox cboAuthor;
        private ComboBox cboPublisher;
    }
}