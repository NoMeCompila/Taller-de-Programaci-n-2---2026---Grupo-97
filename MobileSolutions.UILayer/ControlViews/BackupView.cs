using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class BackupView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        public BackupView()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.picBackupTitle.IconChar = IconChar.Database;
            this.picBackupTitle.IconColor = Color.White;
            this.picBackupTitle.BackColor = Color.Transparent;
            this.btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            this.btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
