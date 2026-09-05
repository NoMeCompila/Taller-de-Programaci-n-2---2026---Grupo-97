using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    public partial class MainForm : MaterialForm
    {
        private readonly List<TabPage> _originalTabPages = new();
        private readonly string _currentUser = "admin";

        public MainForm() : this("admin")
        {
        }

        public MainForm(string username)
        {
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
        }

        private void InitializeTabCacheAndIcons()
        {
            // 1. Setup ImageList resolution and size
            imageList1.ImageSize = new Size(24, 24);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.Images.Clear();

            Color iconColor = Color.White;

            imageList1.Images.Add("home", IconChar.Home.ToBitmap(iconColor, 24));
            imageList1.Images.Add("usuarios", IconChar.UserShield.ToBitmap(iconColor, 24));
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
            tabPage5.ImageKey = "marcas";
            tabPage6.ImageKey = "venta";
            tabPage7.ImageKey = "historial";
            tabPage8.ImageKey = "reportes";

            // 3. Cache original tab list in memory in exact canonical order
            _originalTabPages.Clear();
            _originalTabPages.Add(tabPage1); // Home
            _originalTabPages.Add(tabPage2); // Usuarios
            _originalTabPages.Add(tabPage3); // Clientes
            _originalTabPages.Add(tabPage4); // Productos
            _originalTabPages.Add(tabPage5); // Marcas
            _originalTabPages.Add(tabPage6); // Venta
            _originalTabPages.Add(tabPage7); // Historial De Ventas
            _originalTabPages.Add(tabPage8); // Reportes

            this.DrawerShowIconsWhenHidden = true;
        }

        private void ApplyRoleBasedAccess(string username)
        {
            materialTabControl1.SuspendLayout();
            materialTabControl1.TabPages.Clear();

            string normalizedUser = username.Trim().ToLowerInvariant();

            List<TabPage> allowedTabs;
            switch (normalizedUser)
            {
                case "admin":
                    // Administrator: All 8 tabs visible
                    allowedTabs = new List<TabPage>(_originalTabPages);
                    break;

                case "fer":
                    // Gerente: Only 6 tabs (Usuarios and Clientes removed)
                    allowedTabs = _originalTabPages
                        .Where(tab => tab != tabPage2)
                        .ToList();
                    break;

                case "nico":
                    // Vendedor: Only 5 tabs (Usuarios, Productos, and Marcas removed)
                    allowedTabs = _originalTabPages
                        .Where(tab => tab != tabPage2 && tab != tabPage4 && tab != tabPage5)
                        .ToList();
                    break;

                default:
                    // Fallback: Home tab only
                    allowedTabs = new List<TabPage> { tabPage1 };
                    break;
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

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

