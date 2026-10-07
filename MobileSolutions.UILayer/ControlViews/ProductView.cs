using FontAwesome.Sharp;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class ProductView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        private readonly ProductService _productService;
        private int _selectedProductId = 0;
        private System.Windows.Forms.Timer? _searchDebounceTimer;
        private readonly List<Brand> _brands = new();

        public ProductView()
        {
            InitializeComponent();

            // Asignar íconos FontAwesome a los botones de acción
            //btnSave.Icon = IconChar.Save.ToBitmap(Color.White);
            //btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White);
            //btnDelete.Icon = IconChar.Trash.ToBitmap(Color.White);
            //btnUpdate.Icon = IconChar.Pencil.ToBitmap(Color.White);
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);
            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

            // Íconos de los botones pequeños junto a cada campo
            btnBrand.Icon = IconChar.Tag.ToBitmap(Color.White);
            btnProductCode.Icon = IconChar.Barcode.ToBitmap(Color.White);
            btnName.Icon = IconChar.Box.ToBitmap(Color.White);
            btnStock.Icon = IconChar.LayerGroup.ToBitmap(Color.White);
            btnPurchasePrice.Icon = IconChar.DollarSign.ToBitmap(Color.White);
            btnSalePrice.Icon = IconChar.DollarSign.ToBitmap(Color.White);
            btnImageURL.Icon = IconChar.Image.ToBitmap(Color.White);

            // Ícono del título del panel
            picProductTitle.IconChar = IconChar.BoxOpen;
            picProductTitle.IconColor = Color.White;

            // Estilo del PictureBox de previsualización de imagen
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.BackColor = Color.FromArgb(240, 240, 240);

            _productService = new ProductService();

            dtgProductsConfig();
            InitializeSearchBehavior();
            InitializeStatusSwitch();
            dtgProducts.CellClick += dtgProducts_CellClick;
            btnSearch.Click += btnSearch_Click;
            btnImageURL.Click += btnImageURL_Click;
            LoadBrands();
            fillActiveProducts();
            LimpiarFormulario();
        }

        private void dtgProductsConfig()
        {
            // Evita que el DataGridView autogenere columnas extras a la derecha
            dtgProducts.AutoGenerateColumns = false;

            // Configuración visual: texto en negro sobre fondo blanco
            dtgProducts.DefaultCellStyle.ForeColor = Color.Black;
            dtgProducts.DefaultCellStyle.BackColor = Color.White;
            dtgProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243); // Azul primario para la fila seleccionada
            dtgProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgProducts.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Configuración de encabezados (cabeceras legibles)
            dtgProducts.EnableHeadersVisualStyles = false;
            dtgProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161); // Azul oscuro
            dtgProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtgProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Vinculamos cada columna visual con la propiedad de nuestro objeto Product
            ColumnBrand.DataPropertyName = nameof(Product.BrandName);
            ColumnCode.DataPropertyName = nameof(Product.ProductCode);
            ColumnName.DataPropertyName = nameof(Product.Name);
            ColumnStock.DataPropertyName = nameof(Product.Stock);
            ColumnPurchasePrice.DataPropertyName = nameof(Product.PurchasePrice);
            ColumnSalePrice.DataPropertyName = nameof(Product.SalePrice);
            ColumnImage.DataPropertyName = nameof(Product.Image);
        }

        public void fillActiveProducts()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Product> productos = swtActive.Checked
                    ? _productService.GetActiveProducts()
                    : _productService.GetInactiveProducts();

                // Enlazamos la lista fuertemente tipada
                dtgProducts.DataSource = null; // Limpia enlace previo para forzar refresco
                dtgProducts.DataSource = productos;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error al cargar la lista de productos: {ex.Message}",
                                "Error de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadBrands()
        {
            try
            {
                _brands.Clear();
                cmbBrand.Items.Clear();

                List<Brand> marcas = _productService.GetActiveBrands();

                foreach (Brand marca in marcas)
                {
                    _brands.Add(marca);
                    cmbBrand.Items.Add(marca.Name);
                }

                cmbBrand.SelectedIndex = -1;
                // Forzár el repintado visual del ComboBox
                cmbBrand.Invalidate();
                cmbBrand.Refresh();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error al cargar las marcas: {ex.Message}",
                                "Error de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────────
        //  Validaciones KeyPress
        // ─────────────────────────────────────────────

        /// (stock INT >= 0)
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // Decimales con hasta 2 decimales (purchase_price y sale_price DECIMAL(18,2)).
        private void txtDecimalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as MaterialTextBox2;

            if (txt == null)
            {
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                // Buscamos si ya existe una coma o un punto (devuelve la posición, o -1 si no existe)
                int sepIndex = txt.Text.IndexOfAny(new[] { '.', ',' });

                // Si YA hay un separador decimal, Y el usuario está escribiendo a la derecha de él
                if (sepIndex >= 0 && txt.SelectionStart > sepIndex)
                {
                    // Capturamos solamente los números que están después de la coma/punto
                    string decimals = txt.Text.Substring(sepIndex + 1);

                    int selectedAfterSep = 0;

                    // Si el usuario seleccionó texto con el mouse dentro de la parte decimal
                    if (txt.SelectionLength > 0 && txt.SelectionStart > sepIndex)
                    {
                        // Guardamos cuántos caracteres va a sobreescribir al teclear
                        selectedAfterSep = txt.SelectionLength;
                    }

                    // Si los decimales que ya existen menos los que va a reemplazar suman 2 o más...
                    if (decimals.Length - selectedAfterSep >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                return;
            }

            // Si la tecla presionada no fue un número, evaluamos si fue una coma o un punto:
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // Si el texto ya tiene un punto o una coma previamente escrito...
                if (txt.Text.Contains('.') || txt.Text.Contains(','))
                {
                    e.Handled = true;
                }
                return;
            }

            // Si la tecla no es un número, ni una tecla de control, ni un separador (ej: letras)...
            // ...se bloquea y no se escribe nada en pantalla.
            e.Handled = true;
        }

        // ──-──────────────────────────────────────────
        //  Previsualización de imagen
        // ─────────────────────────────────────────────

        /// <summary>
        /// Carga la imagen al perder el foco del textbox de imagen (Leave event).
        /// Soporta rutas locales y URLs HTTP/HTTPS.
        /// </summary>
        private void txtImageURL_Leave(object sender, EventArgs e)
        {
            CargarPreviewImagen(txtImageURL.Text);
        }

        private void CargarPreviewImagen(string? inputRaw)
        {
            string input = (inputRaw ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(input))
            {
                picProductImage.Image = null;
                return;
            }

            try
            {
                if (input.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                    input.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                {
                    // Cargar desde URL usando HttpClient (WebClient está obsoleto en .NET 6+)
                    using (var client = new HttpClient())
                    using (var stream = client.GetStreamAsync(input).GetAwaiter().GetResult())
                    using (var ms = new System.IO.MemoryStream())
                    {
                        stream.CopyTo(ms);
                        ms.Position = 0;
                        picProductImage.Image = new Bitmap(ms);
                    }
                }
                else
                {
                    // Cargar desde ruta local
                    picProductImage.Image = Image.FromFile(input);
                }
            }
            catch
            {
                picProductImage.Image = null;
                MaterialMessageBox.Show(
                    "No se pudo cargar la imagen. Verificá que la URL o la ruta sean válidas.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnImageURL_Click(object? sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Seleccionar imagen del producto";
                dialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtImageURL.Text = dialog.FileName;
                    CargarPreviewImagen(txtImageURL.Text);
                }
            }
        }

        // ─────────────────────────────────────────────
        //  Botones de acción
        // ─────────────────────────────────────────────

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 1. Construir entidad fuertemente tipada desde el formulario
                Product nuevoProducto = ObtenerProductoDesdeFormulario();

                // 2. Invocar la Capa de Negocio (BLL)
                var (success, message) = _productService.CreateProduct(nuevoProducto);

                if (success)
                {
                    // 3. Notificación de éxito
                    MaterialMessageBox.Show(
                        "Producto agregado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // 4. Refrescar la grilla para mostrar el nuevo registro
                    fillActiveProducts();

                    // 5. Limpiar el formulario y restablecer controles
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al registrar el producto: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private bool ValidateFields(bool isUpdate = false)
        {
            if (cmbBrand.SelectedIndex < 0 || cmbBrand.SelectedIndex >= _brands.Count)
            {
                MaterialMessageBox.Show(
                    "Por favor, seleccione una marca.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbBrand.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductCode.Text)
                || string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtStock.Text)
                || string.IsNullOrWhiteSpace(txtPurchasePrice.Text)
                || string.IsNullOrWhiteSpace(txtSalePrice.Text))
            {
                MaterialMessageBox.Show(
                    "Por favor, complete todos los campos obligatorios (código, nombre, stock, precio de compra y precio de venta).",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            // Validación de stock >= 0 (CHK_Product_Stock)
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MaterialMessageBox.Show(
                    "El stock debe ser un número entero mayor o igual a cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            // Validación de purchase_price >= 0 (CHK_Product_PurchasePrice)
            string purchaseText = txtPurchasePrice.Text.Replace(',', '.');
            if (!decimal.TryParse(purchaseText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal purchasePrice)
                || purchasePrice < 0)
            {
                MaterialMessageBox.Show(
                    "El precio de compra debe ser un número mayor o igual a cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPurchasePrice.Focus();
                return false;
            }

            // Validación de sale_price >= purchase_price (CHK_Product_SalePrice)
            string saleText = txtSalePrice.Text.Replace(',', '.');
            if (!decimal.TryParse(saleText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal salePrice)
                || salePrice < purchasePrice)
            {
                MaterialMessageBox.Show(
                    "El precio de venta debe ser mayor o igual al precio de compra.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSalePrice.Focus();
                return false;
            }

            return true;
        }

        private Product ObtenerProductoDesdeFormulario()
        {
            string purchaseText = txtPurchasePrice.Text.Replace(',', '.');
            decimal purchasePrice = decimal.TryParse(purchaseText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedPurchase)
                ? parsedPurchase
                : 0m;

            string saleText = txtSalePrice.Text.Replace(',', '.');
            decimal salePrice = decimal.TryParse(saleText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedSale)
                ? parsedSale
                : 0m;

            int brandId = cmbBrand.SelectedIndex >= 0 && cmbBrand.SelectedIndex < _brands.Count
                ? _brands[cmbBrand.SelectedIndex].BrandId
                : 0;

            return new Product
            {
                ProductId = _selectedProductId,
                BrandId = brandId,
                ProductCode = txtProductCode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Stock = int.TryParse(txtStock.Text, out int stock) ? stock : 0,
                PurchasePrice = purchasePrice,
                SalePrice = salePrice,
                Image = string.IsNullOrWhiteSpace(txtImageURL.Text) ? null : txtImageURL.Text.Trim()
            };
        }

        private void dtgProducts_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Validación obligatoria: descarta clics en los encabezados (-1) o índices fuera de rango
            if (e.RowIndex < 0 || e.RowIndex >= dtgProducts.Rows.Count)
            {
                return;
            }

            DataGridViewRow fila = dtgProducts.Rows[e.RowIndex];

            // Validación contra filas nuevas o no vinculadas
            if (fila.IsNewRow || fila.DataBoundItem == null)
            {
                return;
            }

            // Mapeo seguro utilizando el objeto de negocio enlazado
            if (fila.DataBoundItem is Product productoSeleccionado)
            {
                MapearProductoAControles(productoSeleccionado);
                ActualizarEstadoBotones(modoEdicion: true);
            }
        }

        private void MapearProductoAControles(Product product)
        {
            _selectedProductId = product.ProductId;

            // ComboBox de marca seleccionado por BrandId
            cmbBrand.SelectedIndex = -1;
            for (int i = 0; i < _brands.Count; i++)
            {
                if (_brands[i].BrandId == product.BrandId)
                {
                    cmbBrand.SelectedIndex = i;
                    // Forzár el repintado visual del ComboBox
                    cmbBrand.Invalidate();
                    cmbBrand.Refresh();
                    break;
                }
            }

            txtProductCode.Text = product.ProductCode;
            txtName.Text = product.Name;
            txtStock.Text = product.Stock.ToString();
            txtPurchasePrice.Text = product.PurchasePrice.ToString(CultureInfo.InvariantCulture);
            txtSalePrice.Text = product.SalePrice.ToString(CultureInfo.InvariantCulture);
            txtImageURL.Text = product.Image ?? string.Empty;

            // Previsualización de la imagen asociada al producto
            CargarPreviewImagen(product.Image);
        }

        private void ActualizarEstadoBotones(bool modoEdicion)
        {
            bool showActiveButtons = swtActive.Checked;

            // Botones de productos activos
            icoBtnClear.Visible = showActiveButtons;
            icoBtnClear.Enabled = showActiveButtons;
            btnClear.Visible = showActiveButtons;
            btnClear.Enabled = showActiveButtons;

            icoBtnSave.Visible = showActiveButtons;
            icoBtnSave.Enabled = showActiveButtons && !modoEdicion;
            btnSave.Visible = showActiveButtons;
            btnSave.Enabled = showActiveButtons && !modoEdicion;

            icoBtnUpdate.Visible = showActiveButtons;
            icoBtnUpdate.Enabled = showActiveButtons && modoEdicion;
            btnUpdate.Visible = showActiveButtons;
            btnUpdate.Enabled = showActiveButtons && modoEdicion;

            icoBtnDelete.Visible = showActiveButtons;
            icoBtnDelete.Enabled = showActiveButtons && modoEdicion;
            btnDelete.Visible = showActiveButtons;
            btnDelete.Enabled = showActiveButtons && modoEdicion;

            // Botones de reactivación (productos inactivos)
            icoBtnReactivate.Visible = !showActiveButtons;
            icoBtnReactivate.Enabled = !showActiveButtons && modoEdicion;
            btnReactivate.Visible = !showActiveButtons;
            btnReactivate.Enabled = !showActiveButtons && modoEdicion;
        }

        private void LimpiarFormulario()
        {
            _selectedProductId = 0;

            cmbBrand.SelectedIndex = -1;
            // Forzár el repintado visual del ComboBox
            cmbBrand.Invalidate();
            cmbBrand.Refresh();

            txtProductCode.Clear();
            txtName.Clear();
            txtStock.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            txtImageURL.Clear();

            // Limpiar previsualización
            picProductImage.Image = null;

            dtgProducts.ClearSelection();
            ActualizarEstadoBotones(modoEdicion: false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedProductId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un producto de la grilla para poder modificarlo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields(isUpdate: true))
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 1. Construir entidad fuertemente tipada desde el formulario con el Id seleccionado
                Product productoModificado = ObtenerProductoDesdeFormulario();

                // 2. Invocar la Capa de Negocio (BLL)
                var (success, message) = _productService.UpdateProduct(productoModificado);

                if (success)
                {
                    // 3. Notificación de éxito
                    MaterialMessageBox.Show(
                        "Producto actualizado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // 4. Refrescar la grilla para mostrar los cambios
                    fillActiveProducts();

                    // 5. Limpiar el formulario y restablecer controles
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al actualizar el producto: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un producto de la grilla para poder darlo de baja.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirmación explícita antes de proceder con la baja lógica
            DialogResult confirmResult = MaterialMessageBox.Show(
                "¿Está seguro de que desea dar de baja al producto seleccionado?",
                "Confirmación de Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Invocar la Capa de Negocio (BLL)
                var (success, message) = _productService.SoftDeleteProduct(_selectedProductId);

                if (success)
                {
                    MaterialMessageBox.Show(
                        "Producto dado de baja correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Refrescar grilla de productos activos
                    fillActiveProducts();

                    // Limpiar formulario y restablecer estado de botones
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al dar de baja al producto: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // ─────────────────────────────────────────────
        //  Búsqueda con debounce
        // ─────────────────────────────────────────────

        private void InitializeSearchBehavior()
        {
            // Configuración del temporizador de debounce (350 ms) para evitar saturación en SQL Server
            _searchDebounceTimer = new System.Windows.Forms.Timer();
            _searchDebounceTimer.Interval = 350;
            _searchDebounceTimer.Tick += SearchDebounceTimer_Tick;

            // Enlazar eventos de entrada de texto y pulsación de teclas
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            // Reinicia la cuenta regresiva con cada pulsación del usuario
            _searchDebounceTimer?.Stop();
            _searchDebounceTimer?.Start();
        }

        private void SearchDebounceTimer_Tick(object? sender, EventArgs e)
        {
            _searchDebounceTimer?.Stop();
            ExecuteProductSearch();
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            // Disparar búsqueda inmediata si presiona Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _searchDebounceTimer?.Stop();
                ExecuteProductSearch();
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            _searchDebounceTimer?.Stop();
            ExecuteProductSearch();
        }

        private void ExecuteProductSearch()
        {
            string searchTerm = txtSearch.Text;
            bool isInactiveMode = !swtActive.Checked;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Consulta sensible al estado del switch en la capa de negocio BLL
                List<Product> productList = _productService.SearchProductsByStatus(searchTerm, isInactiveMode);

                // Asignar los resultados tipados al DataGridView
                dtgProducts.DataSource = null;
                dtgProducts.DataSource = productList;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error al buscar productos: {ex.Message}",
                    "Error de Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // ─────────────────────────────────────────────
        //  Switch de activos/inactivos y reactivación
        // ─────────────────────────────────────────────

        private void InitializeStatusSwitch()
        {
            // Asegurar texto y visibilidad inicial segun el estado del switch
            swtActive.Text = swtActive.Checked ? "Activos" : "Inactivos";
            ActualizarEstadoBotones(modoEdicion: _selectedProductId > 0);
            swtActive.CheckedChanged += swtActive_CheckedChanged;

            // Enlazar eventos de reactivacion
            btnReactivate.Click += btnReactivate_Click;
            icoBtnReactivate.Click += btnReactivate_Click;
        }

        private void swtActive_CheckedChanged(object? sender, EventArgs e)
        {
            swtActive.Text = swtActive.Checked ? "Activos" : "Inactivos";
            ActualizarEstadoBotones(modoEdicion: _selectedProductId > 0);
            txtSearch.Clear();
            LimpiarFormulario();
            fillActiveProducts();
        }

        private void btnReactivate_Click(object? sender, EventArgs e)
        {
            if (_selectedProductId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un producto inactivo de la grilla para reactivarlo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Invocar reactivacion en la capa de negocio BLL
                var (success, message) = _productService.ReactivateProduct(_selectedProductId);

                if (success)
                {
                    // Refrescar grilla de productos inactivos
                    fillActiveProducts();

                    // Limpiar campos del formulario
                    LimpiarFormulario();

                    // Notificacion visual de exito solicitada
                    MaterialMessageBox.Show(
                        "Producto Reactivado",
                        "info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al reactivar el producto: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        // ─────────────────────────────────────────────
        // Handlers vacíos cableados desde el Designer
        // ─────────────────────────────────────────────

        private void btnBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnSalePrice_Click(object sender, EventArgs e)
        {

        }

        private void dtgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProductTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
