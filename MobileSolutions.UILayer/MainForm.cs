using System.Diagnostics;
using System.IO;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class MainForm : MaterialForm
    {
        private readonly List<TabPage> _originalTabPages = new();
        private readonly string _currentUser = "admin";

        public bool IsLoggingOut { get; private set; } = false;

        public MainForm() : this("admin")
        {
        }

        public MainForm(string username)
        {
            //********************************************** Design ************************************************
            InitializeComponent();
            this.FormClosed += MainForm_FormClosed;
            _currentUser = string.IsNullOrWhiteSpace(username) ? "admin" : username.Trim();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            SkinManager.ColorScheme = new ColorScheme(
               Primary.Blue800,
               Primary.Blue900,
               Primary.Blue500,
               Accent.LightBlue200,
               TextShade.WHITE);

            // 1. Configure icons and cache all original tabs
            InitializeTabCacheAndIcons();

            // 2. Apply Role-Based Access Control (RBAC) to drawer navigation
            ApplyRoleBasedAccess(_currentUser);

            // 3. Display personalized welcome banner in HomeView
            homeView1.SetCurrentUser(_currentUser);

            // 4. Set current seller on the Sale view
            saleView1.SetVendedor(_currentUser);

            // 5. Wire decoupled logout events from child views
            WireLogoutEvents(this);

            // 6. Set current user dynamically in all lblCurrentUser labels across all views
            SetCurrentUserInLabels(this, _currentUser);
            foreach (var tab in _originalTabPages)
            {
                SetCurrentUserInLabels(tab, _currentUser);
            }
        }

        private void InitializeTabCacheAndIcons()
        {
            // 1. Setup ImageList resolution and size
            imageList1.ImageSize = new Size(24, 24);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.Images.Clear();

            Color iconColor = Color.White;

            imageList1.Images.Add("home", IconChar.Home.ToBitmap(iconColor, 24));
            imageList1.Images.Add("usuarios", IconChar.UserGear.ToBitmap(iconColor, 24));
            imageList1.Images.Add("clientes", IconChar.Users.ToBitmap(iconColor, 24));
            imageList1.Images.Add("productos", IconChar.MobileAlt.ToBitmap(iconColor, 24));
            imageList1.Images.Add("marcas", IconChar.Tags.ToBitmap(iconColor, 24));
            imageList1.Images.Add("venta", IconChar.CashRegister.ToBitmap(iconColor, 24));
            imageList1.Images.Add("historial", IconChar.History.ToBitmap(iconColor, 24));
            imageList1.Images.Add("reportes", IconChar.ChartBar.ToBitmap(iconColor, 24));

            materialTabControl1.ImageList = imageList1;

            // 2. Assign keys directly to TabPage instances (independent of tab collection order)
            tabPage1.ImageKey = "home";
            tabPage2.ImageKey = "usuarios";
            tabPage3.ImageKey = "clientes";
            tabPage4.ImageKey = "productos";
            tabPage6.ImageKey = "venta";
            tabPage7.ImageKey = "historial";
            tabPage8.ImageKey = "reportes";

            // 3. Cache original tab list in memory in exact canonical order
            _originalTabPages.Clear();
            _originalTabPages.Add(tabPage1); // Home
            _originalTabPages.Add(tabPage2); // Usuarios
            _originalTabPages.Add(tabPage3); // Clientes
            _originalTabPages.Add(tabPage4); // Productos
            _originalTabPages.Add(tabPage6); // Venta
            _originalTabPages.Add(tabPage7); // Historial De Ventas
            _originalTabPages.Add(tabPage8); // Reportes

            this.DrawerShowIconsWhenHidden = true;
        }


        //********************************************** Functionality ************************************************
        private void ApplyRoleBasedAccess(string username)
        {
            materialTabControl1.SuspendLayout();
            materialTabControl1.TabPages.Clear();

            string normalizedUser = username.Trim().ToLowerInvariant();
            int profileId = MobileSolutions.BusinessLayer.SesionActual.ProfileId;
            string profileName = MobileSolutions.BusinessLayer.SesionActual.ProfileName.Trim().ToLowerInvariant();

            List<TabPage> allowedTabs;

            // Role-based access control based on DB profile (with fallback to username)
            if (profileId == 1 || profileName == "administrador" || profileName == "administrator" || normalizedUser == "admin")
            {
                // Administrator: All 7 tabs visible
                allowedTabs = new List<TabPage>(_originalTabPages);
            }
            else if (profileId == 3 || profileName == "gerente" || normalizedUser == "fer" || normalizedUser == "fcaballe")
            {
                // Gerente: Only 6 tabs (Usuarios removed)
                allowedTabs = _originalTabPages
                    .Where(tab => tab != tabPage2)
                    .ToList();
            }
            else if (profileId == 2 || profileName == "vendedor" || normalizedUser == "nico")
            {
                // Vendedor: Only 5 tabs (Usuarios and Productos removed)
                allowedTabs = _originalTabPages
                    .Where(tab => tab != tabPage2 && tab != tabPage4)
                    .ToList();
            }
            else
            {
                // Fallback: Home tab only
                allowedTabs = new List<TabPage> { tabPage1 };
            }

            foreach (var tab in allowedTabs)
            {
                materialTabControl1.TabPages.Add(tab);
            }

            if (materialTabControl1.TabPages.Count > 0)
            {
                materialTabControl1.SelectedIndex = 0;
            }

            // Bind filtered tabs to MaterialSkin drawer
            this.DrawerTabControl = materialTabControl1;
            materialTabControl1.ResumeLayout(true);
        }
 
        private void WireLogoutEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is ILogoutSupport logoutControl)
                {
                    logoutControl.LogoutRequested += HandleLogoutRequested;
                }

                if (control.HasChildren)
                {
                    WireLogoutEvents(control);
                }
            }
        }

        public static void SetCurrentUserInLabels(Control parent, string username)
        {
            if (parent == null || string.IsNullOrWhiteSpace(username))
            {
                return;
            }

            foreach (Control control in parent.Controls)
            {
                if (control.Name == "lblCurrentUser")
                {
                    control.Text = username;
                }

                if (control.HasChildren)
                {
                    SetCurrentUserInLabels(control, username);
                }
            }
        }

        private void HandleLogoutRequested(object? sender, EventArgs e)
        {
            DialogResult result = MaterialMessageBox.Show(
                "¿Seguro que quiere cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            // 1. Limpiar estado de sesión
            MobileSolutions.BusinessLayer.SesionActual.LimpiarSesion();

            // 2. Marcar estado de logout
            IsLoggingOut = true;

            // 3. Ejecutar el ejecutable para reiniciar la aplicación mostrando el Login
            EjecutarReinicioAplicacion();

            // 4. Terminar de forma inmediata el proceso actual para evitar residuos en memoria
            Environment.Exit(0);
        }

        private void EjecutarReinicioAplicacion()
        {
            try
            {
                string targetDir = @"C:\Users\FeR\Desktop\Taller 2\Taller-de-Programaci-n-2---2026---Grupo-97\MobileSolutions.UILayer\bin\Debug\net10.0-windows";
                string exePath = Path.Combine(targetDir, "MobileSolutions.UILayer.exe");

                if (!File.Exists(exePath))
                {
                    exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MobileSolutions.UILayer.exe");
                }

                if (File.Exists(exePath))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = exePath,
                        WorkingDirectory = Path.GetDirectoryName(exePath)!,
                        UseShellExecute = true
                    });
                }
                else
                {
                    string batPath = Path.Combine(targetDir, "restart_app.bat");
                    if (File.Exists(batPath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = batPath,
                            WorkingDirectory = targetDir,
                            UseShellExecute = true
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Error al reiniciar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

