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
            ((System.ComponentModel.ISupportInitialize)picHomeTitle).BeginInit();
            SuspendLayout();
            // 
            // lblHomeTitle
            // 
            lblHomeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHomeTitle.AutoSize = true;
            lblHomeTitle.Depth = 0;
            lblHomeTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHomeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblHomeTitle.Location = new Point(653, 22);
            lblHomeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblHomeTitle.Name = "lblHomeTitle";
            lblHomeTitle.Size = new Size(170, 72);
            lblHomeTitle.TabIndex = 0;
            lblHomeTitle.Text = "HOME";
            // 
            // picHomeTitle
            // 
            picHomeTitle.Location = new Point(549, 22);
            picHomeTitle.Name = "picHomeTitle";
            picHomeTitle.Size = new Size(85, 75);
            picHomeTitle.SizeMode = PictureBoxSizeMode.Zoom;
            picHomeTitle.TabIndex = 1;
            picHomeTitle.TabStop = false;
            // 
            // lblWelcomeBanner
            // 
            lblWelcomeBanner.AutoSize = true;
            lblWelcomeBanner.Depth = 0;
            lblWelcomeBanner.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblWelcomeBanner.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblWelcomeBanner.Location = new Point(549, 105);
            lblWelcomeBanner.MouseState = MaterialSkin.MouseState.HOVER;
            lblWelcomeBanner.Name = "lblWelcomeBanner";
            lblWelcomeBanner.Size = new Size(1, 0);
            lblWelcomeBanner.TabIndex = 2;
            lblWelcomeBanner.Text = "Bienvenido a Mobile Solutions";
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblWelcomeBanner);
            Controls.Add(picHomeTitle);
            Controls.Add(lblHomeTitle);
            Name = "HomeView";
            Size = new Size(1304, 848);
            ((System.ComponentModel.ISupportInitialize)picHomeTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblHomeTitle;
        private PictureBox picHomeTitle;
        private MaterialSkin.Controls.MaterialLabel lblWelcomeBanner;
    }
}
