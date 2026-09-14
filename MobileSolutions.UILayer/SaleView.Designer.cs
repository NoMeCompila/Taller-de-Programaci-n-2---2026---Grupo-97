using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    partial class SaleView
    {

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            picSaleTitle = new IconPictureBox();
            lblProductTitle = new MaterialLabel();
            tlpMain = new TableLayoutPanel();
            tlpLeft = new TableLayoutPanel();
            pnlHeader = new Panel();
            tlpInputsVenta = new TableLayoutPanel();
            txtSaleNumber = new MaterialTextBox2();
            btnSaleNumber = new MaterialButton();
            cmbPaymentType = new MaterialComboBox();
            btnPaymentType = new MaterialButton();
            txtCustomer = new MaterialTextBox2();
            btnCustomer = new MaterialButton();
            txtSeller = new MaterialTextBox2();
            btnSeller = new MaterialButton();
            dgvCustomerInfo = new DataGridView();
            colDni = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colLocalidad = new DataGridViewTextBoxColumn();
            pnlProducto = new Panel();
            tlpInputsProducto = new TableLayoutPanel();
            btnAddDetail = new MaterialButton();
            txtUnitaryPrice = new MaterialTextBox2();
            btnUnitaryPrice = new MaterialButton();
            txtQuantity = new MaterialTextBox2();
            btnQuantity = new MaterialButton();
            txtProductCode = new MaterialTextBox2();
            btnProductCode = new MaterialButton();
            dgvSaleDetails = new DataGridView();
            colCodigoProducto = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colTotalProducto = new DataGridViewTextBoxColumn();
            pnlResumen = new Panel();
            tlpResumen = new TableLayoutPanel();
            lblResumenTitle = new MaterialLabel();
            lblCantidadItems = new MaterialLabel();
            lblSubtotal = new MaterialLabel();
            lblTotalSale = new MaterialLabel();
            btnTotalSale = new MaterialButton();
            btnInvoice = new MaterialButton();
            btnConfirmSale = new MaterialButton();
            btnCancelSale = new MaterialButton();
            ((ISupportInitialize)picSaleTitle).BeginInit();
            tlpMain.SuspendLayout();
            tlpLeft.SuspendLayout();
            pnlHeader.SuspendLayout();
            tlpInputsVenta.SuspendLayout();
            ((ISupportInitialize)dgvCustomerInfo).BeginInit();
            pnlProducto.SuspendLayout();
            tlpInputsProducto.SuspendLayout();
            ((ISupportInitialize)dgvSaleDetails).BeginInit();
            pnlResumen.SuspendLayout();
            tlpResumen.SuspendLayout();
            SuspendLayout();
            // 
            // picSaleTitle
            // 
            picSaleTitle.BackColor = Color.FromArgb(50, 50, 50);
            picSaleTitle.IconChar = IconChar.None;
            picSaleTitle.IconColor = Color.White;
            picSaleTitle.IconFont = IconFont.Auto;
            picSaleTitle.IconSize = 75;
            picSaleTitle.Location = new Point(579, 3);
            picSaleTitle.Name = "picSaleTitle";
            picSaleTitle.Size = new Size(89, 75);
            picSaleTitle.TabIndex = 0;
            picSaleTitle.TabStop = false;
            // 
            // lblProductTitle
            // 
            lblProductTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProductTitle.AutoSize = true;
            lblProductTitle.Depth = 0;
            lblProductTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblProductTitle.ForeColor = Color.White;
            lblProductTitle.Location = new Point(674, 6);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(125, 58);
            lblProductTitle.TabIndex = 36;
            lblProductTitle.Text = "Venta";
            lblProductTitle.Click += lblProductTitle_Click;
            // 
            // tlpMain
            // 
            tlpMain.BackColor = Color.FromArgb(50, 50, 50);
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tlpMain.Controls.Add(tlpLeft, 0, 0);
            tlpMain.Controls.Add(pnlResumen, 1, 0);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new Point(0, 84);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16, 8, 16, 16);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1680, 846);
            tlpMain.TabIndex = 37;
            // 
            // tlpLeft
            // 
            tlpLeft.BackColor = Color.FromArgb(50, 50, 50);
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(pnlHeader, 0, 0);
            tlpLeft.Controls.Add(pnlProducto, 0, 1);
            tlpLeft.Dock = DockStyle.Fill;
            tlpLeft.Location = new Point(19, 11);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 2;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 62F));
            tlpLeft.Size = new Size(1180, 816);
            tlpLeft.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(50, 50, 50);
            pnlHeader.Controls.Add(tlpInputsVenta);
            pnlHeader.Controls.Add(dgvCustomerInfo);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8, 8, 8, 6);
            pnlHeader.Size = new Size(1174, 304);
            pnlHeader.TabIndex = 0;
            // 
            // tlpInputsVenta
            // 
            tlpInputsVenta.BackColor = Color.FromArgb(50, 50, 50);
            tlpInputsVenta.ColumnCount = 8;
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpInputsVenta.Controls.Add(txtSaleNumber, 5, 0);
            tlpInputsVenta.Controls.Add(btnSaleNumber, 4, 0);
            tlpInputsVenta.Controls.Add(cmbPaymentType, 3, 0);
            tlpInputsVenta.Controls.Add(btnPaymentType, 2, 0);
            tlpInputsVenta.Controls.Add(txtCustomer, 1, 0);
            tlpInputsVenta.Controls.Add(btnCustomer, 0, 0);
            tlpInputsVenta.Controls.Add(txtSeller, 7, 0);
            tlpInputsVenta.Controls.Add(btnSeller, 6, 0);
            tlpInputsVenta.Dock = DockStyle.Top;
            tlpInputsVenta.Location = new Point(8, 8);
            tlpInputsVenta.Name = "tlpInputsVenta";
            tlpInputsVenta.RowCount = 1;
            tlpInputsVenta.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpInputsVenta.Size = new Size(1158, 64);
            tlpInputsVenta.TabIndex = 0;
            // 
            // txtSaleNumber
            // 
            txtSaleNumber.AnimateReadOnly = false;
            txtSaleNumber.BackgroundImageLayout = ImageLayout.None;
            txtSaleNumber.CharacterCasing = CharacterCasing.Normal;
            txtSaleNumber.Depth = 0;
            txtSaleNumber.Dock = DockStyle.Fill;
            txtSaleNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleNumber.HideSelection = true;
            txtSaleNumber.Hint = "Número de Venta";
            txtSaleNumber.LeadingIcon = null;
            txtSaleNumber.Location = new Point(656, 11);
            txtSaleNumber.Margin = new Padding(4, 11, 4, 5);
            txtSaleNumber.MaxLength = 100;
            txtSaleNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtSaleNumber.Name = "txtSaleNumber";
            txtSaleNumber.PasswordChar = '\0';
            txtSaleNumber.PrefixSuffixText = null;
            txtSaleNumber.ReadOnly = true;
            txtSaleNumber.RightToLeft = RightToLeft.No;
            txtSaleNumber.SelectedText = "";
            txtSaleNumber.SelectionLength = 0;
            txtSaleNumber.SelectionStart = 0;
            txtSaleNumber.ShortcutsEnabled = true;
            txtSaleNumber.Size = new Size(219, 48);
            txtSaleNumber.TabIndex = 3;
            txtSaleNumber.TabStop = false;
            txtSaleNumber.TextAlign = HorizontalAlignment.Left;
            txtSaleNumber.TrailingIcon = null;
            txtSaleNumber.UseSystemPasswordChar = false;
            // 
            // btnSaleNumber
            // 
            btnSaleNumber.AutoSize = false;
            btnSaleNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaleNumber.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSaleNumber.Depth = 0;
            btnSaleNumber.Dock = DockStyle.Fill;
            btnSaleNumber.HighEmphasis = true;
            btnSaleNumber.Icon = null;
            btnSaleNumber.Location = new Point(605, 6);
            btnSaleNumber.Margin = new Padding(4, 6, 4, 6);
            btnSaleNumber.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaleNumber.Name = "btnSaleNumber";
            btnSaleNumber.NoAccentTextColor = Color.Empty;
            btnSaleNumber.Size = new Size(43, 52);
            btnSaleNumber.TabIndex = 2;
            btnSaleNumber.Type = MaterialButton.MaterialButtonType.Contained;
            btnSaleNumber.UseAccentColor = false;
            btnSaleNumber.UseVisualStyleBackColor = true;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.AutoResize = false;
            cmbPaymentType.BackColor = Color.White;
            cmbPaymentType.Depth = 0;
            cmbPaymentType.Dock = DockStyle.Fill;
            cmbPaymentType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPaymentType.DropDownHeight = 217;
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.DropDownWidth = 250;
            cmbPaymentType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbPaymentType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPaymentType.Hint = "Tipo de Pago";
            cmbPaymentType.IntegralHeight = false;
            cmbPaymentType.ItemHeight = 43;
            cmbPaymentType.Location = new Point(401, 10);
            cmbPaymentType.Margin = new Padding(4, 10, 4, 5);
            cmbPaymentType.MaxDropDownItems = 5;
            cmbPaymentType.MouseState = MaterialSkin.MouseState.OUT;
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(196, 49);
            cmbPaymentType.StartIndex = 0;
            cmbPaymentType.TabIndex = 1;
            cmbPaymentType.TabStop = false;
            // 
            // btnPaymentType
            // 
            btnPaymentType.AutoSize = false;
            btnPaymentType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentType.Density = MaterialButton.MaterialButtonDensity.Default;
            btnPaymentType.Depth = 0;
            btnPaymentType.Dock = DockStyle.Fill;
            btnPaymentType.HighEmphasis = true;
            btnPaymentType.Icon = null;
            btnPaymentType.Location = new Point(350, 6);
            btnPaymentType.Margin = new Padding(4, 6, 4, 6);
            btnPaymentType.MouseState = MaterialSkin.MouseState.HOVER;
            btnPaymentType.Name = "btnPaymentType";
            btnPaymentType.NoAccentTextColor = Color.Empty;
            btnPaymentType.Size = new Size(43, 52);
            btnPaymentType.TabIndex = 4;
            btnPaymentType.Type = MaterialButton.MaterialButtonType.Contained;
            btnPaymentType.UseAccentColor = false;
            btnPaymentType.UseVisualStyleBackColor = true;
            // 
            // txtCustomer
            // 
            txtCustomer.AnimateReadOnly = false;
            txtCustomer.BackgroundImageLayout = ImageLayout.None;
            txtCustomer.CharacterCasing = CharacterCasing.Normal;
            txtCustomer.Depth = 0;
            txtCustomer.Dock = DockStyle.Fill;
            txtCustomer.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomer.HideSelection = true;
            txtCustomer.Hint = "Cliente (DNI / Email)";
            txtCustomer.LeadingIcon = null;
            txtCustomer.Location = new Point(55, 10);
            txtCustomer.Margin = new Padding(4, 10, 4, 5);
            txtCustomer.MaxLength = 100;
            txtCustomer.MouseState = MaterialSkin.MouseState.OUT;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.PasswordChar = '\0';
            txtCustomer.PrefixSuffixText = null;
            txtCustomer.ReadOnly = false;
            txtCustomer.RightToLeft = RightToLeft.No;
            txtCustomer.SelectedText = "";
            txtCustomer.SelectionLength = 0;
            txtCustomer.SelectionStart = 0;
            txtCustomer.ShortcutsEnabled = true;
            txtCustomer.Size = new Size(287, 48);
            txtCustomer.TabIndex = 0;
            txtCustomer.TabStop = false;
            txtCustomer.TextAlign = HorizontalAlignment.Left;
            txtCustomer.TrailingIcon = null;
            txtCustomer.UseSystemPasswordChar = false;
            // 
            // btnCustomer
            // 
            btnCustomer.AutoSize = false;
            btnCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomer.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCustomer.Depth = 0;
            btnCustomer.Dock = DockStyle.Fill;
            btnCustomer.HighEmphasis = true;
            btnCustomer.Icon = null;
            btnCustomer.Location = new Point(4, 6);
            btnCustomer.Margin = new Padding(4, 6, 4, 6);
            btnCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.NoAccentTextColor = Color.Empty;
            btnCustomer.Size = new Size(43, 52);
            btnCustomer.TabIndex = 5;
            btnCustomer.Type = MaterialButton.MaterialButtonType.Contained;
            btnCustomer.UseAccentColor = false;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // txtSeller
            // 
            txtSeller.AnimateReadOnly = false;
            txtSeller.BackgroundImageLayout = ImageLayout.None;
            txtSeller.CharacterCasing = CharacterCasing.Normal;
            txtSeller.Depth = 0;
            txtSeller.Dock = DockStyle.Fill;
            txtSeller.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSeller.HideSelection = true;
            txtSeller.Hint = "Vendedor";
            txtSeller.LeadingIcon = null;
            txtSeller.Location = new Point(934, 10);
            txtSeller.Margin = new Padding(4, 10, 4, 5);
            txtSeller.MaxLength = 100;
            txtSeller.MouseState = MaterialSkin.MouseState.OUT;
            txtSeller.Name = "txtSeller";
            txtSeller.PasswordChar = '\0';
            txtSeller.PrefixSuffixText = null;
            txtSeller.ReadOnly = true;
            txtSeller.RightToLeft = RightToLeft.No;
            txtSeller.SelectedText = "";
            txtSeller.SelectionLength = 0;
            txtSeller.SelectionStart = 0;
            txtSeller.ShortcutsEnabled = true;
            txtSeller.Size = new Size(220, 48);
            txtSeller.TabIndex = 6;
            txtSeller.TabStop = false;
            txtSeller.TextAlign = HorizontalAlignment.Left;
            txtSeller.TrailingIcon = null;
            txtSeller.UseSystemPasswordChar = false;
            // 
            // btnSeller
            // 
            btnSeller.AutoSize = false;
            btnSeller.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSeller.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSeller.Depth = 0;
            btnSeller.Dock = DockStyle.Fill;
            btnSeller.HighEmphasis = true;
            btnSeller.Icon = null;
            btnSeller.Location = new Point(883, 6);
            btnSeller.Margin = new Padding(4, 6, 4, 6);
            btnSeller.MouseState = MaterialSkin.MouseState.HOVER;
            btnSeller.Name = "btnSeller";
            btnSeller.NoAccentTextColor = Color.Empty;
            btnSeller.Size = new Size(43, 52);
            btnSeller.TabIndex = 7;
            btnSeller.Type = MaterialButton.MaterialButtonType.Contained;
            btnSeller.UseAccentColor = false;
            btnSeller.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerInfo
            // 
            dgvCustomerInfo.AllowUserToAddRows = false;
            dgvCustomerInfo.AllowUserToDeleteRows = false;
            dgvCustomerInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(58, 58, 58);
            dgvCustomerInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvCustomerInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerInfo.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvCustomerInfo.BorderStyle = BorderStyle.None;
            dgvCustomerInfo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvCustomerInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvCustomerInfo.ColumnHeadersHeight = 38;
            dgvCustomerInfo.Columns.AddRange(new DataGridViewColumn[] { colDni, colNombre, colApellido, colEmail, colTelefono, colLocalidad });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvCustomerInfo.DefaultCellStyle = dataGridViewCellStyle9;
            dgvCustomerInfo.Dock = DockStyle.Fill;
            dgvCustomerInfo.EnableHeadersVisualStyles = false;
            dgvCustomerInfo.GridColor = Color.FromArgb(70, 70, 70);
            dgvCustomerInfo.Location = new Point(8, 8);
            dgvCustomerInfo.MultiSelect = false;
            dgvCustomerInfo.Name = "dgvCustomerInfo";
            dgvCustomerInfo.ReadOnly = true;
            dgvCustomerInfo.RowHeadersVisible = false;
            dgvCustomerInfo.RowHeadersWidth = 51;
            dgvCustomerInfo.RowTemplate.Height = 32;
            dgvCustomerInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomerInfo.Size = new Size(1158, 290);
            dgvCustomerInfo.TabIndex = 1;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.MinimumWidth = 6;
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // colLocalidad
            // 
            colLocalidad.HeaderText = "Localidad";
            colLocalidad.MinimumWidth = 6;
            colLocalidad.Name = "colLocalidad";
            colLocalidad.ReadOnly = true;
            // 
            // pnlProducto
            // 
            pnlProducto.BackColor = Color.FromArgb(50, 50, 50);
            pnlProducto.Controls.Add(tlpInputsProducto);
            pnlProducto.Controls.Add(dgvSaleDetails);
            pnlProducto.Dock = DockStyle.Fill;
            pnlProducto.Location = new Point(3, 313);
            pnlProducto.Name = "pnlProducto";
            pnlProducto.Padding = new Padding(8, 8, 8, 6);
            pnlProducto.Size = new Size(1174, 500);
            pnlProducto.TabIndex = 1;
            // 
            // tlpInputsProducto
            // 
            tlpInputsProducto.BackColor = Color.FromArgb(50, 50, 50);
            tlpInputsProducto.ColumnCount = 7;
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInputsProducto.Controls.Add(btnAddDetail, 6, 0);
            tlpInputsProducto.Controls.Add(txtUnitaryPrice, 5, 0);
            tlpInputsProducto.Controls.Add(btnUnitaryPrice, 4, 0);
            tlpInputsProducto.Controls.Add(txtQuantity, 3, 0);
            tlpInputsProducto.Controls.Add(btnQuantity, 2, 0);
            tlpInputsProducto.Controls.Add(txtProductCode, 1, 0);
            tlpInputsProducto.Controls.Add(btnProductCode, 0, 0);
            tlpInputsProducto.Dock = DockStyle.Top;
            tlpInputsProducto.Location = new Point(8, 8);
            tlpInputsProducto.Name = "tlpInputsProducto";
            tlpInputsProducto.RowCount = 1;
            tlpInputsProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpInputsProducto.Size = new Size(1158, 64);
            tlpInputsProducto.TabIndex = 0;
            // 
            // btnAddDetail
            // 
            btnAddDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddDetail.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddDetail.Depth = 0;
            btnAddDetail.Dock = DockStyle.Fill;
            btnAddDetail.HighEmphasis = true;
            btnAddDetail.Icon = null;
            btnAddDetail.Location = new Point(1041, 6);
            btnAddDetail.Margin = new Padding(4, 6, 4, 6);
            btnAddDetail.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.NoAccentTextColor = Color.Empty;
            btnAddDetail.Size = new Size(113, 52);
            btnAddDetail.TabIndex = 4;
            btnAddDetail.Text = "Agregar";
            btnAddDetail.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddDetail.UseAccentColor = false;
            btnAddDetail.UseVisualStyleBackColor = true;
            // 
            // txtUnitaryPrice
            // 
            txtUnitaryPrice.AnimateReadOnly = false;
            txtUnitaryPrice.BackgroundImageLayout = ImageLayout.None;
            txtUnitaryPrice.CharacterCasing = CharacterCasing.Normal;
            txtUnitaryPrice.Depth = 0;
            txtUnitaryPrice.Dock = DockStyle.Fill;
            txtUnitaryPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnitaryPrice.HideSelection = true;
            txtUnitaryPrice.Hint = "Precio Unitario";
            txtUnitaryPrice.LeadingIcon = null;
            txtUnitaryPrice.Location = new Point(839, 10);
            txtUnitaryPrice.Margin = new Padding(4, 10, 4, 5);
            txtUnitaryPrice.MaxLength = 100;
            txtUnitaryPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtUnitaryPrice.Name = "txtUnitaryPrice";
            txtUnitaryPrice.PasswordChar = '\0';
            txtUnitaryPrice.PrefixSuffixText = null;
            txtUnitaryPrice.ReadOnly = false;
            txtUnitaryPrice.RightToLeft = RightToLeft.No;
            txtUnitaryPrice.SelectedText = "";
            txtUnitaryPrice.SelectionLength = 0;
            txtUnitaryPrice.SelectionStart = 0;
            txtUnitaryPrice.ShortcutsEnabled = true;
            txtUnitaryPrice.Size = new Size(194, 48);
            txtUnitaryPrice.TabIndex = 3;
            txtUnitaryPrice.TabStop = false;
            txtUnitaryPrice.TextAlign = HorizontalAlignment.Left;
            txtUnitaryPrice.TrailingIcon = null;
            txtUnitaryPrice.UseSystemPasswordChar = false;
            // 
            // btnUnitaryPrice
            // 
            btnUnitaryPrice.AutoSize = false;
            btnUnitaryPrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUnitaryPrice.Density = MaterialButton.MaterialButtonDensity.Default;
            btnUnitaryPrice.Depth = 0;
            btnUnitaryPrice.Dock = DockStyle.Fill;
            btnUnitaryPrice.HighEmphasis = true;
            btnUnitaryPrice.Icon = null;
            btnUnitaryPrice.Location = new Point(788, 6);
            btnUnitaryPrice.Margin = new Padding(4, 6, 4, 6);
            btnUnitaryPrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnUnitaryPrice.Name = "btnUnitaryPrice";
            btnUnitaryPrice.NoAccentTextColor = Color.Empty;
            btnUnitaryPrice.Size = new Size(43, 52);
            btnUnitaryPrice.TabIndex = 5;
            btnUnitaryPrice.Type = MaterialButton.MaterialButtonType.Contained;
            btnUnitaryPrice.UseAccentColor = false;
            btnUnitaryPrice.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Cantidad";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(659, 15);
            txtQuantity.Margin = new Padding(4, 15, 4, 5);
            txtQuantity.MaxLength = 100;
            txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.ReadOnly = false;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(121, 48);
            txtQuantity.TabIndex = 2;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // btnQuantity
            // 
            btnQuantity.AutoSize = false;
            btnQuantity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuantity.Density = MaterialButton.MaterialButtonDensity.Default;
            btnQuantity.Depth = 0;
            btnQuantity.Dock = DockStyle.Fill;
            btnQuantity.HighEmphasis = true;
            btnQuantity.Icon = null;
            btnQuantity.Location = new Point(608, 6);
            btnQuantity.Margin = new Padding(4, 6, 4, 6);
            btnQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuantity.Name = "btnQuantity";
            btnQuantity.NoAccentTextColor = Color.Empty;
            btnQuantity.Size = new Size(43, 52);
            btnQuantity.TabIndex = 6;
            btnQuantity.Type = MaterialButton.MaterialButtonType.Contained;
            btnQuantity.UseAccentColor = false;
            btnQuantity.UseVisualStyleBackColor = true;
            // 
            // txtProductCode
            // 
            txtProductCode.AnimateReadOnly = false;
            txtProductCode.BackgroundImageLayout = ImageLayout.None;
            txtProductCode.CharacterCasing = CharacterCasing.Normal;
            txtProductCode.Depth = 0;
            txtProductCode.Dock = DockStyle.Fill;
            txtProductCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductCode.HideSelection = true;
            txtProductCode.Hint = "Código de Producto";
            txtProductCode.LeadingIcon = null;
            txtProductCode.Location = new Point(55, 10);
            txtProductCode.Margin = new Padding(4, 10, 4, 5);
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
            txtProductCode.Size = new Size(545, 48);
            txtProductCode.TabIndex = 1;
            txtProductCode.TabStop = false;
            txtProductCode.TextAlign = HorizontalAlignment.Left;
            txtProductCode.TrailingIcon = null;
            txtProductCode.UseSystemPasswordChar = false;
            // 
            // btnProductCode
            // 
            btnProductCode.AutoSize = false;
            btnProductCode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProductCode.Density = MaterialButton.MaterialButtonDensity.Default;
            btnProductCode.Depth = 0;
            btnProductCode.Dock = DockStyle.Fill;
            btnProductCode.HighEmphasis = true;
            btnProductCode.Icon = null;
            btnProductCode.Location = new Point(4, 6);
            btnProductCode.Margin = new Padding(4, 6, 4, 6);
            btnProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            btnProductCode.Name = "btnProductCode";
            btnProductCode.NoAccentTextColor = Color.Empty;
            btnProductCode.Size = new Size(43, 52);
            btnProductCode.TabIndex = 6;
            btnProductCode.Type = MaterialButton.MaterialButtonType.Contained;
            btnProductCode.UseAccentColor = false;
            btnProductCode.UseVisualStyleBackColor = true;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.AllowUserToAddRows = false;
            dgvSaleDetails.AllowUserToDeleteRows = false;
            dgvSaleDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(58, 58, 58);
            dgvSaleDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleDetails.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvSaleDetails.BorderStyle = BorderStyle.None;
            dgvSaleDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvSaleDetails.ColumnHeadersHeight = 38;
            dgvSaleDetails.Columns.AddRange(new DataGridViewColumn[] { colCodigoProducto, colProducto, colCantidad, colPrecioUnitario, colTotalProducto });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvSaleDetails.DefaultCellStyle = dataGridViewCellStyle12;
            dgvSaleDetails.Dock = DockStyle.Fill;
            dgvSaleDetails.EnableHeadersVisualStyles = false;
            dgvSaleDetails.GridColor = Color.FromArgb(70, 70, 70);
            dgvSaleDetails.Location = new Point(8, 8);
            dgvSaleDetails.MultiSelect = false;
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.ReadOnly = true;
            dgvSaleDetails.RowHeadersVisible = false;
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.RowTemplate.Height = 32;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.Size = new Size(1158, 486);
            dgvSaleDetails.TabIndex = 1;
            // 
            // colCodigoProducto
            // 
            colCodigoProducto.FillWeight = 15F;
            colCodigoProducto.HeaderText = "Código";
            colCodigoProducto.MinimumWidth = 6;
            colCodigoProducto.Name = "colCodigoProducto";
            colCodigoProducto.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.FillWeight = 35F;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.FillWeight = 15F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.FillWeight = 20F;
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.MinimumWidth = 6;
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colTotalProducto
            // 
            colTotalProducto.FillWeight = 15F;
            colTotalProducto.HeaderText = "Total";
            colTotalProducto.MinimumWidth = 6;
            colTotalProducto.Name = "colTotalProducto";
            colTotalProducto.ReadOnly = true;
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.FromArgb(45, 45, 45);
            pnlResumen.Controls.Add(tlpResumen);
            pnlResumen.Dock = DockStyle.Fill;
            pnlResumen.Location = new Point(1205, 11);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Padding = new Padding(16, 12, 16, 16);
            pnlResumen.Size = new Size(456, 816);
            pnlResumen.TabIndex = 1;
            // 
            // tlpResumen
            // 
            tlpResumen.BackColor = Color.FromArgb(45, 45, 45);
            tlpResumen.ColumnCount = 1;
            tlpResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpResumen.Controls.Add(lblResumenTitle, 0, 0);
            tlpResumen.Controls.Add(lblCantidadItems, 0, 1);
            tlpResumen.Controls.Add(lblSubtotal, 0, 2);
            tlpResumen.Controls.Add(lblTotalSale, 0, 3);
            tlpResumen.Controls.Add(btnTotalSale, 0, 4);
            tlpResumen.Controls.Add(btnInvoice, 0, 5);
            tlpResumen.Controls.Add(btnConfirmSale, 0, 6);
            tlpResumen.Controls.Add(btnCancelSale, 0, 7);
            tlpResumen.Dock = DockStyle.Fill;
            tlpResumen.Location = new Point(16, 12);
            tlpResumen.Name = "tlpResumen";
            tlpResumen.RowCount = 9;
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpResumen.Size = new Size(424, 788);
            tlpResumen.TabIndex = 0;
            // 
            // lblResumenTitle
            // 
            lblResumenTitle.Depth = 0;
            lblResumenTitle.Dock = DockStyle.Fill;
            lblResumenTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblResumenTitle.ForeColor = Color.FromArgb(178, 235, 242);
            lblResumenTitle.Location = new Point(3, 0);
            lblResumenTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblResumenTitle.Name = "lblResumenTitle";
            lblResumenTitle.Size = new Size(418, 48);
            lblResumenTitle.TabIndex = 0;
            lblResumenTitle.Text = "RESUMEN DE VENTA";
            lblResumenTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidadItems
            // 
            lblCantidadItems.Depth = 0;
            lblCantidadItems.Dock = DockStyle.Fill;
            lblCantidadItems.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCantidadItems.ForeColor = Color.White;
            lblCantidadItems.Location = new Point(3, 48);
            lblCantidadItems.MouseState = MaterialSkin.MouseState.HOVER;
            lblCantidadItems.Name = "lblCantidadItems";
            lblCantidadItems.Size = new Size(418, 28);
            lblCantidadItems.TabIndex = 1;
            lblCantidadItems.Text = "Productos: 0";
            lblCantidadItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Depth = 0;
            lblSubtotal.Dock = DockStyle.Fill;
            lblSubtotal.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(3, 76);
            lblSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(418, 28);
            lblSubtotal.TabIndex = 2;
            lblSubtotal.Text = "Subtotal: $ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSale
            // 
            lblTotalSale.Depth = 0;
            lblTotalSale.Dock = DockStyle.Fill;
            lblTotalSale.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalSale.ForeColor = Color.FromArgb(178, 235, 242);
            lblTotalSale.Location = new Point(3, 104);
            lblTotalSale.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(418, 56);
            lblTotalSale.TabIndex = 3;
            lblTotalSale.Text = "$ 0.00";
            lblTotalSale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTotalSale
            // 
            btnTotalSale.AutoSize = false;
            btnTotalSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTotalSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnTotalSale.Depth = 0;
            btnTotalSale.Dock = DockStyle.Fill;
            btnTotalSale.HighEmphasis = true;
            btnTotalSale.Icon = null;
            btnTotalSale.Location = new Point(4, 164);
            btnTotalSale.Margin = new Padding(4);
            btnTotalSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnTotalSale.Name = "btnTotalSale";
            btnTotalSale.NoAccentTextColor = Color.Empty;
            btnTotalSale.Size = new Size(416, 42);
            btnTotalSale.TabIndex = 4;
            btnTotalSale.Text = "Total de Venta";
            btnTotalSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnTotalSale.UseAccentColor = false;
            btnTotalSale.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            btnInvoice.AutoSize = false;
            btnInvoice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInvoice.Density = MaterialButton.MaterialButtonDensity.Default;
            btnInvoice.Depth = 0;
            btnInvoice.Dock = DockStyle.Fill;
            btnInvoice.HighEmphasis = true;
            btnInvoice.Icon = null;
            btnInvoice.Location = new Point(4, 214);
            btnInvoice.Margin = new Padding(4);
            btnInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            btnInvoice.Name = "btnInvoice";
            btnInvoice.NoAccentTextColor = Color.Empty;
            btnInvoice.Size = new Size(416, 42);
            btnInvoice.TabIndex = 5;
            btnInvoice.Text = "Descargar Factura";
            btnInvoice.Type = MaterialButton.MaterialButtonType.Contained;
            btnInvoice.UseAccentColor = false;
            btnInvoice.UseVisualStyleBackColor = true;
            // 
            // btnConfirmSale
            // 
            btnConfirmSale.AutoSize = false;
            btnConfirmSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnConfirmSale.Depth = 0;
            btnConfirmSale.Dock = DockStyle.Fill;
            btnConfirmSale.HighEmphasis = true;
            btnConfirmSale.Icon = null;
            btnConfirmSale.Location = new Point(4, 264);
            btnConfirmSale.Margin = new Padding(4);
            btnConfirmSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmSale.Name = "btnConfirmSale";
            btnConfirmSale.NoAccentTextColor = Color.Empty;
            btnConfirmSale.Size = new Size(416, 42);
            btnConfirmSale.TabIndex = 6;
            btnConfirmSale.Text = "Confirmar Venta";
            btnConfirmSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnConfirmSale.UseAccentColor = false;
            btnConfirmSale.UseVisualStyleBackColor = true;
            // 
            // btnCancelSale
            // 
            btnCancelSale.AutoSize = false;
            btnCancelSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancelSale.Depth = 0;
            btnCancelSale.Dock = DockStyle.Fill;
            btnCancelSale.HighEmphasis = true;
            btnCancelSale.Icon = null;
            btnCancelSale.Location = new Point(4, 314);
            btnCancelSale.Margin = new Padding(4);
            btnCancelSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.NoAccentTextColor = Color.Empty;
            btnCancelSale.Size = new Size(416, 42);
            btnCancelSale.TabIndex = 7;
            btnCancelSale.Text = "Cancelar Venta";
            btnCancelSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancelSale.UseAccentColor = false;
            btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // SaleView
            // 
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tlpMain);
            Controls.Add(lblProductTitle);
            Controls.Add(picSaleTitle);
            Name = "SaleView";
            Size = new Size(1680, 930);
            ((ISupportInitialize)picSaleTitle).EndInit();
            tlpMain.ResumeLayout(false);
            tlpLeft.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            tlpInputsVenta.ResumeLayout(false);
            ((ISupportInitialize)dgvCustomerInfo).EndInit();
            pnlProducto.ResumeLayout(false);
            tlpInputsProducto.ResumeLayout(false);
            tlpInputsProducto.PerformLayout();
            ((ISupportInitialize)dgvSaleDetails).EndInit();
            pnlResumen.ResumeLayout(false);
            tlpResumen.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        private IconPictureBox picSaleTitle;
        private MaterialLabel lblProductTitle;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpLeft;
        private Panel pnlHeader;
        private TableLayoutPanel tlpInputsVenta;
        private MaterialButton btnCustomer;
        private MaterialTextBox2 txtCustomer;
        private MaterialButton btnPaymentType;
        private MaterialComboBox cmbPaymentType;
        private MaterialButton btnSaleNumber;
        private MaterialTextBox2 txtSaleNumber;
        private MaterialButton btnSeller;
        private MaterialTextBox2 txtSeller;
        private DataGridView dgvCustomerInfo;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colLocalidad;
        private Panel pnlProducto;
        private TableLayoutPanel tlpInputsProducto;
        private MaterialButton btnProductCode;
        private MaterialTextBox2 txtProductCode;
        private MaterialButton btnQuantity;
        private MaterialTextBox2 txtQuantity;
        private MaterialButton btnUnitaryPrice;
        private MaterialTextBox2 txtUnitaryPrice;
        private MaterialButton btnAddDetail;
        private DataGridView dgvSaleDetails;
        private DataGridViewTextBoxColumn colCodigoProducto;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colTotalProducto;
        private Panel pnlResumen;
        private TableLayoutPanel tlpResumen;
        private MaterialLabel lblResumenTitle;
        private MaterialLabel lblCantidadItems;
        private MaterialLabel lblSubtotal;
        private MaterialLabel lblTotalSale;
        private MaterialButton btnTotalSale;
        private MaterialButton btnInvoice;
        private MaterialButton btnConfirmSale;
        private MaterialButton btnCancelSale;
    }
}