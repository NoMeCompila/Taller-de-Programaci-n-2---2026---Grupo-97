namespace MobileSolutions.UILayer
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            userView1 = new UserView();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            tabPage3 = new TabPage();
            customerView1 = new CustomerView();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tabPage4 = new TabPage();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            tabPage5 = new TabPage();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            tabPage6 = new TabPage();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            tabPage7 = new TabPage();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            tabPage8 = new TabPage();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage7);
            materialTabControl1.Controls.Add(tabPage8);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 85);
            materialTabControl1.Margin = new Padding(3, 4, 3, 4);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1796, 1013);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(materialLabel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1788, 980);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(560, 424);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(43, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Home";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(userView1);
            tabPage2.Controls.Add(materialLabel3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1788, 980);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Usuarios";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // userView1
            // 
            userView1.Dock = DockStyle.Fill;
            userView1.Location = new Point(3, 4);
            userView1.Name = "userView1";
            userView1.Size = new Size(1782, 972);
            userView1.TabIndex = 3;
            userView1.Load += userView1_Load;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(569, 435);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(63, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Usuarios";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(customerView1);
            tabPage3.Controls.Add(materialLabel2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1770, 980);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Clientes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // customerView1
            // 
            customerView1.Dock = DockStyle.Fill;
            customerView1.Location = new Point(0, 0);
            customerView1.Name = "customerView1";
            customerView1.Size = new Size(1770, 980);
            customerView1.TabIndex = 4;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(560, 424);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(57, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Clientes";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(materialLabel4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1770, 980);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Productos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(560, 424);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(73, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Productos";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(materialLabel5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1770, 980);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Marcas";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(560, 424);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(54, 19);
            materialLabel5.TabIndex = 3;
            materialLabel5.Text = "Marcas";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(materialLabel6);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1770, 980);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Venta";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(560, 424);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(50, 19);
            materialLabel6.TabIndex = 3;
            materialLabel6.Text = "Ventas";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(materialLabel7);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(3, 4, 3, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1770, 980);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Historial De Ventas";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(560, 424);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(134, 19);
            materialLabel7.TabIndex = 3;
            materialLabel7.Text = "Historial de Ventas";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(materialLabel8);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Margin = new Padding(3, 4, 3, 4);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1770, 980);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Reportes";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(560, 424);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(63, 19);
            materialLabel8.TabIndex = 3;
            materialLabel8.Text = "Reportes";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 1102);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Padding = new Padding(3, 85, 3, 4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mobile Solutions";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private ImageList imageList1;
        private UserView userView1;
        private CustomerView customerView1;
    }
}

