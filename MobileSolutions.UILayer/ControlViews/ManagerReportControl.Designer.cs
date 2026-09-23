namespace MobileSolutions.UILayer
{
    partial class ManagerReportControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            picManagerTitle = new FontAwesome.Sharp.IconPictureBox();
            lblManagerTitle = new MaterialSkin.Controls.MaterialLabel();
            tlpMain = new TableLayoutPanel();
            pnlKpisRow = new Panel();
            tlpKpis = new TableLayoutPanel();
            tlpGraficos = new TableLayoutPanel();
            pnlTopProductos = new Panel();
            lblTopProductosTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlMarcas = new Panel();
            lblMarcasTitle = new MaterialSkin.Controls.MaterialLabel();
            tlpTablas = new TableLayoutPanel();
            pnlStockAlerts = new Panel();
            lblStockAlertsTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlTopSellers = new Panel();
            lblTopSellersTitle = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picManagerTitle).BeginInit();
            tlpMain.SuspendLayout();
            pnlKpisRow.SuspendLayout();
            tlpGraficos.SuspendLayout();
            pnlTopProductos.SuspendLayout();
            pnlMarcas.SuspendLayout();
            tlpTablas.SuspendLayout();
            pnlStockAlerts.SuspendLayout();
            pnlTopSellers.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picManagerTitle
            // 
            picManagerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picManagerTitle.BackColor = Color.FromArgb(50, 50, 50);
            picManagerTitle.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            picManagerTitle.IconColor = Color.White;
            picManagerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picManagerTitle.IconSize = 61;
            picManagerTitle.Location = new Point(56, 6);
            picManagerTitle.Name = "picManagerTitle";
            picManagerTitle.Size = new Size(77, 61);
            picManagerTitle.TabIndex = 0;
            picManagerTitle.TabStop = false;
            // 
            // lblManagerTitle
            // 
            lblManagerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblManagerTitle.AutoSize = true;
            lblManagerTitle.Depth = 0;
            lblManagerTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblManagerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblManagerTitle.ForeColor = Color.White;
            lblManagerTitle.Location = new Point(139, 6);
            lblManagerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblManagerTitle.Name = "lblManagerTitle";
            lblManagerTitle.Size = new Size(434, 58);
            lblManagerTitle.TabIndex = 36;
            lblManagerTitle.Text = "Reportes de Gerente";
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(50, 50, 50);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlKpisRow, 0, 0);
            tlpMain.Controls.Add(tlpGraficos, 0, 1);
            tlpMain.Controls.Add(tlpTablas, 0, 2);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new Point(0, 122);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpMain.Size = new Size(1680, 808);
            tlpMain.TabIndex = 37;
            // 
            // pnlKpisRow
            // 
            pnlKpisRow.BackColor = Color.FromArgb(50, 50, 50);
            pnlKpisRow.Controls.Add(tlpKpis);
            pnlKpisRow.Dock = DockStyle.Fill;
            pnlKpisRow.Location = new Point(15, 15);
            pnlKpisRow.Name = "pnlKpisRow";
            pnlKpisRow.Size = new Size(1650, 150);
            pnlKpisRow.TabIndex = 0;
            // 
            // tlpKpis
            // 
            tlpKpis.BackColor = Color.FromArgb(50, 50, 50);
            tlpKpis.ColumnCount = 4;
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpKpis.Dock = DockStyle.Fill;
            tlpKpis.Location = new Point(0, 0);
            tlpKpis.Name = "tlpKpis";
            tlpKpis.RowCount = 1;
            tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKpis.Size = new Size(1650, 150);
            tlpKpis.TabIndex = 0;
            // 
            // tlpGraficos
            // 
            tlpGraficos.BackColor = Color.FromArgb(50, 50, 50);
            tlpGraficos.ColumnCount = 2;
            tlpGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpGraficos.Controls.Add(pnlTopProductos, 0, 0);
            tlpGraficos.Controls.Add(pnlMarcas, 1, 0);
            tlpGraficos.Dock = DockStyle.Fill;
            tlpGraficos.Location = new Point(15, 171);
            tlpGraficos.Name = "tlpGraficos";
            tlpGraficos.RowCount = 1;
            tlpGraficos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpGraficos.Size = new Size(1650, 307);
            tlpGraficos.TabIndex = 1;
            // 
            // pnlTopProductos
            // 
            pnlTopProductos.BackColor = Color.FromArgb(60, 60, 60);
            pnlTopProductos.Controls.Add(lblTopProductosTitle);
            pnlTopProductos.Dock = DockStyle.Fill;
            pnlTopProductos.Location = new Point(6, 6);
            pnlTopProductos.Margin = new Padding(6);
            pnlTopProductos.Name = "pnlTopProductos";
            pnlTopProductos.Padding = new Padding(12);
            pnlTopProductos.Size = new Size(813, 295);
            pnlTopProductos.TabIndex = 0;
            // 
            // lblTopProductosTitle
            // 
            lblTopProductosTitle.Depth = 0;
            lblTopProductosTitle.Dock = DockStyle.Top;
            lblTopProductosTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTopProductosTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblTopProductosTitle.ForeColor = Color.White;
            lblTopProductosTitle.Location = new Point(12, 12);
            lblTopProductosTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTopProductosTitle.Name = "lblTopProductosTitle";
            lblTopProductosTitle.Padding = new Padding(8, 0, 0, 0);
            lblTopProductosTitle.Size = new Size(789, 32);
            lblTopProductosTitle.TabIndex = 0;
            lblTopProductosTitle.Text = "Top 5 Productos más vendidos";
            lblTopProductosTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMarcas
            // 
            pnlMarcas.BackColor = Color.FromArgb(60, 60, 60);
            pnlMarcas.Controls.Add(lblMarcasTitle);
            pnlMarcas.Dock = DockStyle.Fill;
            pnlMarcas.Location = new Point(831, 6);
            pnlMarcas.Margin = new Padding(6);
            pnlMarcas.Name = "pnlMarcas";
            pnlMarcas.Padding = new Padding(12);
            pnlMarcas.Size = new Size(813, 295);
            pnlMarcas.TabIndex = 1;
            // 
            // lblMarcasTitle
            // 
            lblMarcasTitle.Depth = 0;
            lblMarcasTitle.Dock = DockStyle.Top;
            lblMarcasTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMarcasTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblMarcasTitle.ForeColor = Color.White;
            lblMarcasTitle.Location = new Point(12, 12);
            lblMarcasTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblMarcasTitle.Name = "lblMarcasTitle";
            lblMarcasTitle.Padding = new Padding(8, 0, 0, 0);
            lblMarcasTitle.Size = new Size(789, 32);
            lblMarcasTitle.TabIndex = 0;
            lblMarcasTitle.Text = "Ventas por Marca";
            lblMarcasTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpTablas
            // 
            tlpTablas.BackColor = Color.FromArgb(50, 50, 50);
            tlpTablas.ColumnCount = 2;
            tlpTablas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTablas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTablas.Controls.Add(pnlStockAlerts, 0, 0);
            tlpTablas.Controls.Add(pnlTopSellers, 1, 0);
            tlpTablas.Dock = DockStyle.Fill;
            tlpTablas.Location = new Point(15, 484);
            tlpTablas.Name = "tlpTablas";
            tlpTablas.RowCount = 1;
            tlpTablas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTablas.Size = new Size(1650, 309);
            tlpTablas.TabIndex = 2;
            // 
            // pnlStockAlerts
            // 
            pnlStockAlerts.BackColor = Color.FromArgb(60, 60, 60);
            pnlStockAlerts.Controls.Add(lblStockAlertsTitle);
            pnlStockAlerts.Dock = DockStyle.Fill;
            pnlStockAlerts.Location = new Point(6, 6);
            pnlStockAlerts.Margin = new Padding(6);
            pnlStockAlerts.Name = "pnlStockAlerts";
            pnlStockAlerts.Padding = new Padding(12);
            pnlStockAlerts.Size = new Size(813, 297);
            pnlStockAlerts.TabIndex = 0;
            // 
            // lblStockAlertsTitle
            // 
            lblStockAlertsTitle.Depth = 0;
            lblStockAlertsTitle.Dock = DockStyle.Top;
            lblStockAlertsTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStockAlertsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblStockAlertsTitle.ForeColor = Color.White;
            lblStockAlertsTitle.Location = new Point(12, 12);
            lblStockAlertsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblStockAlertsTitle.Name = "lblStockAlertsTitle";
            lblStockAlertsTitle.Padding = new Padding(8, 0, 0, 0);
            lblStockAlertsTitle.Size = new Size(789, 32);
            lblStockAlertsTitle.TabIndex = 0;
            lblStockAlertsTitle.Text = "Alertas de Stock";
            lblStockAlertsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlTopSellers
            // 
            pnlTopSellers.BackColor = Color.FromArgb(60, 60, 60);
            pnlTopSellers.Controls.Add(lblTopSellersTitle);
            pnlTopSellers.Dock = DockStyle.Fill;
            pnlTopSellers.Location = new Point(831, 6);
            pnlTopSellers.Margin = new Padding(6);
            pnlTopSellers.Name = "pnlTopSellers";
            pnlTopSellers.Padding = new Padding(12);
            pnlTopSellers.Size = new Size(813, 297);
            pnlTopSellers.TabIndex = 1;
            // 
            // lblTopSellersTitle
            // 
            lblTopSellersTitle.Depth = 0;
            lblTopSellersTitle.Dock = DockStyle.Top;
            lblTopSellersTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTopSellersTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblTopSellersTitle.ForeColor = Color.White;
            lblTopSellersTitle.Location = new Point(12, 12);
            lblTopSellersTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTopSellersTitle.Name = "lblTopSellersTitle";
            lblTopSellersTitle.Padding = new Padding(8, 0, 0, 0);
            lblTopSellersTitle.Size = new Size(789, 32);
            lblTopSellersTitle.TabIndex = 0;
            lblTopSellersTitle.Text = "Top Sellers";
            lblTopSellersTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1680, 75);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(picManagerTitle);
            panel1.Controls.Add(lblManagerTitle);
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
            panel2.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(182, 6);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(79, 24);
            lblCurrentUser.TabIndex = 2;
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
            btnLogout.Location = new Point(340, 4);
            btnLogout.Margin = new Padding(10);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // ManagerReportControl
            // 
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlpMain);
            Name = "ManagerReportControl";
            Size = new Size(1680, 930);
            ((System.ComponentModel.ISupportInitialize)picManagerTitle).EndInit();
            tlpMain.ResumeLayout(false);
            pnlKpisRow.ResumeLayout(false);
            tlpGraficos.ResumeLayout(false);
            pnlTopProductos.ResumeLayout(false);
            pnlMarcas.ResumeLayout(false);
            tlpTablas.ResumeLayout(false);
            pnlStockAlerts.ResumeLayout(false);
            pnlTopSellers.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picManagerTitle;
        private MaterialSkin.Controls.MaterialLabel lblManagerTitle;
        private TableLayoutPanel tlpMain;
        private Panel pnlKpisRow;
        private TableLayoutPanel tlpKpis;
        private TableLayoutPanel tlpGraficos;
        private Panel pnlTopProductos;
        private MaterialSkin.Controls.MaterialLabel lblTopProductosTitle;
        private Panel pnlMarcas;
        private MaterialSkin.Controls.MaterialLabel lblMarcasTitle;
        private TableLayoutPanel tlpTablas;
        private Panel pnlStockAlerts;
        private MaterialSkin.Controls.MaterialLabel lblStockAlertsTitle;
        private Panel pnlTopSellers;
        private MaterialSkin.Controls.MaterialLabel lblTopSellersTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
    }
}
