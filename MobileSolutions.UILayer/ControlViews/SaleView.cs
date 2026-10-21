using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class SaleView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;
        public event EventHandler? NavigateToCustomerRequested;
        public event EventHandler? NavigateToProductRequested;

        // Servicios de la arquitectura
        private readonly SaleService _saleService;
        private readonly CustomerService _customerService;
        private readonly ProductService _productService;
        private readonly UserService _userService;
        private readonly TicketReportService _ticketReportService;

        // Timers para búsqueda con debounce (350 ms)
        private System.Windows.Forms.Timer? _customerSearchDebounceTimer;
        private System.Windows.Forms.Timer? _productSearchDebounceTimer;

        // Estado en memoria de la venta
        private int _selectedCustomerId = 0;
        private Customer? _selectedCustomer = null;
        private bool _isCustomerLocked = false;
        private Product? _selectedProduct = null;
        private readonly List<SaleDetail> _cartItems = new();
        private int _lastCreatedSaleId = 0;
        private string _lastCreatedSaleNumber = string.Empty;
        private SaleTicketData? _lastCompletedSaleTicket = null;
        private bool _isSaleFinalized = false;

        public SaleView()
        {
            InitializeComponent();

            _saleService = new SaleService();
            _customerService = new CustomerService();
            _productService = new ProductService();
            _userService = new UserService();
            _ticketReportService = new TicketReportService();

            ConfigurarIconos();
            ConfigurarGrillas();
            ConfigurarBuscadoresYDebounce();
            ConfigurarEventosControles();

            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            radEfectivo.Checked = true;
            ActualizarEstadoBotonImprimir(habilitado: false);
            ActualizarEstadoSeccionProductos(habilitado: false);

            CargarDatosUsuarioActual();
            CargarClientesActivos();
            CargarProductosActivos();
            LimpiarVentaCompleta();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                CargarDatosUsuarioActual();
                CargarClientesActivos();
                CargarProductosActivos();
            }
        }

        public void SetSeller(User? user = null)
        {
            CargarDatosUsuarioActual();
        }

        public void SetSeller(string? username)
        {
            CargarDatosUsuarioActual();
        }

        public void SetVendedor(User? user = null)
        {
            CargarDatosUsuarioActual();
        }

        public void SetVendedor(string? username)
        {
            CargarDatosUsuarioActual();
        }

        public void LoadCurrentUserData()
        {
            CargarDatosUsuarioActual();
        }

        #region Configuración Visual y Grillas

        private void ConfigurarIconos()
        {
            icoBtnSell.IconChar = IconChar.Donate;
            icoBtnCancel.IconChar = IconChar.CreativeCommonsNc;
            icoBtnPrint.IconChar = IconChar.FilePdf;
            btnAddProd.Icon = IconChar.CartPlus.ToBitmap(Color.White);
            btnAddUser.Icon = IconChar.UserPlus.ToBitmap(Color.White);
            btnProduct.Icon = IconChar.MobileScreenButton.ToBitmap(Color.White);

            picSaleTitle.IconChar = IconChar.Shopify;
            picSaleTitle.IconColor = Color.White;

            picCart.IconChar = IconChar.ShoppingCart;
            picCart.IconColor = Color.White;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void ConfigurarGrillas()
        {
            // 1. Grilla de Clientes
            dtgCustomers.AutoGenerateColumns = false;
            dtgCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dtgCustomers.DefaultCellStyle.BackColor = Color.White;
            dtgCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dtgCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dtgCustomers.EnableHeadersVisualStyles = false;
            dtgCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
            dtgCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtgCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ColumnName.DataPropertyName = nameof(Customer.Name);
            ColumnLastname.DataPropertyName = nameof(Customer.Lastname);
            ColumnDNI.DataPropertyName = nameof(Customer.Dni);
            ColumnPhone.DataPropertyName = nameof(Customer.Phone);

            // 2. Grilla de Productos
            dtgProducts.AutoGenerateColumns = false;
            dtgProducts.DefaultCellStyle.ForeColor = Color.Black;
            dtgProducts.DefaultCellStyle.BackColor = Color.White;
            dtgProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dtgProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dtgProducts.EnableHeadersVisualStyles = false;
            dtgProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
            dtgProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtgProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ColumnCode.DataPropertyName = nameof(Product.ProductCode);
            ColumnBrand.DataPropertyName = nameof(Product.BrandName);
            dataGridViewTextBoxColumn1.DataPropertyName = nameof(Product.Name);
            ColumnStock.DataPropertyName = nameof(Product.Stock);
            ColumnPurchasePrice.DataPropertyName = nameof(Product.PurchasePrice);
            ColumnSalePrice.DataPropertyName = nameof(Product.SalePrice);

            // 3. Grilla de Carrito
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewTextBoxColumn2.DataPropertyName = nameof(SaleDetail.ProductCode);
            dataGridViewTextBoxColumn3.DataPropertyName = nameof(SaleDetail.BrandName);
            dataGridViewTextBoxColumn4.DataPropertyName = nameof(SaleDetail.ProductName);
            dataGridViewTextBoxColumn5.DataPropertyName = nameof(SaleDetail.Quantity);
            dataGridViewTextBoxColumn7.DataPropertyName = nameof(SaleDetail.UnitPrice);
            SubTotal.DataPropertyName = nameof(SaleDetail.Subtotal);
            Remove.UseColumnTextForButtonValue = false;
        }

        private void ConfigurarEventosControles()
        {
            // Selección en Grillas
            dtgCustomers.CellClick += dtgCustomers_CellClick;
            dtgProducts.CellClick += dtgProducts_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;

            // Restricción de edición exclusiva para cantidad
            txtName.ReadOnly = true;
            txtLastname.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtTel.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtPName.ReadOnly = true;
            txtStock.ReadOnly = true;
            txtPVenta.ReadOnly = true;
            txtSubTotal.ReadOnly = true;
            txtQtty.ReadOnly = false;

            // Restricción y cálculo de cantidad en vivo
            txtQtty.KeyPress += SoloNumeros_KeyPress;
            txtQtty.TextChanged += txtQtty_TextChanged;

            // Acciones principales
            // Interceptores y avisos para interacción en sección producto sin cliente confirmado (AC11)
            pnlHeader.Click += SeccionProducto_Click;
            tlpInputsVenta.Click += SeccionProducto_Click;
            txtProducto.Click += SeccionProducto_Click;

            btnAddUser.Click += (s, e) => NavigateToCustomerRequested?.Invoke(this, EventArgs.Empty);
            btnProduct.Click += (s, e) => NavigateToProductRequested?.Invoke(this, EventArgs.Empty);
            btnCheckCustomer.Click += btnCheckCustomer_Click;
            btnAddProd.Click += btnAddProd_Click;
            btnSell.Click += btnSell_Click;
            icoBtnSell.Click += btnSell_Click;
            btnCancel.Click += btnCancel_Click;
            icoBtnCancel.Click += btnCancel_Click;
            btnPrint.Click += btnPrint_Click;
            icoBtnPrint.Click += btnPrint_Click;
        }

        #endregion

        #region Sesión y Vendedor Activo

        public void CargarDatosUsuarioActual()
        {
            string username = CurrentSession.Username;
            string name = CurrentSession.Name;
            string lastName = CurrentSession.Lastname;
            string dni = CurrentSession.Dni;

            if ((string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(dni)) && !string.IsNullOrWhiteSpace(username))
            {
                try
                {
                    var user = _userService.GetUserByUsername(username);
                    if (user != null)
                    {
                        if (string.IsNullOrWhiteSpace(name)) name = user.Name;
                        if (string.IsNullOrWhiteSpace(lastName)) lastName = user.Lastname;
                        if (string.IsNullOrWhiteSpace(dni)) dni = user.Dni;
                    }
                }
                catch
                {
                    // Fallback silencioso
                }
            }

            string fullName = $"{name} {lastName}".Trim();
            lblNomyApeValue.Text = string.IsNullOrWhiteSpace(fullName) ? "-" : fullName;
            lblUserValue.Text = string.IsNullOrWhiteSpace(username) ? "-" : username;
            lblDniValue.Text = string.IsNullOrWhiteSpace(dni) ? "-" : dni;
        }

        #endregion

        #region Carga y Búsqueda de Clientes y Productos (Debounce 350ms)

        private void ConfigurarBuscadoresYDebounce()
        {
            // Debounce Clientes
            _customerSearchDebounceTimer = new System.Windows.Forms.Timer { Interval = 350 };
            _customerSearchDebounceTimer.Tick += (s, e) =>
            {
                _customerSearchDebounceTimer.Stop();
                EjecutarBusquedaClientes();
            };
            txtSearchClient.TextChanged += (s, e) =>
            {
                _customerSearchDebounceTimer.Stop();
                _customerSearchDebounceTimer.Start();
            };

            // Debounce Productos
            _productSearchDebounceTimer = new System.Windows.Forms.Timer { Interval = 350 };
            _productSearchDebounceTimer.Tick += (s, e) =>
            {
                _productSearchDebounceTimer.Stop();
                EjecutarBusquedaProductos();
            };
            txtProducto.TextChanged += (s, e) =>
            {
                _productSearchDebounceTimer.Stop();
                _productSearchDebounceTimer.Start();
            };
        }

        private void CargarClientesActivos()
        {
            try
            {
                var customers = _customerService.GetActiveCustomers();
                dtgCustomers.DataSource = null;
                dtgCustomers.DataSource = customers;
                dtgCustomers.ClearSelection();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarBusquedaClientes()
        {
            try
            {
                var customers = _customerService.SearchCustomers(txtSearchClient.Text);
                dtgCustomers.DataSource = null;
                dtgCustomers.DataSource = customers;
                dtgCustomers.ClearSelection();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error en búsqueda de clientes: {ex.Message}", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductosActivos()
        {
            try
            {
                var products = _productService.GetActiveProducts();
                dtgProducts.DataSource = null;
                dtgProducts.DataSource = products;
                dtgProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error al cargar productos: {ex.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarBusquedaProductos()
        {
            try
            {
                var products = _productService.SearchProducts(txtProducto.Text);
                dtgProducts.DataSource = null;
                dtgProducts.DataSource = products;
                dtgProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error en búsqueda de productos: {ex.Message}", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Selección de Cliente y Producto

        private void dtgCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_isCustomerLocked) return;
            if (e.RowIndex < 0 || e.RowIndex >= dtgCustomers.Rows.Count) return;

            var fila = dtgCustomers.Rows[e.RowIndex];
            if (fila.DataBoundItem is Customer cliente)
            {
                _selectedCustomer = cliente;
                _selectedCustomerId = cliente.CustomerId;
                txtName.Text = cliente.Name;
                txtLastname.Text = cliente.Lastname;
                txtDni.Text = cliente.Dni;
                txtTel.Text = cliente.Phone ?? string.Empty;
            }
        }

        private void btnCheckCustomer_Click(object? sender, EventArgs e)
        {
            if (_isCustomerLocked)
            {
                // Si ya está bloqueado, al hacer clic se desbloquea para permitir cambiar de cliente
                DesbloquearSeleccionCliente();
                return;
            }

            if (_selectedCustomer == null || _selectedCustomerId <= 0)
            {
                MaterialMessageBox.Show("Debe seleccionar un cliente de la lista antes de confirmar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bloquear y filtrar la grilla al cliente confirmado
            _isCustomerLocked = true;
            btnCheckCustomer.BackColor = Color.ForestGreen;
            txtSearchClient.Enabled = false;
            btnAddUser.Enabled = false;

            // Filtrar DataGridView para mostrar únicamente el registro elegido
            dtgCustomers.DataSource = null;
            dtgCustomers.DataSource = new List<Customer> { _selectedCustomer };
            dtgCustomers.ClearSelection();

            ActualizarEstadoSeccionProductos(habilitado: true);
        }

        private void DesbloquearSeleccionCliente()
        {
            _isCustomerLocked = false;
            ActualizarEstadoSeccionProductos(habilitado: false);
            btnCheckCustomer.BackColor = Color.FromArgb(13, 71, 161);
            txtSearchClient.Enabled = true;
            btnAddUser.Enabled = true;

            // Restaurar listado de clientes
            if (!string.IsNullOrWhiteSpace(txtSearchClient.Text))
            {
                EjecutarBusquedaClientes();
            }
            else
            {
                CargarClientesActivos();
            }
        }

        private void dtgProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (!_isCustomerLocked)
            {
                MaterialMessageBox.Show("Debe seleccionar y confirmar primero un cliente antes de interactuar con los productos.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (e.RowIndex < 0 || e.RowIndex >= dtgProducts.Rows.Count) return;

            var fila = dtgProducts.Rows[e.RowIndex];
            if (fila.DataBoundItem is Product producto)
            {
                _selectedProduct = producto;
                txtMarca.Text = producto.BrandName;
                txtPName.Text = producto.Name;
                txtStock.Text = producto.Stock.ToString();
                txtPVenta.Text = producto.SalePrice.ToString("F2");
                txtQtty.Text = "1";

                RecalcularSubtotalItem();
            }
        }

        private void txtQtty_TextChanged(object? sender, EventArgs e)
        {
            RecalcularSubtotalItem();
        }

        private void RecalcularSubtotalItem()
        {
            if (_selectedProduct != null && int.TryParse(txtQtty.Text.Trim(), out int cantidad) && cantidad > 0)
            {
                decimal subtotal = cantidad * _selectedProduct.SalePrice;
                txtSubTotal.Text = subtotal.ToString("F2");
            }
            else
            {
                txtSubTotal.Text = "0.00";
            }
        }

        #endregion

        #region Gestión del Carrito (Agregar, Acumular, Eliminar, Recalcular Total)

        private void btnAddProd_Click(object? sender, EventArgs e)
        {
            if (!_isCustomerLocked)
            {
                MaterialMessageBox.Show("Debe seleccionar y confirmar primero un cliente antes de interactuar con los productos.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_selectedProduct == null)
            {
                MaterialMessageBox.Show("Debe seleccionar un producto de la grilla de productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQtty.Text.Trim(), out int cantidadAAgregar) || cantidadAAgregar <= 0)
            {
                MaterialMessageBox.Show("Debe ingresar una cantidad entera mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar stock total considerando lo que ya esté en el carrito para este producto
            var itemExistente = _cartItems.FirstOrDefault(i => i.ProductId == _selectedProduct.ProductId);
            int cantidadPrevia = itemExistente?.Quantity ?? 0;
            int cantidadTotalRequerida = cantidadPrevia + cantidadAAgregar;

            if (cantidadTotalRequerida > _selectedProduct.Stock)
            {
                MaterialMessageBox.Show(
                    $"Stock insuficiente. Disponibles: {_selectedProduct.Stock}. Ya en carrito: {cantidadPrevia}. No es posible agregar {cantidadAAgregar}.",
                    "Stock Insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (itemExistente != null)
            {
                // Acumular cantidad sin crear una fila nueva
                itemExistente.Quantity += cantidadAAgregar;
            }
            else
            {
                // Agregar nuevo ítem al carrito
                _cartItems.Add(new SaleDetail
                {
                    ProductId = _selectedProduct.ProductId,
                    ProductCode = _selectedProduct.ProductCode,
                    BrandName = _selectedProduct.BrandName,
                    ProductName = _selectedProduct.Name,
                    Quantity = cantidadAAgregar,
                    UnitPrice = _selectedProduct.SalePrice
                });
            }

            RefrescarCarrito();
            LimpiarInputsProducto();
        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _cartItems.Count) return;

            // Verificar si se hizo clic en la columna de botón "Eliminar"
            if (dataGridView1.Columns[e.ColumnIndex] == Remove)
            {
                _cartItems.RemoveAt(e.RowIndex);
                RefrescarCarrito();
            }
        }

        private void dataGridView1_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] == Remove)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                // Dibujar icono de basura (TrashAlt) en color rojo dentro del botón
                using var trashIcon = IconChar.TrashAlt.ToBitmap(Color.Crimson, 18);
                int x = e.CellBounds.Left + (e.CellBounds.Width - trashIcon.Width) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - trashIcon.Height) / 2;
                e.Graphics?.DrawImage(trashIcon, new Point(x, y));

                e.Handled = true;
            }
        }

        private void RefrescarCarrito()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _cartItems.ToList(); // ToList para forzar refresco
            dataGridView1.ClearSelection();

            ActualizarTotalVenta();
        }

        private void ActualizarTotalVenta()
        {
            decimal total = _cartItems.Sum(i => i.Subtotal);
            lblTotalAmount.Text = TicketReportService.FormatCurrency(total);
        }

        private void LimpiarInputsProducto()
        {
            _selectedProduct = null;
            txtMarca.Clear();
            txtPName.Clear();
            txtStock.Clear();
            txtPVenta.Clear();
            txtQtty.Clear();
            txtSubTotal.Clear();
            dtgProducts.ClearSelection();
        }

        #endregion

        #region Proceso de Venta (Check-out), Impresión de Ticket y Cancelación

        private void btnSell_Click(object? sender, EventArgs e)
        {
            if (_selectedCustomerId <= 0)
            {
                MaterialMessageBox.Show("Debe seleccionar un cliente para realizar la venta.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CurrentSession.IsAuthenticated || CurrentSession.UserId <= 0)
            {
                MaterialMessageBox.Show("No se encontró una sesión de vendedor válida.", "Sesión Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_cartItems.Count == 0)
            {
                MaterialMessageBox.Show("El carrito de compras está vacío. Agregue al menos un producto.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalCalculado = _cartItems.Sum(i => i.Subtotal);
            string metodoPago = radTrans.Checked ? "Transferencia" : "Efectivo";

            DialogResult confirmacion = MaterialMessageBox.Show(
                $"¿Confirmar venta por un total de {TicketReportService.FormatCurrency(totalCalculado)}?\nMétodo de pago: {metodoPago}",
                "Confirmar Venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var nuevaVenta = new SaleHeader
                {
                    CustomerId = _selectedCustomerId,
                    UserId = CurrentSession.UserId,
                    PaymentTypeId = radTrans.Checked ? 1 : 2, // 1: Transferencia, 2: Efectivo
                    Details = _cartItems.ToList()
                };

                var (success, message, saleId, saleNumber, total) = _saleService.CreateSale(nuevaVenta);

                if (success)
                {
                    _lastCreatedSaleId = saleId;
                    _lastCreatedSaleNumber = saleNumber;

                    string nombreCliente = _selectedCustomer != null
                        ? $"{_selectedCustomer.Name} {_selectedCustomer.Lastname}".Trim()
                        : $"{txtName.Text} {txtLastname.Text}".Trim();
                    string dniCliente = _selectedCustomer?.Dni ?? txtDni.Text.Trim();

                    _lastCompletedSaleTicket = new SaleTicketData
                    {
                        SaleNumber = saleNumber,
                        SaleDate = DateTime.Now,
                        SellerName = lblNomyApeValue.Text,
                        SellerUsername = lblUserValue.Text,
                        SellerDni = lblDniValue.Text,
                        CustomerName = nombreCliente,
                        CustomerDni = dniCliente,
                        CustomerVatCondition = "Consumidor Final",
                        PaymentMethod = metodoPago,
                        Total = total,
                        Items = _cartItems.Select(i => new SaleDetail
                        {
                            ProductId = i.ProductId,
                            ProductCode = i.ProductCode,
                            BrandName = i.BrandName,
                            ProductName = i.ProductName,
                            Quantity = i.Quantity,
                            UnitPrice = i.UnitPrice
                        }).ToList()
                    };

                    // Mostrar número de venta en el panel de resumen
                    lblSaleNumberValue.Text = saleNumber;

                    // Habilitar impresión de ticket/factura
                    ActualizarEstadoBotonImprimir(habilitado: true);
                    ConfigurarBotonesAccionVentaFinalizada(finalizada: true);

                    MaterialMessageBox.Show(
                        $"¡Venta registrada con éxito!\nComprobante: {saleNumber}\nTotal: {TicketReportService.FormatCurrency(total)}",
                        "Venta Confirmada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Vaciar carrito y selecciones para la siguiente operación
                    _cartItems.Clear();
                    RefrescarCarrito();
                    LimpiarSeleccionCliente();
                    LimpiarInputsProducto();

                    // Refrescar grilla de productos para mostrar stock actualizado
                    CargarProductosActivos();
                }
                else
                {
                    MaterialMessageBox.Show(message, "Error al Procesar Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error inesperado al registrar la venta: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            if (_isSaleFinalized)
            {
                // Modo "Nueva Venta" tras finalizar la venta previa
                LimpiarVentaCompleta();
                return;
            }

            if (_cartItems.Count > 0 || _selectedCustomerId > 0 || _selectedProduct != null)
            {
                DialogResult dialog = MaterialMessageBox.Show(
                    "¿Desea cancelar la operación actual y vaciar el carrito?",
                    "Cancelar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog != DialogResult.Yes) return;
            }

            LimpiarVentaCompleta();
        }

        private void btnPrint_Click(object? sender, EventArgs e)
        {
            // Si hay un ID de venta registrado pero no está en memoria el objeto, intentar recuperarlo de la capa de negocio
            if (_lastCompletedSaleTicket == null && _lastCreatedSaleId > 0)
            {
                try
                {
                    var saleFromDb = _saleService.GetSaleById(_lastCreatedSaleId);
                    if (saleFromDb != null && saleFromDb.Details != null && saleFromDb.Details.Count > 0)
                    {
                        _lastCompletedSaleTicket = new SaleTicketData
                        {
                            SaleNumber = saleFromDb.SaleNumber,
                            SaleDate = saleFromDb.SaleDate != DateTime.MinValue ? saleFromDb.SaleDate : DateTime.Now,
                            SellerName = !string.IsNullOrWhiteSpace(saleFromDb.SellerFullName) ? saleFromDb.SellerFullName : lblNomyApeValue.Text,
                            SellerUsername = !string.IsNullOrWhiteSpace(saleFromDb.UserUsername) ? saleFromDb.UserUsername : lblUserValue.Text,
                            SellerDni = lblDniValue.Text,
                            CustomerName = saleFromDb.CustomerFullName,
                            CustomerDni = saleFromDb.CustomerDni,
                            CustomerVatCondition = "Consumidor Final",
                            PaymentMethod = saleFromDb.PaymentTypeName,
                            Total = saleFromDb.TotalSale,
                            Items = saleFromDb.Details
                        };
                    }
                }
                catch (Exception ex)
                {
                    _ticketReportService.LogError(ex);
                }
            }

            // Escenario 3: Intento de impresión sin venta válida o sin productos
            if (_lastCompletedSaleTicket == null ||
                string.IsNullOrWhiteSpace(_lastCompletedSaleTicket.SaleNumber) ||
                _lastCompletedSaleTicket.Items == null ||
                _lastCompletedSaleTicket.Items.Count == 0)
            {
                MaterialMessageBox.Show(
                    "Debe registrar o seleccionar una venta válida con al menos un producto antes de imprimir el ticket.",
                    "Venta Incompleta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Escenario 1 y 2: Generación de ticket PDF desde ticketSample.html y manejo de errores de plantilla
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var result = _ticketReportService.GenerateSaleTicketPdf(_lastCompletedSaleTicket);
                AbrirVistaPreviaOImpresionPdf(result.PdfFilePath, _lastCompletedSaleTicket);
            }
            catch (FileNotFoundException fnfEx)
            {
                _ticketReportService.LogError(fnfEx);
                MaterialMessageBox.Show(
                    "No se encontró la plantilla de ticket 'ticketSample.html' en la ruta base del sistema.",
                    "Plantilla No Encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _ticketReportService.LogError(ex);
                MaterialMessageBox.Show(
                    $"Ocurrió un error al generar o imprimir el ticket: {ex.Message}",
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void AbrirVistaPreviaOImpresionPdf(string pdfFilePath, SaleTicketData ticketData)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = pdfFilePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                _ticketReportService.LogError(ex);
                MostrarDialogoVistaPreviaImpresion(ticketData);
            }
        }

        private void MostrarDialogoVistaPreviaImpresion(SaleTicketData ticketData)
        {
            using var printDocument = new PrintDocument();
            printDocument.DocumentName = $"Ticket_{ticketData.SaleNumber}";
            printDocument.PrintPage += (s, ev) =>
            {
                if (ev.Graphics == null) return;

                using var titleFont = new Font("Segoe UI", 14F, FontStyle.Bold);
                using var sectionFont = new Font("Segoe UI", 10F, FontStyle.Bold);
                using var regularFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);

                float x = 40f;
                float y = 40f;

                ev.Graphics.DrawString("MOBILE SOLUTIONS - PUNTO DE VENTA", titleFont, Brushes.Black, x, y);
                y += 28f;
                ev.Graphics.DrawString($"Comprobante de Venta: {ticketData.SaleNumber}", sectionFont, Brushes.Black, x, y);
                y += 20f;
                ev.Graphics.DrawString($"Fecha de emisión: {ticketData.SaleDate:dd/MM/yyyy}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DATOS DEL VENDEDOR Y TRANSACCIÓN", sectionFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"N° Venta: {ticketData.SaleNumber}  |  Fecha: {ticketData.SaleDate:dd/MM/yyyy}", regularFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"Vendedor: {ticketData.SellerName} ({ticketData.SellerUsername}) - DNI: {ticketData.SellerDni}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DATOS DEL CLIENTE", sectionFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"Cliente: {ticketData.CustomerName}", regularFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"DNI / CUIT: {ticketData.CustomerDni}  |  Condición IVA: {ticketData.CustomerVatCondition}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DETALLE DE LA COMPRA", sectionFont, Brushes.Black, x, y);
                y += 20f;

                foreach (var item in ticketData.Items)
                {
                    string prod = !string.IsNullOrWhiteSpace(item.ProductName) ? item.ProductName : item.BrandName;
                    string line = $"{prod}  |  Cant: {item.Quantity}  |  Unit: {TicketReportService.FormatCurrency(item.UnitPrice)}  |  Subtotal: {TicketReportService.FormatCurrency(item.Subtotal)}";
                    ev.Graphics.DrawString(line, regularFont, Brushes.Black, x, y);
                    y += 18f;
                }

                y += 14f;
                ev.Graphics.DrawString($"Método de Pago: {ticketData.PaymentMethod}", sectionFont, Brushes.Black, x, y);
                y += 22f;
                ev.Graphics.DrawString($"MONTO TOTAL ABONADO: {TicketReportService.FormatCurrency(ticketData.Total)}", titleFont, Brushes.Black, x, y);
                ev.HasMorePages = false;
            };

            using var previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent
            };

            previewDialog.ShowDialog(this);
        }

        private void ActualizarEstadoBotonImprimir(bool habilitado)
        {
            // Se mantiene habilitado el clic para que el operador reciba la alerta de validación (Escenario 3) si intenta imprimir sin venta válida
            btnPrint.Enabled = true;
            icoBtnPrint.Enabled = true;
            icoBtnPrint.BackColor = habilitado ? Color.RoyalBlue : Color.FromArgb(70, 90, 130);
        }

        private void ActualizarEstadoSeccionProductos(bool habilitado)
        {
            dtgProducts.Enabled = habilitado;
            txtProducto.Enabled = habilitado;
            txtQtty.Enabled = habilitado;
            btnAddProd.Enabled = habilitado;

            if (!habilitado)
            {
                dtgProducts.ClearSelection();
                LimpiarInputsProducto();
            }
        }

        private void SeccionProducto_Click(object? sender, EventArgs e)
        {
            if (!_isCustomerLocked)
            {
                MaterialMessageBox.Show("Debe seleccionar y confirmar primero un cliente antes de interactuar con los productos.", "Cliente Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarSeleccionCliente()
        {
            _selectedCustomer = null;
            _selectedCustomerId = 0;
            txtName.Clear();
            txtLastname.Clear();
            txtDni.Clear();
            txtTel.Clear();
            txtSearchClient.Clear();
            DesbloquearSeleccionCliente();
            dtgCustomers.ClearSelection();
        }

        private void LimpiarVentaCompleta()
        {
            LimpiarSeleccionCliente();
            LimpiarInputsProducto();

            _cartItems.Clear();
            RefrescarCarrito();

            lblSaleNumberValue.Text = "-";
            _lastCreatedSaleId = 0;
            _lastCreatedSaleNumber = string.Empty;
            _lastCompletedSaleTicket = null;
            ActualizarEstadoBotonImprimir(habilitado: false);
            ActualizarEstadoSeccionProductos(habilitado: false);
            ConfigurarBotonesAccionVentaFinalizada(finalizada: false);
        }

        private void ConfigurarBotonesAccionVentaFinalizada(bool finalizada)
        {
            _isSaleFinalized = finalizada;

            if (finalizada)
            {
                btnSell.Enabled = false;
                icoBtnSell.Enabled = false;
                icoBtnSell.BackColor = Color.FromArgb(70, 90, 130);

                btnCancel.Text = "Nueva Venta";
                icoBtnCancel.Text = "NUEVA VENTA";
                icoBtnCancel.IconChar = IconChar.PlusCircle;
                icoBtnCancel.BackColor = Color.ForestGreen;
                btnCancel.Enabled = true;
                icoBtnCancel.Enabled = true;
            }
            else
            {
                btnSell.Enabled = true;
                icoBtnSell.Enabled = true;
                icoBtnSell.BackColor = Color.RoyalBlue;

                btnCancel.Text = "Cancelar Venta";
                icoBtnCancel.Text = "CANCELAR";
                icoBtnCancel.IconChar = IconChar.CreativeCommonsNc;
                icoBtnCancel.BackColor = Color.RoyalBlue;
                btnCancel.Enabled = true;
                icoBtnCancel.Enabled = true;
            }
        }

        #endregion

        #region Restricciones de Teclado (KeyPress)

        private void SoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloAlfanumerico_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblProductTitle_Click(object sender, EventArgs e)
        {
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
        }

        private void tlpInputsProducto_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tlpLeft_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion
    }
}
