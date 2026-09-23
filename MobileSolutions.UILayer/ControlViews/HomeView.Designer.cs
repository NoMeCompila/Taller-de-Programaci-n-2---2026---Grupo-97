namespace MobileSolutions.UILayer
{
    partial class HomeView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblHomeTitle = new MaterialSkin.Controls.MaterialLabel();
            picHomeTitle = new PictureBox();
            lblWelcomeBanner = new MaterialSkin.Controls.MaterialLabel();
            cardUsers = new MaterialSkin.Controls.MaterialCard();
            label1 = new Label();
            picUsers = new PictureBox();
            lblUsers = new MaterialSkin.Controls.MaterialLabel();
            cardCustomer = new MaterialSkin.Controls.MaterialCard();
            label2 = new Label();
            picCustomers = new PictureBox();
            lblCustomer = new MaterialSkin.Controls.MaterialLabel();
            cardSales = new MaterialSkin.Controls.MaterialCard();
            label4 = new Label();
            picSalesHome = new PictureBox();
            lblSales = new MaterialSkin.Controls.MaterialLabel();
            cardHistory = new MaterialSkin.Controls.MaterialCard();
            label5 = new Label();
            picHistoryHome = new PictureBox();
            lblHistory = new MaterialSkin.Controls.MaterialLabel();
            cardReports = new MaterialSkin.Controls.MaterialCard();
            label6 = new Label();
            picReportsHome = new PictureBox();
            lblCharts = new MaterialSkin.Controls.MaterialLabel();
            cardProducts = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            picProductsHome = new PictureBox();
            lblProducts = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picHomeTitle).BeginInit();
            cardUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsers).BeginInit();
            cardCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomers).BeginInit();
            cardSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSalesHome).BeginInit();
            cardHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHistoryHome).BeginInit();
            cardReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReportsHome).BeginInit();
            cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductsHome).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblHomeTitle
            // 
            lblHomeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomeTitle.AutoSize = true;
            lblHomeTitle.Depth = 0;
            lblHomeTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHomeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblHomeTitle.Location = new Point(267, 0);
            lblHomeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblHomeTitle.Name = "lblHomeTitle";
            lblHomeTitle.Size = new Size(137, 58);
            lblHomeTitle.TabIndex = 0;
            lblHomeTitle.Text = "HOME";
            // 
            // picHomeTitle
            // 
            picHomeTitle.Location = new Point(169, 3);
            picHomeTitle.Name = "picHomeTitle";
            picHomeTitle.Size = new Size(81, 59);
            picHomeTitle.SizeMode = PictureBoxSizeMode.Zoom;
            picHomeTitle.TabIndex = 1;
            picHomeTitle.TabStop = false;
            // 
            // lblWelcomeBanner
            // 
            lblWelcomeBanner.AutoSize = true;
            lblWelcomeBanner.Depth = 0;
            lblWelcomeBanner.Dock = DockStyle.Fill;
            lblWelcomeBanner.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblWelcomeBanner.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblWelcomeBanner.Location = new Point(507, 75);
            lblWelcomeBanner.MouseState = MaterialSkin.MouseState.HOVER;
            lblWelcomeBanner.Name = "lblWelcomeBanner";
            lblWelcomeBanner.Size = new Size(666, 71);
            lblWelcomeBanner.TabIndex = 2;
            lblWelcomeBanner.Text = "Bienvenido a Mobile Solutions";
            lblWelcomeBanner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardUsers
            // 
            cardUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardUsers.BackColor = Color.FromArgb(255, 255, 255);
            cardUsers.Controls.Add(label1);
            cardUsers.Controls.Add(picUsers);
            cardUsers.Controls.Add(lblUsers);
            cardUsers.Cursor = Cursors.Hand;
            cardUsers.Depth = 0;
            cardUsers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardUsers.Location = new Point(714, 14);
            cardUsers.Margin = new Padding(14);
            cardUsers.MouseState = MaterialSkin.MouseState.HOVER;
            cardUsers.Name = "cardUsers";
            cardUsers.Padding = new Padding(14);
            cardUsers.Size = new Size(250, 319);
            cardUsers.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 147);
            label1.Name = "label1";
            label1.Size = new Size(188, 63);
            label1.TabIndex = 11;
            label1.Text = "Gestiona accesos, roles \r\ny perfiles del personal  \r\ndel sistema.";
            // 
            // picUsers
            // 
            picUsers.Anchor = AnchorStyles.Top;
            picUsers.Location = new Point(79, 36);
            picUsers.Name = "picUsers";
            picUsers.Size = new Size(85, 75);
            picUsers.SizeMode = PictureBoxSizeMode.Zoom;
            picUsers.TabIndex = 9;
            picUsers.TabStop = false;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Depth = 0;
            lblUsers.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsers.Location = new Point(88, 14);
            lblUsers.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(76, 19);
            lblUsers.TabIndex = 7;
            lblUsers.Text = "USUARIOS";
            // 
            // cardCustomer
            // 
            cardCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardCustomer.BackColor = Color.FromArgb(255, 255, 255);
            cardCustomer.Controls.Add(label2);
            cardCustomer.Controls.Add(picCustomers);
            cardCustomer.Controls.Add(lblCustomer);
            cardCustomer.Cursor = Cursors.Hand;
            cardCustomer.Depth = 0;
            cardCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardCustomer.Location = new Point(154, 14);
            cardCustomer.Margin = new Padding(14);
            cardCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            cardCustomer.Name = "cardCustomer";
            cardCustomer.Padding = new Padding(14);
            cardCustomer.Size = new Size(250, 319);
            cardCustomer.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 157);
            label2.Name = "label2";
            label2.Size = new Size(191, 63);
            label2.TabIndex = 12;
            label2.Text = "Administra la base de \r\ndatos de tus clientes \r\ny sus datos de contacto.";
            // 
            // picCustomers
            // 
            picCustomers.Anchor = AnchorStyles.Top;
            picCustomers.Location = new Point(78, 36);
            picCustomers.Name = "picCustomers";
            picCustomers.Size = new Size(85, 75);
            picCustomers.SizeMode = PictureBoxSizeMode.Zoom;
            picCustomers.TabIndex = 10;
            picCustomers.TabStop = false;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Depth = 0;
            lblCustomer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCustomer.Location = new Point(78, 14);
            lblCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(73, 19);
            lblCustomer.TabIndex = 9;
            lblCustomer.Text = "CLIENTES";
            // 
            // cardSales
            // 
            cardSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardSales.BackColor = Color.FromArgb(255, 255, 255);
            cardSales.Controls.Add(label4);
            cardSales.Controls.Add(picSalesHome);
            cardSales.Controls.Add(lblSales);
            cardSales.Cursor = Cursors.Hand;
            cardSales.Depth = 0;
            cardSales.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardSales.Location = new Point(154, 361);
            cardSales.Margin = new Padding(14);
            cardSales.MouseState = MaterialSkin.MouseState.HOVER;
            cardSales.Name = "cardSales";
            cardSales.Padding = new Padding(14);
            cardSales.Size = new Size(250, 319);
            cardSales.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 159);
            label4.Name = "label4";
            label4.Size = new Size(226, 63);
            label4.TabIndex = 13;
            label4.Text = "Realiza nuevas cotizaciones \r\ny procesa órdenes de \r\nventa rápidamente.";
            // 
            // picSalesHome
            // 
            picSalesHome.Anchor = AnchorStyles.Top;
            picSalesHome.Location = new Point(79, 36);
            picSalesHome.Name = "picSalesHome";
            picSalesHome.Size = new Size(85, 75);
            picSalesHome.SizeMode = PictureBoxSizeMode.Zoom;
            picSalesHome.TabIndex = 12;
            picSalesHome.TabStop = false;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Depth = 0;
            lblSales.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSales.Location = new Point(88, 14);
            lblSales.MouseState = MaterialSkin.MouseState.HOVER;
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(61, 19);
            lblSales.TabIndex = 8;
            lblSales.Text = "VENTAS";
            // 
            // cardHistory
            // 
            cardHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardHistory.BackColor = Color.FromArgb(255, 255, 255);
            cardHistory.Controls.Add(label5);
            cardHistory.Controls.Add(picHistoryHome);
            cardHistory.Controls.Add(lblHistory);
            cardHistory.Cursor = Cursors.Hand;
            cardHistory.Depth = 0;
            cardHistory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardHistory.Location = new Point(714, 361);
            cardHistory.Margin = new Padding(14);
            cardHistory.MouseState = MaterialSkin.MouseState.HOVER;
            cardHistory.Name = "cardHistory";
            cardHistory.Padding = new Padding(14);
            cardHistory.Size = new Size(250, 319);
            cardHistory.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 159);
            label5.Name = "label5";
            label5.Size = new Size(224, 63);
            label5.TabIndex = 13;
            label5.Text = "Consulta y revisa el registro \r\ncompleto de todas \r\nlas ventas pasadas.";
            // 
            // picHistoryHome
            // 
            picHistoryHome.Anchor = AnchorStyles.Top;
            picHistoryHome.Location = new Point(78, 36);
            picHistoryHome.Name = "picHistoryHome";
            picHistoryHome.Size = new Size(85, 75);
            picHistoryHome.SizeMode = PictureBoxSizeMode.Zoom;
            picHistoryHome.TabIndex = 12;
            picHistoryHome.TabStop = false;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Depth = 0;
            lblHistory.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHistory.Location = new Point(37, 14);
            lblHistory.MouseState = MaterialSkin.MouseState.HOVER;
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(168, 19);
            lblHistory.TabIndex = 8;
            lblHistory.Text = "HISTORIAL DE VENTAS";
            // 
            // cardReports
            // 
            cardReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardReports.BackColor = Color.FromArgb(255, 255, 255);
            cardReports.Controls.Add(label6);
            cardReports.Controls.Add(picReportsHome);
            cardReports.Controls.Add(lblCharts);
            cardReports.Cursor = Cursors.Hand;
            cardReports.Depth = 0;
            cardReports.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardReports.Location = new Point(1274, 361);
            cardReports.Margin = new Padding(14);
            cardReports.MouseState = MaterialSkin.MouseState.HOVER;
            cardReports.Name = "cardReports";
            cardReports.Padding = new Padding(14);
            cardReports.Size = new Size(250, 319);
            cardReports.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 159);
            label6.Name = "label6";
            label6.Size = new Size(212, 63);
            label6.TabIndex = 13;
            label6.Text = "Genera informes y analiza \r\nel desempeño de tu \r\nnegocio con gráficas.";
            // 
            // picReportsHome
            // 
            picReportsHome.Anchor = AnchorStyles.Top;
            picReportsHome.Location = new Point(75, 36);
            picReportsHome.Name = "picReportsHome";
            picReportsHome.Size = new Size(85, 75);
            picReportsHome.SizeMode = PictureBoxSizeMode.Zoom;
            picReportsHome.TabIndex = 12;
            picReportsHome.TabStop = false;
            // 
            // lblCharts
            // 
            lblCharts.AutoSize = true;
            lblCharts.Depth = 0;
            lblCharts.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCharts.Location = new Point(75, 14);
            lblCharts.MouseState = MaterialSkin.MouseState.HOVER;
            lblCharts.Name = "lblCharts";
            lblCharts.Size = new Size(80, 19);
            lblCharts.TabIndex = 8;
            lblCharts.Text = "REPORTES";
            // 
            // cardProducts
            // 
            cardProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cardProducts.BackColor = Color.FromArgb(255, 255, 255);
            cardProducts.Controls.Add(label3);
            cardProducts.Controls.Add(picProductsHome);
            cardProducts.Controls.Add(lblProducts);
            cardProducts.Cursor = Cursors.Hand;
            cardProducts.Depth = 0;
            cardProducts.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardProducts.Location = new Point(1274, 14);
            cardProducts.Margin = new Padding(14);
            cardProducts.MouseState = MaterialSkin.MouseState.HOVER;
            cardProducts.Name = "cardProducts";
            cardProducts.Padding = new Padding(14);
            cardProducts.Size = new Size(250, 319);
            cardProducts.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 157);
            label3.Name = "label3";
            label3.Size = new Size(213, 63);
            label3.TabIndex = 12;
            label3.Text = "Controla el inventario, \r\nprecios, stock y categorías \r\nde tus productos";
            // 
            // picProductsHome
            // 
            picProductsHome.Anchor = AnchorStyles.Top;
            picProductsHome.Location = new Point(84, 36);
            picProductsHome.Name = "picProductsHome";
            picProductsHome.Size = new Size(85, 75);
            picProductsHome.SizeMode = PictureBoxSizeMode.Zoom;
            picProductsHome.TabIndex = 11;
            picProductsHome.TabStop = false;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Depth = 0;
            lblProducts.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProducts.Location = new Point(75, 14);
            lblProducts.MouseState = MaterialSkin.MouseState.HOVER;
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(94, 19);
            lblProducts.TabIndex = 9;
            lblProducts.Text = "PRODUCTOS";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Controls.Add(cardReports, 2, 1);
            tableLayoutPanel1.Controls.Add(cardUsers, 1, 0);
            tableLayoutPanel1.Controls.Add(cardProducts, 2, 0);
            tableLayoutPanel1.Controls.Add(cardSales, 0, 1);
            tableLayoutPanel1.Controls.Add(cardHistory, 1, 1);
            tableLayoutPanel1.Controls.Add(cardCustomer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 236);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1680, 694);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(lblWelcomeBanner, 1, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1680, 146);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(picHomeTitle);
            panel1.Controls.Add(lblHomeTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(507, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 69);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1179, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 69);
            panel2.TabIndex = 3;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(140, 10);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(79, 24);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "[Usuario]";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(354, 6);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // HomeView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "HomeView";
            Size = new Size(1680, 930);
            ((System.ComponentModel.ISupportInitialize)picHomeTitle).EndInit();
            cardUsers.ResumeLayout(false);
            cardUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUsers).EndInit();
            cardCustomer.ResumeLayout(false);
            cardCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCustomers).EndInit();
            cardSales.ResumeLayout(false);
            cardSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSalesHome).EndInit();
            cardHistory.ResumeLayout(false);
            cardHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHistoryHome).EndInit();
            cardReports.ResumeLayout(false);
            cardReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picReportsHome).EndInit();
            cardProducts.ResumeLayout(false);
            cardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProductsHome).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblHomeTitle;
        private PictureBox picHomeTitle;
        private MaterialSkin.Controls.MaterialLabel lblWelcomeBanner;
        private MaterialSkin.Controls.MaterialCard cardUsers;
        private MaterialSkin.Controls.MaterialLabel lblUsers;
        private MaterialSkin.Controls.MaterialCard cardCustomer;
        private MaterialSkin.Controls.MaterialLabel lblCustomer;
        private MaterialSkin.Controls.MaterialCard cardSales;
        private MaterialSkin.Controls.MaterialLabel lblSales;
        private MaterialSkin.Controls.MaterialCard cardHistory;
        private MaterialSkin.Controls.MaterialLabel lblHistory;
        private MaterialSkin.Controls.MaterialCard cardReports;
        private MaterialSkin.Controls.MaterialLabel lblCharts;
        private MaterialSkin.Controls.MaterialCard cardProducts;
        private MaterialSkin.Controls.MaterialLabel lblProducts;
        private PictureBox picUsers;
        private PictureBox picCustomers;
        private PictureBox picSalesHome;
        private PictureBox picHistoryHome;
        private PictureBox picReportsHome;
        private PictureBox picProductsHome;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
    }
}
