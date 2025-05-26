namespace BTL_BookStoreApp.MenuView
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            cboMenu = new ComboBox();
            btnBook = new Button();
            btnSalesInvoice = new Button();
            btnPurchaseInvoice = new Button();
            btnExit = new Button();
            btnCRUD = new Button();
            pnlUtils = new Panel();
            pnlNameStore = new Panel();
            ptbAvatar = new PictureBox();
            pnlLogo = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pnlUtils.SuspendLayout();
            pnlNameStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            SuspendLayout();
            // 
            // cboMenu
            // 
            cboMenu.BackColor = Color.DimGray;
            cboMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(24, 480);
            cboMenu.Margin = new Padding(4);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(209, 36);
            cboMenu.TabIndex = 16;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Silver;
            btnBook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(6, 159);
            btnBook.Margin = new Padding(6);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(238, 74);
            btnBook.TabIndex = 15;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnSalesInvoice
            // 
            btnSalesInvoice.BackColor = Color.LightGray;
            btnSalesInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesInvoice.ForeColor = Color.DeepPink;
            btnSalesInvoice.Location = new Point(6, 73);
            btnSalesInvoice.Margin = new Padding(6);
            btnSalesInvoice.Name = "btnSalesInvoice";
            btnSalesInvoice.RightToLeft = RightToLeft.No;
            btnSalesInvoice.Size = new Size(238, 74);
            btnSalesInvoice.TabIndex = 17;
            btnSalesInvoice.Text = "Sales Invoice";
            btnSalesInvoice.UseVisualStyleBackColor = false;
            btnSalesInvoice.Click += btnSalesInvoice_Click;
            // 
            // btnPurchaseInvoice
            // 
            btnPurchaseInvoice.BackColor = Color.DarkGray;
            btnPurchaseInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPurchaseInvoice.Location = new Point(6, 245);
            btnPurchaseInvoice.Margin = new Padding(6);
            btnPurchaseInvoice.Name = "btnPurchaseInvoice";
            btnPurchaseInvoice.Size = new Size(238, 74);
            btnPurchaseInvoice.TabIndex = 18;
            btnPurchaseInvoice.Text = "Purchase Invoice";
            btnPurchaseInvoice.UseVisualStyleBackColor = false;
            btnPurchaseInvoice.Click += btnPurchaseInvoice_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(6, 574);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(238, 74);
            btnExit.TabIndex = 21;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCRUD
            // 
            btnCRUD.BackColor = Color.Gray;
            btnCRUD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCRUD.Location = new Point(6, 396);
            btnCRUD.Margin = new Padding(6);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(238, 74);
            btnCRUD.TabIndex = 22;
            btnCRUD.Text = "CRUD";
            btnCRUD.UseVisualStyleBackColor = false;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // pnlUtils
            // 
            pnlUtils.BackColor = Color.Tan;
            pnlUtils.Controls.Add(btnBook);
            pnlUtils.Controls.Add(btnCRUD);
            pnlUtils.Controls.Add(btnSalesInvoice);
            pnlUtils.Controls.Add(btnPurchaseInvoice);
            pnlUtils.Controls.Add(btnExit);
            pnlUtils.Controls.Add(cboMenu);
            pnlUtils.ForeColor = Color.DeepPink;
            pnlUtils.Location = new Point(3, 129);
            pnlUtils.Name = "pnlUtils";
            pnlUtils.Size = new Size(250, 668);
            pnlUtils.TabIndex = 24;
            // 
            // pnlNameStore
            // 
            pnlNameStore.BackColor = Color.Tan;
            pnlNameStore.Controls.Add(label1);
            pnlNameStore.Controls.Add(ptbAvatar);
            pnlNameStore.Location = new Point(252, 3);
            pnlNameStore.Name = "pnlNameStore";
            pnlNameStore.Size = new Size(1040, 130);
            pnlNameStore.TabIndex = 25;
            // 
            // ptbAvatar
            // 
            ptbAvatar.BackColor = SystemColors.Control;
            ptbAvatar.BackgroundImage = (Image)resources.GetObject("ptbAvatar.BackgroundImage");
            ptbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            ptbAvatar.Location = new Point(917, 26);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(83, 86);
            ptbAvatar.TabIndex = 0;
            ptbAvatar.TabStop = false;
            ptbAvatar.Click += ptbAvatar_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = (Image)resources.GetObject("pnlLogo.BackgroundImage");
            pnlLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogo.Location = new Point(1, 3);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(252, 133);
            pnlLogo.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(252, 132);
            panel4.Name = "panel4";
            panel4.Size = new Size(1040, 665);
            panel4.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 52.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 17);
            label1.Name = "label1";
            label1.Size = new Size(572, 109);
            label1.TabIndex = 1;
            label1.Text = "Book Store";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 801);
            Controls.Add(panel4);
            Controls.Add(pnlLogo);
            Controls.Add(pnlNameStore);
            Controls.Add(pnlUtils);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            pnlUtils.ResumeLayout(false);
            pnlNameStore.ResumeLayout(false);
            pnlNameStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboMenu;
        private Button btnBook;
        private Button btnSalesInvoice;
        private Button btnPurchaseInvoice;
        private Button btnExit;
        private Button btnCRUD;
        private Panel pnlUtils;
        private Panel pnlNameStore;
        private Panel pnlLogo;
        private Panel panel4;
        private PictureBox ptbAvatar;
        private Label label1;
    }
}