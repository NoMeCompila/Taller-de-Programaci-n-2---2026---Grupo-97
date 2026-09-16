namespace MobileSolutions.UILayer
{
    partial class SellerReportControl
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
            picSellerTitle = new FontAwesome.Sharp.IconPictureBox();
            lblSellerTitle = new MaterialSkin.Controls.MaterialLabel();
            tlpMain = new TableLayoutPanel();
            pnlKpisRow = new Panel();
            tlpKpis = new TableLayoutPanel();
            pnlEvolucion = new Panel();
            lblEvolucionTitle = new MaterialSkin.Controls.MaterialLabel();
            tlpDistribucion = new TableLayoutPanel();
            pnlTopProductos = new Panel();
            lblTopProductosTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlMarcas = new Panel();
            lblMarcasTitle = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picSellerTitle).BeginInit();
            tlpMain.SuspendLayout();
            pnlKpisRow.SuspendLayout();
            pnlEvolucion.SuspendLayout();
            tlpDistribucion.SuspendLayout();
            pnlTopProductos.SuspendLayout();
            pnlMarcas.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picSellerTitle
            // 
            picSellerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picSellerTitle.BackColor = Color.FromArgb(50, 50, 50);
            picSellerTitle.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            picSellerTitle.IconColor = Color.White;
            picSellerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picSellerTitle.IconSize = 61;
            picSellerTitle.Location = new Point(41, 5);
            picSellerTitle.Name = "picSellerTitle";
            picSellerTitle.Size = new Size(84, 61);
            picSellerTitle.TabIndex = 0;
            picSellerTitle.TabStop = false;
            // 
            // lblSellerTitle
            // 
            lblSellerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblSellerTitle.AutoSize = true;
            lblSellerTitle.Depth = 0;
            lblSellerTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSellerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblSellerTitle.ForeColor = Color.White;
            lblSellerTitle.Location = new Point(131, 3);
            lblSellerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblSellerTitle.Name = "lblSellerTitle";
            lblSellerTitle.Size = new Size(472, 58);
            lblSellerTitle.TabIndex = 36;
            lblSellerTitle.Text = "Reportes de Vendedor";
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(50, 50, 50);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlKpisRow, 0, 0);
            tlpMain.Controls.Add(pnlEvolucion, 0, 1);
            tlpMain.Controls.Add(tlpDistribucion, 0, 2);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new Point(0, 84);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpMain.Size = new Size(1680, 846);
            tlpMain.TabIndex = 37;
            // 
            // pnlKpisRow
            // 
            pnlKpisRow.BackColor = Color.FromArgb(50, 50, 50);
            pnlKpisRow.Controls.Add(tlpKpis);
            pnlKpisRow.Dock = DockStyle.Fill;
            pnlKpisRow.Location = new Point(15, 15);
            pnlKpisRow.Name = "pnlKpisRow";
            pnlKpisRow.Size = new Size(1650, 158);
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
            tlpKpis.Size = new Size(1650, 158);
            tlpKpis.TabIndex = 0;
            // 
            // pnlEvolucion
            // 
            pnlEvolucion.BackColor = Color.FromArgb(60, 60, 60);
            pnlEvolucion.Controls.Add(lblEvolucionTitle);
            pnlEvolucion.Dock = DockStyle.Fill;
            pnlEvolucion.Location = new Point(18, 182);
            pnlEvolucion.Margin = new Padding(6);
            pnlEvolucion.Name = "pnlEvolucion";
            pnlEvolucion.Padding = new Padding(12);
            pnlEvolucion.Size = new Size(1644, 357);
            pnlEvolucion.TabIndex = 1;
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
            lblEvolucionTitle.Size = new Size(1620, 32);
            lblEvolucionTitle.TabIndex = 0;
            lblEvolucionTitle.Text = "Evolución de Ventas Diarias";
            lblEvolucionTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpDistribucion
            // 
            tlpDistribucion.BackColor = Color.FromArgb(50, 50, 50);
            tlpDistribucion.ColumnCount = 2;
            tlpDistribucion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDistribucion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpDistribucion.Controls.Add(pnlTopProductos, 0, 0);
            tlpDistribucion.Controls.Add(pnlMarcas, 1, 0);
            tlpDistribucion.Dock = DockStyle.Fill;
            tlpDistribucion.Location = new Point(15, 548);
            tlpDistribucion.Name = "tlpDistribucion";
            tlpDistribucion.RowCount = 1;
            tlpDistribucion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDistribucion.Size = new Size(1650, 283);
            tlpDistribucion.TabIndex = 2;
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
            pnlTopProductos.Size = new Size(813, 271);
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
            lblTopProductosTitle.Text = "Mis Top 5 Productos";
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
            pnlMarcas.Size = new Size(813, 271);
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
            lblMarcasTitle.Text = "Rendimiento por Marca";
            lblMarcasTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1674, 75);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(picSellerTitle);
            panel1.Controls.Add(lblSellerTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(505, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 69);
            panel1.TabIndex = 0;
            // 
            // SellerReportControl
            // 
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlpMain);
            Name = "SellerReportControl";
            Size = new Size(1680, 930);
            ((System.ComponentModel.ISupportInitialize)picSellerTitle).EndInit();
            tlpMain.ResumeLayout(false);
            pnlKpisRow.ResumeLayout(false);
            pnlEvolucion.ResumeLayout(false);
            tlpDistribucion.ResumeLayout(false);
            pnlTopProductos.ResumeLayout(false);
            pnlMarcas.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picSellerTitle;
        private MaterialSkin.Controls.MaterialLabel lblSellerTitle;
        private TableLayoutPanel tlpMain;
        private Panel pnlKpisRow;
        private TableLayoutPanel tlpKpis;
        private Panel pnlEvolucion;
        private MaterialSkin.Controls.MaterialLabel lblEvolucionTitle;
        private TableLayoutPanel tlpDistribucion;
        private Panel pnlTopProductos;
        private MaterialSkin.Controls.MaterialLabel lblTopProductosTitle;
        private Panel pnlMarcas;
        private MaterialSkin.Controls.MaterialLabel lblMarcasTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
