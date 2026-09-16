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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtImageURL = new MaterialSkin.Controls.MaterialTextBox2();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            lblProductTitle = new MaterialSkin.Controls.MaterialLabel();
            btnImageURL = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            dtgProducts = new DataGridView();
            ColumnBrand = new DataGridViewLinkColumn();
            ColumnCode = new DataGridViewLinkColumn();
            ColumnName = new DataGridViewLinkColumn();
            ColumnStock = new DataGridViewLinkColumn();
            ColumnPurchasePrice = new DataGridViewLinkColumn();
            ColumnSalePrice = new DataGridViewLinkColumn();
            ColumnImage = new DataGridViewLinkColumn();
            materialCardImage = new MaterialSkin.Controls.MaterialCard();
            picProductImage = new PictureBox();
            picProductTitle = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnBrand = new MaterialSkin.Controls.MaterialButton();
            btnProductCode = new MaterialSkin.Controls.MaterialButton();
            btnName = new MaterialSkin.Controls.MaterialButton();
            btnStock = new MaterialSkin.Controls.MaterialButton();
            btnPurchasePrice = new MaterialSkin.Controls.MaterialButton();
            btnSalePrice = new MaterialSkin.Controls.MaterialButton();
            cmbBrand = new MaterialSkin.Controls.MaterialComboBox();
            txtProductCode = new MaterialSkin.Controls.MaterialTextBox2();
            txtName = new MaterialSkin.Controls.MaterialTextBox2();
            txtStock = new MaterialSkin.Controls.MaterialTextBox2();
            txtPurchasePrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtSalePrice = new MaterialSkin.Controls.MaterialTextBox2();
            panel1 = new Panel();
            panel4 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconBtn = new FontAwesome.Sharp.IconButton();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProducts).BeginInit();
            materialCardImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).BeginInit();
            panel3.SuspendLayout();
            materialCard2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // txtImageURL
            // 
            txtImageURL.Anchor = AnchorStyles.Bottom;
            txtImageURL.AnimateReadOnly = false;
            txtImageURL.BackgroundImageLayout = ImageLayout.None;
            txtImageURL.CharacterCasing = CharacterCasing.Normal;
            txtImageURL.Depth = 0;
            txtImageURL.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImageURL.HideSelection = true;
            txtImageURL.Hint = "URL o Ruta de Imagen";
            txtImageURL.LeadingIcon = null;
            txtImageURL.Location = new Point(63, 284);
            txtImageURL.Margin = new Padding(3, 2, 3, 2);
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
            txtImageURL.Size = new Size(357, 48);
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
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(200, 89);
            btnSave.Margin = new Padding(4);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(126, 33);
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
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(43, 236);
            btnClear.Margin = new Padding(4);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(126, 33);
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
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(200, 236);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(126, 33);
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
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(43, 89);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(126, 33);
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
            lblProductTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblProductTitle.Location = new Point(641, 0);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(277, 58);
            lblProductTitle.TabIndex = 35;
            lblProductTitle.Text = "PRODUCTOS";
            // 
            // btnImageURL
            // 
            btnImageURL.Anchor = AnchorStyles.Bottom;
            btnImageURL.AutoSize = false;
            btnImageURL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImageURL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImageURL.Depth = 0;
            btnImageURL.HighEmphasis = true;
            btnImageURL.Icon = null;
            btnImageURL.Location = new Point(18, 284);
            btnImageURL.Margin = new Padding(4);
            btnImageURL.MouseState = MaterialSkin.MouseState.HOVER;
            btnImageURL.Name = "btnImageURL";
            btnImageURL.NoAccentTextColor = Color.Empty;
            btnImageURL.Size = new Size(38, 38);
            btnImageURL.TabIndex = 50;
            btnImageURL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImageURL.UseAccentColor = false;
            btnImageURL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtgProducts);
            panel2.Location = new Point(0, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(1470, 166);
            panel2.TabIndex = 40;
            // 
            // dtgProducts
            // 
            dtgProducts.AllowUserToOrderColumns = true;
            dtgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProducts.BackgroundColor = Color.MidnightBlue;
            dtgProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducts.Columns.AddRange(new DataGridViewColumn[] { ColumnBrand, ColumnCode, ColumnName, ColumnStock, ColumnPurchasePrice, ColumnSalePrice, ColumnImage });
            dtgProducts.Dock = DockStyle.Fill;
            dtgProducts.GridColor = SystemColors.InactiveCaptionText;
            dtgProducts.Location = new Point(0, 0);
            dtgProducts.Margin = new Padding(3, 2, 3, 2);
            dtgProducts.Name = "dtgProducts";
            dtgProducts.RowHeadersWidth = 51;
            dtgProducts.Size = new Size(1470, 166);
            dtgProducts.TabIndex = 33;
            dtgProducts.CellContentClick += dtgProducts_CellContentClick;
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
            // materialCardImage
            // 
            materialCardImage.Anchor = AnchorStyles.Right;
            materialCardImage.BackColor = Color.FromArgb(255, 255, 255);
            materialCardImage.Controls.Add(picProductImage);
            materialCardImage.Controls.Add(btnImageURL);
            materialCardImage.Controls.Add(txtImageURL);
            materialCardImage.Depth = 0;
            materialCardImage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardImage.Location = new Point(23, 24);
            materialCardImage.Margin = new Padding(14);
            materialCardImage.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardImage.Name = "materialCardImage";
            materialCardImage.Padding = new Padding(14);
            materialCardImage.Size = new Size(439, 340);
            materialCardImage.TabIndex = 43;
            // 
            // picProductImage
            // 
            picProductImage.BackColor = Color.FromArgb(240, 240, 240);
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(47, 20);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(338, 255);
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
            picProductTitle.IconSize = 75;
            picProductTitle.Location = new Point(551, -2);
            picProductTitle.Name = "picProductTitle";
            picProductTitle.Size = new Size(85, 75);
            picProductTitle.TabIndex = 45;
            picProductTitle.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Right;
            panel3.Controls.Add(materialCardImage);
            panel3.Location = new Point(618, 95);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 367);
            panel3.TabIndex = 46;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Left;
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
            materialCard2.Location = new Point(14, 22);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(561, 326);
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
            btnBrand.Location = new Point(66, 28);
            btnBrand.Margin = new Padding(4);
            btnBrand.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrand.Name = "btnBrand";
            btnBrand.NoAccentTextColor = Color.Empty;
            btnBrand.Size = new Size(38, 38);
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
            btnProductCode.Location = new Point(66, 74);
            btnProductCode.Margin = new Padding(4);
            btnProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            btnProductCode.Name = "btnProductCode";
            btnProductCode.NoAccentTextColor = Color.Empty;
            btnProductCode.Size = new Size(38, 38);
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
            btnName.Location = new Point(66, 120);
            btnName.Margin = new Padding(4);
            btnName.MouseState = MaterialSkin.MouseState.HOVER;
            btnName.Name = "btnName";
            btnName.NoAccentTextColor = Color.Empty;
            btnName.Size = new Size(38, 38);
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
            btnStock.Location = new Point(66, 166);
            btnStock.Margin = new Padding(4);
            btnStock.MouseState = MaterialSkin.MouseState.HOVER;
            btnStock.Name = "btnStock";
            btnStock.NoAccentTextColor = Color.Empty;
            btnStock.Size = new Size(38, 38);
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
            btnPurchasePrice.Location = new Point(66, 212);
            btnPurchasePrice.Margin = new Padding(4);
            btnPurchasePrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnPurchasePrice.Name = "btnPurchasePrice";
            btnPurchasePrice.NoAccentTextColor = Color.Empty;
            btnPurchasePrice.Size = new Size(38, 38);
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
            btnSalePrice.Location = new Point(66, 257);
            btnSalePrice.Margin = new Padding(4);
            btnSalePrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalePrice.Name = "btnSalePrice";
            btnSalePrice.NoAccentTextColor = Color.Empty;
            btnSalePrice.Size = new Size(38, 38);
            btnSalePrice.TabIndex = 49;
            btnSalePrice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalePrice.UseAccentColor = false;
            btnSalePrice.UseVisualStyleBackColor = true;
            btnSalePrice.Click += btnSalePrice_Click;
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
            cmbBrand.Location = new Point(111, 28);
            cmbBrand.Margin = new Padding(3, 2, 3, 2);
            cmbBrand.MaxDropDownItems = 4;
            cmbBrand.MouseState = MaterialSkin.MouseState.OUT;
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(386, 49);
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
            txtProductCode.Location = new Point(111, 76);
            txtProductCode.Margin = new Padding(3, 2, 3, 2);
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
            txtProductCode.Size = new Size(387, 48);
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
            txtName.Location = new Point(111, 120);
            txtName.Margin = new Padding(3, 2, 3, 2);
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
            txtName.Size = new Size(386, 48);
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
            txtStock.Location = new Point(111, 166);
            txtStock.Margin = new Padding(3, 2, 3, 2);
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
            txtStock.Size = new Size(386, 48);
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
            txtPurchasePrice.Location = new Point(111, 214);
            txtPurchasePrice.Margin = new Padding(3, 2, 3, 2);
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
            txtPurchasePrice.Size = new Size(386, 48);
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
            txtSalePrice.Location = new Point(111, 260);
            txtSalePrice.Margin = new Padding(3, 2, 3, 2);
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
            txtSalePrice.Size = new Size(386, 48);
            txtSalePrice.TabIndex = 5;
            txtSalePrice.TabStop = false;
            txtSalePrice.TextAlign = HorizontalAlignment.Left;
            txtSalePrice.TrailingIcon = null;
            txtSalePrice.UseSystemPasswordChar = false;
            txtSalePrice.KeyPress += txtDecimalPrice_KeyPress;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(materialCard2);
            panel1.Location = new Point(4, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 363);
            panel1.TabIndex = 39;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(iconButton2);
            panel4.Controls.Add(iconButton1);
            panel4.Controls.Add(iconButton3);
            panel4.Controls.Add(iconBtn);
            panel4.Location = new Point(1100, 132);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(347, 309);
            panel4.TabIndex = 56;
            // 
            // iconButton2
            // 
            iconButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton2.BackColor = Color.RoyalBlue;
            iconButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.Control;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 60;
            iconButton2.Location = new Point(32, 166);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(150, 120);
            iconButton2.TabIndex = 46;
            iconButton2.Text = "BUTTON";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton1.BackColor = Color.RoyalBlue;
            iconButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 60;
            iconButton1.Location = new Point(32, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(150, 120);
            iconButton1.TabIndex = 45;
            iconButton1.Text = "BUTTON";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton3.BackColor = Color.RoyalBlue;
            iconButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.Control;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 60;
            iconButton3.Location = new Point(186, 166);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(150, 120);
            iconButton3.TabIndex = 47;
            iconButton3.Text = "BUTTON";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconBtn
            // 
            iconBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconBtn.BackColor = Color.RoyalBlue;
            iconBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtn.ForeColor = SystemColors.Control;
            iconBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconBtn.IconColor = Color.White;
            iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtn.IconSize = 60;
            iconBtn.Location = new Point(186, 18);
            iconBtn.Name = "iconBtn";
            iconBtn.Size = new Size(150, 120);
            iconBtn.TabIndex = 44;
            iconBtn.Text = "BUTTON";
            iconBtn.TextAlign = ContentAlignment.BottomCenter;
            iconBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            iconBtn.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom;
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(521, 485);
            btnSearch.Margin = new Padding(4);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(38, 38);
            btnSearch.TabIndex = 57;
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // materialTextBox21
            // 
            materialTextBox21.Anchor = AnchorStyles.Bottom;
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HelperText = "Buscar por...";
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Buscar";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(566, 485);
            materialTextBox21.Margin = new Padding(3, 2, 3, 2);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(304, 48);
            materialTextBox21.TabIndex = 58;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialSwitch1
            // 
            materialSwitch1.Anchor = AnchorStyles.Bottom;
            materialSwitch1.AutoSize = true;
            materialSwitch1.Checked = true;
            materialSwitch1.CheckState = CheckState.Checked;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(873, 488);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(102, 37);
            materialSwitch1.TabIndex = 59;
            materialSwitch1.Text = "Activo";
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialSwitch1);
            Controls.Add(materialTextBox21);
            Controls.Add(btnSearch);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(picProductTitle);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblProductTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductView";
            Size = new Size(1470, 698);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgProducts).EndInit();
            materialCardImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).EndInit();
            panel3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2   txtImageURL;
        private MaterialSkin.Controls.MaterialButton     btnSave;
        private MaterialSkin.Controls.MaterialButton     btnClear;
        private MaterialSkin.Controls.MaterialButton     btnDelete;
        private MaterialSkin.Controls.MaterialButton     btnUpdate;
        private MaterialSkin.Controls.MaterialLabel      lblProductTitle;
        private Panel                                    panel2;
        private DataGridView                             dtgProducts;
        private MaterialSkin.Controls.MaterialCard       materialCardImage;
        private PictureBox                               picProductImage;
        private FontAwesome.Sharp.IconPictureBox         picProductTitle;
        private MaterialSkin.Controls.MaterialButton     btnImageURL;
        private DataGridViewLinkColumn ColumnBrand;
        private DataGridViewLinkColumn ColumnCode;
        private DataGridViewLinkColumn ColumnName;
        private DataGridViewLinkColumn ColumnStock;
        private DataGridViewLinkColumn ColumnPurchasePrice;
        private DataGridViewLinkColumn ColumnSalePrice;
        private DataGridViewLinkColumn ColumnImage;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btnBrand;
        private MaterialSkin.Controls.MaterialButton btnProductCode;
        private MaterialSkin.Controls.MaterialButton btnName;
        private MaterialSkin.Controls.MaterialButton btnStock;
        private MaterialSkin.Controls.MaterialButton btnPurchasePrice;
        private MaterialSkin.Controls.MaterialButton btnSalePrice;
        private MaterialSkin.Controls.MaterialComboBox cmbBrand;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductCode;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtStock;
        private MaterialSkin.Controls.MaterialTextBox2 txtPurchasePrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtSalePrice;
        private Panel panel1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconBtn;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}
