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
            dtgProducts = new DataGridView();
            materialCardImage = new MaterialSkin.Controls.MaterialCard();
            picProductImage = new PictureBox();
            picProductTitle = new FontAwesome.Sharp.IconPictureBox();
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
            panel4 = new Panel();
            btnReactivate = new MaterialSkin.Controls.MaterialButton();
            icoBtnReactivate = new FontAwesome.Sharp.IconButton();
            icoBtnUpdate = new FontAwesome.Sharp.IconButton();
            icoBtnClear = new FontAwesome.Sharp.IconButton();
            icoBtnDelete = new FontAwesome.Sharp.IconButton();
            icoBtnSave = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            swtActive = new MaterialSkin.Controls.MaterialSwitch();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel6 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            ColumnBrand = new DataGridViewTextBoxColumn();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnPurchasePrice = new DataGridViewTextBoxColumn();
            ColumnSalePrice = new DataGridViewTextBoxColumn();
            ColumnImage = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgProducts).BeginInit();
            materialCardImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).BeginInit();
            materialCard2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
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
            txtImageURL.Location = new Point(92, 338);
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
            btnSave.Location = new Point(195, 72);
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
            btnClear.Location = new Point(14, 72);
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
            btnDelete.Location = new Point(195, 243);
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
            btnUpdate.Location = new Point(14, 243);
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
            lblProductTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblProductTitle.AutoSize = true;
            lblProductTitle.Depth = 0;
            lblProductTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblProductTitle.Location = new Point(251, 3);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(277, 58);
            lblProductTitle.TabIndex = 35;
            lblProductTitle.Text = "PRODUCTOS";
            lblProductTitle.Click += lblProductTitle_Click;
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
            btnImageURL.Location = new Point(47, 346);
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
            dtgProducts.Dock = DockStyle.Bottom;
            dtgProducts.GridColor = SystemColors.InactiveCaptionText;
            dtgProducts.Location = new Point(0, 72);
            dtgProducts.Margin = new Padding(3, 2, 3, 2);
            dtgProducts.Name = "dtgProducts";
            dtgProducts.RowHeadersWidth = 51;
            dtgProducts.Size = new Size(1674, 317);
            dtgProducts.TabIndex = 33;
            dtgProducts.CellContentClick += dtgProducts_CellContentClick;
            // 
            // materialCardImage
            // 
            materialCardImage.Anchor = AnchorStyles.None;
            materialCardImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCardImage.BackColor = Color.FromArgb(255, 255, 255);
            materialCardImage.Controls.Add(picProductImage);
            materialCardImage.Controls.Add(btnImageURL);
            materialCardImage.Controls.Add(txtImageURL);
            materialCardImage.Depth = 0;
            materialCardImage.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardImage.Location = new Point(621, 14);
            materialCardImage.Margin = new Padding(14);
            materialCardImage.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardImage.Name = "materialCardImage";
            materialCardImage.Padding = new Padding(14);
            materialCardImage.Size = new Size(497, 402);
            materialCardImage.TabIndex = 43;
            // 
            // picProductImage
            // 
            picProductImage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picProductImage.BackColor = Color.FromArgb(240, 240, 240);
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(47, 38);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(402, 275);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 0;
            picProductImage.TabStop = false;
            // 
            // picProductTitle
            // 
            picProductTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picProductTitle.BackColor = Color.FromArgb(255, 255, 255);
            picProductTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProductTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picProductTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProductTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProductTitle.IconSize = 67;
            picProductTitle.Location = new Point(167, 0);
            picProductTitle.Name = "picProductTitle";
            picProductTitle.Size = new Size(78, 67);
            picProductTitle.TabIndex = 45;
            picProductTitle.TabStop = false;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(565, 402);
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
            btnBrand.Location = new Point(70, 66);
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
            btnProductCode.Location = new Point(70, 112);
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
            btnName.Location = new Point(70, 158);
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
            btnStock.Location = new Point(70, 204);
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
            btnPurchasePrice.Location = new Point(70, 250);
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
            btnSalePrice.Location = new Point(70, 295);
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
            cmbBrand.Location = new Point(115, 66);
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
            txtProductCode.Location = new Point(115, 114);
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
            txtName.Location = new Point(115, 158);
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
            txtStock.Location = new Point(115, 204);
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
            txtPurchasePrice.Location = new Point(115, 252);
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
            txtSalePrice.Location = new Point(115, 298);
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
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(btnReactivate);
            panel4.Controls.Add(icoBtnReactivate);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(icoBtnUpdate);
            panel4.Controls.Add(icoBtnClear);
            panel4.Controls.Add(icoBtnDelete);
            panel4.Controls.Add(icoBtnSave);
            panel4.Location = new Point(1246, 71);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 287);
            panel4.TabIndex = 56;
            // 
            // btnReactivate
            // 
            btnReactivate.Anchor = AnchorStyles.None;
            btnReactivate.AutoSize = false;
            btnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReactivate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReactivate.Depth = 0;
            btnReactivate.Enabled = false;
            btnReactivate.HighEmphasis = true;
            btnReactivate.Icon = null;
            btnReactivate.Location = new Point(111, 160);
            btnReactivate.Margin = new Padding(4);
            btnReactivate.MouseState = MaterialSkin.MouseState.HOVER;
            btnReactivate.Name = "btnReactivate";
            btnReactivate.NoAccentTextColor = Color.Empty;
            btnReactivate.Size = new Size(114, 35);
            btnReactivate.TabIndex = 59;
            btnReactivate.Text = "Reactivar";
            btnReactivate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReactivate.UseAccentColor = false;
            btnReactivate.UseVisualStyleBackColor = true;
            btnReactivate.Visible = false;
            // 
            // icoBtnReactivate
            // 
            icoBtnReactivate.Anchor = AnchorStyles.None;
            icoBtnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnReactivate.BackColor = Color.RoyalBlue;
            icoBtnReactivate.Enabled = false;
            icoBtnReactivate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnReactivate.ForeColor = SystemColors.Control;
            icoBtnReactivate.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            icoBtnReactivate.IconColor = Color.White;
            icoBtnReactivate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnReactivate.IconSize = 60;
            icoBtnReactivate.Location = new Point(99, 79);
            icoBtnReactivate.Margin = new Padding(2, 3, 2, 3);
            icoBtnReactivate.Name = "icoBtnReactivate";
            icoBtnReactivate.Size = new Size(137, 128);
            icoBtnReactivate.TabIndex = 58;
            icoBtnReactivate.Text = "BUTTON";
            icoBtnReactivate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnReactivate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnReactivate.UseVisualStyleBackColor = false;
            icoBtnReactivate.Visible = false;
            // 
            // icoBtnUpdate
            // 
            icoBtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            icoBtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnUpdate.BackColor = Color.RoyalBlue;
            icoBtnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnUpdate.ForeColor = SystemColors.Control;
            icoBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            icoBtnUpdate.IconColor = Color.White;
            icoBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnUpdate.IconSize = 60;
            icoBtnUpdate.Location = new Point(0, 167);
            icoBtnUpdate.Name = "icoBtnUpdate";
            icoBtnUpdate.Size = new Size(150, 120);
            icoBtnUpdate.TabIndex = 46;
            icoBtnUpdate.Text = "BUTTON";
            icoBtnUpdate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnUpdate.UseVisualStyleBackColor = false;
            // 
            // icoBtnClear
            // 
            icoBtnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnClear.BackColor = Color.RoyalBlue;
            icoBtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnClear.ForeColor = SystemColors.Control;
            icoBtnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            icoBtnClear.IconColor = Color.White;
            icoBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnClear.IconSize = 60;
            icoBtnClear.Location = new Point(4, 3);
            icoBtnClear.Name = "icoBtnClear";
            icoBtnClear.Size = new Size(150, 120);
            icoBtnClear.TabIndex = 45;
            icoBtnClear.Text = "BUTTON";
            icoBtnClear.TextAlign = ContentAlignment.BottomCenter;
            icoBtnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnClear.UseVisualStyleBackColor = false;
            // 
            // icoBtnDelete
            // 
            icoBtnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            icoBtnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnDelete.BackColor = Color.RoyalBlue;
            icoBtnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnDelete.ForeColor = SystemColors.Control;
            icoBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            icoBtnDelete.IconColor = Color.White;
            icoBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnDelete.IconSize = 60;
            icoBtnDelete.Location = new Point(181, 164);
            icoBtnDelete.Name = "icoBtnDelete";
            icoBtnDelete.Size = new Size(150, 120);
            icoBtnDelete.TabIndex = 47;
            icoBtnDelete.Text = "BUTTON";
            icoBtnDelete.TextAlign = ContentAlignment.BottomCenter;
            icoBtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnDelete.UseVisualStyleBackColor = false;
            // 
            // icoBtnSave
            // 
            icoBtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            icoBtnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnSave.BackColor = Color.RoyalBlue;
            icoBtnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnSave.ForeColor = SystemColors.Control;
            icoBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            icoBtnSave.IconColor = Color.White;
            icoBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnSave.IconSize = 60;
            icoBtnSave.Location = new Point(184, 0);
            icoBtnSave.Name = "icoBtnSave";
            icoBtnSave.Size = new Size(150, 120);
            icoBtnSave.TabIndex = 44;
            icoBtnSave.Text = "BUTTON";
            icoBtnSave.TextAlign = ContentAlignment.BottomCenter;
            icoBtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.29762F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.97619F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.72619F));
            tableLayoutPanel1.Controls.Add(materialCardImage, 1, 0);
            tableLayoutPanel1.Controls.Add(materialCard2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.121212F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.878788F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1680, 830);
            tableLayoutPanel1.TabIndex = 60;
            // 
            // panel5
            // 
            tableLayoutPanel1.SetColumnSpan(panel5, 3);
            panel5.Controls.Add(dtgProducts);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(swtActive);
            panel5.Controls.Add(btnSearch);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 438);
            panel5.Name = "panel5";
            panel5.Size = new Size(1674, 389);
            panel5.TabIndex = 57;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom;
            txtSearch.AnimateReadOnly = false;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.HelperText = "Buscar por...";
            txtSearch.HideSelection = true;
            txtSearch.Hint = "Buscar";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(666, 9);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.ReadOnly = false;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(304, 48);
            txtSearch.TabIndex = 58;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(973, 20);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(102, 37);
            swtActive.TabIndex = 59;
            swtActive.Text = "Activo";
            swtActive.UseVisualStyleBackColor = true;
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
            btnSearch.Location = new Point(621, 18);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1680, 73);
            tableLayoutPanel2.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.Controls.Add(picProductTitle);
            panel2.Controls.Add(lblProductTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(507, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 67);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblCurrentUser);
            panel6.Controls.Add(btnLogout);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1179, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(498, 67);
            panel6.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(363, -1);
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
            btnLogout.Location = new Point(363, 28);
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
            // ColumnBrand
            // 
            ColumnBrand.HeaderText = "Marca";
            ColumnBrand.MinimumWidth = 6;
            ColumnBrand.Name = "ColumnBrand";
            ColumnBrand.Resizable = DataGridViewTriState.True;
            ColumnBrand.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Código";
            ColumnCode.MinimumWidth = 6;
            ColumnCode.Name = "ColumnCode";
            ColumnCode.Resizable = DataGridViewTriState.True;
            ColumnCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Resizable = DataGridViewTriState.True;
            ColumnName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStock
            // 
            ColumnStock.HeaderText = "Stock";
            ColumnStock.MinimumWidth = 6;
            ColumnStock.Name = "ColumnStock";
            ColumnStock.Resizable = DataGridViewTriState.True;
            ColumnStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPurchasePrice
            // 
            ColumnPurchasePrice.HeaderText = "P. Compra";
            ColumnPurchasePrice.MinimumWidth = 6;
            ColumnPurchasePrice.Name = "ColumnPurchasePrice";
            ColumnPurchasePrice.Resizable = DataGridViewTriState.True;
            ColumnPurchasePrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSalePrice
            // 
            ColumnSalePrice.HeaderText = "P. Venta";
            ColumnSalePrice.MinimumWidth = 6;
            ColumnSalePrice.Name = "ColumnSalePrice";
            ColumnSalePrice.Resizable = DataGridViewTriState.True;
            ColumnSalePrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnImage
            // 
            ColumnImage.HeaderText = "Imagen";
            ColumnImage.MinimumWidth = 6;
            ColumnImage.Name = "ColumnImage";
            ColumnImage.Resizable = DataGridViewTriState.True;
            ColumnImage.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductView";
            Size = new Size(1680, 930);
            ((System.ComponentModel.ISupportInitialize)dtgProducts).EndInit();
            materialCardImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProductTitle).EndInit();
            materialCard2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2   txtImageURL;
        private MaterialSkin.Controls.MaterialButton     btnSave;
        private MaterialSkin.Controls.MaterialButton     btnClear;
        private MaterialSkin.Controls.MaterialButton     btnDelete;
        private MaterialSkin.Controls.MaterialButton     btnUpdate;
        private MaterialSkin.Controls.MaterialLabel      lblProductTitle;
        private DataGridView                             dtgProducts;
        private MaterialSkin.Controls.MaterialCard       materialCardImage;
        private PictureBox                               picProductImage;
        private FontAwesome.Sharp.IconPictureBox         picProductTitle;
        private MaterialSkin.Controls.MaterialButton     btnImageURL;
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
        private Panel panel4;
        private FontAwesome.Sharp.IconButton icoBtnUpdate;
        private FontAwesome.Sharp.IconButton icoBtnClear;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnSave;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin.Controls.MaterialSwitch swtActive;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
        private FontAwesome.Sharp.IconButton icoBtnReactivate;
        private MaterialSkin.Controls.MaterialButton btnReactivate;
        private DataGridViewTextBoxColumn ColumnBrand;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnPurchasePrice;
        private DataGridViewTextBoxColumn ColumnSalePrice;
        private DataGridViewTextBoxColumn ColumnImage;
    }
}
