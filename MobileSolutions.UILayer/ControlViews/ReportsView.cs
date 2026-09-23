using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace MobileSolutions.UILayer
{
    public partial class ReportsView : UserControl
    {

        public ReportsView()
        {
            InitializeComponent();

            // Ícono del título del panel
            picReportsTitle.IconChar = IconChar.ChartColumn;
            picReportsTitle.IconColor = Color.White;

            picProximamente.IconChar = IconChar.UserSlash;
            picProximamente.IconColor = Color.Red;

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
        }

        private bool _reporteInyectado = false;

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible && !_reporteInyectado)
            {
                CargarReporteSegunPerfil();
            }
        }

        private void CargarReporteSegunPerfil()
        {
            int perfilActual = MobileSolutions.BusinessLayer.SesionActual.ProfileId;
            UserControl reporteAutorizado = null;

            switch (perfilActual)
            {
                case 1:
                    reporteAutorizado = new AdminReportControl();
                    break;
                case 2:
                    reporteAutorizado = new ManagerReportControl();
                    break;
                case 3:
                    reporteAutorizado = new SellerReportControl();
                    break;
                default:
                    // Perfil no reconocido: se deja el diseño original del panel (ícono + texto "Perfil No Autorizado")
                    return;
            }

            if (reporteAutorizado != null)
            {
                reporteAutorizado.Dock = DockStyle.Fill;
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(reporteAutorizado);
                _reporteInyectado = true;
            }
        }
    }
}
