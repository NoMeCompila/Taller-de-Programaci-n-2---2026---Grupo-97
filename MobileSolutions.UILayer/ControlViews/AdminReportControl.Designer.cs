namespace MobileSolutions.UILayer
{
    partial class AdminReportControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            picSellerTitle = new FontAwesome.Sharp.IconPictureBox();
            lblSellerTitle = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            picProximamente = new FontAwesome.Sharp.IconPictureBox();
            lblProximamente = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSellerTitle).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProximamente).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3928566F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.86905F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6785717F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1680, 73);
            tableLayoutPanel1.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.Controls.Add(picSellerTitle);
            panel1.Controls.Add(lblSellerTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(396, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(815, 67);
            panel1.TabIndex = 0;
            // 
            // picSellerTitle
            // 
            picSellerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picSellerTitle.BackColor = Color.FromArgb(50, 50, 50);
            picSellerTitle.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            picSellerTitle.IconColor = Color.White;
            picSellerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picSellerTitle.IconSize = 28;
            picSellerTitle.Location = new Point(115, 20);
            picSellerTitle.Name = "picSellerTitle";
            picSellerTitle.Size = new Size(34, 28);
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
            lblSellerTitle.Location = new Point(155, 5);
            lblSellerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblSellerTitle.Name = "lblSellerTitle";
            lblSellerTitle.Size = new Size(571, 58);
            lblSellerTitle.TabIndex = 36;
            lblSellerTitle.Text = "Reportes de Administrador";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1217, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 67);
            panel2.TabIndex = 1;
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
            btnLogout.Location = new Point(270, 13);
            btnLogout.Margin = new Padding(10);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(124, 17);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(79, 24);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "[Usuario]";
            // 
            // picProximamente
            // 
            picProximamente.BackColor = Color.Yellow;
            picProximamente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconChar = FontAwesome.Sharp.IconChar.None;
            picProximamente.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProximamente.IconSize = 75;
            picProximamente.Location = new Point(333, 276);
            picProximamente.Name = "picProximamente";
            picProximamente.Size = new Size(85, 75);
            picProximamente.TabIndex = 49;
            picProximamente.TabStop = false;
            // 
            // lblProximamente
            // 
            lblProximamente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProximamente.AutoSize = true;
            lblProximamente.Depth = 0;
            lblProximamente.Font = new Font("Roboto Light", 96F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProximamente.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            lblProximamente.Location = new Point(445, 255);
            lblProximamente.MouseState = MaterialSkin.MouseState.HOVER;
            lblProximamente.Name = "lblProximamente";
            lblProximamente.Size = new Size(770, 115);
            lblProximamente.TabIndex = 50;
            lblProximamente.Text = "En Mantenimiento";
            // 
            // AdminReportControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblProximamente);
            Controls.Add(picProximamente);
            Controls.Add(tableLayoutPanel1);
            Name = "AdminReportControl";
            Size = new Size(1680, 930);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSellerTitle).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProximamente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox picSellerTitle;
        private MaterialSkin.Controls.MaterialLabel lblSellerTitle;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private FontAwesome.Sharp.IconPictureBox picProximamente;
        private MaterialSkin.Controls.MaterialLabel lblProximamente;
    }
}
