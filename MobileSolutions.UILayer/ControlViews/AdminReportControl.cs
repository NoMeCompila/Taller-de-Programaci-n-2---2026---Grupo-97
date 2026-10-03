using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class AdminReportControl : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        public AdminReportControl()
        {
            InitializeComponent();
            picProximamente.IconChar = IconChar.ScrewdriverWrench;
            picProximamente.IconColor = Color.Black;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
