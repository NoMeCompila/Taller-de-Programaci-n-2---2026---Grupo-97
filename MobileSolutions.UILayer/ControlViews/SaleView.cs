using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class SaleView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;
        public event EventHandler? NavigateToCustomerRequested;

        private List<ClienteInfo> _clientesMock = new();

        public SaleView()
        {
            InitializeComponent();

            ConfigurarIconos();
            CargarClientesMock();
            ConfigurarEventosYValidaciones();
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            CargarDatosUsuarioActual();
            //CargarClientes();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                CargarDatosUsuarioActual();
            }
        }

        public void SetVendedor(string username)
        {
            CargarDatosUsuarioActual();
        }

        public void CargarDatosUsuarioActual()
        {
            string username = SesionActual.Username;
            string nombre = SesionActual.Name;
            string apellido = SesionActual.Lastname;
            string dni = SesionActual.Dni;

            // Fallback: si por alguna razón no se precargaron en SesionActual pero tenemos el username
            if ((string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni)) && !string.IsNullOrWhiteSpace(username))
            {
                try
                {
                    var userService = new UserService();
                    var user = userService.GetUserByUsername(username);
                    if (user != null)
                    {
                        if (string.IsNullOrWhiteSpace(nombre)) nombre = user.Name;
                        if (string.IsNullOrWhiteSpace(apellido)) apellido = user.Lastname;
                        if (string.IsNullOrWhiteSpace(dni)) dni = user.Dni;
                    }
                }
                catch
                {
                    // Fallback silencioso para no interrumpir el flujo visual
                }
            }

            string nombreCompleto = $"{nombre} {apellido}".Trim();
            lblNomyApeValue.Text = string.IsNullOrWhiteSpace(nombreCompleto) ? "-" : nombreCompleto;
            lblUserValue.Text = string.IsNullOrWhiteSpace(username) ? "-" : username;
            lblDniValue.Text = string.IsNullOrWhiteSpace(dni) ? "-" : dni;
        }

        private void ConfigurarIconos()
        {


            icoBtnSell.IconChar = IconChar.DollarSign;
            icoBtnCancel.IconChar = IconChar.Cancel;
            icoBtnPrint.IconChar = IconChar.Print;
            btnAddProd.Icon = IconChar.CartPlus.ToBitmap(Color.White);
            btnAddUser.Icon = IconChar.UserPlus.ToBitmap(Color.White);
            btnProduct.Icon = IconChar.MobileScreenButton.ToBitmap(Color.White);

            picSaleTitle.IconChar = IconChar.Shopify;
            picSaleTitle.IconColor = Color.White;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

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
            btnAddUser.Click += BtnAddUser_Click;
            txtProducto.TextChanged += txtCustomer_TextChanged;


            txtSearchClient.KeyPress += SoloAlfanumerico_KeyPress;
            txtProducto.KeyPress += Cliente_KeyPress;
        }

        private void BtnAddUser_Click(object? sender, EventArgs e)
        {
            if (NavigateToCustomerRequested != null)
            {
                NavigateToCustomerRequested.Invoke(this, EventArgs.Empty);
                return;
            }

            // Fallback: Redirección automática buscando el TabControl contenedor
            Control? parent = this.Parent;
            while (parent != null)
            {
                if (parent is TabControl tabControl)
                {
                    foreach (TabPage page in tabControl.TabPages)
                    {
                        if (page.Controls.OfType<CustomerView>().Any() ||
                            page.Text.Equals("Clientes", StringComparison.OrdinalIgnoreCase))
                        {
                            tabControl.SelectedTab = page;
                            return;
                        }
                    }
                }
                parent = parent.Parent;
            }
        }



        private void txtCustomer_TextChanged(object? sender, EventArgs e)
        {
            //CargarClientes(txtCustomer.Text.Trim());
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

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void tlpInputsProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpLeft_Paint(object sender, PaintEventArgs e)
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