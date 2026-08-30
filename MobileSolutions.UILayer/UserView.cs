using FontAwesome.Sharp;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobileSolutions.UILayer
{
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();

            // Configuración de colores oscuros/azules para el DateTimePicker
            dtpBirth.CalendarMonthBackground = Color.FromArgb(21, 101, 192); // Blue800
            dtpBirth.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);   // Blue900
            dtpBirth.CalendarTitleForeColor = Color.White;
            dtpBirth.CalendarTrailingForeColor = Color.Gray;
            dtpBirth.BackColor = Color.FromArgb(50, 50, 50); // Fondo oscuro general
            dtpBirth.ForeColor = Color.White;

            // Generar iconos blancos de 24x24 px y asignarlos a los botones
            btnSave.Icon = IconChar.Save.ToBitmap(Color.White, 24);
            btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White, 24);
            btnActive.Icon = IconChar.ToggleOn.ToBitmap(Color.White, 24);
            btnInactive.Icon = IconChar.ToggleOff.ToBitmap(Color.White, 24);
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
