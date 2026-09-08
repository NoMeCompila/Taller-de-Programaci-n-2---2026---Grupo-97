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
            this.picUsers.Image = IconChar.UserGear.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
            this.picCustomers.Image = IconChar.Users.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
            this.picProductsHome.Image = IconChar.MobileAlt.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
            this.picSalesHome.Image = IconChar.CashRegister.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
            this.picHistoryHome.Image = IconChar.History.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
            this.picReportsHome.Image = IconChar.ChartBar.ToBitmap(ColorTranslator.FromHtml("#1379ED"), 64);
        }

        public void SetCurrentUser(string username)
        {
            lblWelcomeBanner.Text = $"Bienvenido {username} a Mobile Solutions";
        }
    }
}
