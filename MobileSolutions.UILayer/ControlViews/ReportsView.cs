using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MobileSolutions.UILayer.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MobileSolutions.UILayer
{
    public partial class ReportsView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        public ReportsView()
        {
            InitializeComponent();

            // Ícono del título del panel
            picReportsTitle.IconChar = IconChar.ChartColumn;
            picReportsTitle.IconColor = Color.White;

            picProximamente.IconChar = IconChar.UserSlash;
            picProximamente.IconColor = Color.Red;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private bool _reportInjected = false;

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible && !_reportInjected)
            {
                LoadReportByProfile();
            }
            else if (this.Visible && pnlContainer.Controls.Count > 0 && pnlContainer.Controls[0] is SellerReportControl sellerReport)
            {
                sellerReport.RefreshReportData();
            }
        }

        private void LoadReportByProfile()
        {
            int currentProfile = MobileSolutions.BusinessLayer.CurrentSession.ProfileId;
            UserControl? authorizedReport = null;

            switch (currentProfile)
            {
                case 1:
                    authorizedReport = new AdminReportControl();
                    break;
                case 2:
                    authorizedReport = new ManagerReportControl();
                    break;
                case 3:
                    authorizedReport = new SellerReportControl();
                    break;
                default:
                    // Perfil no reconocido: se deja el diseño original del panel (ícono + texto "Perfil No Autorizado")
                    return;
            }

            if (authorizedReport != null)
            {
                if (authorizedReport is ILogoutSupport logoutSupport)
                {
                    logoutSupport.LogoutRequested += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
                }

                string currentUsername = !string.IsNullOrWhiteSpace(MobileSolutions.BusinessLayer.CurrentSession.Username)
                    ? MobileSolutions.BusinessLayer.CurrentSession.Username
                    : "admin";

                MainForm.SetCurrentUserInLabels(authorizedReport, currentUsername);

                authorizedReport.Dock = DockStyle.Fill;
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(authorizedReport);
                _reportInjected = true;
            }
        }
    }
}
