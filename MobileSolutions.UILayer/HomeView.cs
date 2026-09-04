using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobileSolutions.UILayer
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            this.picHomeTitle.Image = IconChar.Home.ToBitmap(Color.White, 64);
        }

        public void SetCurrentUser(string username)
        {
            lblWelcomeBanner.Text = $"Bienvenido {username} a Mobile Solutions";
        }
    }
}
