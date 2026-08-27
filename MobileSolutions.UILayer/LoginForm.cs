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

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Remove left, right, and bottom white borders while keeping top Action Bar (64px) for window control buttons
            this.Padding = new Padding(0, 64, 0, 0);

            // Make logo picture boxes transparent over the background image (pictureBox3)
            Point p1 = pictureBox1.Location;
            Point p2 = pictureBox2.Location;

            pictureBox1.Parent = pictureBox3;
            pictureBox1.Location = pictureBox3.PointToClient(this.PointToScreen(p1));
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.None;

            pictureBox2.Parent = pictureBox3;
            pictureBox2.Location = pictureBox3.PointToClient(this.PointToScreen(p2));
            pictureBox2.BackColor = Color.Transparent;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = materialTextBox1.Text;
            string password = materialTextBox2.Text;

            bool isAuthenticated = _userService.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

