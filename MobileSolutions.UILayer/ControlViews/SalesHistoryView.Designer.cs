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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblCurrentUser = new MaterialLabel();
            btnLogout = new MaterialButton();
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
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(50, 50, 50);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(splitContainer, 0, 2);
            tlpPrincipal.Controls.Add(flpFiltros, 0, 0);
            tlpPrincipal.Dock = DockStyle.Bottom;
            tlpPrincipal.Location = new Point(0, 168);
            tlpPrincipal.Margin = new Padding(3, 2, 3, 2);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(14, 9, 14, 9);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.RowStyles.Add(new RowStyle());
            tlpPrincipal.Size = new Size(1680, 762);
            tlpPrincipal.TabIndex = 0;
            // 
            // splitContainer
            // 
            splitContainer.BackColor = Color.FromArgb(50, 50, 50);
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(17, 93);
            splitContainer.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer.Size = new Size(1646, 717);
            splitContainer.SplitterDistance = 371;
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
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.EnableHeadersVisualStyles = false;
            dgvSales.GridColor = Color.FromArgb(70, 70, 70);
            dgvSales.Location = new Point(0, 0);
            dgvSales.Margin = new Padding(3, 2, 3, 2);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersVisible = false;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.RowTemplate.Height = 34;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(1646, 371);
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
            tlpDetalle.Margin = new Padding(3, 2, 3, 2);
            tlpDetalle.Name = "tlpDetalle";
            tlpDetalle.RowCount = 2;
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpDetalle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpDetalle.Size = new Size(1646, 342);
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
            lblDetailTitle.Size = new Size(1640, 22);
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
            dgvSaleDetails.Location = new Point(3, 24);
            dgvSaleDetails.Margin = new Padding(3, 2, 3, 2);
            dgvSaleDetails.MultiSelect = false;
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.ReadOnly = true;
            dgvSaleDetails.RowHeadersVisible = false;
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.RowTemplate.Height = 30;
            dgvSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaleDetails.Size = new Size(1640, 316);
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
            flpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpFiltros.BackColor = Color.FromArgb(50, 50, 50);
            flpFiltros.Controls.Add(txtFilterSaleNumber);
            flpFiltros.Controls.Add(dtpDateFrom);
            flpFiltros.Controls.Add(dtpDateTo);
            flpFiltros.Controls.Add(txtFilterClient);
            flpFiltros.Controls.Add(cboFilterSeller);
            flpFiltros.Controls.Add(btnSearch);
            flpFiltros.Controls.Add(btnClear);
            flpFiltros.Location = new Point(17, 11);
            flpFiltros.Margin = new Padding(3, 2, 3, 2);
            flpFiltros.Name = "flpFiltros";
            flpFiltros.Size = new Size(1646, 78);
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
            txtFilterSaleNumber.Location = new Point(5, 12);
            txtFilterSaleNumber.Margin = new Padding(5, 12, 5, 12);
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
            txtFilterSaleNumber.Size = new Size(205, 48);
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
            dtpDateFrom.Location = new Point(220, 18);
            dtpDateFrom.Margin = new Padding(5, 18, 5, 18);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(123, 23);
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
            dtpDateTo.Location = new Point(353, 18);
            dtpDateTo.Margin = new Padding(5, 18, 5, 18);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(123, 23);
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
            txtFilterClient.Location = new Point(486, 12);
            txtFilterClient.Margin = new Padding(5, 12, 5, 12);
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
            txtFilterClient.Size = new Size(249, 48);
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
            cboFilterSeller.Location = new Point(745, 12);
            cboFilterSeller.Margin = new Padding(5, 12, 5, 12);
            cboFilterSeller.MaxDropDownItems = 4;
            cboFilterSeller.MouseState = MaterialSkin.MouseState.OUT;
            cboFilterSeller.Name = "cboFilterSeller";
            cboFilterSeller.Size = new Size(154, 49);
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
            btnSearch.Location = new Point(909, 12);
            btnSearch.Margin = new Padding(5, 12, 5, 12);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(96, 36);
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
            btnClear.Location = new Point(1015, 12);
            btnClear.Margin = new Padding(5, 12, 5, 12);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(96, 36);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitle.AutoSize = true;
            lblTitle.Depth = 0;
            lblTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(120, 4);
            lblTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 58);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HISTORIAL DE VENTAS";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picHistoryTitle
            // 
            picHistoryTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picHistoryTitle.BackColor = Color.FromArgb(50, 50, 50);
            picHistoryTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picHistoryTitle.IconColor = Color.White;
            picHistoryTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picHistoryTitle.IconSize = 65;
            picHistoryTitle.Location = new Point(49, 4);
            picHistoryTitle.Margin = new Padding(3, 2, 3, 2);
            picHistoryTitle.Name = "picHistoryTitle";
            picHistoryTitle.Size = new Size(65, 72);
            picHistoryTitle.TabIndex = 7;
            picHistoryTitle.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1680, 90);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(picHistoryTitle);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(507, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 84);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblCurrentUser);
            panel3.Controls.Add(btnLogout);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1179, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(498, 84);
            panel3.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(149, 16);
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
            btnLogout.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(327, 4);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // SalesHistoryView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(tlpPrincipal);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
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
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private MaterialButton btnLogout;
        private MaterialLabel lblCurrentUser;
    }
}
