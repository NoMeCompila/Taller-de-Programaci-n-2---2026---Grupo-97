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
            pnlFilterBar = new Panel();
            flpFilters = new FlowLayoutPanel();
            lblDesde = new Label();
            dtpDateFrom = new DateTimePicker();
            lblHasta = new Label();
            dtpDateTo = new DateTimePicker();
            btnFilter = new MaterialSkin.Controls.MaterialButton();
            btnClearFilter = new MaterialSkin.Controls.MaterialButton();
            pnlKpisRow = new Panel();
            tlpKpis = new TableLayoutPanel();
            pnlEvolucion = new Panel();
            lblEvolucionTitle = new MaterialSkin.Controls.MaterialLabel();
            tlpDistribucion = new TableLayoutPanel();
            pnlTopProductos = new Panel();
            lblTopProductosTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlSellerDistribution = new Panel();
            lblSellerDistributionTitle = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picManagerTitle).BeginInit();
            tlpMain.SuspendLayout();
            pnlFilterBar.SuspendLayout();
            flpFilters.SuspendLayout();
            pnlKpisRow.SuspendLayout();
            pnlEvolucion.SuspendLayout();
            tlpDistribucion.SuspendLayout();
            pnlTopProductos.SuspendLayout();
            pnlSellerDistribution.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picManagerTitle
            // 
            picManagerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picManagerTitle.BackColor = Color.FromArgb(50, 50, 50);
            picManagerTitle.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            picManagerTitle.IconColor = Color.White;
            picManagerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picManagerTitle.IconSize = 61;
            picManagerTitle.Location = new Point(45, 5);
            picManagerTitle.Name = "picManagerTitle";
            picManagerTitle.Size = new Size(84, 61);
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
            lblManagerTitle.Location = new Point(135, 3);
            lblManagerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblManagerTitle.Name = "lblManagerTitle";
            lblManagerTitle.Size = new Size(465, 58);
            lblManagerTitle.TabIndex = 36;
            lblManagerTitle.Text = "Reportes de Gerente";
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
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(364, 4);
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
            btnLogout.Location = new Point(363, 31);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
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
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(50, 50, 50);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlFilterBar, 0, 0);
            tlpMain.Controls.Add(pnlKpisRow, 0, 1);
            tlpMain.Controls.Add(pnlEvolucion, 0, 2);
            tlpMain.Controls.Add(tlpDistribucion, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 75);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12, 4, 12, 8);
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tlpMain.Size = new Size(1680, 855);
            tlpMain.TabIndex = 37;
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.BackColor = Color.FromArgb(50, 50, 50);
            pnlFilterBar.Controls.Add(flpFilters);
            pnlFilterBar.Dock = DockStyle.Fill;
            pnlFilterBar.Location = new Point(15, 6);
            pnlFilterBar.Margin = new Padding(3, 2, 3, 2);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1650, 42);
            pnlFilterBar.TabIndex = 0;
            // 
            // flpFilters
            // 
            flpFilters.BackColor = Color.Transparent;
            flpFilters.Controls.Add(lblDesde);
            flpFilters.Controls.Add(dtpDateFrom);
            flpFilters.Controls.Add(lblHasta);
            flpFilters.Controls.Add(dtpDateTo);
            flpFilters.Controls.Add(btnFilter);
            flpFilters.Controls.Add(btnClearFilter);
            flpFilters.Dock = DockStyle.Fill;
            flpFilters.Location = new Point(0, 0);
            flpFilters.Margin = new Padding(0);
            flpFilters.Name = "flpFilters";
            flpFilters.Size = new Size(1650, 42);
            flpFilters.TabIndex = 0;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Roboto", 10F, FontStyle.Bold);
            lblDesde.ForeColor = Color.White;
            lblDesde.Location = new Point(4, 10);
            lblDesde.Margin = new Padding(4, 10, 4, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(52, 17);
            lblDesde.TabIndex = 0;
            lblDesde.Text = "Desde:";
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.BackColor = Color.FromArgb(60, 60, 60);
            dtpDateFrom.CalendarForeColor = Color.White;
            dtpDateFrom.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtpDateFrom.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);
            dtpDateFrom.CalendarTitleForeColor = Color.White;
            dtpDateFrom.CalendarTrailingForeColor = Color.FromArgb(150, 150, 150);
            dtpDateFrom.Font = new Font("Roboto", 9.5F);
            dtpDateFrom.ForeColor = Color.White;
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(63, 7);
            dtpDateFrom.Margin = new Padding(3, 7, 8, 3);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(140, 23);
            dtpDateFrom.TabIndex = 1;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Roboto", 10F, FontStyle.Bold);
            lblHasta.ForeColor = Color.White;
            lblHasta.Location = new Point(221, 10);
            lblHasta.Margin = new Padding(10, 10, 4, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(49, 17);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            // 
            // dtpDateTo
            // 
            dtpDateTo.BackColor = Color.FromArgb(60, 60, 60);
            dtpDateTo.CalendarForeColor = Color.White;
            dtpDateTo.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtpDateTo.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);
            dtpDateTo.CalendarTitleForeColor = Color.White;
            dtpDateTo.CalendarTrailingForeColor = Color.FromArgb(150, 150, 150);
            dtpDateTo.Font = new Font("Roboto", 9.5F);
            dtpDateTo.ForeColor = Color.White;
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(277, 7);
            dtpDateTo.Margin = new Padding(3, 7, 12, 3);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(140, 23);
            dtpDateTo.TabIndex = 3;
            // 
            // btnFilter
            // 
            btnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnFilter.Depth = 0;
            btnFilter.HighEmphasis = true;
            btnFilter.Icon = null;
            btnFilter.Location = new Point(433, 3);
            btnFilter.Margin = new Padding(4, 3, 4, 3);
            btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            btnFilter.Name = "btnFilter";
            btnFilter.NoAccentTextColor = Color.Empty;
            btnFilter.Size = new Size(80, 36);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filtrar";
            btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFilter.UseAccentColor = false;
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            btnClearFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            btnClearFilter.Depth = 0;
            btnClearFilter.HighEmphasis = false;
            btnClearFilter.Icon = null;
            btnClearFilter.Location = new Point(521, 3);
            btnClearFilter.Margin = new Padding(4, 3, 4, 3);
            btnClearFilter.MouseState = MaterialSkin.MouseState.HOVER;
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.NoAccentTextColor = Color.Empty;
            btnClearFilter.Size = new Size(106, 36);
            btnClearFilter.TabIndex = 5;
            btnClearFilter.Text = "Mes Actual";
            btnClearFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnClearFilter.UseAccentColor = false;
            btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // pnlKpisRow
            // 
            pnlKpisRow.BackColor = Color.FromArgb(50, 50, 50);
            pnlKpisRow.Controls.Add(tlpKpis);
            pnlKpisRow.Dock = DockStyle.Fill;
            pnlKpisRow.Location = new Point(15, 52);
            pnlKpisRow.Margin = new Padding(3, 2, 3, 2);
            pnlKpisRow.Name = "pnlKpisRow";
            pnlKpisRow.Size = new Size(1650, 172);
            pnlKpisRow.TabIndex = 1;
            // 
            // tlpKpis
            // 
            tlpKpis.BackColor = Color.FromArgb(50, 50, 50);
            tlpKpis.ColumnCount = 6;
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpKpis.Dock = DockStyle.Fill;
            tlpKpis.Location = new Point(0, 0);
            tlpKpis.Name = "tlpKpis";
            tlpKpis.RowCount = 1;
            tlpKpis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKpis.Size = new Size(1650, 172);
            tlpKpis.TabIndex = 0;
            // 
            // pnlEvolucion
            // 
            pnlEvolucion.BackColor = Color.FromArgb(60, 60, 60);
            pnlEvolucion.Controls.Add(lblEvolucionTitle);
            pnlEvolucion.Dock = DockStyle.Fill;
            pnlEvolucion.Location = new Point(18, 230);
            pnlEvolucion.Margin = new Padding(6, 4, 6, 4);
            pnlEvolucion.Name = "pnlEvolucion";
            pnlEvolucion.Padding = new Padding(12);
            pnlEvolucion.Size = new Size(1644, 328);
            pnlEvolucion.TabIndex = 2;
            // 
            // lblEvolucionTitle
            // 
            lblEvolucionTitle.Depth = 0;
            lblEvolucionTitle.Dock = DockStyle.Top;
            lblEvolucionTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEvolucionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblEvolucionTitle.ForeColor = Color.White;
            lblEvolucionTitle.Location = new Point(12, 12);
            lblEvolucionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblEvolucionTitle.Name = "lblEvolucionTitle";
            lblEvolucionTitle.Padding = new Padding(8, 0, 0, 0);
            lblEvolucionTitle.Size = new Size(1620, 26);
            lblEvolucionTitle.TabIndex = 0;
            lblEvolucionTitle.Text = "Evolución Comparativa de Facturación";
            lblEvolucionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpDistribucion
            // 
            tlpDistribucion.BackColor = Color.FromArgb(50, 50, 50);
            tlpDistribucion.ColumnCount = 2;
            tlpDistribucion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDistribucion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDistribucion.Controls.Add(pnlTopProductos, 0, 0);
            tlpDistribucion.Controls.Add(pnlSellerDistribution, 1, 0);
            tlpDistribucion.Dock = DockStyle.Fill;
            tlpDistribucion.Location = new Point(15, 564);
            tlpDistribucion.Margin = new Padding(3, 2, 3, 2);
            tlpDistribucion.Name = "tlpDistribucion";
            tlpDistribucion.RowCount = 1;
            tlpDistribucion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDistribucion.Size = new Size(1650, 281);
            tlpDistribucion.TabIndex = 3;
            // 
            // pnlTopProductos
            // 
            pnlTopProductos.BackColor = Color.FromArgb(60, 60, 60);
            pnlTopProductos.Controls.Add(lblTopProductosTitle);
            pnlTopProductos.Dock = DockStyle.Fill;
            pnlTopProductos.Location = new Point(6, 4);
            pnlTopProductos.Margin = new Padding(6, 4, 6, 4);
            pnlTopProductos.Name = "pnlTopProductos";
            pnlTopProductos.Padding = new Padding(12);
            pnlTopProductos.Size = new Size(813, 273);
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
            lblTopProductosTitle.Size = new Size(789, 26);
            lblTopProductosTitle.TabIndex = 0;
            lblTopProductosTitle.Text = "Top 5 Productos más Vendidos";
            lblTopProductosTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSellerDistribution
            // 
            pnlSellerDistribution.BackColor = Color.FromArgb(60, 60, 60);
            pnlSellerDistribution.Controls.Add(lblSellerDistributionTitle);
            pnlSellerDistribution.Dock = DockStyle.Fill;
            pnlSellerDistribution.Location = new Point(831, 4);
            pnlSellerDistribution.Margin = new Padding(6, 4, 6, 4);
            pnlSellerDistribution.Name = "pnlSellerDistribution";
            pnlSellerDistribution.Padding = new Padding(12);
            pnlSellerDistribution.Size = new Size(813, 273);
            pnlSellerDistribution.TabIndex = 1;
            // 
            // lblSellerDistributionTitle
            // 
            lblSellerDistributionTitle.Depth = 0;
            lblSellerDistributionTitle.Dock = DockStyle.Top;
            lblSellerDistributionTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSellerDistributionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblSellerDistributionTitle.ForeColor = Color.White;
            lblSellerDistributionTitle.Location = new Point(12, 12);
            lblSellerDistributionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblSellerDistributionTitle.Name = "lblSellerDistributionTitle";
            lblSellerDistributionTitle.Padding = new Padding(8, 0, 0, 0);
            lblSellerDistributionTitle.Size = new Size(789, 26);
            lblSellerDistributionTitle.TabIndex = 0;
            lblSellerDistributionTitle.Text = "Participación en Ventas por Vendedor";
            lblSellerDistributionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManagerReportControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tlpMain);
            Controls.Add(tableLayoutPanel1);
            Name = "ManagerReportControl";
            Size = new Size(1680, 930);
            ((System.ComponentModel.ISupportInitialize)picManagerTitle).EndInit();
            tlpMain.ResumeLayout(false);
            pnlFilterBar.ResumeLayout(false);
            flpFilters.ResumeLayout(false);
            flpFilters.PerformLayout();
            pnlKpisRow.ResumeLayout(false);
            pnlEvolucion.ResumeLayout(false);
            tlpDistribucion.ResumeLayout(false);
            pnlTopProductos.ResumeLayout(false);
            pnlSellerDistribution.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;

        private TableLayoutPanel tlpMain;
        private Panel pnlFilterBar;
        private FlowLayoutPanel flpFilters;
        private Label lblDesde;
        private DateTimePicker dtpDateFrom;
        private Label lblHasta;
        private DateTimePicker dtpDateTo;
        private MaterialSkin.Controls.MaterialButton btnFilter;
        private MaterialSkin.Controls.MaterialButton btnClearFilter;

        private Panel pnlKpisRow;
        private TableLayoutPanel tlpKpis;

        private Panel pnlEvolucion;
        private MaterialSkin.Controls.MaterialLabel lblEvolucionTitle;

        private TableLayoutPanel tlpDistribucion;
        private Panel pnlTopProductos;
        private MaterialSkin.Controls.MaterialLabel lblTopProductosTitle;
        private Panel pnlSellerDistribution;
        private MaterialSkin.Controls.MaterialLabel lblSellerDistributionTitle;
    }
}
