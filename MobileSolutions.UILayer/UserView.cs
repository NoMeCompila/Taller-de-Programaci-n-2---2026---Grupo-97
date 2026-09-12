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
        private int _selectedUserId = 0;
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
            dtgUsers.CellClick += dtgUsers_CellClick;
            fillActiveUsers();
            LimpiarFormulario();
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
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 1. Construir entidad fuertemente tipada desde el formulario
                User nuevoUsuario = ObtenerUsuarioDesdeFormulario();

                // 2. Invocar la Capa de Negocio (BLL)
                var (success, message) = _userService.CreateUser(nuevoUsuario);

                if (success)
                {
                    // 3. Notificación de éxito
                    MaterialMessageBox.Show(
                        "Usuario agregado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // 4. Refrescar la grilla para mostrar el nuevo registro
                    fillActiveUsers();

                    // 5. Limpiar el formulario y restablecer controles
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al registrar el usuario: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private bool ValidateFields(bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtLastname.Text)
                || string.IsNullOrWhiteSpace(txtDNI.Text)
                || string.IsNullOrWhiteSpace(txtUsername.Text)
                || (!isUpdate && string.IsNullOrWhiteSpace(txtPassword.Text))
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtNationality.Text)
                || string.IsNullOrWhiteSpace(txtLocality.Text))
            {
                MaterialMessageBox.Show(
                    "Por favor, complete todos los campos obligatorios.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (txtDNI.Text.Trim().Length < 7 || txtDNI.Text.Trim().Length > 8)
            {
                MaterialMessageBox.Show(
                    "El DNI debe contener entre 7 y 8 dígitos numéricos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MaterialMessageBox.Show(
                    "Ingrese un formato de correo electrónico válido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (dtpBirth.Value.Date >= DateTime.Today)
            {
                MaterialMessageBox.Show(
                    "La fecha de nacimiento debe ser anterior a la fecha actual.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpBirth.Focus();
                return false;
            }

            return true;
        }

        private User ObtenerUsuarioDesdeFormulario()
        {
            // Determinar Sexo seleccionado
            string sexo = materialRadioButton6.Checked ? "Masculino" : (materialRadioButton9.Checked ? "Femenino" : "Otro");

            // Determinar Perfil seleccionado (1: Administrador, 2: Vendedor, 3: Gerente)
            int profileId = 1;
            string profileName = "Administrador";

            if (materialRadioButton2.Checked)
            {
                profileId = 2;
                profileName = "Vendedor";
            }
            else if (materialRadioButton3.Checked)
            {
                profileId = 3;
                profileName = "Gerente";
            }

            return new User
            {
                UserId = _selectedUserId,
                ProfileId = profileId,
                ProfileName = profileName,
                Name = txtName.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Dni = txtDNI.Text.Trim(),
                Sex = sexo,
                Username = txtUsername.Text.Trim(),
                Password = string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text,
                Email = txtEmail.Text.Trim(),
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                Birth = dtpBirth.Value.Date,
                Nationality = txtNationality.Text.Trim(),
                Locality = txtLocality.Text.Trim(),
                RegisterDate = DateTime.Now
            };
        }

        private void dtgUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Validación obligatoria: descarta clics en los encabezados (-1) o índices fuera de rango
            if (e.RowIndex < 0 || e.RowIndex >= dtgUsers.Rows.Count)
            {
                return;
            }

            DataGridViewRow fila = dtgUsers.Rows[e.RowIndex];

            // Validación contra filas nuevas o no vinculadas
            if (fila.IsNewRow || fila.DataBoundItem == null)
            {
                return;
            }

            // Mapeo seguro utilizando el objeto de negocio enlazado
            if (fila.DataBoundItem is User usuarioSeleccionado)
            {
                MapearUsuarioAControles(usuarioSeleccionado);
                ActualizarEstadoBotones(modoEdicion: true);
            }
        }

        private void MapearUsuarioAControles(User user)
        {
            _selectedUserId = user.UserId;

            txtName.Text = user.Name;
            txtLastname.Text = user.Lastname;
            txtDNI.Text = user.Dni;
            txtUsername.Text = user.Username;
            txtPassword.Clear();
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone ?? string.Empty;
            txtAddress.Text = user.Address ?? string.Empty;
            txtNationality.Text = user.Nationality;
            txtLocality.Text = user.Locality;

            // DateTimePicker con validación de rango permitido
            if (user.Birth >= dtpBirth.MinDate && user.Birth <= dtpBirth.MaxDate)
            {
                dtpBirth.Value = user.Birth;
            }
            else
            {
                dtpBirth.Value = DateTime.Today;
            }

            // RadioButtons de Sexo
            materialRadioButton6.Checked = string.Equals(user.Sex, "Masculino", StringComparison.OrdinalIgnoreCase);
            materialRadioButton9.Checked = string.Equals(user.Sex, "Femenino", StringComparison.OrdinalIgnoreCase);
            materialRadioButton7.Checked = string.Equals(user.Sex, "Otro", StringComparison.OrdinalIgnoreCase);

            // RadioButtons de Perfil
            materialRadioButton1.Checked = string.Equals(user.ProfileName, "Administrador", StringComparison.OrdinalIgnoreCase);
            materialRadioButton2.Checked = string.Equals(user.ProfileName, "Vendedor", StringComparison.OrdinalIgnoreCase);
            materialRadioButton3.Checked = string.Equals(user.ProfileName, "Gerente", StringComparison.OrdinalIgnoreCase);
        }

        private void ActualizarEstadoBotones(bool modoEdicion)
        {
            btnSave.Enabled = !modoEdicion;
            btnUpdate.Enabled = modoEdicion;
            btnDelete.Enabled = modoEdicion;
            btnClear.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            _selectedUserId = 0;

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

            dtpBirth.Value = DateTime.Today;

            // Restablecer valores por defecto de radio buttons
            materialRadioButton6.Checked = true; // Masculino
            materialRadioButton1.Checked = true; // Administrador

            dtgUsers.ClearSelection();
            ActualizarEstadoBotones(modoEdicion: false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un usuario de la grilla para poder modificarlo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields(isUpdate: true))
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 1. Construir entidad fuertemente tipada desde el formulario con el Id seleccionado
                User usuarioModificado = ObtenerUsuarioDesdeFormulario();

                // 2. Invocar la Capa de Negocio (BLL)
                var (success, message) = _userService.UpdateUser(usuarioModificado);

                if (success)
                {
                    // 3. Notificación de éxito
                    MaterialMessageBox.Show(
                        "Usuario actualizado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // 4. Refrescar la grilla para mostrar los cambios
                    fillActiveUsers();

                    // 5. Limpiar el formulario y restablecer controles
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al actualizar el usuario: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedUserId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un usuario de la grilla para poder darlo de baja.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirmación explícita antes de proceder con la baja lógica
            DialogResult confirmResult = MaterialMessageBox.Show(
                "¿Está seguro de que desea dar de baja al usuario seleccionado?",
                "Confirmación de Baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Invocar la Capa de Negocio (BLL)
                var (success, message) = _userService.SoftDeleteUser(_selectedUserId);

                if (success)
                {
                    MaterialMessageBox.Show(
                        "Usuario dado de baja correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Refrescar grilla de usuarios activos
                    fillActiveUsers();

                    // Limpiar formulario y restablecer estado de botones
                    LimpiarFormulario();
                }
                else
                {
                    MaterialMessageBox.Show(
                        message,
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error inesperado al dar de baja al usuario: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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
