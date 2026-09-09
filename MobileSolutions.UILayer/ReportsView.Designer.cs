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
            pnlContainer = new Panel();
            lblReportsTitle = new MaterialSkin.Controls.MaterialLabel();
            picReportsTitle = new FontAwesome.Sharp.IconPictureBox();
            lblProximamente = new MaterialSkin.Controls.MaterialLabel();
            picProximamente = new FontAwesome.Sharp.IconPictureBox();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReportsTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProximamente).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(picProximamente);
            pnlContainer.Controls.Add(lblProximamente);
            pnlContainer.Controls.Add(picReportsTitle);
            pnlContainer.Controls.Add(lblReportsTitle);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(881, 513);
            pnlContainer.TabIndex = 0;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.Depth = 0;
            lblReportsTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblReportsTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblReportsTitle.Location = new Point(364, 50);
            lblReportsTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(295, 72);
            lblReportsTitle.TabIndex = 36;
            lblReportsTitle.Text = "REPORTES";
            // 
            // picReportsTitle
            // 
            picReportsTitle.BackColor = Color.FromArgb(255, 255, 255);
            picReportsTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picReportsTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picReportsTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picReportsTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picReportsTitle.IconSize = 97;
            picReportsTitle.Location = new Point(245, 35);
            picReportsTitle.Margin = new Padding(3, 4, 3, 4);
            picReportsTitle.Name = "picReportsTitle";
            picReportsTitle.Size = new Size(97, 100);
            picReportsTitle.TabIndex = 46;
            picReportsTitle.TabStop = false;
            // 
            // lblProximamente
            // 
            lblProximamente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProximamente.AutoSize = true;
            lblProximamente.Depth = 0;
            lblProximamente.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProximamente.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblProximamente.Location = new Point(323, 286);
            lblProximamente.MouseState = MaterialSkin.MouseState.HOVER;
            lblProximamente.Name = "lblProximamente";
            lblProximamente.Size = new Size(386, 72);
            lblProximamente.TabIndex = 47;
            lblProximamente.Text = "Proximamente";
            // 
            // picProximamente
            // 
            picProximamente.BackColor = Color.FromArgb(255, 255, 255);
            picProximamente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconChar = FontAwesome.Sharp.IconChar.None;
            picProximamente.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProximamente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProximamente.IconSize = 97;
            picProximamente.Location = new Point(208, 276);
            picProximamente.Margin = new Padding(3, 4, 3, 4);
            picProximamente.Name = "picProximamente";
            picProximamente.Size = new Size(97, 100);
            picProximamente.TabIndex = 48;
            picProximamente.TabStop = false;
            // 
            // ReportsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContainer);
            Name = "ReportsView";
            Size = new Size(881, 513);
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picReportsTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProximamente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private MaterialSkin.Controls.MaterialLabel lblReportsTitle;
        private FontAwesome.Sharp.IconPictureBox picProximamente;
        private MaterialSkin.Controls.MaterialLabel lblProximamente;
        private FontAwesome.Sharp.IconPictureBox picReportsTitle;
    }
}
