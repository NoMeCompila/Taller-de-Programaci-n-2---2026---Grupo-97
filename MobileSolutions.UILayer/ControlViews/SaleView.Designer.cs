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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            picSaleTitle = new IconPictureBox();
            lblProductTitle = new MaterialLabel();
            tlpMain = new TableLayoutPanel();
            tlpLeft = new TableLayoutPanel();
            pnlProducto = new Panel();
            dtgCustomers = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastname = new DataGridViewTextBoxColumn();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            tlpInputsProducto = new TableLayoutPanel();
            txtDni = new MaterialTextBox2();
            txtLastname = new MaterialTextBox2();
            txtName = new MaterialTextBox2();
            txtSearchClient = new MaterialTextBox2();
            btnAddUser = new MaterialButton();
            txtTel = new MaterialTextBox2();
            btnCheckCustomer = new IconButton();
            pnlHeader = new Panel();
            dtgProducts = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnBrand = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColumnStock = new DataGridViewTextBoxColumn();
            ColumnPurchasePrice = new DataGridViewTextBoxColumn();
            ColumnSalePrice = new DataGridViewTextBoxColumn();
            tlpInputsVenta = new TableLayoutPanel();
            btnAddProd = new MaterialButton();
            txtSubTotal = new MaterialTextBox2();
            txtStock = new MaterialTextBox2();
            txtPName = new MaterialTextBox2();
            txtMarca = new MaterialTextBox2();
            txtProducto = new MaterialTextBox2();
            btnProduct = new MaterialButton();
            txtPVenta = new MaterialTextBox2();
            txtQtty = new MaterialTextBox2();
            flpCartHeader = new FlowLayoutPanel();
            picCart = new IconPictureBox();
            lblCart = new MaterialLabel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewButtonColumn();
            pnlResumen = new Panel();
            tlpSummaryBox = new TableLayoutPanel();
            lblSaleNumber = new MaterialLabel();
            lblSaleNumberValue = new MaterialLabel();
            lblToday = new MaterialLabel();
            lblDate = new MaterialLabel();
            lblNomYApe = new MaterialLabel();
            lblNomyApeValue = new MaterialLabel();
            lblUser = new MaterialLabel();
            lblUserValue = new MaterialLabel();
            lblDni = new MaterialLabel();
            lblDniValue = new MaterialLabel();
            btnPrint = new MaterialButton();
            icoBtnPrint = new IconButton();
            btnCancel = new MaterialButton();
            icoBtnCancel = new IconButton();
            btnSell = new MaterialButton();
            icoBtnSell = new IconButton();
            radTrans = new MaterialRadioButton();
            radEfectivo = new MaterialRadioButton();
            lblPayType = new MaterialLabel();
            lblTot = new MaterialLabel();
            lblTotalAmount = new MaterialLabel();
            lblResume = new MaterialLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogout = new MaterialButton();
            lblCurrentUser = new MaterialLabel();
            ((ISupportInitialize)picSaleTitle).BeginInit();
            tlpMain.SuspendLayout();
            tlpLeft.SuspendLayout();
            pnlProducto.SuspendLayout();
            ((ISupportInitialize)dtgCustomers).BeginInit();
            tlpInputsProducto.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((ISupportInitialize)dtgProducts).BeginInit();
            tlpInputsVenta.SuspendLayout();
            flpCartHeader.SuspendLayout();
            ((ISupportInitialize)picCart).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            pnlResumen.SuspendLayout();
            tlpSummaryBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picSaleTitle
            // 
            picSaleTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picSaleTitle.BackColor = Color.FromArgb(50, 50, 50);
            picSaleTitle.IconChar = IconChar.None;
            picSaleTitle.IconColor = Color.White;
            picSaleTitle.IconFont = IconFont.Auto;
            picSaleTitle.IconSize = 55;
            picSaleTitle.Location = new Point(212, 6);
            picSaleTitle.Name = "picSaleTitle";
            picSaleTitle.Size = new Size(70, 55);
            picSaleTitle.TabIndex = 0;
            picSaleTitle.TabStop = false;
            // 
            // lblProductTitle
            // 
            lblProductTitle.Anchor = AnchorStyles.Top;
            lblProductTitle.AutoSize = true;
            lblProductTitle.Depth = 0;
            lblProductTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblProductTitle.ForeColor = Color.White;
            lblProductTitle.Location = new Point(297, 3);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(153, 58);
            lblProductTitle.TabIndex = 36;
            lblProductTitle.Text = "VENTA";
            lblProductTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            tlpMain.Location = new Point(0, 124);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(16, 8, 16, 16);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1680, 806);
            tlpMain.TabIndex = 37;
            // 
            // tlpLeft
            // 
            tlpLeft.BackColor = Color.FromArgb(50, 50, 50);
            tlpLeft.ColumnCount = 1;
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.Controls.Add(pnlProducto, 0, 0);
            tlpLeft.Controls.Add(pnlHeader, 0, 1);
            tlpLeft.Controls.Add(flpCartHeader, 0, 2);
            tlpLeft.Controls.Add(dataGridView1, 0, 3);
            tlpLeft.Location = new Point(19, 11);
            tlpLeft.Name = "tlpLeft";
            tlpLeft.RowCount = 4;
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 42.0107727F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 57.9892273F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 161F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLeft.Size = new Size(1180, 776);
            tlpLeft.TabIndex = 0;
            // 
            // pnlProducto
            // 
            pnlProducto.Anchor = AnchorStyles.Top;
            pnlProducto.BackColor = Color.FromArgb(50, 50, 50);
            pnlProducto.Controls.Add(dtgCustomers);
            pnlProducto.Controls.Add(tlpInputsProducto);
            pnlProducto.Location = new Point(3, 3);
            pnlProducto.Name = "pnlProducto";
            pnlProducto.Padding = new Padding(8, 8, 8, 6);
            pnlProducto.Size = new Size(1174, 211);
            pnlProducto.TabIndex = 1;
            // 
            // dtgCustomers
            // 
            dtgCustomers.AllowUserToOrderColumns = true;
            dtgCustomers.BackgroundColor = Color.MidnightBlue;
            dtgCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastname, ColumnDNI, ColumnPhone });
            dtgCustomers.Dock = DockStyle.Bottom;
            dtgCustomers.GridColor = SystemColors.InactiveCaptionText;
            dtgCustomers.Location = new Point(8, 74);
            dtgCustomers.Margin = new Padding(3, 2, 3, 2);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 51;
            dtgCustomers.Size = new Size(1158, 131);
            dtgCustomers.TabIndex = 34;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Resizable = DataGridViewTriState.True;
            ColumnName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnName.Width = 277;
            // 
            // ColumnLastname
            // 
            ColumnLastname.HeaderText = "Apellido";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            ColumnLastname.Resizable = DataGridViewTriState.True;
            ColumnLastname.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnLastname.Width = 277;
            // 
            // ColumnDNI
            // 
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.MinimumWidth = 6;
            ColumnDNI.Name = "ColumnDNI";
            ColumnDNI.Resizable = DataGridViewTriState.True;
            ColumnDNI.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnDNI.Width = 276;
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Teléfono";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.Resizable = DataGridViewTriState.True;
            ColumnPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnPhone.Width = 277;
            // 
            // tlpInputsProducto
            // 
            tlpInputsProducto.BackColor = Color.FromArgb(50, 50, 50);
            tlpInputsProducto.ColumnCount = 7;
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpInputsProducto.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tlpInputsProducto.Controls.Add(txtDni, 4, 0);
            tlpInputsProducto.Controls.Add(txtLastname, 3, 0);
            tlpInputsProducto.Controls.Add(txtName, 2, 0);
            tlpInputsProducto.Controls.Add(txtSearchClient, 1, 0);
            tlpInputsProducto.Controls.Add(btnAddUser, 0, 0);
            tlpInputsProducto.Controls.Add(txtTel, 5, 0);
            tlpInputsProducto.Controls.Add(btnCheckCustomer, 6, 0);
            tlpInputsProducto.Dock = DockStyle.Top;
            tlpInputsProducto.Location = new Point(8, 8);
            tlpInputsProducto.Name = "tlpInputsProducto";
            tlpInputsProducto.RowCount = 1;
            tlpInputsProducto.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpInputsProducto.Size = new Size(1158, 64);
            tlpInputsProducto.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.AnimateReadOnly = false;
            txtDni.BackgroundImageLayout = ImageLayout.None;
            txtDni.CharacterCasing = CharacterCasing.Normal;
            txtDni.Depth = 0;
            txtDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDni.HideSelection = true;
            txtDni.Hint = "DNI";
            txtDni.LeadingIcon = null;
            txtDni.Location = new Point(699, 10);
            txtDni.Margin = new Padding(4, 10, 4, 5);
            txtDni.MaxLength = 100;
            txtDni.MouseState = MaterialSkin.MouseState.OUT;
            txtDni.Name = "txtDni";
            txtDni.PasswordChar = '\0';
            txtDni.PrefixSuffixText = null;
            txtDni.ReadOnly = true;
            txtDni.RightToLeft = RightToLeft.No;
            txtDni.SelectedText = "";
            txtDni.SelectionLength = 0;
            txtDni.SelectionStart = 0;
            txtDni.ShortcutsEnabled = true;
            txtDni.Size = new Size(182, 48);
            txtDni.TabIndex = 10;
            txtDni.TabStop = false;
            txtDni.TextAlign = HorizontalAlignment.Left;
            txtDni.TrailingIcon = null;
            txtDni.UseSystemPasswordChar = false;
            // 
            // txtLastname
            // 
            txtLastname.AnimateReadOnly = false;
            txtLastname.BackgroundImageLayout = ImageLayout.None;
            txtLastname.CharacterCasing = CharacterCasing.Normal;
            txtLastname.Depth = 0;
            txtLastname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastname.HideSelection = true;
            txtLastname.Hint = "Apellido";
            txtLastname.LeadingIcon = null;
            txtLastname.Location = new Point(501, 10);
            txtLastname.Margin = new Padding(4, 10, 4, 5);
            txtLastname.MaxLength = 100;
            txtLastname.MouseState = MaterialSkin.MouseState.OUT;
            txtLastname.Name = "txtLastname";
            txtLastname.PasswordChar = '\0';
            txtLastname.PrefixSuffixText = null;
            txtLastname.ReadOnly = true;
            txtLastname.RightToLeft = RightToLeft.No;
            txtLastname.SelectedText = "";
            txtLastname.SelectionLength = 0;
            txtLastname.SelectionStart = 0;
            txtLastname.ShortcutsEnabled = true;
            txtLastname.Size = new Size(189, 48);
            txtLastname.TabIndex = 9;
            txtLastname.TabStop = false;
            txtLastname.TextAlign = HorizontalAlignment.Left;
            txtLastname.TrailingIcon = null;
            txtLastname.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(310, 10);
            txtName.Margin = new Padding(4, 10, 4, 5);
            txtName.MaxLength = 100;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = true;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(183, 48);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtSearchClient
            // 
            txtSearchClient.AnimateReadOnly = false;
            txtSearchClient.BackgroundImageLayout = ImageLayout.None;
            txtSearchClient.CharacterCasing = CharacterCasing.Normal;
            txtSearchClient.Depth = 0;
            txtSearchClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearchClient.HideSelection = true;
            txtSearchClient.Hint = "Buscar Cliente";
            txtSearchClient.LeadingIcon = null;
            txtSearchClient.Location = new Point(55, 10);
            txtSearchClient.Margin = new Padding(4, 10, 4, 5);
            txtSearchClient.MaxLength = 100;
            txtSearchClient.MouseState = MaterialSkin.MouseState.OUT;
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.PasswordChar = '\0';
            txtSearchClient.PrefixSuffixText = null;
            txtSearchClient.ReadOnly = false;
            txtSearchClient.RightToLeft = RightToLeft.No;
            txtSearchClient.SelectedText = "";
            txtSearchClient.SelectionLength = 0;
            txtSearchClient.SelectionStart = 0;
            txtSearchClient.ShortcutsEnabled = true;
            txtSearchClient.Size = new Size(230, 48);
            txtSearchClient.TabIndex = 1;
            txtSearchClient.TabStop = false;
            txtSearchClient.TextAlign = HorizontalAlignment.Left;
            txtSearchClient.TrailingIcon = null;
            txtSearchClient.UseSystemPasswordChar = false;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSize = false;
            btnAddUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddUser.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddUser.Depth = 0;
            btnAddUser.Dock = DockStyle.Fill;
            btnAddUser.HighEmphasis = true;
            btnAddUser.Icon = null;
            btnAddUser.Location = new Point(4, 6);
            btnAddUser.Margin = new Padding(4, 6, 4, 6);
            btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.NoAccentTextColor = Color.Empty;
            btnAddUser.Size = new Size(43, 52);
            btnAddUser.TabIndex = 6;
            btnAddUser.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddUser.UseAccentColor = false;
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            txtTel.AnimateReadOnly = false;
            txtTel.BackgroundImageLayout = ImageLayout.None;
            txtTel.CharacterCasing = CharacterCasing.Normal;
            txtTel.Depth = 0;
            txtTel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTel.HideSelection = true;
            txtTel.Hint = "Teléfono";
            txtTel.LeadingIcon = null;
            txtTel.Location = new Point(891, 10);
            txtTel.Margin = new Padding(4, 10, 4, 5);
            txtTel.MaxLength = 100;
            txtTel.MouseState = MaterialSkin.MouseState.OUT;
            txtTel.Name = "txtTel";
            txtTel.PasswordChar = '\0';
            txtTel.PrefixSuffixText = null;
            txtTel.ReadOnly = true;
            txtTel.RightToLeft = RightToLeft.No;
            txtTel.SelectedText = "";
            txtTel.SelectionLength = 0;
            txtTel.SelectionStart = 0;
            txtTel.ShortcutsEnabled = true;
            txtTel.Size = new Size(189, 48);
            txtTel.TabIndex = 11;
            txtTel.TabStop = false;
            txtTel.TextAlign = HorizontalAlignment.Left;
            txtTel.TrailingIcon = null;
            txtTel.UseSystemPasswordChar = false;
            // 
            // btnCheckCustomer
            // 
            btnCheckCustomer.BackColor = Color.FromArgb(13, 71, 161);
            btnCheckCustomer.Dock = DockStyle.Fill;
            btnCheckCustomer.FlatAppearance.BorderSize = 0;
            btnCheckCustomer.FlatStyle = FlatStyle.Flat;
            btnCheckCustomer.ForeColor = Color.White;
            btnCheckCustomer.IconChar = IconChar.Check;
            btnCheckCustomer.IconColor = Color.White;
            btnCheckCustomer.IconFont = IconFont.Auto;
            btnCheckCustomer.IconSize = 28;
            btnCheckCustomer.Location = new Point(1111, 6);
            btnCheckCustomer.Margin = new Padding(4, 6, 4, 6);
            btnCheckCustomer.Name = "btnCheckCustomer";
            btnCheckCustomer.Size = new Size(43, 52);
            btnCheckCustomer.TabIndex = 12;
            btnCheckCustomer.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top;
            pnlHeader.BackColor = Color.FromArgb(50, 50, 50);
            pnlHeader.Controls.Add(dtgProducts);
            pnlHeader.Controls.Add(tlpInputsVenta);
            pnlHeader.Location = new Point(3, 237);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8, 8, 8, 6);
            pnlHeader.Size = new Size(1174, 298);
            pnlHeader.TabIndex = 0;
            // 
            // dtgProducts
            // 
            dtgProducts.AllowUserToOrderColumns = true;
            dtgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProducts.BackgroundColor = Color.MidnightBlue;
            dtgProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProducts.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnBrand, dataGridViewTextBoxColumn1, ColumnStock, ColumnPurchasePrice, ColumnSalePrice });
            dtgProducts.Dock = DockStyle.Bottom;
            dtgProducts.GridColor = SystemColors.InactiveCaptionText;
            dtgProducts.Location = new Point(8, 79);
            dtgProducts.Margin = new Padding(3, 2, 3, 2);
            dtgProducts.Name = "dtgProducts";
            dtgProducts.RowHeadersWidth = 51;
            dtgProducts.Size = new Size(1158, 213);
            dtgProducts.TabIndex = 34;
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Código";
            ColumnCode.MinimumWidth = 6;
            ColumnCode.Name = "ColumnCode";
            ColumnCode.Resizable = DataGridViewTriState.True;
            ColumnCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnBrand
            // 
            ColumnBrand.HeaderText = "Marca";
            ColumnBrand.MinimumWidth = 6;
            ColumnBrand.Name = "ColumnBrand";
            ColumnBrand.Resizable = DataGridViewTriState.True;
            ColumnBrand.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // tlpInputsVenta
            // 
            tlpInputsVenta.BackColor = Color.FromArgb(50, 50, 50);
            tlpInputsVenta.ColumnCount = 9;
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tlpInputsVenta.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpInputsVenta.Controls.Add(btnAddProd, 8, 0);
            tlpInputsVenta.Controls.Add(txtSubTotal, 7, 0);
            tlpInputsVenta.Controls.Add(txtStock, 4, 0);
            tlpInputsVenta.Controls.Add(txtPName, 3, 0);
            tlpInputsVenta.Controls.Add(txtMarca, 2, 0);
            tlpInputsVenta.Controls.Add(txtProducto, 1, 0);
            tlpInputsVenta.Controls.Add(btnProduct, 0, 0);
            tlpInputsVenta.Controls.Add(txtPVenta, 5, 0);
            tlpInputsVenta.Controls.Add(txtQtty, 6, 0);
            tlpInputsVenta.Dock = DockStyle.Top;
            tlpInputsVenta.Location = new Point(8, 8);
            tlpInputsVenta.Name = "tlpInputsVenta";
            tlpInputsVenta.RowCount = 1;
            tlpInputsVenta.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tlpInputsVenta.Size = new Size(1158, 54);
            tlpInputsVenta.TabIndex = 0;
            // 
            // btnAddProd
            // 
            btnAddProd.AutoSize = false;
            btnAddProd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddProd.Density = MaterialButton.MaterialButtonDensity.Dense;
            btnAddProd.Depth = 0;
            btnAddProd.Dock = DockStyle.Fill;
            btnAddProd.HighEmphasis = true;
            btnAddProd.Icon = null;
            btnAddProd.Location = new Point(1039, 4);
            btnAddProd.Margin = new Padding(3, 4, 3, 4);
            btnAddProd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddProd.Name = "btnAddProd";
            btnAddProd.NoAccentTextColor = Color.Empty;
            btnAddProd.Size = new Size(116, 46);
            btnAddProd.TabIndex = 15;
            btnAddProd.Text = "agregar";
            btnAddProd.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddProd.UseAccentColor = false;
            btnAddProd.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.AnimateReadOnly = true;
            txtSubTotal.BackgroundImageLayout = ImageLayout.None;
            txtSubTotal.CharacterCasing = CharacterCasing.Normal;
            txtSubTotal.Depth = 0;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSubTotal.HideSelection = true;
            txtSubTotal.Hint = "SubTot";
            txtSubTotal.LeadingIcon = null;
            txtSubTotal.Location = new Point(871, 4);
            txtSubTotal.Margin = new Padding(3, 4, 3, 3);
            txtSubTotal.MaxLength = 100;
            txtSubTotal.MouseState = MaterialSkin.MouseState.OUT;
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PasswordChar = '\0';
            txtSubTotal.PrefixSuffixText = null;
            txtSubTotal.ReadOnly = true;
            txtSubTotal.RightToLeft = RightToLeft.No;
            txtSubTotal.SelectedText = "";
            txtSubTotal.SelectionLength = 0;
            txtSubTotal.SelectionStart = 0;
            txtSubTotal.ShortcutsEnabled = true;
            txtSubTotal.Size = new Size(130, 48);
            txtSubTotal.TabIndex = 14;
            txtSubTotal.TabStop = false;
            txtSubTotal.TextAlign = HorizontalAlignment.Left;
            txtSubTotal.TrailingIcon = null;
            txtSubTotal.UseSystemPasswordChar = false;
            // 
            // txtStock
            // 
            txtStock.AnimateReadOnly = false;
            txtStock.BackgroundImageLayout = ImageLayout.None;
            txtStock.CharacterCasing = CharacterCasing.Normal;
            txtStock.Depth = 0;
            txtStock.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStock.HideSelection = true;
            txtStock.Hint = "Stock";
            txtStock.LeadingIcon = null;
            txtStock.Location = new Point(518, 4);
            txtStock.Margin = new Padding(3, 4, 3, 3);
            txtStock.MaxLength = 100;
            txtStock.MouseState = MaterialSkin.MouseState.OUT;
            txtStock.Name = "txtStock";
            txtStock.PasswordChar = '\0';
            txtStock.PrefixSuffixText = null;
            txtStock.ReadOnly = true;
            txtStock.RightToLeft = RightToLeft.No;
            txtStock.SelectedText = "";
            txtStock.SelectionLength = 0;
            txtStock.SelectionStart = 0;
            txtStock.ShortcutsEnabled = true;
            txtStock.Size = new Size(74, 48);
            txtStock.TabIndex = 11;
            txtStock.TabStop = false;
            txtStock.TextAlign = HorizontalAlignment.Left;
            txtStock.TrailingIcon = null;
            txtStock.UseSystemPasswordChar = false;
            // 
            // txtPName
            // 
            txtPName.AnimateReadOnly = false;
            txtPName.BackgroundImageLayout = ImageLayout.None;
            txtPName.CharacterCasing = CharacterCasing.Normal;
            txtPName.Depth = 0;
            txtPName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPName.HideSelection = true;
            txtPName.Hint = "Nombre";
            txtPName.LeadingIcon = null;
            txtPName.Location = new Point(366, 4);
            txtPName.Margin = new Padding(3, 4, 3, 3);
            txtPName.MaxLength = 100;
            txtPName.MouseState = MaterialSkin.MouseState.OUT;
            txtPName.Name = "txtPName";
            txtPName.PasswordChar = '\0';
            txtPName.PrefixSuffixText = null;
            txtPName.ReadOnly = true;
            txtPName.RightToLeft = RightToLeft.No;
            txtPName.SelectedText = "";
            txtPName.SelectionLength = 0;
            txtPName.SelectionStart = 0;
            txtPName.ShortcutsEnabled = true;
            txtPName.Size = new Size(128, 48);
            txtPName.TabIndex = 10;
            txtPName.TabStop = false;
            txtPName.TextAlign = HorizontalAlignment.Left;
            txtPName.TrailingIcon = null;
            txtPName.UseSystemPasswordChar = false;
            // 
            // txtMarca
            // 
            txtMarca.AnimateReadOnly = false;
            txtMarca.BackgroundImageLayout = ImageLayout.None;
            txtMarca.CharacterCasing = CharacterCasing.Normal;
            txtMarca.Depth = 0;
            txtMarca.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMarca.HideSelection = true;
            txtMarca.Hint = "Marca";
            txtMarca.LeadingIcon = null;
            txtMarca.Location = new Point(261, 4);
            txtMarca.Margin = new Padding(3, 4, 3, 3);
            txtMarca.MaxLength = 100;
            txtMarca.MouseState = MaterialSkin.MouseState.OUT;
            txtMarca.Name = "txtMarca";
            txtMarca.PasswordChar = '\0';
            txtMarca.PrefixSuffixText = null;
            txtMarca.ReadOnly = true;
            txtMarca.RightToLeft = RightToLeft.No;
            txtMarca.SelectedText = "";
            txtMarca.SelectionLength = 0;
            txtMarca.SelectionStart = 0;
            txtMarca.ShortcutsEnabled = true;
            txtMarca.Size = new Size(99, 48);
            txtMarca.TabIndex = 9;
            txtMarca.TabStop = false;
            txtMarca.TextAlign = HorizontalAlignment.Left;
            txtMarca.TrailingIcon = null;
            txtMarca.UseSystemPasswordChar = false;
            // 
            // txtProducto
            // 
            txtProducto.AnimateReadOnly = false;
            txtProducto.BackgroundImageLayout = ImageLayout.None;
            txtProducto.CharacterCasing = CharacterCasing.Normal;
            txtProducto.Depth = 0;
            txtProducto.Dock = DockStyle.Fill;
            txtProducto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProducto.HideSelection = true;
            txtProducto.Hint = "Buscar Producto";
            txtProducto.LeadingIcon = null;
            txtProducto.Location = new Point(48, 4);
            txtProducto.Margin = new Padding(3, 4, 3, 3);
            txtProducto.MaxLength = 100;
            txtProducto.MouseState = MaterialSkin.MouseState.OUT;
            txtProducto.Name = "txtProducto";
            txtProducto.PasswordChar = '\0';
            txtProducto.PrefixSuffixText = null;
            txtProducto.ReadOnly = false;
            txtProducto.RightToLeft = RightToLeft.No;
            txtProducto.SelectedText = "";
            txtProducto.SelectionLength = 0;
            txtProducto.SelectionStart = 0;
            txtProducto.ShortcutsEnabled = true;
            txtProducto.Size = new Size(207, 48);
            txtProducto.TabIndex = 0;
            txtProducto.TabStop = false;
            txtProducto.TextAlign = HorizontalAlignment.Left;
            txtProducto.TrailingIcon = null;
            txtProducto.UseSystemPasswordChar = false;
            // 
            // btnProduct
            // 
            btnProduct.AutoSize = false;
            btnProduct.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProduct.Density = MaterialButton.MaterialButtonDensity.Dense;
            btnProduct.Depth = 0;
            btnProduct.Dock = DockStyle.Fill;
            btnProduct.HighEmphasis = true;
            btnProduct.Icon = null;
            btnProduct.Location = new Point(3, 4);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.MouseState = MaterialSkin.MouseState.HOVER;
            btnProduct.Name = "btnProduct";
            btnProduct.NoAccentTextColor = Color.Empty;
            btnProduct.Size = new Size(39, 46);
            btnProduct.TabIndex = 5;
            btnProduct.Type = MaterialButton.MaterialButtonType.Contained;
            btnProduct.UseAccentColor = false;
            btnProduct.UseVisualStyleBackColor = true;
            // 
            // txtPVenta
            // 
            txtPVenta.AnimateReadOnly = false;
            txtPVenta.BackgroundImageLayout = ImageLayout.None;
            txtPVenta.CharacterCasing = CharacterCasing.Normal;
            txtPVenta.Depth = 0;
            txtPVenta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPVenta.HideSelection = true;
            txtPVenta.Hint = "Precio";
            txtPVenta.LeadingIcon = null;
            txtPVenta.Location = new Point(598, 4);
            txtPVenta.Margin = new Padding(3, 4, 3, 3);
            txtPVenta.MaxLength = 100;
            txtPVenta.MouseState = MaterialSkin.MouseState.OUT;
            txtPVenta.Name = "txtPVenta";
            txtPVenta.PasswordChar = '\0';
            txtPVenta.PrefixSuffixText = null;
            txtPVenta.ReadOnly = true;
            txtPVenta.RightToLeft = RightToLeft.No;
            txtPVenta.SelectedText = "";
            txtPVenta.SelectionLength = 0;
            txtPVenta.SelectionStart = 0;
            txtPVenta.ShortcutsEnabled = true;
            txtPVenta.Size = new Size(130, 48);
            txtPVenta.TabIndex = 12;
            txtPVenta.TabStop = false;
            txtPVenta.TextAlign = HorizontalAlignment.Left;
            txtPVenta.TrailingIcon = null;
            txtPVenta.UseSystemPasswordChar = false;
            // 
            // txtQtty
            // 
            txtQtty.AnimateReadOnly = true;
            txtQtty.BackgroundImageLayout = ImageLayout.None;
            txtQtty.CharacterCasing = CharacterCasing.Normal;
            txtQtty.Depth = 0;
            txtQtty.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQtty.HideSelection = true;
            txtQtty.Hint = "Cant.";
            txtQtty.LeadingIcon = null;
            txtQtty.Location = new Point(766, 4);
            txtQtty.Margin = new Padding(3, 4, 3, 3);
            txtQtty.MaxLength = 100;
            txtQtty.MouseState = MaterialSkin.MouseState.OUT;
            txtQtty.Name = "txtQtty";
            txtQtty.PasswordChar = '\0';
            txtQtty.PrefixSuffixText = null;
            txtQtty.ReadOnly = false;
            txtQtty.RightToLeft = RightToLeft.No;
            txtQtty.SelectedText = "";
            txtQtty.SelectionLength = 0;
            txtQtty.SelectionStart = 0;
            txtQtty.ShortcutsEnabled = true;
            txtQtty.Size = new Size(99, 48);
            txtQtty.TabIndex = 13;
            txtQtty.TabStop = false;
            txtQtty.TextAlign = HorizontalAlignment.Left;
            txtQtty.TrailingIcon = null;
            txtQtty.UseSystemPasswordChar = false;
            // 
            // flpCartHeader
            // 
            flpCartHeader.Anchor = AnchorStyles.None;
            flpCartHeader.AutoSize = true;
            flpCartHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpCartHeader.Controls.Add(picCart);
            flpCartHeader.Controls.Add(lblCart);
            flpCartHeader.Location = new Point(497, 564);
            flpCartHeader.Margin = new Padding(0);
            flpCartHeader.Name = "flpCartHeader";
            flpCartHeader.Size = new Size(186, 43);
            flpCartHeader.TabIndex = 2;
            flpCartHeader.WrapContents = false;
            // 
            // picCart
            // 
            picCart.BackColor = Color.FromArgb(50, 50, 50);
            picCart.IconChar = IconChar.CartShopping;
            picCart.IconColor = Color.White;
            picCart.IconFont = IconFont.Auto;
            picCart.IconSize = 36;
            picCart.Location = new Point(3, 4);
            picCart.Margin = new Padding(3, 4, 8, 3);
            picCart.Name = "picCart";
            picCart.Size = new Size(36, 36);
            picCart.TabIndex = 0;
            picCart.TabStop = false;
            // 
            // lblCart
            // 
            lblCart.Anchor = AnchorStyles.Left;
            lblCart.AutoSize = true;
            lblCart.Depth = 0;
            lblCart.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCart.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblCart.Location = new Point(47, 1);
            lblCart.Margin = new Padding(0);
            lblCart.MouseState = MaterialSkin.MouseState.HOVER;
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(139, 41);
            lblCart.TabIndex = 1;
            lblCart.Text = "CARRITO";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7, SubTotal, Remove });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(3, 616);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1174, 158);
            dataGridView1.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Código";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Marca";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "P. Venta";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            // 
            // Remove
            // 
            Remove.HeaderText = "Eliminar";
            Remove.Name = "Remove";
            Remove.Resizable = DataGridViewTriState.True;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            Remove.Text = "Eliminar";
            // 
            // pnlResumen
            // 
            pnlResumen.BackColor = Color.FromArgb(45, 45, 45);
            pnlResumen.Controls.Add(tlpSummaryBox);
            pnlResumen.Controls.Add(btnPrint);
            pnlResumen.Controls.Add(icoBtnPrint);
            pnlResumen.Controls.Add(btnCancel);
            pnlResumen.Controls.Add(icoBtnCancel);
            pnlResumen.Controls.Add(btnSell);
            pnlResumen.Controls.Add(icoBtnSell);
            pnlResumen.Controls.Add(radTrans);
            pnlResumen.Controls.Add(radEfectivo);
            pnlResumen.Controls.Add(lblPayType);
            pnlResumen.Controls.Add(lblTot);
            pnlResumen.Controls.Add(lblTotalAmount);
            pnlResumen.Controls.Add(lblResume);
            pnlResumen.Dock = DockStyle.Fill;
            pnlResumen.Location = new Point(1205, 11);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Padding = new Padding(16, 12, 16, 16);
            pnlResumen.Size = new Size(456, 776);
            pnlResumen.TabIndex = 1;
            // 
            // tlpSummaryBox
            // 
            tlpSummaryBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpSummaryBox.BackColor = Color.FromArgb(40, 40, 40);
            tlpSummaryBox.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpSummaryBox.ColumnCount = 2;
            tlpSummaryBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpSummaryBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpSummaryBox.Controls.Add(lblSaleNumber, 0, 0);
            tlpSummaryBox.Controls.Add(lblSaleNumberValue, 1, 0);
            tlpSummaryBox.Controls.Add(lblToday, 0, 1);
            tlpSummaryBox.Controls.Add(lblDate, 1, 1);
            tlpSummaryBox.Controls.Add(lblNomYApe, 0, 2);
            tlpSummaryBox.Controls.Add(lblNomyApeValue, 1, 2);
            tlpSummaryBox.Controls.Add(lblUser, 0, 3);
            tlpSummaryBox.Controls.Add(lblUserValue, 1, 3);
            tlpSummaryBox.Controls.Add(lblDni, 0, 4);
            tlpSummaryBox.Controls.Add(lblDniValue, 1, 4);
            tlpSummaryBox.Location = new Point(18, 52);
            tlpSummaryBox.Name = "tlpSummaryBox";
            tlpSummaryBox.RowCount = 5;
            tlpSummaryBox.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpSummaryBox.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpSummaryBox.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpSummaryBox.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpSummaryBox.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpSummaryBox.Size = new Size(420, 225);
            tlpSummaryBox.TabIndex = 2;
            // 
            // lblSaleNumber
            // 
            lblSaleNumber.Depth = 0;
            lblSaleNumber.Dock = DockStyle.Fill;
            lblSaleNumber.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSaleNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblSaleNumber.Location = new Point(9, 1);
            lblSaleNumber.Margin = new Padding(8, 0, 3, 0);
            lblSaleNumber.MouseState = MaterialSkin.MouseState.HOVER;
            lblSaleNumber.Name = "lblSaleNumber";
            lblSaleNumber.Size = new Size(147, 43);
            lblSaleNumber.TabIndex = 61;
            lblSaleNumber.Text = "N° Venta";
            lblSaleNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSaleNumberValue
            // 
            lblSaleNumberValue.AutoEllipsis = true;
            lblSaleNumberValue.Depth = 0;
            lblSaleNumberValue.Dock = DockStyle.Fill;
            lblSaleNumberValue.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSaleNumberValue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblSaleNumberValue.Location = new Point(168, 1);
            lblSaleNumberValue.Margin = new Padding(8, 0, 3, 0);
            lblSaleNumberValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblSaleNumberValue.Name = "lblSaleNumberValue";
            lblSaleNumberValue.Size = new Size(248, 43);
            lblSaleNumberValue.TabIndex = 62;
            lblSaleNumberValue.Text = "-";
            lblSaleNumberValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblToday
            // 
            lblToday.Depth = 0;
            lblToday.Dock = DockStyle.Fill;
            lblToday.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblToday.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblToday.Location = new Point(9, 45);
            lblToday.Margin = new Padding(8, 0, 3, 0);
            lblToday.MouseState = MaterialSkin.MouseState.HOVER;
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(147, 43);
            lblToday.TabIndex = 54;
            lblToday.Text = "Fecha";
            lblToday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.AutoEllipsis = true;
            lblDate.Depth = 0;
            lblDate.Dock = DockStyle.Fill;
            lblDate.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblDate.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblDate.Location = new Point(168, 45);
            lblDate.Margin = new Padding(8, 0, 3, 0);
            lblDate.MouseState = MaterialSkin.MouseState.HOVER;
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(248, 43);
            lblDate.TabIndex = 53;
            lblDate.Text = "00/00/00";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomYApe
            // 
            lblNomYApe.Depth = 0;
            lblNomYApe.Dock = DockStyle.Fill;
            lblNomYApe.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblNomYApe.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblNomYApe.Location = new Point(9, 89);
            lblNomYApe.Margin = new Padding(8, 0, 3, 0);
            lblNomYApe.MouseState = MaterialSkin.MouseState.HOVER;
            lblNomYApe.Name = "lblNomYApe";
            lblNomYApe.Size = new Size(147, 43);
            lblNomYApe.TabIndex = 55;
            lblNomYApe.Text = "Vendedor";
            lblNomYApe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNomyApeValue
            // 
            lblNomyApeValue.AutoEllipsis = true;
            lblNomyApeValue.Depth = 0;
            lblNomyApeValue.Dock = DockStyle.Fill;
            lblNomyApeValue.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblNomyApeValue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblNomyApeValue.Location = new Point(168, 89);
            lblNomyApeValue.Margin = new Padding(8, 0, 3, 0);
            lblNomyApeValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblNomyApeValue.Name = "lblNomyApeValue";
            lblNomyApeValue.Size = new Size(248, 43);
            lblNomyApeValue.TabIndex = 56;
            lblNomyApeValue.Text = "Name Lastname";
            lblNomyApeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            lblUser.Depth = 0;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblUser.Location = new Point(9, 133);
            lblUser.Margin = new Padding(8, 0, 3, 0);
            lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(147, 43);
            lblUser.TabIndex = 57;
            lblUser.Text = "Usuario";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserValue
            // 
            lblUserValue.AutoEllipsis = true;
            lblUserValue.Depth = 0;
            lblUserValue.Dock = DockStyle.Fill;
            lblUserValue.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblUserValue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblUserValue.Location = new Point(168, 133);
            lblUserValue.Margin = new Padding(8, 0, 3, 0);
            lblUserValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserValue.Name = "lblUserValue";
            lblUserValue.Size = new Size(248, 43);
            lblUserValue.TabIndex = 58;
            lblUserValue.Text = "User";
            lblUserValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDni
            // 
            lblDni.Depth = 0;
            lblDni.Dock = DockStyle.Fill;
            lblDni.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblDni.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblDni.Location = new Point(9, 177);
            lblDni.Margin = new Padding(8, 0, 3, 0);
            lblDni.MouseState = MaterialSkin.MouseState.HOVER;
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(147, 47);
            lblDni.TabIndex = 59;
            lblDni.Text = "DNI";
            lblDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDniValue
            // 
            lblDniValue.AutoEllipsis = true;
            lblDniValue.Depth = 0;
            lblDniValue.Dock = DockStyle.Fill;
            lblDniValue.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblDniValue.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            lblDniValue.Location = new Point(168, 177);
            lblDniValue.Margin = new Padding(8, 0, 3, 0);
            lblDniValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblDniValue.Name = "lblDniValue";
            lblDniValue.Size = new Size(248, 47);
            lblDniValue.TabIndex = 60;
            lblDniValue.Text = "00000000";
            lblDniValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.None;
            btnPrint.AutoSize = false;
            btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrint.Density = MaterialButton.MaterialButtonDensity.Default;
            btnPrint.Depth = 0;
            btnPrint.HighEmphasis = true;
            btnPrint.Icon = null;
            btnPrint.Location = new Point(156, 724);
            btnPrint.Margin = new Padding(4);
            btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrint.Name = "btnPrint";
            btnPrint.NoAccentTextColor = Color.Empty;
            btnPrint.Size = new Size(126, 33);
            btnPrint.TabIndex = 51;
            btnPrint.Text = "Imprimir Ticket";
            btnPrint.Type = MaterialButton.MaterialButtonType.Contained;
            btnPrint.UseAccentColor = false;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // icoBtnPrint
            // 
            icoBtnPrint.Anchor = AnchorStyles.None;
            icoBtnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnPrint.BackColor = Color.RoyalBlue;
            icoBtnPrint.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnPrint.ForeColor = SystemColors.Control;
            icoBtnPrint.IconChar = IconChar.FilePdf;
            icoBtnPrint.IconColor = Color.White;
            icoBtnPrint.IconFont = IconFont.Auto;
            icoBtnPrint.IconSize = 60;
            icoBtnPrint.Location = new Point(146, 646);
            icoBtnPrint.Name = "icoBtnPrint";
            icoBtnPrint.Size = new Size(150, 120);
            icoBtnPrint.TabIndex = 52;
            icoBtnPrint.Text = "BUTTON";
            icoBtnPrint.TextAlign = ContentAlignment.BottomCenter;
            icoBtnPrint.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnPrint.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(257, 580);
            btnCancel.Margin = new Padding(4);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(126, 33);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancelar Venta";
            btnCancel.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = false;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // icoBtnCancel
            // 
            icoBtnCancel.Anchor = AnchorStyles.None;
            icoBtnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnCancel.BackColor = Color.RoyalBlue;
            icoBtnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnCancel.ForeColor = SystemColors.Control;
            icoBtnCancel.IconChar = IconChar.CreativeCommonsNc;
            icoBtnCancel.IconColor = Color.White;
            icoBtnCancel.IconFont = IconFont.Auto;
            icoBtnCancel.IconSize = 60;
            icoBtnCancel.Location = new Point(244, 502);
            icoBtnCancel.Name = "icoBtnCancel";
            icoBtnCancel.Size = new Size(150, 120);
            icoBtnCancel.TabIndex = 50;
            icoBtnCancel.Text = "BUTTON";
            icoBtnCancel.TextAlign = ContentAlignment.BottomCenter;
            icoBtnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            btnSell.Anchor = AnchorStyles.None;
            btnSell.AutoSize = false;
            btnSell.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSell.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSell.Depth = 0;
            btnSell.HighEmphasis = true;
            btnSell.Icon = null;
            btnSell.Location = new Point(64, 580);
            btnSell.Margin = new Padding(4);
            btnSell.MouseState = MaterialSkin.MouseState.HOVER;
            btnSell.Name = "btnSell";
            btnSell.NoAccentTextColor = Color.Empty;
            btnSell.Size = new Size(126, 33);
            btnSell.TabIndex = 47;
            btnSell.Text = "vender";
            btnSell.Type = MaterialButton.MaterialButtonType.Contained;
            btnSell.UseAccentColor = false;
            btnSell.UseVisualStyleBackColor = true;
            // 
            // icoBtnSell
            // 
            icoBtnSell.Anchor = AnchorStyles.None;
            icoBtnSell.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnSell.BackColor = Color.RoyalBlue;
            icoBtnSell.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnSell.ForeColor = SystemColors.Control;
            icoBtnSell.IconChar = IconChar.Donate;
            icoBtnSell.IconColor = Color.White;
            icoBtnSell.IconFont = IconFont.Auto;
            icoBtnSell.IconSize = 60;
            icoBtnSell.Location = new Point(54, 502);
            icoBtnSell.Name = "icoBtnSell";
            icoBtnSell.Size = new Size(150, 120);
            icoBtnSell.TabIndex = 48;
            icoBtnSell.Text = "BUTTON";
            icoBtnSell.TextAlign = ContentAlignment.BottomCenter;
            icoBtnSell.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnSell.UseVisualStyleBackColor = false;
            // 
            // radTrans
            // 
            radTrans.AutoSize = true;
            radTrans.Depth = 0;
            radTrans.Location = new Point(230, 441);
            radTrans.Margin = new Padding(0);
            radTrans.MouseLocation = new Point(-1, -1);
            radTrans.MouseState = MaterialSkin.MouseState.HOVER;
            radTrans.Name = "radTrans";
            radTrans.Ripple = true;
            radTrans.Size = new Size(133, 37);
            radTrans.TabIndex = 7;
            radTrans.TabStop = true;
            radTrans.Text = "Transferencia";
            radTrans.UseVisualStyleBackColor = true;
            // 
            // radEfectivo
            // 
            radEfectivo.AutoSize = true;
            radEfectivo.Depth = 0;
            radEfectivo.Location = new Point(99, 441);
            radEfectivo.Margin = new Padding(0);
            radEfectivo.MouseLocation = new Point(-1, -1);
            radEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            radEfectivo.Name = "radEfectivo";
            radEfectivo.Ripple = true;
            radEfectivo.Size = new Size(92, 37);
            radEfectivo.TabIndex = 6;
            radEfectivo.TabStop = true;
            radEfectivo.Text = "Efectivo";
            radEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblPayType
            // 
            lblPayType.Anchor = AnchorStyles.Top;
            lblPayType.AutoSize = true;
            lblPayType.Depth = 0;
            lblPayType.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPayType.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblPayType.Location = new Point(116, 400);
            lblPayType.MouseState = MaterialSkin.MouseState.HOVER;
            lblPayType.Name = "lblPayType";
            lblPayType.Size = new Size(206, 41);
            lblPayType.TabIndex = 5;
            lblPayType.Text = "Tipo de Pago:";
            // 
            // lblTot
            // 
            lblTot.Anchor = AnchorStyles.Top;
            lblTot.AutoSize = true;
            lblTot.Depth = 0;
            lblTot.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTot.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTot.Location = new Point(116, 294);
            lblTot.MouseState = MaterialSkin.MouseState.HOVER;
            lblTot.Name = "lblTot";
            lblTot.Size = new Size(206, 41);
            lblTot.TabIndex = 4;
            lblTot.Text = "Total A Pagar";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Top;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Depth = 0;
            lblTotalAmount.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTotalAmount.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblTotalAmount.Location = new Point(116, 347);
            lblTotalAmount.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(94, 41);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "$ 0.00";
            // 
            // lblResume
            // 
            lblResume.Anchor = AnchorStyles.Top;
            lblResume.AutoSize = true;
            lblResume.Depth = 0;
            lblResume.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblResume.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            lblResume.Location = new Point(74, 7);
            lblResume.MouseState = MaterialSkin.MouseState.HOVER;
            lblResume.Name = "lblResume";
            lblResume.Size = new Size(320, 41);
            lblResume.TabIndex = 3;
            lblResume.Text = "RESUMEN DE VENTA";
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
            tableLayoutPanel1.Size = new Size(1680, 78);
            tableLayoutPanel1.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(picSaleTitle);
            panel1.Controls.Add(lblProductTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(507, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 72);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lblCurrentUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1179, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 72);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(363, 30);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(363, 3);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(79, 24);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "[Usuario]";
            // 
            // SaleView
            // 
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlpMain);
            Name = "SaleView";
            Size = new Size(1680, 930);
            ((ISupportInitialize)picSaleTitle).EndInit();
            tlpMain.ResumeLayout(false);
            tlpLeft.ResumeLayout(false);
            tlpLeft.PerformLayout();
            pnlProducto.ResumeLayout(false);
            ((ISupportInitialize)dtgCustomers).EndInit();
            tlpInputsProducto.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ((ISupportInitialize)dtgProducts).EndInit();
            tlpInputsVenta.ResumeLayout(false);
            flpCartHeader.ResumeLayout(false);
            flpCartHeader.PerformLayout();
            ((ISupportInitialize)picCart).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            pnlResumen.ResumeLayout(false);
            pnlResumen.PerformLayout();
            tlpSummaryBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        private IconPictureBox picSaleTitle;
        private MaterialLabel lblProductTitle;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpLeft;
        private Panel pnlHeader;
        private TableLayoutPanel tlpInputsVenta;
        private MaterialButton btnProduct;
        private MaterialTextBox2 txtProducto;
        private Panel pnlProducto;
        private Panel pnlResumen;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialLabel lblCurrentUser;
        private MaterialButton btnLogout;
        private TableLayoutPanel tlpInputsProducto;
        private MaterialTextBox2 txtSearchClient;
        private MaterialButton btnAddUser;
        private DataGridView dtgCustomers;
        private MaterialTextBox2 txtName;
        private MaterialTextBox2 txtLastname;
        private MaterialTextBox2 txtDni;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnPhone;
        private MaterialTextBox2 txtTel;
        private IconButton btnCheckCustomer;
        private DataGridView dtgProducts;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnBrand;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColumnStock;
        private DataGridViewTextBoxColumn ColumnPurchasePrice;
        private DataGridViewTextBoxColumn ColumnSalePrice;
        private DataGridView dataGridView1;
        private MaterialTextBox2 txtMarca;
        private MaterialTextBox2 txtStock;
        private MaterialTextBox2 txtPName;
        private MaterialTextBox2 txtQtty;
        private MaterialTextBox2 txtPVenta;
        private MaterialButton btnAddProd;
        private MaterialTextBox2 txtSubTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewButtonColumn Remove;
        private FlowLayoutPanel flpCartHeader;
        private IconPictureBox picCart;
        private MaterialLabel lblCart;
        private MaterialLabel lblResume;
        private MaterialLabel lblTot;
        private MaterialRadioButton radTrans;
        private MaterialRadioButton radEfectivo;
        private MaterialLabel lblPayType;
        private MaterialButton btnPrint;
        private IconButton icoBtnPrint;
        private MaterialButton btnCancel;
        private IconButton icoBtnCancel;
        private MaterialButton btnSell;
        private IconButton icoBtnSell;
        private MaterialLabel lblDate;
        private MaterialLabel lblDniValue;
        private MaterialLabel lblDni;
        private MaterialLabel lblUserValue;
        private MaterialLabel lblUser;
        private MaterialLabel lblNomyApeValue;
        private MaterialLabel lblNomYApe;
        private MaterialLabel lblToday;
        private MaterialLabel lblSaleNumber;
        private MaterialLabel lblSaleNumberValue;
        private MaterialLabel lblTotalAmount;
        private TableLayoutPanel tlpSummaryBox;
    }
}
