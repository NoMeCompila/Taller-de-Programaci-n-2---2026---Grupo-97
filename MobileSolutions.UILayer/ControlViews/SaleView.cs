using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    public partial class SaleView : UserControl
    {
        private List<ClienteInfo> _clientesMock = new();

        public SaleView()
        {
            InitializeComponent();

            ConfigurarIconos();
            CargarTiposDePago();
            CargarClientesMock();
            ConfigurarEventosYValidaciones();
            CargarClientes();
        }

        private void ConfigurarIconos()
        {
            btnAddDetail.Icon = IconChar.CartPlus.ToBitmap(Color.White);
            btnTotalSale.Icon = IconChar.Coins.ToBitmap(Color.White);
            btnConfirmSale.Icon = IconChar.CircleCheck.ToBitmap(Color.White);
            btnCancelSale.Icon = IconChar.Trash.ToBitmap(Color.White);
            btnInvoice.Icon = IconChar.FileInvoiceDollar.ToBitmap(Color.White);

            btnCustomer.Icon = IconChar.UserTag.ToBitmap(Color.White);
            btnSaleNumber.Icon = IconChar.Barcode.ToBitmap(Color.White);
            btnPaymentType.Icon = IconChar.MoneyCheckDollar.ToBitmap(Color.White);
            btnQuantity.Icon = IconChar.LayerGroup.ToBitmap(Color.White);
            btnUnitaryPrice.Icon = IconChar.DollarSign.ToBitmap(Color.White);
            btnProductCode.Icon = IconChar.Barcode.ToBitmap(Color.White);
            btnSeller.Icon = IconChar.UserEdit.ToBitmap(Color.White);

            picSaleTitle.IconChar = IconChar.Shopify;
            picSaleTitle.IconColor = Color.White;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
        }

        private void CargarTiposDePago()
        {
            cmbPaymentType.Items.Clear();
            cmbPaymentType.Items.AddRange(new object[] { "Efectivo", "Tarjeta Débito", "Tarjeta Crédito", "Transferencia" });
            cmbPaymentType.SelectedIndex = 0;
        }

        private void CargarClientesMock()
        {
            _clientesMock = new List<ClienteInfo>
            {
                new ClienteInfo { Dni = "30112233", Nombre = "María", Apellido = "López", Email = "maria.lopez@mail.com", Telefono = "3515550101", Localidad = "Córdoba" },
                new ClienteInfo { Dni = "28445566", Nombre = "Carlos", Apellido = "Gómez", Email = "carlos.gomez@mail.com", Telefono = "3515550102", Localidad = "Córdoba" },
                new ClienteInfo { Dni = "31223344", Nombre = "Ana", Apellido = "Martínez", Email = "ana.martinez@mail.com", Telefono = "3515550103", Localidad = "La Calera" },
                new ClienteInfo { Dni = "27778899", Nombre = "Luis", Apellido = "Fernández", Email = "luis.fernandez@mail.com", Telefono = "3515550104", Localidad = "Villa María" },
                new ClienteInfo { Dni = "33556677", Nombre = "Julia", Apellido = "Rodríguez", Email = "julia.rodriguez@mail.com", Telefono = "3515550105", Localidad = "Córdoba" }
            };
        }

        private void ConfigurarEventosYValidaciones()
        {
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            btnInvoice.Click += btnInvoice_Click;

            txtQuantity.KeyPress += SoloNumeros_KeyPress;
            txtUnitaryPrice.KeyPress += Precio_KeyPress;
            txtSaleNumber.KeyPress += SoloAlfanumerico_KeyPress;
            txtProductCode.KeyPress += SoloAlfanumerico_KeyPress;
            txtCustomer.KeyPress += Cliente_KeyPress;
        }

        public void SetVendedor(string vendedor)
        {
            txtSeller.Text = string.IsNullOrWhiteSpace(vendedor) ? "S/N" : vendedor.Trim();
        }

        private void txtCustomer_TextChanged(object? sender, EventArgs e)
        {
            CargarClientes(txtCustomer.Text.Trim());
        }

        private void CargarClientes(string? filtro = null)
        {
            dgvCustomerInfo.Rows.Clear();

            IEnumerable<ClienteInfo> clientes = _clientesMock;

            if (!string.IsNullOrEmpty(filtro))
            {
                clientes = clientes.Where(c =>
                    c.Dni.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    c.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    c.Apellido.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    c.Email.Contains(filtro, StringComparison.OrdinalIgnoreCase));
            }

            foreach (var cliente in clientes)
            {
                dgvCustomerInfo.Rows.Add(cliente.Dni, cliente.Nombre, cliente.Apellido, cliente.Email, cliente.Telefono, cliente.Localidad);
            }
        }

        private void btnInvoice_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "La generación de la factura estará disponible en una próxima versión.",
                "Factura",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void SoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Precio_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            char separador = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            bool esSeparador = e.KeyChar == '.' || e.KeyChar == ',';

            if (esSeparador)
            {
                var textBox = (MaterialTextBox2)sender!;
                if (textBox.Text.Contains('.') || textBox.Text.Contains(','))
                {
                    e.Handled = true;
                }
                else if (separador == '.')
                {
                    e.KeyChar = '.';
                }
                else
                {
                    e.KeyChar = ',';
                }
                return;
            }

            e.Handled = true;
        }

        private void SoloAlfanumerico_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cliente_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            if (e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-')
                return;

            e.Handled = true;
        }

        private void lblProductTitle_Click(object sender, EventArgs e)
        {

        }
    }

    public class ClienteInfo
    {
        public string Dni { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Localidad { get; set; } = string.Empty;
    }
}