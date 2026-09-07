namespace MobileSolutions.UILayer
{
    partial class ProductView
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
            cmbBrand = new MaterialSkin.Controls.MaterialComboBox();
            txtProductCode = new MaterialSkin.Controls.MaterialTextBox2();
            txtName = new MaterialSkin.Controls.MaterialTextBox2();
            txtStock = new MaterialSkin.Controls.MaterialTextBox2();
            txtPurchasePrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtSalePrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtImageURL = new MaterialSkin.Controls.MaterialTextBox2();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            lblProductTitle = new MaterialSkin.Controls.MaterialLabel();
            swtActive = new MaterialSkin.Controls.MaterialSwitch();
            panel1 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnBrand = new MaterialSkin.Controls.MaterialButton();
            btnProductCode = new MaterialSkin.Controls.MaterialButton();
            btnName = new MaterialSkin.Controls.MaterialButton();
            btnStock = new MaterialSkin.Controls.MaterialButton();
            btnPurchasePrice = new MaterialSkin.Controls.MaterialButton();
            btnSalePrice = new MaterialSkin.Controls.MaterialButton();
            btnImageURL = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            dtgProducts = new DataGridView();
            panel3 = new Panel();
            materialCardImage = new MaterialSkin.Controls.MaterialCard();
            picProductImage = new PictureBox();
            picProductTitle = new FontAwesome.Sharp.IconPictureBox();
            ColumnId = new DataGridViewLinkColumn();
            ColumnBrand = new DataGridViewLinkColumn();
            ColumnCode = new DataGridViewLinkColumn();
            ColumnName = new DataGridViewLinkColumn();
            ColumnStock = new DataGridViewLinkColumn();
            ColumnPurchasePrice = new DataGridViewLinkColumn();
            ColumnSalePrice = new DataGridViewLinkColumn();
            ColumnImage = new DataGridViewLinkColumn();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProducts).BeginInit();
            panel3.SuspendLayout();
            materialCardImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).BeginInit();
            SuspendLayout();
            // 
            // cmbBrand
            // 
            cmbBrand.Anchor = AnchorStyles.Right;
            cmbBrand.AutoResize = false;
            cmbBrand.BackColor = Color.FromArgb(255, 255, 255);
            cmbBrand.Depth = 0;
            cmbBrand.DrawMode = DrawMode.OwnerDrawVariable;
            cmbBrand.DropDownHeight = 174;
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.DropDownWidth = 121;
            cmbBrand.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbBrand.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbBrand.Hint = "Marca";
            cmbBrand.IntegralHeight = false;
            cmbBrand.ItemHeight = 43;
            cmbBrand.Location = new Point(115, 22);
            cmbBrand.MaxDropDownItems = 4;
            cmbBrand.MouseState = MaterialSkin.MouseState.OUT;
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(441, 49);
            cmbBrand.StartIndex = 0;
            cmbBrand.TabIndex = 0;
            cmbBrand.TabStop = false;
            // 
            // txtProductCode
            // 
            txtProductCode.Anchor = AnchorStyles.Right;
            txtProductCode.AnimateReadOnly = false;
            txtProductCode.BackgroundImageLayout = ImageLayout.None;
            txtProductCode.CharacterCasing = CharacterCasing.Normal;
            txtProductCode.Depth = 0;
            txtProductCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductCode.HideSelection = true;
            txtProductCode.Hint = "Código de Producto";
            txtProductCode.LeadingIcon = null;
            txtProductCode.Location = new Point(115, 105);
            txtProductCode.MaxLength = 100;
            txtProductCode.MouseState = MaterialSkin.MouseState.OUT;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PasswordChar = '\0';
            txtProductCode.PrefixSuffixText = null;
            txtProductCode.ReadOnly = false;
            txtProductCode.RightToLeft = RightToLeft.No;
            txtProductCode.SelectedText = "";
            txtProductCode.SelectionLength = 0;
            txtProductCode.SelectionStart = 0;
            txtProductCode.ShortcutsEnabled = true;
            txtProductCode.Size = new Size(442, 48);
            txtProductCode.TabIndex = 1;
            txtProductCode.TabStop = false;
            txtProductCode.TextAlign = HorizontalAlignment.Left;
            txtProductCode.TrailingIcon = null;
            txtProductCode.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Right;
            txtName.AnimateReadOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(114, 203);
            txtName.MaxLength = 100;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(441, 48);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Right;
            txtStock.AnimateReadOnly = false;
            txtStock.BackgroundImageLayout = ImageLayout.None;
            txtStock.CharacterCasing = CharacterCasing.Normal;
            txtStock.Depth = 0;
            txtStock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStock.HideSelection = true;
            txtStock.Hint = "Stock";
            txtStock.LeadingIcon = null;
            txtStock.Location = new Point(114, 309);
            txtStock.MaxLength = 10;
            txtStock.MouseState = MaterialSkin.MouseState.OUT;
            txtStock.Name = "txtStock";
            txtStock.PasswordChar = '\0';
            txtStock.PrefixSuffixText = null;
            txtStock.ReadOnly = false;
            txtStock.RightToLeft = RightToLeft.No;
            txtStock.SelectedText = "";
            txtStock.SelectionLength = 0;
            txtStock.SelectionStart = 0;
            txtStock.ShortcutsEnabled = true;
            txtStock.Size = new Size(441, 48);
            txtStock.TabIndex = 3;
            txtStock.TabStop = false;
            txtStock.TextAlign = HorizontalAlignment.Left;
            txtStock.TrailingIcon = null;
            txtStock.UseSystemPasswordChar = false;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Anchor = AnchorStyles.Right;
            txtPurchasePrice.AnimateReadOnly = false;
            txtPurchasePrice.BackgroundImageLayout = ImageLayout.None;
            txtPurchasePrice.CharacterCasing = CharacterCasing.Normal;
            txtPurchasePrice.Depth = 0;
            txtPurchasePrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPurchasePrice.HideSelection = true;
            txtPurchasePrice.Hint = "Precio de Compra";
            txtPurchasePrice.LeadingIcon = null;
            txtPurchasePrice.Location = new Point(114, 412);
            txtPurchasePrice.MaxLength = 20;
            txtPurchasePrice.MouseState = MaterialSkin.MouseState.OUT;
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.PasswordChar = '\0';
            txtPurchasePrice.PrefixSuffixText = null;
            txtPurchasePrice.ReadOnly = false;
            txtPurchasePrice.RightToLeft = RightToLeft.No;
            txtPurchasePrice.SelectedText = "";
            txtPurchasePrice.SelectionLength = 0;
            txtPurchasePrice.SelectionStart = 0;
            txtPurchasePrice.ShortcutsEnabled = true;
            txtPurchasePrice.Size = new Size(441, 48);
            txtPurchasePrice.TabIndex = 4;
            txtPurchasePrice.TabStop = false;
            txtPurchasePrice.TextAlign = HorizontalAlignment.Left;
            txtPurchasePrice.TrailingIcon = null;
            txtPurchasePrice.UseSystemPasswordChar = false;
            txtPurchasePrice.KeyPress += txtDecimalPrice_KeyPress;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Anchor = AnchorStyles.Right;
            txtSalePrice.AnimateReadOnly = false;
            txtSalePrice.BackgroundImageLayout = ImageLayout.None;
            txtSalePrice.CharacterCasing = CharacterCasing.Normal;
            txtSalePrice.Depth = 0;
            txtSalePrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalePrice.HideSelection = true;
            txtSalePrice.Hint = "Precio de Venta";
            txtSalePrice.LeadingIcon = null;
            txtSalePrice.Location = new Point(115, 506);
            txtSalePrice.MaxLength = 20;
            txtSalePrice.MouseState = MaterialSkin.MouseState.OUT;
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.PasswordChar = '\0';
            txtSalePrice.PrefixSuffixText = null;
            txtSalePrice.ReadOnly = false;
            txtSalePrice.RightToLeft = RightToLeft.No;
            txtSalePrice.SelectedText = "";
            txtSalePrice.SelectionLength = 0;
            txtSalePrice.SelectionStart = 0;
            txtSalePrice.ShortcutsEnabled = true;
            txtSalePrice.Size = new Size(441, 48);
            txtSalePrice.TabIndex = 5;
            txtSalePrice.TabStop = false;
            txtSalePrice.TextAlign = HorizontalAlignment.Left;
            txtSalePrice.TrailingIcon = null;
            txtSalePrice.UseSystemPasswordChar = false;
            txtSalePrice.KeyPress += txtDecimalPrice_KeyPress;
            // 
            // txtImageURL
            // 
            txtImageURL.Anchor = AnchorStyles.Right;
            txtImageURL.AnimateReadOnly = false;
            txtImageURL.BackgroundImageLayout = ImageLayout.None;
            txtImageURL.CharacterCasing = CharacterCasing.Normal;
            txtImageURL.Depth = 0;
            txtImageURL.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImageURL.HideSelection = true;
            txtImageURL.Hint = "URL o Ruta de Imagen";
            txtImageURL.LeadingIcon = null;
            txtImageURL.Location = new Point(103, 526);
            txtImageURL.MaxLength = 255;
            txtImageURL.MouseState = MaterialSkin.MouseState.OUT;
            txtImageURL.Name = "txtImageURL";
            txtImageURL.PasswordChar = '\0';
            txtImageURL.PrefixSuffixText = null;
            txtImageURL.ReadOnly = false;
            txtImageURL.RightToLeft = RightToLeft.No;
            txtImageURL.SelectedText = "";
            txtImageURL.SelectionLength = 0;
            txtImageURL.SelectionStart = 0;
            txtImageURL.ShortcutsEnabled = true;
            txtImageURL.Size = new Size(408, 48);
            txtImageURL.TabIndex = 6;
            txtImageURL.TabStop = false;
            txtImageURL.TextAlign = HorizontalAlignment.Left;
            txtImageURL.TrailingIcon = null;
            txtImageURL.UseSystemPasswordChar = false;
            txtImageURL.Leave += txtImageURL_Leave;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(598, 144);
            btnSave.Margin = new Padding(5);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(88, 36);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(598, 232);
            btnClear.Margin = new Padding(5);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(79, 36);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(598, 324);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(88, 36);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(598, 416);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblProductTitle
            // 
            lblProductTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProductTitle.AutoSize = true;
            lblProductTitle.Depth = 0;
            lblProductTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblProductTitle.Location = new Point(632, 24);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(347, 72);
            lblProductTitle.TabIndex = 35;
            lblProductTitle.Text = "PRODUCTOS";
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(24, 734);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(102, 37);
            swtActive.TabIndex = 38;
            swtActive.Text = "Activo";
            swtActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(swtActive);
            panel1.Location = new Point(11, 111);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 771);
            panel1.TabIndex = 39;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnBrand);
            materialCard2.Controls.Add(btnProductCode);
            materialCard2.Controls.Add(btnName);
            materialCard2.Controls.Add(btnStock);
            materialCard2.Controls.Add(btnPurchasePrice);
            materialCard2.Controls.Add(btnSalePrice);
            materialCard2.Controls.Add(cmbBrand);
            materialCard2.Controls.Add(txtProductCode);
            materialCard2.Controls.Add(txtName);
            materialCard2.Controls.Add(txtStock);
            materialCard2.Controls.Add(txtPurchasePrice);
            materialCard2.Controls.Add(txtSalePrice);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(5, 56);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(598, 620);
            materialCard2.TabIndex = 43;
            // 
            // btnBrand
            // 
            btnBrand.Anchor = AnchorStyles.Right;
            btnBrand.AutoSize = false;
            btnBrand.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrand.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBrand.Depth = 0;
            btnBrand.HighEmphasis = true;
            btnBrand.Icon = null;
            btnBrand.Location = new Point(50, 20);
            btnBrand.Margin = new Padding(5);
            btnBrand.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrand.Name = "btnBrand";
            btnBrand.NoAccentTextColor = Color.Empty;
            btnBrand.Size = new Size(43, 51);
            btnBrand.TabIndex = 44;
            btnBrand.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBrand.UseAccentColor = false;
            btnBrand.UseVisualStyleBackColor = true;
            btnBrand.Click += btnBrand_Click;
            // 
            // btnProductCode
            // 
            btnProductCode.Anchor = AnchorStyles.Right;
            btnProductCode.AutoSize = false;
            btnProductCode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProductCode.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnProductCode.Depth = 0;
            btnProductCode.HighEmphasis = true;
            btnProductCode.Icon = null;
            btnProductCode.Location = new Point(50, 102);
            btnProductCode.Margin = new Padding(5);
            btnProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            btnProductCode.Name = "btnProductCode";
            btnProductCode.NoAccentTextColor = Color.Empty;
            btnProductCode.Size = new Size(43, 51);
            btnProductCode.TabIndex = 45;
            btnProductCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnProductCode.UseAccentColor = false;
            btnProductCode.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            btnName.Anchor = AnchorStyles.Right;
            btnName.AutoSize = false;
            btnName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnName.Depth = 0;
            btnName.HighEmphasis = true;
            btnName.Icon = null;
            btnName.Location = new Point(50, 200);
            btnName.Margin = new Padding(5);
            btnName.MouseState = MaterialSkin.MouseState.HOVER;
            btnName.Name = "btnName";
            btnName.NoAccentTextColor = Color.Empty;
            btnName.Size = new Size(43, 51);
            btnName.TabIndex = 46;
            btnName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnName.UseAccentColor = false;
            btnName.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            btnStock.Anchor = AnchorStyles.Right;
            btnStock.AutoSize = false;
            btnStock.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStock.Depth = 0;
            btnStock.HighEmphasis = true;
            btnStock.Icon = null;
            btnStock.Location = new Point(50, 306);
            btnStock.Margin = new Padding(5);
            btnStock.MouseState = MaterialSkin.MouseState.HOVER;
            btnStock.Name = "btnStock";
            btnStock.NoAccentTextColor = Color.Empty;
            btnStock.Size = new Size(43, 51);
            btnStock.TabIndex = 47;
            btnStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStock.UseAccentColor = false;
            btnStock.UseVisualStyleBackColor = true;
            // 
            // btnPurchasePrice
            // 
            btnPurchasePrice.Anchor = AnchorStyles.Right;
            btnPurchasePrice.AutoSize = false;
            btnPurchasePrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPurchasePrice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPurchasePrice.Depth = 0;
            btnPurchasePrice.HighEmphasis = true;
            btnPurchasePrice.Icon = null;
            btnPurchasePrice.Location = new Point(50, 409);
            btnPurchasePrice.Margin = new Padding(5);
            btnPurchasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnPurchasePrice.Name = "btnPurchasePrice";
            btnPurchasePrice.NoAccentTextColor = Color.Empty;
            btnPurchasePrice.Size = new Size(43, 51);
            btnPurchasePrice.TabIndex = 48;
            btnPurchasePrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPurchasePrice.UseAccentColor = false;
            btnPurchasePrice.UseVisualStyleBackColor = true;
            // 
            // btnSalePrice
            // 
            btnSalePrice.Anchor = AnchorStyles.Right;
            btnSalePrice.AutoSize = false;
            btnSalePrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalePrice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalePrice.Depth = 0;
            btnSalePrice.HighEmphasis = true;
            btnSalePrice.Icon = null;
            btnSalePrice.Location = new Point(50, 503);
            btnSalePrice.Margin = new Padding(5);
            btnSalePrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalePrice.Name = "btnSalePrice";
            btnSalePrice.NoAccentTextColor = Color.Empty;
            btnSalePrice.Size = new Size(43, 51);
            btnSalePrice.TabIndex = 49;
            btnSalePrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalePrice.UseAccentColor = false;
            btnSalePrice.UseVisualStyleBackColor = true;
            btnSalePrice.Click += btnSalePrice_Click;
            // 
            // btnImageURL
            // 
            btnImageURL.Anchor = AnchorStyles.Right;
            btnImageURL.AutoSize = false;
            btnImageURL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImageURL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImageURL.Depth = 0;
            btnImageURL.HighEmphasis = true;
            btnImageURL.Icon = null;
            btnImageURL.Location = new Point(39, 523);
            btnImageURL.Margin = new Padding(5);
            btnImageURL.MouseState = MaterialSkin.MouseState.HOVER;
            btnImageURL.Name = "btnImageURL";
            btnImageURL.NoAccentTextColor = Color.Empty;
            btnImageURL.Size = new Size(43, 51);
            btnImageURL.TabIndex = 50;
            btnImageURL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImageURL.UseAccentColor = false;
            btnImageURL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtgProducts);
            panel2.Location = new Point(0, 937);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1618, 273);
            panel2.TabIndex = 40;
            // 
            // dtgProducts
            // 
            dtgProducts.AllowUserToOrderColumns = true;
            dtgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProducts.BackgroundColor = Color.MidnightBlue;
            dtgProducts.BorderStyle = BorderStyle.None;
            dtgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducts.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnBrand, ColumnCode, ColumnName, ColumnStock, ColumnPurchasePrice, ColumnSalePrice, ColumnImage });
            dtgProducts.Dock = DockStyle.Fill;
            dtgProducts.GridColor = SystemColors.InactiveCaptionText;
            dtgProducts.Location = new Point(0, 0);
            dtgProducts.Name = "dtgProducts";
            dtgProducts.RowHeadersWidth = 51;
            dtgProducts.Size = new Size(1618, 273);
            dtgProducts.TabIndex = 33;
            dtgProducts.CellContentClick += dtgProducts_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.Controls.Add(materialCardImage);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(696, 111);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 771);
            panel3.TabIndex = 41;
            // 
            // materialCardImage
            // 
            materialCardImage.BackColor = Color.FromArgb(255, 255, 255);
            materialCardImage.Controls.Add(picProductImage);
            materialCardImage.Controls.Add(btnImageURL);
            materialCardImage.Controls.Add(txtImageURL);
            materialCardImage.Depth = 0;
            materialCardImage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardImage.Location = new Point(5, 56);
            materialCardImage.Margin = new Padding(16, 19, 16, 19);
            materialCardImage.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardImage.Name = "materialCardImage";
            materialCardImage.Padding = new Padding(16, 19, 16, 19);
            materialCardImage.Size = new Size(551, 620);
            materialCardImage.TabIndex = 43;
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.FromArgb(240, 240, 240);
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(52, 48);
            picProductImage.Margin = new Padding(3, 4, 3, 4);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(448, 448);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 0;
            picProductImage.TabStop = false;
            // 
            // picProductTitle
            // 
            picProductTitle.BackColor = Color.FromArgb(255, 255, 255);
            picProductTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProductTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picProductTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProductTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProductTitle.IconSize = 97;
            picProductTitle.Location = new Point(528, 20);
            picProductTitle.Margin = new Padding(3, 4, 3, 4);
            picProductTitle.Name = "picProductTitle";
            picProductTitle.Size = new Size(97, 100);
            picProductTitle.TabIndex = 45;
            picProductTitle.TabStop = false;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "ID";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            // 
            // ColumnBrand
            // 
            ColumnBrand.HeaderText = "Marca";
            ColumnBrand.MinimumWidth = 6;
            ColumnBrand.Name = "ColumnBrand";
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Código";
            ColumnCode.MinimumWidth = 6;
            ColumnCode.Name = "ColumnCode";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock";
            ColumnStock.MinimumWidth = 6;
            ColumnStock.Name = "ColumnStock";
            // 
            // ColumnPurchasePrice
            // 
            ColumnPurchasePrice.HeaderText = "P. Compra";
            ColumnPurchasePrice.MinimumWidth = 6;
            ColumnPurchasePrice.Name = "ColumnPurchasePrice";
            // 
            // ColumnSalePrice
            // 
            ColumnSalePrice.HeaderText = "P. Venta";
            ColumnSalePrice.MinimumWidth = 6;
            ColumnSalePrice.Name = "ColumnSalePrice";
            // 
            // ColumnImage
            // 
            ColumnImage.HeaderText = "Imagen";
            ColumnImage.MinimumWidth = 6;
            ColumnImage.Name = "ColumnImage";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picProductTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblProductTitle);
            Name = "ProductView";
            Size = new Size(1618, 1211);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProducts).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            materialCardImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ─── Declaración de controles ─────────────────────────────────────────
        private MaterialSkin.Controls.MaterialComboBox   cmbBrand;
        private MaterialSkin.Controls.MaterialTextBox2   txtProductCode;
        private MaterialSkin.Controls.MaterialTextBox2   txtName;
        private MaterialSkin.Controls.MaterialTextBox2   txtStock;
        private MaterialSkin.Controls.MaterialTextBox2   txtPurchasePrice;
        private MaterialSkin.Controls.MaterialTextBox2   txtSalePrice;
        private MaterialSkin.Controls.MaterialTextBox2   txtImageURL;
        private MaterialSkin.Controls.MaterialButton     btnSave;
        private MaterialSkin.Controls.MaterialButton     btnClear;
        private MaterialSkin.Controls.MaterialButton     btnDelete;
        private MaterialSkin.Controls.MaterialButton     btnUpdate;
        private MaterialSkin.Controls.MaterialLabel      lblProductTitle;
        private MaterialSkin.Controls.MaterialSwitch     swtActive;
        private Panel                                    panel1;
        private Panel                                    panel2;
        private Panel                                    panel3;
        private DataGridView                             dtgProducts;
        private MaterialSkin.Controls.MaterialCard       materialCard2;
        private MaterialSkin.Controls.MaterialCard       materialCardImage;
        private PictureBox                               picProductImage;
        private FontAwesome.Sharp.IconPictureBox         picProductTitle;
        private MaterialSkin.Controls.MaterialButton     btnBrand;
        private MaterialSkin.Controls.MaterialButton     btnProductCode;
        private MaterialSkin.Controls.MaterialButton     btnName;
        private MaterialSkin.Controls.MaterialButton     btnStock;
        private MaterialSkin.Controls.MaterialButton     btnPurchasePrice;
        private MaterialSkin.Controls.MaterialButton     btnSalePrice;
        private MaterialSkin.Controls.MaterialButton     btnImageURL;
        private DataGridViewLinkColumn ColumnId;
        private DataGridViewLinkColumn ColumnBrand;
        private DataGridViewLinkColumn ColumnCode;
        private DataGridViewLinkColumn ColumnName;
        private DataGridViewLinkColumn ColumnStock;
        private DataGridViewLinkColumn ColumnPurchasePrice;
        private DataGridViewLinkColumn ColumnSalePrice;
        private DataGridViewLinkColumn ColumnImage;
    }
}
