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

            SkinManager.ColorScheme = new ColorScheme(
               Primary.Blue800,
               Primary.Blue900,
               Primary.Blue500,
               Accent.LightBlue200,
               TextShade.WHITE);
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

