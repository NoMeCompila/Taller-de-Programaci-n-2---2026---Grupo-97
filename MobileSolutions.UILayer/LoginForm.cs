using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;

namespace MobileSolutions.UILayer
{
    public partial class LoginForm : MaterialForm
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Environment.Exit(0);
            _userService = new UserService();


            //********************************************** Design ************************************************
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Remove left, right, and bottom white borders while keeping top Action Bar (64px) for window control buttons
            this.Padding = new Padding(0, 64, 0, 0);

            // Make logo picture boxes transparent over the background image (pictureBox3)
            Point p1 = picBanner.Location;
            Point p2 = picLogo.Location;

            picBanner.Parent = picBG;
            picBanner.Location = picBG.PointToClient(this.PointToScreen(p1));
            picBanner.BackColor = Color.Transparent;
            picBanner.BorderStyle = BorderStyle.None;

            picLogo.Parent = picBG;
            picLogo.Location = picBG.PointToClient(this.PointToScreen(p2));
            picLogo.BackColor = Color.Transparent;

            // Set the color scheme for the MaterialSkin theme
            SkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE);

            picLogo.Parent = picBG;
            picLogo.BackColor = Color.Transparent;

            Bitmap loginIcon = IconChar.SignInAlt.ToBitmap(Color.White, 24);
            // Asignar el icono al MaterialButton
            btnLogin.Icon = loginIcon;
        }


        //************************************************ Functionality ************************************************
        private void materialButton1_Click(object sender, EventArgs e)
        {

            // 1. Probar conectividad con SQL Server
            var (isConnected, errorMessage) = _userService.CheckDatabaseConnection();
            if (!isConnected)
            {
                MaterialMessageBox.Show(
                    $"No se pudo conectar a la base de datos SQL Server.\n\nDetalle: {errorMessage}",
                    "Error de Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // Opcional para confirmar visualmente que conectó:
            //MaterialMessageBox.Show(
             //   "Conexión exitosa a SQL Server (MobileSolutionsDB).",
             //   "Conectado",
              //  MessageBoxButtons.OK,
              //  MessageBoxIcon.Information);


            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            var (success, message, user) = _userService.Login(username, password);

            if (success && user != null)
            {
                MobileSolutions.BusinessLayer.SesionActual.IniciarSesion(user);
                MainForm mainForm = new MainForm(user.Username);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MaterialMessageBox.Show(message, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

