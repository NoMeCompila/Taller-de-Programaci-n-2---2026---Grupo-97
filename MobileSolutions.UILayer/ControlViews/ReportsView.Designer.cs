namespace MobileSolutions.UILayer
{
    partial class ReportsView
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
            picProximamente = new FontAwesome.Sharp.IconPictureBox();
            lblProximamente = new MaterialSkin.Controls.MaterialLabel();
            picReportsTitle = new FontAwesome.Sharp.IconPictureBox();
            lblReportsTitle = new MaterialSkin.Controls.MaterialLabel();
            pnlContainer = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)picProximamente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReportsTitle).BeginInit();
            pnlContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picProximamente
            // 
            picProximamente.BackColor = Color.FromArgb(255, 255, 255);
            picProximamente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconChar = FontAwesome.Sharp.IconChar.None;
            picProximamente.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProximamente.IconSize = 75;
            picProximamente.Location = new Point(321, 236);
            picProximamente.Name = "picProximamente";
            picProximamente.Size = new Size(85, 75);
            picProximamente.TabIndex = 48;
            picProximamente.TabStop = false;
            // 
            // lblProximamente
            // 
            lblProximamente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProximamente.AutoSize = true;
            lblProximamente.Depth = 0;
            lblProximamente.Font = new Font("Roboto Light", 96F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProximamente.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            lblProximamente.Location = new Point(419, 225);
            lblProximamente.MouseState = MaterialSkin.MouseState.HOVER;
            lblProximamente.Name = "lblProximamente";
            lblProximamente.Size = new Size(843, 115);
            lblProximamente.TabIndex = 47;
            lblProximamente.Text = "Perfil No Autorizado";
            // 
            // picReportsTitle
            // 
            picReportsTitle.BackColor = Color.FromArgb(255, 255, 255);
            picReportsTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picReportsTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picReportsTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picReportsTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picReportsTitle.IconSize = 75;
            picReportsTitle.Location = new Point(106, 3);
            picReportsTitle.Name = "picReportsTitle";
            picReportsTitle.Size = new Size(85, 75);
            picReportsTitle.TabIndex = 46;
            picReportsTitle.TabStop = false;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.Depth = 0;
            lblReportsTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblReportsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblReportsTitle.Location = new Point(215, 20);
            lblReportsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(235, 58);
            lblReportsTitle.TabIndex = 36;
            lblReportsTitle.Text = "REPORTES";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Controls.Add(picProximamente);
            pnlContainer.Controls.Add(lblProximamente);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1479, 698);
            pnlContainer.TabIndex = 49;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1473, 100);
            tableLayoutPanel1.TabIndex = 49;
            // 
            // panel1
            // 
            panel1.Controls.Add(picReportsTitle);
            panel1.Controls.Add(lblReportsTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(444, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 94);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1033, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 94);
            panel2.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(115, 10);
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
            btnLogout.Location = new Point(251, 6);
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
            // ReportsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportsView";
            Size = new Size(1479, 698);
            ((System.ComponentModel.ISupportInitialize)picProximamente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReportsTitle).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblReportsTitle;
        private FontAwesome.Sharp.IconPictureBox picProximamente;
        private MaterialSkin.Controls.MaterialLabel lblProximamente;
        private FontAwesome.Sharp.IconPictureBox picReportsTitle;
        private Panel pnlContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
    }
}
