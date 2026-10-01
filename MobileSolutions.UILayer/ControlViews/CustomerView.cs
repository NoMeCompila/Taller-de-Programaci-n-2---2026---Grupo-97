using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace MobileSolutions.UILayer
{
    public partial class CustomerView : UserControl
    {
        private readonly CustomerService _customerService;
        private int _selectedCustomerId = 0;
        private System.Windows.Forms.Timer? _searchDebounceTimer;

        public CustomerView()
        {
            InitializeComponent();

            // Configuración visual para el DateTimePicker
            dtpBirth.CalendarMonthBackground = Color.FromArgb(21, 101, 192); // Blue800
            dtpBirth.CalendarTitleBackColor = Color.FromArgb(13, 71, 161);   // Blue900
            dtpBirth.CalendarTitleForeColor = Color.White;
            dtpBirth.CalendarTrailingForeColor = Color.Gray;
            dtpBirth.BackColor = Color.FromArgb(50, 50, 50);
            dtpBirth.ForeColor = Color.White;

            // Iconos FontAwesome
            btnName.Icon = IconChar.UserEdit.ToBitmap(Color.White);
            btnLastname.Icon = IconChar.UserEdit.ToBitmap(Color.White);
            btnDni.Icon = IconChar.IdCard.ToBitmap(Color.White);
            btnEmail.Icon = IconChar.Envelope.ToBitmap(Color.White);
            btnCel.Icon = IconChar.Phone.ToBitmap(Color.White);
            btnAddress.Icon = IconChar.MapMarker.ToBitmap(Color.White);
            btnNat.Icon = IconChar.Flag.ToBitmap(Color.White);
            btnLoc.Icon = IconChar.MapMarkerAlt.ToBitmap(Color.White);
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);
            picSex.IconChar = IconChar.VenusMars;
            picSex.IconColor = Color.White;
            picBirth.IconChar = IconChar.Calendar;
            picBirth.IconColor = Color.White;
            picCustomerTitle.IconChar = IconChar.Users;
            picCustomerTitle.IconColor = Color.White;
            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);

            _customerService = new CustomerService();

            ConfigBasicsRestrictions();
            dtgCustomersConfig();
            InitializeSearchBehavior();
            InitializeStatusSwitch();
            dtgCustomers.CellClick += dtgCustomers_CellClick;
            fillActiveCustomers();
            LimpiarFormulario();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            fillActiveCustomers();
        }

        private void ConfigBasicsRestrictions()
        {
            dtpBirth.MaxDate = DateTime.Now.Date;
        }

        private void dtgCustomersConfig()
        {
            dtgCustomers.AutoGenerateColumns = false;

            // Estilos generales del DataGridView
            dtgCustomers.DefaultCellStyle.ForeColor = Color.Black;
            dtgCustomers.DefaultCellStyle.BackColor = Color.White;
            dtgCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
            dtgCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            dtgCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Estilos de cabecera
            dtgCustomers.EnableHeadersVisualStyles = false;
            dtgCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 71, 161);
            dtgCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtgCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Vinculación de columnas con las propiedades de Customer
            ColumnName.DataPropertyName = nameof(Customer.Name);
            ColumnLastname.DataPropertyName = nameof(Customer.Lastname);
            ColumnDNI.DataPropertyName = nameof(Customer.Dni);
            ColumnSex.DataPropertyName = nameof(Customer.Sex);
            ColumnBirth.DataPropertyName = nameof(Customer.Birth);
            ColumnEmail.DataPropertyName = nameof(Customer.Email);
            ColumnPhone.DataPropertyName = nameof(Customer.Phone);
            ColumnAddress.DataPropertyName = nameof(Customer.Address);
            ColumnNationality.DataPropertyName = nameof(Customer.Nationality);
            ColumnLocality.DataPropertyName = nameof(Customer.Locality);
        }

        public void fillActiveCustomers()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Customer> clientes = swtActive.Checked
                    ? _customerService.GetActiveCustomers()
                    : _customerService.GetInactiveCustomers();

                dtgCustomers.DataSource = null;
                dtgCustomers.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error al cargar la lista de clientes: {ex.Message}",
                    "Error de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #region Restricciones de Teclado (KeyPress)

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Acciones CRUD (Guardar, Editar, Eliminar, Reactivar, Limpiar)

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Customer nuevoCliente = ObtenerClienteDesdeFormulario();
                var (success, message) = _customerService.CreateCustomer(nuevoCliente);

                if (success)
                {
                    MaterialMessageBox.Show(
                        "Cliente agregado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    fillActiveCustomers();
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
                    $"Error inesperado al registrar el cliente: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un cliente de la grilla para poder modificarlo.",
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

                Customer clienteModificado = ObtenerClienteDesdeFormulario();
                var (success, message) = _customerService.UpdateCustomer(clienteModificado);

                if (success)
                {
                    MaterialMessageBox.Show(
                        "Cliente actualizado correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    fillActiveCustomers();
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
                    $"Error inesperado al actualizar el cliente: {ex.Message}",
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
            if (_selectedCustomerId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un cliente de la grilla para poder darlo de baja.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MaterialMessageBox.Show(
                "¿Está seguro de que desea dar de baja al cliente seleccionado?",
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

                var (success, message) = _customerService.SoftDeleteCustomer(_selectedCustomerId);

                if (success)
                {
                    MaterialMessageBox.Show(
                        "Cliente dado de baja correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    fillActiveCustomers();
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
                    $"Error inesperado al dar de baja al cliente: {ex.Message}",
                    "Error de Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnReactivate_Click(object? sender, EventArgs e)
        {
            if (_selectedCustomerId <= 0)
            {
                MaterialMessageBox.Show(
                    "Debe seleccionar un cliente inactivo de la grilla para reactivarlo.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                var (success, message) = _customerService.ReactivateCustomer(_selectedCustomerId);

                if (success)
                {
                    fillActiveCustomers();
                    LimpiarFormulario();

                    MaterialMessageBox.Show(
                        "Cliente Reactivado Exitosamente",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
                    $"Error inesperado al reactivar el cliente: {ex.Message}",
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

        #endregion

        #region Mapeo y Validaciones Auxiliares

        private bool ValidateFields(bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)
                || string.IsNullOrWhiteSpace(txtLastname.Text)
                || string.IsNullOrWhiteSpace(txtDNI.Text)
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

            if (dtpBirth.Value.Date > DateTime.Today.AddYears(-18))
            {
                MaterialMessageBox.Show(
                    "El cliente debe ser mayor de edad (18 años o más).",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpBirth.Focus();
                return false;
            }

            return true;
        }

        private Customer ObtenerClienteDesdeFormulario()
        {
            string sexo = radMale.Checked ? "Masculino" : (radFemale.Checked ? "Femenino" : "Otro");

            return new Customer
            {
                CustomerId = _selectedCustomerId,
                Name = txtName.Text.Trim(),
                Lastname = txtLastname.Text.Trim(),
                Dni = txtDNI.Text.Trim(),
                Sex = sexo,
                Email = txtEmail.Text.Trim(),
                Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                Birth = dtpBirth.Value.Date,
                Nationality = txtNationality.Text.Trim(),
                Locality = txtLocality.Text.Trim()
            };
        }

        private void dtgCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dtgCustomers.Rows.Count)
            {
                return;
            }

            DataGridViewRow fila = dtgCustomers.Rows[e.RowIndex];

            if (fila.IsNewRow || fila.DataBoundItem == null)
            {
                return;
            }

            if (fila.DataBoundItem is Customer clienteSeleccionado)
            {
                MapearClienteAControles(clienteSeleccionado);
                ActualizarEstadoBotones(modoEdicion: true);
            }
        }

        private void MapearClienteAControles(Customer customer)
        {
            _selectedCustomerId = customer.CustomerId;

            txtName.Text = customer.Name;
            txtLastname.Text = customer.Lastname;
            txtDNI.Text = customer.Dni;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone ?? string.Empty;
            txtAddress.Text = customer.Address ?? string.Empty;
            txtNationality.Text = customer.Nationality;
            txtLocality.Text = customer.Locality;

            if (customer.Birth >= dtpBirth.MinDate && customer.Birth <= dtpBirth.MaxDate)
            {
                dtpBirth.Value = customer.Birth;
            }
            else
            {
                dtpBirth.Value = DateTime.Today;
            }

            radMale.Checked = string.Equals(customer.Sex, "Masculino", StringComparison.OrdinalIgnoreCase);
            radFemale.Checked = string.Equals(customer.Sex, "Femenino", StringComparison.OrdinalIgnoreCase);
            radOther.Checked = string.Equals(customer.Sex, "Otro", StringComparison.OrdinalIgnoreCase);
        }

        private void ActualizarEstadoBotones(bool modoEdicion)
        {
            bool showActiveButtons = swtActive.Checked;

            icoBtnClear.Visible = showActiveButtons;
            icoBtnClear.Enabled = showActiveButtons;
            btnClear.Visible = showActiveButtons;
            btnClear.Enabled = showActiveButtons;

            icoBtnSave.Visible = showActiveButtons;
            icoBtnSave.Enabled = showActiveButtons && !modoEdicion;
            btnSave.Visible = showActiveButtons;
            btnSave.Enabled = showActiveButtons && !modoEdicion;

            icoBtnUpdate.Visible = showActiveButtons;
            icoBtnUpdate.Enabled = showActiveButtons && modoEdicion;
            btnUpdate.Visible = showActiveButtons;
            btnUpdate.Enabled = showActiveButtons && modoEdicion;

            icoBtnDelete.Visible = showActiveButtons;
            icoBtnDelete.Enabled = showActiveButtons && modoEdicion;
            btnDelete.Visible = showActiveButtons;
            btnDelete.Enabled = showActiveButtons && modoEdicion;

            icoBtnReactivate.Visible = !showActiveButtons;
            icoBtnReactivate.Enabled = !showActiveButtons;
            btnReactivate.Visible = !showActiveButtons;
            btnReactivate.Enabled = !showActiveButtons;
        }

        private void LimpiarFormulario()
        {
            _selectedCustomerId = 0;

            txtName.Clear();
            txtLastname.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtNationality.Clear();
            txtLocality.Clear();

            dtpBirth.Value = DateTime.Today;
            radMale.Checked = true; // Masculino por defecto

            dtgCustomers.ClearSelection();
            ActualizarEstadoBotones(modoEdicion: false);
        }

        #endregion

        #region Comportamiento del Buscador Dinámico

        private void InitializeSearchBehavior()
        {
            _searchDebounceTimer = new System.Windows.Forms.Timer();
            _searchDebounceTimer.Interval = 350;
            _searchDebounceTimer.Tick += SearchDebounceTimer_Tick;

            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            _searchDebounceTimer?.Stop();
            _searchDebounceTimer?.Start();
        }

        private void SearchDebounceTimer_Tick(object? sender, EventArgs e)
        {
            _searchDebounceTimer?.Stop();
            ExecuteCustomerSearch();
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _searchDebounceTimer?.Stop();
                ExecuteCustomerSearch();
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            _searchDebounceTimer?.Stop();
            ExecuteCustomerSearch();
        }

        private void ExecuteCustomerSearch()
        {
            string searchTerm = txtSearch.Text;
            bool isInactiveMode = !swtActive.Checked;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                List<Customer> customerList = _customerService.SearchCustomersByStatus(searchTerm, isInactiveMode);

                dtgCustomers.DataSource = null;
                dtgCustomers.DataSource = customerList;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error al buscar clientes: {ex.Message}",
                    "Error de Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region Control del Switch de Estado (Activos / Inactivos)

        private void InitializeStatusSwitch()
        {
            swtActive.Text = swtActive.Checked ? "Activos" : "Inactivos";
            ActualizarEstadoBotones(modoEdicion: _selectedCustomerId > 0);
            swtActive.CheckedChanged += swtActive_CheckedChanged;

            btnReactivate.Click += btnReactivate_Click;
            icoBtnReactivate.Click += btnReactivate_Click;
        }

        private void swtActive_CheckedChanged(object? sender, EventArgs e)
        {
            swtActive.Text = swtActive.Checked ? "Activos" : "Inactivos";
            ActualizarEstadoBotones(modoEdicion: _selectedCustomerId > 0);
            txtSearch.Clear();
            LimpiarFormulario();
            fillActiveCustomers();
        }

        #endregion
    }
}

