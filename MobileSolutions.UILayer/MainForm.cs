using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MobileSolutions.UILayer
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            ConfigurarIconosMenu();

            SkinManager.ColorScheme = new ColorScheme(
               Primary.Blue800,
               Primary.Blue900,
               Primary.Blue500,
               Accent.LightBlue200,
               TextShade.WHITE);
        }

        private void ConfigurarIconosMenu()
        {
            // 1. Configurar resolución y tamaño del ImageList
            imageList1.ImageSize = new Size(24, 24);
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.Images.Clear();

            // 2. Color base para los iconos
            Color iconColor = Color.White;

            // 3. Generar Bitmaps con FontAwesome.Sharp y agregarlos al ImageList
            imageList1.Images.Add("home", IconChar.Home.ToBitmap(iconColor, 24));
            imageList1.Images.Add("usuarios", IconChar.UserShield.ToBitmap(iconColor, 24));
            imageList1.Images.Add("clientes", IconChar.Users.ToBitmap(iconColor, 24));
            imageList1.Images.Add("productos", IconChar.MobileAlt.ToBitmap(iconColor, 24));
            imageList1.Images.Add("marcas", IconChar.Tags.ToBitmap(iconColor, 24));
            imageList1.Images.Add("venta", IconChar.CashRegister.ToBitmap(iconColor, 24));
            imageList1.Images.Add("historial", IconChar.History.ToBitmap(iconColor, 24));
            imageList1.Images.Add("reportes", IconChar.ChartBar.ToBitmap(iconColor, 24));

            // 4. Vincular el ImageList a tu MaterialTabControl
            materialTabControl1.ImageList = imageList1;

            // 5. Asignar las claves (ImageKey) a cada TabPage
            // (Reemplaza los nombres de variables por los que tengan tus TabPages en el Designer)
            materialTabControl1.TabPages[0].ImageKey = "home";
            materialTabControl1.TabPages[1].ImageKey = "usuarios";
            materialTabControl1.TabPages[2].ImageKey = "clientes";
            materialTabControl1.TabPages[3].ImageKey = "productos";
            materialTabControl1.TabPages[4].ImageKey = "marcas";
            materialTabControl1.TabPages[5].ImageKey = "venta";
            materialTabControl1.TabPages[6].ImageKey = "historial";
            materialTabControl1.TabPages[7].ImageKey = "reportes";
            // 6. Configurar el Drawer nativo del MaterialForm
            this.DrawerTabControl = materialTabControl1;
            this.DrawerShowIconsWhenHidden = true; // Mantiene visibles los iconos al colapsar
        }

        private void MainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {

        }


        private void button1_Click(object? sender, EventArgs e)
        {
            // Immediate, deadlock-free process termination for all forms and background threads
            //Environment.Exit(0);
        }
    }
}

