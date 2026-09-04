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
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            var user = _userService.GetUser(username, password);

            if (user != null)
            {
                MainForm mainForm = new MainForm(user.Username);
                mainForm.Show();
                this.Hide();
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MaterialMessageBox.Show("Por favor ingrese las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MaterialMessageBox.Show("Usuario/Contraseña no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

