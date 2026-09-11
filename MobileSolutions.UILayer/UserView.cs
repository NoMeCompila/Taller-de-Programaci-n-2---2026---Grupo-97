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
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;


namespace MobileSolutions.UILayer
{
    public partial class UserView : UserControl
    {

        private readonly UserService _userService;
        public UserView()
        {
            InitializeComponent();

            // Configuración de colores oscuros/azules para el DateTimePicker
            dtpBirth.CalendarMonthBackground = Color.FromArgb(21, 101, 192); // Blue800
            dtpBirth.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);   // Blue900
            dtpBirth.CalendarTitleForeColor = Color.White;
            dtpBirth.CalendarTrailingForeColor = Color.Gray;
            dtpBirth.BackColor = Color.FromArgb(50, 50, 50); // Dark Mode Theme
            dtpBirth.ForeColor = Color.White;

            // Generar iconos blancos de 24x24 px y asignarlos a los botones
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
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);
            picSex.IconChar = IconChar.VenusMars;
            picSex.IconColor = Color.White;
            picProfile.IconChar = IconChar.UserCircle;
            picProfile.IconColor = Color.White;
            picBirth.IconChar = IconChar.Calendar;
            picBirth.IconColor = Color.White;
            picUserTitle.IconChar = IconChar.UserGear;
            picUserTitle.IconColor = Color.White;

            _userService = new UserService();

            ConfigBasicsRestrictions();
            dtgUsersConfig();
            fillActiveUsers();
        }

        private void dtgUsersConfig()
        {
            // Evita que el DataGridView autogenere columnas extras a la derecha
            dtgUsers.AutoGenerateColumns = false;

            // Configuración visual: texto en negro sobre fondo blanco
            dtgUsers.DefaultCellStyle.ForeColor = Color.Black;
            dtgUsers.DefaultCellStyle.BackColor = Color.White;
            dtgUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243); // Azul primario para la fila seleccionada
            dtgUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Configuración de encabezados (cabeceras legibles)
            dtgUsers.EnableHeadersVisualStyles = false;
            dtgUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161); // Azul oscuro
            dtgUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtgUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Vinculamos cada columna visual con la propiedad de nuestro objeto User
            ColumnProfile.DataPropertyName = nameof(User.ProfileName);
            ColumnName.DataPropertyName = nameof(User.Name);
            ColumnLastname.DataPropertyName = nameof(User.Lastname);
            ColumnUsername.DataPropertyName = nameof(User.Username);
            ColumnDNI.DataPropertyName = nameof(User.Dni);
            ColumnSex.DataPropertyName = nameof(User.Sex);
            ColumnBirth.DataPropertyName = nameof(User.Birth);
            ColumnEmail.DataPropertyName = nameof(User.Email);
            ColumnPhone.DataPropertyName = nameof(User.Phone);
            ColumnAddress.DataPropertyName = nameof(User.Address);
            ColumnNationality.DataPropertyName = nameof(User.Nationality);
            ColumnLocality.DataPropertyName = nameof(User.Locality);
        }


        public void fillActiveUsers()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<User> usuarios = _userService.GetActiveUsers();
                // Enlazamos la lista fuertemente tipada
                dtgUsers.DataSource = null; // Limpia enlace previo para forzar refresco
                dtgUsers.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de usuarios: {ex.Message}",
                                "Error de Datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void UserView_Load(object sender, EventArgs e)
        {
            fillActiveUsers();
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
