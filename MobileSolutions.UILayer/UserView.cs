using FontAwesome.Sharp;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using MaterialSkin.Controls;

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
            btnSave.Icon = IconChar.Save.ToBitmap(Color.White);
            btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White);
            btnName.Icon = IconChar.UserEdit.ToBitmap(Color.White);
            btnLastname.Icon = IconChar.UserEdit.ToBitmap(Color.White);
            btnDni.Icon = IconChar.IdCard.ToBitmap(Color.White);
            btnUser.Icon = IconChar.User.ToBitmap(Color.White);
            btnPassword.Icon = IconChar.Key.ToBitmap(Color.White);
            btnEmail.Icon = IconChar.Envelope.ToBitmap(Color.White);
            btnCel.Icon = IconChar.Phone.ToBitmap(Color.White);
            btnAddress.Icon = IconChar.MapMarker.ToBitmap(Color.White);
            btnNat.Icon = IconChar.Flag.ToBitmap(Color.White);
            btnLoc.Icon = IconChar.MapMarkerAlt.ToBitmap(Color.White);
            picSex.IconChar = IconChar.VenusMars;
            picProfile.IconChar = IconChar.UserCircle;
            picBirth.IconChar = IconChar.Calendar;
            picUserTitle.IconChar = IconChar.User;
            picUserTitle.IconColor = Color.White;
            btnDelete.Icon = IconChar.Trash.ToBitmap(Color.White);
            btnUpdate.Icon = IconChar.Pencil.ToBitmap(Color.White);


            ConfigBasicsRestrictions();
        }

        private void ConfigBasicsRestrictions()
        {
            // Restringir el DateTimePicker para que la fecha máxima sea hoy.
            dtpBirth.MaxDate = DateTime.Now.Date;
        }



        // Esto aprete por accidente, no tiene funcionalidad, pero lo dejo por si acaso.
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo Letras y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo Letras y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtDNI.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtNationality.Text)
                || string.IsNullOrWhiteSpace(txtLocality.Text) || string.IsNullOrWhiteSpace(txtLastname.Text)
                || dtpBirth.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Vaciar TextBoxes
            txtName.Clear();
            txtLastname.Clear();
            txtDNI.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtNationality.Clear();
            txtLocality.Clear();




            // Resetear Fecha
            dtpBirth.Value = DateTime.Now.Date;
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control(como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la pulsación de la tecla
            }
        }
    }
}
