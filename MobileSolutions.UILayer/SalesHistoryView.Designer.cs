using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    partial class SalesHistoryView
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tlpPrincipal = new TableLayoutPanel();
            splitContainer = new SplitContainer();
            dgvSales = new DataGridView();
            colNumeroVenta = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colVendedor = new DataGridViewTextBoxColumn();
            colMetodoPago = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewImageColumn();
            tlpDetalle = new TableLayoutPanel();
            lblDetailTitle = new MaterialLabel();
            dgvSaleDetails = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            flpFiltros = new FlowLayoutPanel();
            txtFilterSaleNumber = new MaterialTextBox2();
            dtpDateFrom = new DateTimePicker();
            dtpDateTo = new DateTimePicker();
            txtFilterClient = new MaterialTextBox2();
            cboFilterSeller = new MaterialComboBox();
            btnSearch = new MaterialButton();
            btnClear = new MaterialButton();
            lblTitle = new MaterialLabel();
            picHistoryTitle = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            tlpPrincipal.SuspendLayout();
            ((ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((ISupportInitialize)dgvSales).BeginInit();
            tlpDetalle.SuspendLayout();
            ((ISupportInitialize)dgvSaleDetails).BeginInit();
            flpFiltros.SuspendLayout();
            ((ISupportInitialize)picHistoryTitle).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(50, 50, 50);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(splitContainer, 0, 2);
            tlpPrincipal.Controls.Add(flpFiltros, 0, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(16, 12, 16, 12);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tlpPrincipal.Size = new Size(1680, 830);
            tlpPrincipal.TabIndex = 0;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(50, 50, 50);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(19, 100);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(50, 50, 50);
            splitContainer.Panel1.Controls.Add(dgvSales);
            splitContainer.Panel1MinSize = 120;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.FromArgb(50, 50, 50);
            splitContainer.Panel2.Controls.Add(tlpDetalle);
            splitContainer.Panel2MinSize = 120;
            splitContainer.Size = new Size(1642, 715);
            splitContainer.SplitterDistance = 372;
            splitContainer.SplitterWidth = 6;
            splitContainer.TabIndex = 2;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 58, 58);
            dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvSales.BorderStyle = BorderStyle.None;
            dgvSales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSales.ColumnHeadersHeight = 38;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { colNumeroVenta, colFecha, colCliente, colVendedor, colMetodoPago, colTotal, colAcciones });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.GridColor = Color.FromArgb(70, 70, 70);
            dgvSales.Location = new Point(0, 56);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersVisible = false;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.RowTemplate.Height = 34;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(1295, 254);
            dgvSales.TabIndex = 0;
            // 
            // colNumeroVenta
            // 
            colNumeroVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNumeroVenta.HeaderText = "N° Venta";
            colNumeroVenta.MinimumWidth = 6;
            colNumeroVenta.Name = "colNumeroVenta";
            colNumeroVenta.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colVendedor
            // 
            colVendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVendedor.HeaderText = "Vendedor";
            colVendedor.MinimumWidth = 6;
            colVendedor.Name = "colVendedor";
            colVendedor.ReadOnly = true;
            // 
            // colMetodoPago
            // 
            colMetodoPago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMetodoPago.HeaderText = "Método Pago";
            colMetodoPago.MinimumWidth = 6;
            colMetodoPago.Name = "colMetodoPago";
            colMetodoPago.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotal.HeaderText = "Total ($)";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colAcciones
            // 
            colAcciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAcciones.HeaderText = "Acciones";
            colAcciones.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAcciones.MinimumWidth = 6;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            // 
            // tlpDetalle
            // 
            tlpDetalle.BackColor = Color.FromArgb(50, 50, 50);
            tlpDetalle.ColumnCount = 1;
            tlpDetalle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDetalle.Controls.Add(lblDetailTitle, 0, 0);
            tlpDetalle.Controls.Add(dgvSaleDetails, 0, 1);
            tlpDetalle.Dock = DockStyle.Fill;
            tlpDetalle.Location = new Point(0, 0);
            tlpDetalle.Name = "tlpDetalle";
            tlpDetalle.RowCount = 2;
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetalle.Size = new Size(1642, 337);
            tlpDetalle.TabIndex = 0;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.Depth = 0;
            lblDetailTitle.Dock = DockStyle.Fill;
            lblDetailTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDetailTitle.ForeColor = Color.FromArgb(178, 235, 242);
            lblDetailTitle.Location = new Point(3, 0);
            lblDetailTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(1636, 30);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Detalle del comprobante seleccionado";
            lblDetailTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblDetailTitle.Click += lblDetailTitle_Click;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.AllowUserToAddRows = false;
            dgvSaleDetails.AllowUserToDeleteRows = false;
            dgvSaleDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 58, 58);
            dgvSaleDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaleDetails.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvSaleDetails.BorderStyle = BorderStyle.None;
            dgvSaleDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSaleDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSaleDetails.ColumnHeadersHeight = 38;
            dgvSaleDetails.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colCantidad, colPrecioUnitario, colSubtotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSaleDetails.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSaleDetails.Dock = DockStyle.Fill;
            dgvSaleDetails.EnableHeadersVisualStyles = false;
            dgvSaleDetails.GridColor = Color.FromArgb(70, 70, 70);
            dgvSaleDetails.Location = new Point(3, 33);
            dgvSaleDetails.MultiSelect = false;
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.ReadOnly = true;
            dgvSaleDetails.RowHeadersVisible = false;
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.RowTemplate.Height = 30;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.Size = new Size(1636, 301);
            dgvSaleDetails.TabIndex = 1;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.FillWeight = 180F;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.MinimumWidth = 6;
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 6;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // flpFiltros
            // 
            flpFiltros.BackColor = Color.FromArgb(50, 50, 50);
            flpFiltros.Controls.Add(txtFilterSaleNumber);
            flpFiltros.Controls.Add(dtpDateFrom);
            flpFiltros.Controls.Add(dtpDateTo);
            flpFiltros.Controls.Add(txtFilterClient);
            flpFiltros.Controls.Add(cboFilterSeller);
            flpFiltros.Controls.Add(btnSearch);
            flpFiltros.Controls.Add(btnClear);
            flpFiltros.Dock = DockStyle.Top;
            flpFiltros.Location = new Point(19, 15);
            flpFiltros.Name = "flpFiltros";
            flpFiltros.Size = new Size(1642, 60);
            flpFiltros.TabIndex = 1;
            // 
            // txtFilterSaleNumber
            // 
            txtFilterSaleNumber.AnimateReadOnly = false;
            txtFilterSaleNumber.BackgroundImageLayout = ImageLayout.None;
            txtFilterSaleNumber.CharacterCasing = CharacterCasing.Normal;
            txtFilterSaleNumber.Depth = 0;
            txtFilterSaleNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFilterSaleNumber.HideSelection = true;
            txtFilterSaleNumber.Hint = "N° Comprobante";
            txtFilterSaleNumber.LeadingIcon = null;
            txtFilterSaleNumber.Location = new Point(6, 16);
            txtFilterSaleNumber.Margin = new Padding(6, 16, 6, 16);
            txtFilterSaleNumber.MaxLength = 100;
            txtFilterSaleNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtFilterSaleNumber.Name = "txtFilterSaleNumber";
            txtFilterSaleNumber.PasswordChar = '\0';
            txtFilterSaleNumber.PrefixSuffixText = null;
            txtFilterSaleNumber.ReadOnly = false;
            txtFilterSaleNumber.RightToLeft = RightToLeft.No;
            txtFilterSaleNumber.SelectedText = "";
            txtFilterSaleNumber.SelectionLength = 0;
            txtFilterSaleNumber.SelectionStart = 0;
            txtFilterSaleNumber.ShortcutsEnabled = true;
            txtFilterSaleNumber.Size = new Size(234, 48);
            txtFilterSaleNumber.TabIndex = 0;
            txtFilterSaleNumber.TabStop = false;
            txtFilterSaleNumber.TextAlign = HorizontalAlignment.Left;
            txtFilterSaleNumber.TrailingIcon = null;
            txtFilterSaleNumber.UseSystemPasswordChar = false;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.BackColor = Color.FromArgb(60, 60, 60);
            dtpDateFrom.CalendarForeColor = Color.White;
            dtpDateFrom.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtpDateFrom.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);
            dtpDateFrom.CalendarTitleForeColor = Color.White;
            dtpDateFrom.CalendarTrailingForeColor = Color.FromArgb(150, 150, 150);
            dtpDateFrom.ForeColor = Color.White;
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(252, 24);
            dtpDateFrom.Margin = new Padding(6, 24, 6, 24);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(140, 27);
            dtpDateFrom.TabIndex = 1;
            dtpDateFrom.Value = new DateTime(2026, 9, 1, 0, 0, 0, 0);
            // 
            // dtpDateTo
            // 
            dtpDateTo.BackColor = Color.FromArgb(60, 60, 60);
            dtpDateTo.CalendarForeColor = Color.White;
            dtpDateTo.CalendarMonthBackground = Color.FromArgb(60, 60, 60);
            dtpDateTo.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);
            dtpDateTo.CalendarTitleForeColor = Color.White;
            dtpDateTo.CalendarTrailingForeColor = Color.FromArgb(150, 150, 150);
            dtpDateTo.ForeColor = Color.White;
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(404, 24);
            dtpDateTo.Margin = new Padding(6, 24, 6, 24);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(140, 27);
            dtpDateTo.TabIndex = 2;
            dtpDateTo.Value = new DateTime(2026, 9, 12, 0, 0, 0, 0);
            // 
            // txtFilterClient
            // 
            txtFilterClient.AnimateReadOnly = false;
            txtFilterClient.BackgroundImageLayout = ImageLayout.None;
            txtFilterClient.CharacterCasing = CharacterCasing.Normal;
            txtFilterClient.Depth = 0;
            txtFilterClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFilterClient.HideSelection = true;
            txtFilterClient.Hint = "Buscar Cliente por DNI/Nombre";
            txtFilterClient.LeadingIcon = null;
            txtFilterClient.Location = new Point(556, 16);
            txtFilterClient.Margin = new Padding(6, 16, 6, 16);
            txtFilterClient.MaxLength = 100;
            txtFilterClient.MouseState = MaterialSkin.MouseState.OUT;
            txtFilterClient.Name = "txtFilterClient";
            txtFilterClient.PasswordChar = '\0';
            txtFilterClient.PrefixSuffixText = null;
            txtFilterClient.ReadOnly = false;
            txtFilterClient.RightToLeft = RightToLeft.No;
            txtFilterClient.SelectedText = "";
            txtFilterClient.SelectionLength = 0;
            txtFilterClient.SelectionStart = 0;
            txtFilterClient.ShortcutsEnabled = true;
            txtFilterClient.Size = new Size(285, 48);
            txtFilterClient.TabIndex = 3;
            txtFilterClient.TabStop = false;
            txtFilterClient.TextAlign = HorizontalAlignment.Left;
            txtFilterClient.TrailingIcon = null;
            txtFilterClient.UseSystemPasswordChar = false;
            // 
            // cboFilterSeller
            // 
            cboFilterSeller.AutoResize = false;
            cboFilterSeller.BackColor = Color.White;
            cboFilterSeller.Depth = 0;
            cboFilterSeller.DrawMode = DrawMode.OwnerDrawVariable;
            cboFilterSeller.DropDownHeight = 174;
            cboFilterSeller.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterSeller.DropDownWidth = 170;
            cboFilterSeller.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            cboFilterSeller.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFilterSeller.FormattingEnabled = true;
            cboFilterSeller.Hint = "Vendedor";
            cboFilterSeller.IntegralHeight = false;
            cboFilterSeller.ItemHeight = 43;
            cboFilterSeller.Items.AddRange(new object[] { "Todos", "nico", "fer", "admin" });
            cboFilterSeller.Location = new Point(853, 16);
            cboFilterSeller.Margin = new Padding(6, 16, 6, 16);
            cboFilterSeller.MaxDropDownItems = 4;
            cboFilterSeller.MouseState = MaterialSkin.MouseState.OUT;
            cboFilterSeller.Name = "cboFilterSeller";
            cboFilterSeller.Size = new Size(175, 49);
            cboFilterSeller.StartIndex = 0;
            cboFilterSeller.TabIndex = 4;
            cboFilterSeller.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(1040, 16);
            btnSearch.Margin = new Padding(6, 16, 6, 16);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(110, 48);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar";
            btnSearch.Type = MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = false;
            btnClear.Icon = null;
            btnClear.Location = new Point(1162, 16);
            btnClear.Margin = new Padding(6, 16, 6, 16);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(110, 48);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(603, 0);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(621, 72);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HISTORIAL DE VENTAS";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picHistoryTitle
            // 
            picHistoryTitle.BackColor = Color.FromArgb(50, 50, 50);
            picHistoryTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picHistoryTitle.IconColor = Color.White;
            picHistoryTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picHistoryTitle.IconSize = 94;
            picHistoryTitle.Location = new Point(491, 0);
            picHistoryTitle.Name = "picHistoryTitle";
            picHistoryTitle.Size = new Size(97, 94);
            picHistoryTitle.TabIndex = 7;
            picHistoryTitle.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tlpPrincipal);
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 830);
            panel1.TabIndex = 8;
            // 
            // SalesHistoryView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblTitle);
            Controls.Add(picHistoryTitle);
            Controls.Add(panel1);
            Name = "SalesHistoryView";
            Size = new Size(1680, 930);
            tlpPrincipal.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((ISupportInitialize)dgvSales).EndInit();
            tlpDetalle.ResumeLayout(false);
            ((ISupportInitialize)dgvSaleDetails).EndInit();
            flpFiltros.ResumeLayout(false);
            ((ISupportInitialize)picHistoryTitle).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpPrincipal;
        private MaterialLabel lblTitle;
        private FontAwesome.Sharp.IconPictureBox picHistoryTitle;
        private FlowLayoutPanel flpFiltros;
        private MaterialTextBox2 txtFilterSaleNumber;
        private DateTimePicker dtpDateFrom;
        private DateTimePicker dtpDateTo;
        private MaterialTextBox2 txtFilterClient;
        private MaterialComboBox cboFilterSeller;
        private MaterialButton btnSearch;
        private MaterialButton btnClear;
        private SplitContainer splitContainer;
        private DataGridView dgvSales;
        private DataGridViewTextBoxColumn colNumeroVenta;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colVendedor;
        private DataGridViewTextBoxColumn colMetodoPago;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewImageColumn colAcciones;
        private TableLayoutPanel tlpDetalle;
        private MaterialLabel lblDetailTitle;
        private DataGridView dgvSaleDetails;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colSubtotal;
        private Panel panel1;
    }
}