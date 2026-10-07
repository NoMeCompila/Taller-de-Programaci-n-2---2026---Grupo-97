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

        private void lblForgotMyPassword_Click(object sender, EventArgs e)
        {
            txtCorreo.Visible = true;
            txtCorreo.Enabled = true;
            btnSendEmail.Visible = true;
            btnSendEmail.Enabled = true;
            txtCorreo.Focus();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MaterialMessageBox.Show("Por favor ingrese su correo electrónico o nombre de usuario.", "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            var (success, message) = _userService.RequestPasswordReset(email);
            if (!success)
            {
                MaterialMessageBox.Show(message, "Error al Enviar Código", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MaterialMessageBox.Show(message, "Código Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Habilitar campos del paso 2 (código y nueva contraseña)
            txtCode.Visible = true;
            txtCode.Enabled = true;
            txtNewPassword.Visible = true;
            txtNewPassword.Enabled = true;
            btnConfirm.Visible = true;
            btnConfirm.Enabled = true;
            txtCode.Focus();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string email = txtCorreo.Text.Trim();
            string code = txtCode.Text.Trim();
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MaterialMessageBox.Show("Por favor ingrese su correo electrónico o usuario.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(code))
            {
                MaterialMessageBox.Show("Por favor ingrese el código de verificación de 6 dígitos.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MaterialMessageBox.Show("Por favor ingrese su nueva contraseña.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            var (success, message) = _userService.CompletePasswordReset(email, code, newPassword);
            if (!success)
            {
                MaterialMessageBox.Show(message, "Error al Restablecer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MaterialMessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar y ocultar controles de recuperación
            txtCorreo.Clear();
            txtCode.Clear();
            txtNewPassword.Clear();

            txtCorreo.Visible = false;
            txtCorreo.Enabled = false;
            btnSendEmail.Visible = false;
            btnSendEmail.Enabled = false;

            txtCode.Visible = false;
            txtCode.Enabled = false;
            txtNewPassword.Visible = false;
            txtNewPassword.Enabled = false;
            btnConfirm.Visible = false;
            btnConfirm.Enabled = false;

            // Enfocar campo de contraseña principal para inicio de sesión
            txtPassword.Focus();
        }
    }
}

