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

        int perfilActual = 4; // Asigno manualmente el perfil actual para pruebas (1: Admin, 2: Manager, 3: Seller)
        public ReportsView()
        {
            InitializeComponent();

            // Ícono del título del panel
            picReportsTitle.IconChar = IconChar.ChartColumn;
            picReportsTitle.IconColor = Color.White;

            picProximamente.IconChar = IconChar.UserSlash;
            picProximamente.IconColor = Color.Red;

            this.Load += ReportsView_Load;
        }

        private void ReportsView_Load(object sender, EventArgs e)
        {
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
                    MaterialMessageBox.Show("Perfil no autorizado para ver reportes.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            // Inyectamos el panel correspondiente en el contenedor
            if (reporteAutorizado != null)
            {
                reporteAutorizado.Dock = DockStyle.Fill;
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(reporteAutorizado);
            }
        }
    }
}
