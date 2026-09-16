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

namespace MobileSolutions.UILayer
{
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();

            // Asignar íconos FontAwesome a los botones de acción
            //btnSave.Icon = IconChar.Save.ToBitmap(Color.White);
            //btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White);
            //btnDelete.Icon = IconChar.Trash.ToBitmap(Color.White);
            //btnUpdate.Icon = IconChar.Pencil.ToBitmap(Color.White);
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);

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
            string input = txtImageURL.Text.Trim();

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
                MessageBox.Show(
                    "No se pudo cargar la imagen. Verificá que la URL o la ruta sean válidas.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ─────────────────────────────────────────────
        //  Botones de acción
        // ─────────────────────────────────────────────

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validar campos obligatorios vacíos -
            // saco la validacion de Marca ya que el checkbox esta vacio y siempre va a faltar este campo obligatorio: cmbBrand.SelectedIndex < 0
            if (string.IsNullOrWhiteSpace(txtProductCode.Text)
                || string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtStock.Text)
                || string.IsNullOrWhiteSpace(txtPurchasePrice.Text)
                || string.IsNullOrWhiteSpace(txtSalePrice.Text))
            {
                MessageBox.Show(
                    "Por favor, complete los campos obligatorios (marca, código, nombre, stock, precio de compra y precio de venta).",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar stock >= 0 (CHK_Product_Stock)
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show(
                    "El stock debe ser un número entero mayor o igual a cero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 3. Validar purchase_price >= 0 (CHK_Product_PurchasePrice)
            string purchaseText = txtPurchasePrice.Text.Replace(',', '.'); //En caso de haberse ingresado como separador decimal una coma, la reemplazamos por un punto para que decimal.TryParse funcione correctamente.
            if (!decimal.TryParse(purchaseText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal purchasePrice)
                || purchasePrice < 0)
            {
                MessageBox.Show(
                    "El precio de compra debe ser un número mayor o igual a cero.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 4. Validar sale_price >= purchase_price (CHK_Product_SalePrice)
            string saleText = txtSalePrice.Text.Replace(',', '.'); // En caso de haberse ingresado como separador decimal una coma, la reemplazamos por un punto para que decimal.TryParse funcione correctamente.
            if (!decimal.TryParse(saleText, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal salePrice)
                || salePrice < purchasePrice)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor o igual al precio de compra.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // TODO: implementar lógica de guardado en BD
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            cmbBrand.SelectedIndex = -1;
            txtProductCode.Clear();
            txtName.Clear();
            txtStock.Clear();
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            txtImageURL.Clear();

            // Limpiar previsualización
            picProductImage.Image = null;

            // Resetear switch
            //swtActive.Checked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: implementar lógica de eliminación en BD
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: implementar lógica de modificación en BD
        }


        // ─────────────────────────────────────────────
        // Funciones basura, apretadas sin querer, eliminarlas...
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
