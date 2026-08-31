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
            btnSave.Icon = IconChar.Save.ToBitmap(Color.White, 24);
            btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White, 24);
            btnActive.Icon = IconChar.ToggleOn.ToBitmap(Color.White, 24);
            btnInactive.Icon = IconChar.ToggleOff.ToBitmap(Color.White, 24);

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
                || (chkAdmin.Checked == false && chkManager.Checked == false && chkSeller.Checked == false)
                || (radMale.Checked == false && radFemale.Checked == false && radOther.Checked == false)
                || dtpBirth.Value == DateTime.Now.Date)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Aquí llamas a la capa de negocio (UserService) pasando los datos.
            // Ejemplo:
            // UserService servicio = new UserService();
            // bool exito = servicio.RegistrarUsuario(txtName.Text, txtDni.Text, ...);

            // 3. Si se guardó con éxito en la BD, actualizas el DataGridView
            // ActualizarGrilla();
            // btnLimpiar.PerformClick();
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

            // Resetear RadioButtons (Sexo)
            radMale.Checked = false;
            radFemale.Checked = false;
            radOther.Checked = false;

            // Resetear CheckBoxes (Roles)
            chkAdmin.Checked = false;
            chkManager.Checked = false;
            chkSeller.Checked = false;

            // Resetear Fecha
            dtpBirth.Value = DateTime.Now.Date;
        }

        private void chkAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                chkManager.Checked = false;
                chkSeller.Checked = false;
            }
        }

        private void chkManager_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManager.Checked)
            {
                chkAdmin.Checked = false;
                chkSeller.Checked = false;
            }
        }

        private void chkSeller_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeller.Checked)
            {
                chkAdmin.Checked = false;
                chkManager.Checked = false;
            }
        }
    }
}
