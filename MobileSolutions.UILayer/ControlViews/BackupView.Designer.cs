namespace MobileSolutions.UILayer
{
    partial class BackupView
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
            pnlContainer = new Panel();
            pnlBackupContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            picBackupTitle = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            pnlContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackupTitle).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(50, 50, 50);
            pnlContainer.Controls.Add(pnlBackupContent);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1680, 930);
            pnlContainer.TabIndex = 0;
            // 
            // pnlBackupContent
            // 
            pnlBackupContent.BackColor = Color.FromArgb(50, 50, 50);
            pnlBackupContent.Dock = DockStyle.Fill;
            pnlBackupContent.Location = new Point(0, 82);
            pnlBackupContent.Name = "pnlBackupContent";
            pnlBackupContent.Size = new Size(1680, 848);
            pnlBackupContent.TabIndex = 1;
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
            tableLayoutPanel1.Size = new Size(1680, 82);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(picBackupTitle);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(507, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 76);
            panel1.TabIndex = 0;
            // 
            // picBackupTitle
            // 
            picBackupTitle.BackColor = Color.Transparent;
            picBackupTitle.ForeColor = Color.White;
            picBackupTitle.IconChar = FontAwesome.Sharp.IconChar.Database;
            picBackupTitle.IconColor = Color.White;
            picBackupTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBackupTitle.IconSize = 64;
            picBackupTitle.Location = new Point(140, 6);
            picBackupTitle.Name = "picBackupTitle";
            picBackupTitle.Size = new Size(81, 64);
            picBackupTitle.SizeMode = PictureBoxSizeMode.Zoom;
            picBackupTitle.TabIndex = 1;
            picBackupTitle.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTitulo.Location = new Point(235, 12);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Backup";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1179, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 76);
            panel2.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(220, 10);
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
            btnLogout.Location = new Point(356, 6);
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
            // BackupView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(pnlContainer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BackupView";
            Size = new Size(1680, 930);
            pnlContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackupTitle).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlBackupContent;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox picBackupTitle;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
        private MaterialSkin.Controls.MaterialButton btnLogout;
    }
}
