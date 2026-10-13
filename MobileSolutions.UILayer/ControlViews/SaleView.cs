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

        private List<CustomerInfo> _mockCustomers = new();

        public SaleView()
        {
            InitializeComponent();

            ConfigureIcons();
            LoadMockCustomers();
            ConfigureEventsAndValidations();
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            LoadCurrentUserData();
            //CargarClientes();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                LoadCurrentUserData();
            }
        }

        public void SetSeller(string username)
        {
            LoadCurrentUserData();
        }

        public void SetVendedor(string username) => SetSeller(username);

        public void LoadCurrentUserData()
        {
            string username = CurrentSession.Username;
            string name = CurrentSession.Name;
            string lastName = CurrentSession.Lastname;
            string dni = CurrentSession.Dni;

            // Fallback: si por alguna razón no se precargaron en CurrentSession pero tenemos el username
            if ((string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(dni)) && !string.IsNullOrWhiteSpace(username))
            {
                try
                {
                    var userService = new UserService();
                    var user = userService.GetUserByUsername(username);
                    if (user != null)
                    {
                        if (string.IsNullOrWhiteSpace(name)) name = user.Name;
                        if (string.IsNullOrWhiteSpace(lastName)) lastName = user.Lastname;
                        if (string.IsNullOrWhiteSpace(dni)) dni = user.Dni;
                    }
                }
                catch
                {
                    // Fallback silencioso para no interrumpir el flujo visual
                }
            }

            string fullName = $"{name} {lastName}".Trim();
            lblNomyApeValue.Text = string.IsNullOrWhiteSpace(fullName) ? "-" : fullName;
            lblUserValue.Text = string.IsNullOrWhiteSpace(username) ? "-" : username;
            lblDniValue.Text = string.IsNullOrWhiteSpace(dni) ? "-" : dni;
        }

        private void ConfigureIcons()
        {
            icoBtnSell.IconChar = IconChar.Donate;
            icoBtnCancel.IconChar = IconChar.Cancel;
            icoBtnPrint.IconChar = IconChar.FilePdf;
            btnAddProd.Icon = IconChar.CartPlus.ToBitmap(Color.White);
            btnAddUser.Icon = IconChar.UserPlus.ToBitmap(Color.White);
            btnProduct.Icon = IconChar.MobileScreenButton.ToBitmap(Color.White);

            picSaleTitle.IconChar = IconChar.Shopify;
            picSaleTitle.IconColor = Color.White;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void LoadMockCustomers()
        {
            _mockCustomers = new List<CustomerInfo>
            {
                new CustomerInfo { Dni = "30112233", Name = "María", LastName = "López", Email = "maria.lopez@mail.com", Phone = "3515550101", Location = "Córdoba" },
                new CustomerInfo { Dni = "28445566", Name = "Carlos", LastName = "Gómez", Email = "carlos.gomez@mail.com", Phone = "3515550102", Location = "Córdoba" },
                new CustomerInfo { Dni = "31223344", Name = "Ana", LastName = "Martínez", Email = "ana.martinez@mail.com", Phone = "3515550103", Location = "La Calera" },
                new CustomerInfo { Dni = "27778899", Name = "Luis", LastName = "Fernández", Email = "luis.fernandez@mail.com", Phone = "3515550104", Location = "Villa María" },
                new CustomerInfo { Dni = "33556677", Name = "Julia", LastName = "Rodríguez", Email = "julia.rodriguez@mail.com", Phone = "3515550105", Location = "Córdoba" }
            };
        }

        private void ConfigureEventsAndValidations()
        {
            btnAddUser.Click += BtnAddUser_Click;
            txtProducto.TextChanged += TxtCustomer_TextChanged;

            txtSearchClient.KeyPress += OnlyAlphanumeric_KeyPress;
            txtProducto.KeyPress += Customer_KeyPress;
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

        private void TxtCustomer_TextChanged(object? sender, EventArgs e)
        {
            //LoadCustomers(txtCustomer.Text.Trim());
        }

        private void btnInvoice_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "La generación de la factura estará disponible en una próxima versión.",
                "Factura",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnlyNumbers_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Price_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            bool isSeparator = e.KeyChar == '.' || e.KeyChar == ',';

            if (isSeparator)
            {
                var textBox = (MaterialTextBox2)sender!;
                if (textBox.Text.Contains('.') || textBox.Text.Contains(','))
                {
                    e.Handled = true;
                }
                else if (separator == '.')
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

        private void OnlyAlphanumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Customer_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            if (e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-')
                return;

            e.Handled = true;
        }
    }

    public class CustomerInfo
    {
        public string Dni { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}