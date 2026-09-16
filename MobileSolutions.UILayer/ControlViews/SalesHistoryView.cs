using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MobileSolutions.UILayer
{
    public partial class SalesHistoryView : UserControl
    {
        public SalesHistoryView()
        {
            InitializeComponent();
            ConfigurarIconos();
            CargarDatosDummy();
            Load += (s, e) => splitContainer.SplitterDistance = (int)(splitContainer.Height * 0.6);
        }

private void ConfigurarIconos()
        {
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);
            btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White);
            picHistoryTitle.IconChar = IconChar.History;
            picHistoryTitle.IconColor = Color.White;
        }

        private void CargarDatosDummy()
        {
            var iconoPdf = IconChar.FilePdf.ToBitmap(Color.White, 24);

            dgvSales.Rows.Clear();
            dgvSales.Rows.Add("FV-0001", "05/09/2026", "María López", "nico", "Efectivo", "$2,180.00", iconoPdf);
            dgvSales.Rows.Add("FV-0002", "06/09/2026", "Carlos Gómez", "fer", "Tarjeta Crédito", "$1,400.00", iconoPdf);
            dgvSales.Rows.Add("FV-0003", "08/09/2026", "Ana Martínez", "nico", "Débito", "$3,160.00", iconoPdf);
            dgvSales.Rows.Add("FV-0004", "09/09/2026", "Luis Fernández", "fer", "Efectivo", "$1,060.00", iconoPdf);

            dgvSaleDetails.Rows.Clear();
            dgvSaleDetails.Rows.Add("CEL-014", "iPhone 14 128GB", 2, "$900.00", "$1,800.00");
            dgvSaleDetails.Rows.Add("CEL-002", "Galaxy A14 128GB", 1, "$380.00", "$380.00");
        }

        private void lblDetailTitle_Click(object sender, EventArgs e)
        {

        }
    }
}