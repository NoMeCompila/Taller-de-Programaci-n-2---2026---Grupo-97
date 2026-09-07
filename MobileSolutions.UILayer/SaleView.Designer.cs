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
            picSaleTitle = new IconPictureBox();
            lblProductTitle = new MaterialLabel();
            panel1 = new Panel();
            txtSaleNumber = new MaterialTextBox2();
            btnSaleNumber = new MaterialButton();
            cmbPaymentType = new MaterialComboBox();
            btnPaymentType = new MaterialButton();
            txtCustomer = new MaterialTextBox2();
            btnCustomer = new MaterialButton();
            panel2 = new Panel();
            btnAddDetail = new MaterialButton();
            txtUnitaryPrice = new MaterialTextBox2();
            btnUnitaryPrice = new MaterialButton();
            txtQuantity = new MaterialTextBox2();
            btnQuantity = new MaterialButton();
            txtProductCode = new MaterialTextBox2();
            btnProductCode = new MaterialButton();
            dgvSaleDetails = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            TotalProducto = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            lblTotalSale = new MaterialLabel();
            btnTotalSale = new MaterialButton();
            btnConfirmSale = new MaterialButton();
            btnCancelSale = new MaterialButton();
            panel3 = new Panel();
            ((ISupportInitialize)picSaleTitle).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)dgvSaleDetails).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // picSaleTitle
            // 
            picSaleTitle.BackColor = SystemColors.Control;
            picSaleTitle.ForeColor = SystemColors.ControlText;
            picSaleTitle.IconChar = IconChar.None;
            picSaleTitle.IconColor = SystemColors.ControlText;
            picSaleTitle.IconFont = IconFont.Auto;
            picSaleTitle.IconSize = 83;
            picSaleTitle.Location = new Point(332, 29);
            picSaleTitle.Name = "picSaleTitle";
            picSaleTitle.Size = new Size(83, 84);
            picSaleTitle.TabIndex = 0;
            picSaleTitle.TabStop = false;
            // 
            // lblProductTitle
            // 
            lblProductTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblProductTitle.AutoSize = true;
            lblProductTitle.Depth = 0;
            lblProductTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProductTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblProductTitle.Location = new Point(446, 29);
            lblProductTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(153, 72);
            lblProductTitle.TabIndex = 36;
            lblProductTitle.Text = "Venta";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSaleNumber);
            panel1.Controls.Add(btnSaleNumber);
            panel1.Controls.Add(cmbPaymentType);
            panel1.Controls.Add(btnPaymentType);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(btnCustomer);
            panel1.Location = new Point(3, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 110);
            panel1.TabIndex = 37;
            // 
            // txtSaleNumber
            // 
            txtSaleNumber.Anchor = AnchorStyles.Right;
            txtSaleNumber.AnimateReadOnly = false;
            txtSaleNumber.BackgroundImageLayout = ImageLayout.None;
            txtSaleNumber.CharacterCasing = CharacterCasing.Normal;
            txtSaleNumber.Depth = 0;
            txtSaleNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSaleNumber.HideSelection = true;
            txtSaleNumber.Hint = "Numero de Venta";
            txtSaleNumber.LeadingIcon = null;
            txtSaleNumber.Location = new Point(781, 34);
            txtSaleNumber.MaxLength = 100;
            txtSaleNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtSaleNumber.Name = "txtSaleNumber";
            txtSaleNumber.PasswordChar = '\0';
            txtSaleNumber.PrefixSuffixText = null;
            txtSaleNumber.ReadOnly = false;
            txtSaleNumber.RightToLeft = RightToLeft.No;
            txtSaleNumber.SelectedText = "";
            txtSaleNumber.SelectionLength = 0;
            txtSaleNumber.SelectionStart = 0;
            txtSaleNumber.ShortcutsEnabled = true;
            txtSaleNumber.Size = new Size(226, 48);
            txtSaleNumber.TabIndex = 52;
            txtSaleNumber.TabStop = false;
            txtSaleNumber.TextAlign = HorizontalAlignment.Left;
            txtSaleNumber.TrailingIcon = null;
            txtSaleNumber.UseSystemPasswordChar = false;
            // 
            // btnSaleNumber
            // 
            btnSaleNumber.Anchor = AnchorStyles.Right;
            btnSaleNumber.AutoSize = false;
            btnSaleNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaleNumber.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSaleNumber.Depth = 0;
            btnSaleNumber.HighEmphasis = true;
            btnSaleNumber.Icon = null;
            btnSaleNumber.Location = new Point(730, 31);
            btnSaleNumber.Margin = new Padding(5);
            btnSaleNumber.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaleNumber.Name = "btnSaleNumber";
            btnSaleNumber.NoAccentTextColor = Color.Empty;
            btnSaleNumber.Size = new Size(43, 51);
            btnSaleNumber.TabIndex = 51;
            btnSaleNumber.Type = MaterialButton.MaterialButtonType.Contained;
            btnSaleNumber.UseAccentColor = false;
            btnSaleNumber.UseVisualStyleBackColor = true;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.Anchor = AnchorStyles.Right;
            cmbPaymentType.AutoResize = false;
            cmbPaymentType.BackColor = Color.FromArgb(255, 255, 255);
            cmbPaymentType.Depth = 0;
            cmbPaymentType.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPaymentType.DropDownHeight = 174;
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.DropDownWidth = 121;
            cmbPaymentType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cmbPaymentType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPaymentType.Hint = "Tipo de Pago";
            cmbPaymentType.IntegralHeight = false;
            cmbPaymentType.ItemHeight = 43;
            cmbPaymentType.Location = new Point(446, 31);
            cmbPaymentType.MaxDropDownItems = 4;
            cmbPaymentType.MouseState = MaterialSkin.MouseState.OUT;
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(254, 49);
            cmbPaymentType.StartIndex = 0;
            cmbPaymentType.TabIndex = 50;
            cmbPaymentType.TabStop = false;
            // 
            // btnPaymentType
            // 
            btnPaymentType.Anchor = AnchorStyles.Right;
            btnPaymentType.AutoSize = false;
            btnPaymentType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentType.Density = MaterialButton.MaterialButtonDensity.Default;
            btnPaymentType.Depth = 0;
            btnPaymentType.HighEmphasis = true;
            btnPaymentType.Icon = null;
            btnPaymentType.Location = new Point(395, 29);
            btnPaymentType.Margin = new Padding(5);
            btnPaymentType.MouseState = MaterialSkin.MouseState.HOVER;
            btnPaymentType.Name = "btnPaymentType";
            btnPaymentType.NoAccentTextColor = Color.Empty;
            btnPaymentType.Size = new Size(43, 51);
            btnPaymentType.TabIndex = 49;
            btnPaymentType.Type = MaterialButton.MaterialButtonType.Contained;
            btnPaymentType.UseAccentColor = false;
            btnPaymentType.UseVisualStyleBackColor = true;
            // 
            // txtCustomer
            // 
            txtCustomer.Anchor = AnchorStyles.Right;
            txtCustomer.AnimateReadOnly = false;
            txtCustomer.BackgroundImageLayout = ImageLayout.None;
            txtCustomer.CharacterCasing = CharacterCasing.Normal;
            txtCustomer.Depth = 0;
            txtCustomer.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCustomer.HideSelection = true;
            txtCustomer.Hint = "Cliente";
            txtCustomer.LeadingIcon = null;
            txtCustomer.Location = new Point(67, 31);
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
            txtCustomer.Size = new Size(297, 48);
            txtCustomer.TabIndex = 48;
            txtCustomer.TabStop = false;
            txtCustomer.TextAlign = HorizontalAlignment.Left;
            txtCustomer.TrailingIcon = null;
            txtCustomer.UseSystemPasswordChar = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Right;
            btnCustomer.AutoSize = false;
            btnCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomer.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCustomer.Depth = 0;
            btnCustomer.HighEmphasis = true;
            btnCustomer.Icon = null;
            btnCustomer.Location = new Point(16, 28);
            btnCustomer.Margin = new Padding(5);
            btnCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnCustomer.Name = "btnCustomer";
            btnCustomer.NoAccentTextColor = Color.Empty;
            btnCustomer.Size = new Size(43, 51);
            btnCustomer.TabIndex = 47;
            btnCustomer.Type = MaterialButton.MaterialButtonType.Contained;
            btnCustomer.UseAccentColor = false;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddDetail);
            panel2.Controls.Add(txtUnitaryPrice);
            panel2.Controls.Add(btnUnitaryPrice);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(btnQuantity);
            panel2.Controls.Add(txtProductCode);
            panel2.Controls.Add(btnProductCode);
            panel2.Location = new Point(9, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 110);
            panel2.TabIndex = 38;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Anchor = AnchorStyles.Right;
            btnAddDetail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddDetail.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddDetail.Depth = 0;
            btnAddDetail.HighEmphasis = true;
            btnAddDetail.Icon = null;
            btnAddDetail.Location = new Point(855, 38);
            btnAddDetail.Margin = new Padding(5);
            btnAddDetail.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.NoAccentTextColor = Color.Empty;
            btnAddDetail.Size = new Size(88, 36);
            btnAddDetail.TabIndex = 52;
            btnAddDetail.Text = "Agregar";
            btnAddDetail.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddDetail.UseAccentColor = false;
            btnAddDetail.UseVisualStyleBackColor = true;
            // 
            // txtUnitaryPrice
            // 
            txtUnitaryPrice.Anchor = AnchorStyles.Right;
            txtUnitaryPrice.AnimateReadOnly = false;
            txtUnitaryPrice.BackgroundImageLayout = ImageLayout.None;
            txtUnitaryPrice.CharacterCasing = CharacterCasing.Normal;
            txtUnitaryPrice.Depth = 0;
            txtUnitaryPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnitaryPrice.HideSelection = true;
            txtUnitaryPrice.Hint = "Precio Unitario";
            txtUnitaryPrice.LeadingIcon = null;
            txtUnitaryPrice.Location = new Point(669, 29);
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
            txtUnitaryPrice.Size = new Size(138, 48);
            txtUnitaryPrice.TabIndex = 51;
            txtUnitaryPrice.TabStop = false;
            txtUnitaryPrice.TextAlign = HorizontalAlignment.Left;
            txtUnitaryPrice.TrailingIcon = null;
            txtUnitaryPrice.UseSystemPasswordChar = false;
            // 
            // btnUnitaryPrice
            // 
            btnUnitaryPrice.Anchor = AnchorStyles.Right;
            btnUnitaryPrice.AutoSize = false;
            btnUnitaryPrice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUnitaryPrice.Density = MaterialButton.MaterialButtonDensity.Default;
            btnUnitaryPrice.Depth = 0;
            btnUnitaryPrice.HighEmphasis = true;
            btnUnitaryPrice.Icon = null;
            btnUnitaryPrice.Location = new Point(607, 26);
            btnUnitaryPrice.Margin = new Padding(5);
            btnUnitaryPrice.MouseState = MaterialSkin.MouseState.HOVER;
            btnUnitaryPrice.Name = "btnUnitaryPrice";
            btnUnitaryPrice.NoAccentTextColor = Color.Empty;
            btnUnitaryPrice.Size = new Size(43, 51);
            btnUnitaryPrice.TabIndex = 50;
            btnUnitaryPrice.Type = MaterialButton.MaterialButtonType.Contained;
            btnUnitaryPrice.UseAccentColor = false;
            btnUnitaryPrice.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Right;
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.CharacterCasing = CharacterCasing.Normal;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Cantidad";
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(437, 26);
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
            txtQuantity.Size = new Size(129, 48);
            txtQuantity.TabIndex = 49;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            // 
            // btnQuantity
            // 
            btnQuantity.Anchor = AnchorStyles.Right;
            btnQuantity.AutoSize = false;
            btnQuantity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuantity.Density = MaterialButton.MaterialButtonDensity.Default;
            btnQuantity.Depth = 0;
            btnQuantity.HighEmphasis = true;
            btnQuantity.Icon = null;
            btnQuantity.Location = new Point(389, 23);
            btnQuantity.Margin = new Padding(5);
            btnQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            btnQuantity.Name = "btnQuantity";
            btnQuantity.NoAccentTextColor = Color.Empty;
            btnQuantity.Size = new Size(43, 51);
            btnQuantity.TabIndex = 48;
            btnQuantity.Type = MaterialButton.MaterialButtonType.Contained;
            btnQuantity.UseAccentColor = false;
            btnQuantity.UseVisualStyleBackColor = true;
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
            txtProductCode.Location = new Point(61, 23);
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
            txtProductCode.Size = new Size(297, 48);
            txtProductCode.TabIndex = 47;
            txtProductCode.TabStop = false;
            txtProductCode.TextAlign = HorizontalAlignment.Left;
            txtProductCode.TrailingIcon = null;
            txtProductCode.UseSystemPasswordChar = false;
            // 
            // btnProductCode
            // 
            btnProductCode.Anchor = AnchorStyles.Right;
            btnProductCode.AutoSize = false;
            btnProductCode.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnProductCode.Density = MaterialButton.MaterialButtonDensity.Default;
            btnProductCode.Depth = 0;
            btnProductCode.HighEmphasis = true;
            btnProductCode.Icon = null;
            btnProductCode.Location = new Point(10, 20);
            btnProductCode.Margin = new Padding(5);
            btnProductCode.MouseState = MaterialSkin.MouseState.HOVER;
            btnProductCode.Name = "btnProductCode";
            btnProductCode.NoAccentTextColor = Color.Empty;
            btnProductCode.Size = new Size(43, 51);
            btnProductCode.TabIndex = 46;
            btnProductCode.Type = MaterialButton.MaterialButtonType.Contained;
            btnProductCode.UseAccentColor = false;
            btnProductCode.UseVisualStyleBackColor = true;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.BackgroundColor = Color.MidnightBlue;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetails.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, PrecioUnitario, TotalProducto, Eliminar });
            dgvSaleDetails.Location = new Point(6, 3);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.Size = new Size(679, 174);
            dgvSaleDetails.TabIndex = 39;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "PrecioUnitario";
            PrecioUnitario.MinimumWidth = 6;
            PrecioUnitario.Name = "PrecioUnitario";
            PrecioUnitario.Width = 125;
            // 
            // TotalProducto
            // 
            TotalProducto.HeaderText = "TotalProducto";
            TotalProducto.MinimumWidth = 6;
            TotalProducto.Name = "TotalProducto";
            TotalProducto.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 125;
            // 
            // lblTotalSale
            // 
            lblTotalSale.AutoSize = true;
            lblTotalSale.Depth = 0;
            lblTotalSale.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTotalSale.Location = new Point(937, 50);
            lblTotalSale.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalSale.Name = "lblTotalSale";
            lblTotalSale.Size = new Size(70, 19);
            lblTotalSale.TabIndex = 40;
            lblTotalSale.Text = "$ xxxxxxx";
            // 
            // btnTotalSale
            // 
            btnTotalSale.Anchor = AnchorStyles.Right;
            btnTotalSale.AutoSize = false;
            btnTotalSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTotalSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnTotalSale.Depth = 0;
            btnTotalSale.HighEmphasis = true;
            btnTotalSale.Icon = null;
            btnTotalSale.Location = new Point(801, 39);
            btnTotalSale.Margin = new Padding(5);
            btnTotalSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnTotalSale.Name = "btnTotalSale";
            btnTotalSale.NoAccentTextColor = Color.Empty;
            btnTotalSale.Size = new Size(118, 37);
            btnTotalSale.TabIndex = 51;
            btnTotalSale.Text = "Total de Venta";
            btnTotalSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnTotalSale.UseAccentColor = false;
            btnTotalSale.UseVisualStyleBackColor = true;
            // 
            // btnConfirmSale
            // 
            btnConfirmSale.Anchor = AnchorStyles.Right;
            btnConfirmSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnConfirmSale.Depth = 0;
            btnConfirmSale.HighEmphasis = true;
            btnConfirmSale.Icon = null;
            btnConfirmSale.Location = new Point(832, 86);
            btnConfirmSale.Margin = new Padding(5);
            btnConfirmSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmSale.Name = "btnConfirmSale";
            btnConfirmSale.NoAccentTextColor = Color.Empty;
            btnConfirmSale.Size = new Size(156, 36);
            btnConfirmSale.TabIndex = 53;
            btnConfirmSale.Text = "Confirmar Venta";
            btnConfirmSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnConfirmSale.UseAccentColor = false;
            btnConfirmSale.UseVisualStyleBackColor = true;
            // 
            // btnCancelSale
            // 
            btnCancelSale.Anchor = AnchorStyles.Right;
            btnCancelSale.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelSale.Density = MaterialButton.MaterialButtonDensity.Default;
            btnCancelSale.Depth = 0;
            btnCancelSale.HighEmphasis = true;
            btnCancelSale.Icon = null;
            btnCancelSale.Location = new Point(841, 132);
            btnCancelSale.Margin = new Padding(5);
            btnCancelSale.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.NoAccentTextColor = Color.Empty;
            btnCancelSale.Size = new Size(147, 36);
            btnCancelSale.TabIndex = 54;
            btnCancelSale.Text = "Cancelar Venta";
            btnCancelSale.Type = MaterialButton.MaterialButtonType.Contained;
            btnCancelSale.UseAccentColor = false;
            btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvSaleDetails);
            panel3.Controls.Add(btnTotalSale);
            panel3.Controls.Add(lblTotalSale);
            panel3.Controls.Add(btnCancelSale);
            panel3.Controls.Add(btnConfirmSale);
            panel3.Location = new Point(3, 443);
            panel3.Name = "panel3";
            panel3.Size = new Size(1036, 189);
            panel3.TabIndex = 55;
            // 
            // SaleView
            // 
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblProductTitle);
            Controls.Add(picSaleTitle);
            Name = "SaleView";
            Size = new Size(1100, 675);
            ((ISupportInitialize)picSaleTitle).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)dgvSaleDetails).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private IconPictureBox picSaleTitle;
        private MaterialLabel lblProductTitle;
        private Panel panel1;
        private MaterialButton btnCustomer;
        private MaterialTextBox2 txtCustomer;
        private MaterialButton btnPaymentType;
        private MaterialComboBox cmbPaymentType;
        private MaterialTextBox2 txtSaleNumber;
        private MaterialButton btnSaleNumber;
        private Panel panel2;
        private MaterialButton btnProductCode;
        private MaterialTextBox2 txtProductCode;
        private MaterialTextBox2 txtQuantity;
        private MaterialButton btnQuantity;
        private MaterialTextBox2 txtUnitaryPrice;
        private MaterialButton btnUnitaryPrice;
        private MaterialButton btnAddDetail;
        private DataGridView dgvSaleDetails;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn TotalProducto;
        private DataGridViewButtonColumn Eliminar;
        private MaterialLabel lblTotalSale;
        private MaterialButton btnTotalSale;
        private MaterialButton btnConfirmSale;
        private MaterialButton btnCancelSale;
        private Panel panel3;
    }
}
    
