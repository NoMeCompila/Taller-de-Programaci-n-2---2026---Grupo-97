using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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

            picProximamente.IconChar = IconChar.ScrewdriverWrench;
            picProximamente.IconColor = Color.Yellow;
        }
    }
}
