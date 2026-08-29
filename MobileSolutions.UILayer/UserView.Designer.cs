namespace MobileSolutions.UILayer
{
    partial class UserView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new MaterialSkin.Controls.MaterialTextBox2();
            txtLastname = new MaterialSkin.Controls.MaterialTextBox2();
            txtDNI = new MaterialSkin.Controls.MaterialTextBox2();
            txtUsername = new MaterialSkin.Controls.MaterialTextBox2();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox2();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            txtNationality = new MaterialSkin.Controls.MaterialTextBox2();
            txtLocality = new MaterialSkin.Controls.MaterialTextBox2();
            lblName = new MaterialSkin.Controls.MaterialLabel();
            lblLastname = new MaterialSkin.Controls.MaterialLabel();
            lblDNI = new MaterialSkin.Controls.MaterialLabel();
            lblUsername = new MaterialSkin.Controls.MaterialLabel();
            lblPassword = new MaterialSkin.Controls.MaterialLabel();
            lblEmail = new MaterialSkin.Controls.MaterialLabel();
            lblPhone = new MaterialSkin.Controls.MaterialLabel();
            lblAddress = new MaterialSkin.Controls.MaterialLabel();
            lblNationality = new MaterialSkin.Controls.MaterialLabel();
            lblLocality = new MaterialSkin.Controls.MaterialLabel();
            radMale = new MaterialSkin.Controls.MaterialRadioButton();
            radFemale = new MaterialSkin.Controls.MaterialRadioButton();
            radOther = new MaterialSkin.Controls.MaterialRadioButton();
            lblSex = new MaterialSkin.Controls.MaterialLabel();
            lblBirth = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker1 = new DateTimePicker();
            lblProfile = new MaterialSkin.Controls.MaterialLabel();
            chkAdmin = new MaterialSkin.Controls.MaterialCheckbox();
            chkManager = new MaterialSkin.Controls.MaterialCheckbox();
            chkSeller = new MaterialSkin.Controls.MaterialCheckbox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            ColumnId = new DataGridViewLinkColumn();
            ColumnProfile = new DataGridViewLinkColumn();
            ColumnName = new DataGridViewLinkColumn();
            ColumnLastname = new DataGridViewLinkColumn();
            ColumnUsername = new DataGridViewLinkColumn();
            ColumnDNI = new DataGridViewLinkColumn();
            ColumnSex = new DataGridViewLinkColumn();
            ColumnBirth = new DataGridViewLinkColumn();
            ColumnEmail = new DataGridViewLinkColumn();
            ColumnPhone = new DataGridViewLinkColumn();
            ColumnAddress = new DataGridViewLinkColumn();
            ColumnNationality = new DataGridViewLinkColumn();
            ColumnLocality = new DataGridViewLinkColumn();
            btnActive = new MaterialSkin.Controls.MaterialButton();
            btnInactive = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(172, 31);
            txtName.MaxLength = 32767;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(239, 48);
            txtName.TabIndex = 0;
            txtName.TabStop = false;
            txtName.Text = "Nombre";
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtLastname
            // 
            txtLastname.AnimateReadOnly = false;
            txtLastname.BackgroundImageLayout = ImageLayout.None;
            txtLastname.CharacterCasing = CharacterCasing.Normal;
            txtLastname.Depth = 0;
            txtLastname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastname.HideSelection = true;
            txtLastname.LeadingIcon = null;
            txtLastname.Location = new Point(171, 85);
            txtLastname.MaxLength = 32767;
            txtLastname.MouseState = MaterialSkin.MouseState.OUT;
            txtLastname.Name = "txtLastname";
            txtLastname.PasswordChar = '\0';
            txtLastname.PrefixSuffixText = null;
            txtLastname.ReadOnly = false;
            txtLastname.RightToLeft = RightToLeft.No;
            txtLastname.SelectedText = "";
            txtLastname.SelectionLength = 0;
            txtLastname.SelectionStart = 0;
            txtLastname.ShortcutsEnabled = true;
            txtLastname.Size = new Size(240, 48);
            txtLastname.TabIndex = 1;
            txtLastname.TabStop = false;
            txtLastname.Text = "Apellido";
            txtLastname.TextAlign = HorizontalAlignment.Left;
            txtLastname.TrailingIcon = null;
            txtLastname.UseSystemPasswordChar = false;
            // 
            // txtDNI
            // 
            txtDNI.AnimateReadOnly = false;
            txtDNI.BackgroundImageLayout = ImageLayout.None;
            txtDNI.CharacterCasing = CharacterCasing.Normal;
            txtDNI.Depth = 0;
            txtDNI.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDNI.HideSelection = true;
            txtDNI.LeadingIcon = null;
            txtDNI.Location = new Point(171, 139);
            txtDNI.MaxLength = 32767;
            txtDNI.MouseState = MaterialSkin.MouseState.OUT;
            txtDNI.Name = "txtDNI";
            txtDNI.PasswordChar = '\0';
            txtDNI.PrefixSuffixText = null;
            txtDNI.ReadOnly = false;
            txtDNI.RightToLeft = RightToLeft.No;
            txtDNI.SelectedText = "";
            txtDNI.SelectionLength = 0;
            txtDNI.SelectionStart = 0;
            txtDNI.ShortcutsEnabled = true;
            txtDNI.Size = new Size(239, 48);
            txtDNI.TabIndex = 2;
            txtDNI.TabStop = false;
            txtDNI.Text = "DNI";
            txtDNI.TextAlign = HorizontalAlignment.Left;
            txtDNI.TrailingIcon = null;
            txtDNI.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            txtUsername.AnimateReadOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HideSelection = true;
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(171, 193);
            txtUsername.MaxLength = 32767;
            txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PrefixSuffixText = null;
            txtUsername.ReadOnly = false;
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Size = new Size(238, 48);
            txtUsername.TabIndex = 3;
            txtUsername.TabStop = false;
            txtUsername.Text = "Nombre de usuario";
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(171, 247);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(238, 48);
            txtPassword.TabIndex = 4;
            txtPassword.TabStop = false;
            txtPassword.Text = "Contrasena";
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(549, 31);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(238, 48);
            txtEmail.TabIndex = 5;
            txtEmail.TabStop = false;
            txtEmail.Text = "Email";
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            txtPhone.AnimateReadOnly = false;
            txtPhone.BackgroundImageLayout = ImageLayout.None;
            txtPhone.CharacterCasing = CharacterCasing.Normal;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.HideSelection = true;
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(549, 85);
            txtPhone.MaxLength = 32767;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.PrefixSuffixText = null;
            txtPhone.ReadOnly = false;
            txtPhone.RightToLeft = RightToLeft.No;
            txtPhone.SelectedText = "";
            txtPhone.SelectionLength = 0;
            txtPhone.SelectionStart = 0;
            txtPhone.ShortcutsEnabled = true;
            txtPhone.Size = new Size(240, 48);
            txtPhone.TabIndex = 6;
            txtPhone.TabStop = false;
            txtPhone.Text = "Telefono";
            txtPhone.TextAlign = HorizontalAlignment.Left;
            txtPhone.TrailingIcon = null;
            txtPhone.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(551, 139);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.ReadOnly = false;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(238, 48);
            txtAddress.TabIndex = 7;
            txtAddress.TabStop = false;
            txtAddress.Text = "Direccion";
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtNationality
            // 
            txtNationality.AnimateReadOnly = false;
            txtNationality.BackgroundImageLayout = ImageLayout.None;
            txtNationality.CharacterCasing = CharacterCasing.Normal;
            txtNationality.Depth = 0;
            txtNationality.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNationality.HideSelection = true;
            txtNationality.LeadingIcon = null;
            txtNationality.Location = new Point(551, 193);
            txtNationality.MaxLength = 32767;
            txtNationality.MouseState = MaterialSkin.MouseState.OUT;
            txtNationality.Name = "txtNationality";
            txtNationality.PasswordChar = '\0';
            txtNationality.PrefixSuffixText = null;
            txtNationality.ReadOnly = false;
            txtNationality.RightToLeft = RightToLeft.No;
            txtNationality.SelectedText = "";
            txtNationality.SelectionLength = 0;
            txtNationality.SelectionStart = 0;
            txtNationality.ShortcutsEnabled = true;
            txtNationality.Size = new Size(238, 48);
            txtNationality.TabIndex = 8;
            txtNationality.TabStop = false;
            txtNationality.Text = "Nacionalidad";
            txtNationality.TextAlign = HorizontalAlignment.Left;
            txtNationality.TrailingIcon = null;
            txtNationality.UseSystemPasswordChar = false;
            // 
            // txtLocality
            // 
            txtLocality.AnimateReadOnly = false;
            txtLocality.BackgroundImageLayout = ImageLayout.None;
            txtLocality.CharacterCasing = CharacterCasing.Normal;
            txtLocality.Depth = 0;
            txtLocality.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocality.HideSelection = true;
            txtLocality.LeadingIcon = null;
            txtLocality.Location = new Point(551, 247);
            txtLocality.MaxLength = 32767;
            txtLocality.MouseState = MaterialSkin.MouseState.OUT;
            txtLocality.Name = "txtLocality";
            txtLocality.PasswordChar = '\0';
            txtLocality.PrefixSuffixText = null;
            txtLocality.ReadOnly = false;
            txtLocality.RightToLeft = RightToLeft.No;
            txtLocality.SelectedText = "";
            txtLocality.SelectionLength = 0;
            txtLocality.SelectionStart = 0;
            txtLocality.ShortcutsEnabled = true;
            txtLocality.Size = new Size(238, 48);
            txtLocality.TabIndex = 9;
            txtLocality.TabStop = false;
            txtLocality.Text = "Localidad";
            txtLocality.TextAlign = HorizontalAlignment.Left;
            txtLocality.TrailingIcon = null;
            txtLocality.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Depth = 0;
            lblName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblName.Location = new Point(83, 60);
            lblName.MouseState = MaterialSkin.MouseState.HOVER;
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 19);
            lblName.TabIndex = 10;
            lblName.Text = "Nombre:";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Depth = 0;
            lblLastname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLastname.Location = new Point(83, 114);
            lblLastname.MouseState = MaterialSkin.MouseState.HOVER;
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(62, 19);
            lblLastname.TabIndex = 11;
            lblLastname.Text = "Apellido:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Depth = 0;
            lblDNI.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDNI.Location = new Point(83, 168);
            lblDNI.MouseState = MaterialSkin.MouseState.HOVER;
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(31, 19);
            lblDNI.TabIndex = 12;
            lblDNI.Text = "DNI:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Depth = 0;
            lblUsername.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUsername.Location = new Point(83, 222);
            lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 19);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Depth = 0;
            lblPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPassword.Location = new Point(83, 276);
            lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 19);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Contraseña:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Depth = 0;
            lblEmail.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEmail.Location = new Point(450, 60);
            lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(45, 19);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Depth = 0;
            lblPhone.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblPhone.Location = new Point(450, 114);
            lblPhone.MouseState = MaterialSkin.MouseState.HOVER;
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(68, 19);
            lblPhone.TabIndex = 16;
            lblPhone.Text = "Telefono:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Depth = 0;
            lblAddress.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAddress.Location = new Point(450, 168);
            lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(71, 19);
            lblAddress.TabIndex = 17;
            lblAddress.Text = "Direccion:";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Depth = 0;
            lblNationality.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNationality.Location = new Point(450, 222);
            lblNationality.MouseState = MaterialSkin.MouseState.HOVER;
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(99, 19);
            lblNationality.TabIndex = 18;
            lblNationality.Text = "Nacionalidad:";
            // 
            // lblLocality
            // 
            lblLocality.AutoSize = true;
            lblLocality.Depth = 0;
            lblLocality.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblLocality.Location = new Point(450, 276);
            lblLocality.MouseState = MaterialSkin.MouseState.HOVER;
            lblLocality.Name = "lblLocality";
            lblLocality.Size = new Size(75, 19);
            lblLocality.TabIndex = 19;
            lblLocality.Text = "Localidad:";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Depth = 0;
            radMale.Location = new Point(877, 38);
            radMale.Margin = new Padding(0);
            radMale.MouseLocation = new Point(-1, -1);
            radMale.MouseState = MaterialSkin.MouseState.HOVER;
            radMale.Name = "radMale";
            radMale.Ripple = true;
            radMale.Size = new Size(109, 37);
            radMale.TabIndex = 20;
            radMale.TabStop = true;
            radMale.Text = "Masculino";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Depth = 0;
            radFemale.Location = new Point(986, 38);
            radFemale.Margin = new Padding(0);
            radFemale.MouseLocation = new Point(-1, -1);
            radFemale.MouseState = MaterialSkin.MouseState.HOVER;
            radFemale.Name = "radFemale";
            radFemale.Ripple = true;
            radFemale.Size = new Size(105, 37);
            radFemale.TabIndex = 21;
            radFemale.TabStop = true;
            radFemale.Text = "Femenino";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            radOther.AutoSize = true;
            radOther.Depth = 0;
            radOther.Location = new Point(1091, 38);
            radOther.Margin = new Padding(0);
            radOther.MouseLocation = new Point(-1, -1);
            radOther.MouseState = MaterialSkin.MouseState.HOVER;
            radOther.Name = "radOther";
            radOther.Ripple = true;
            radOther.Size = new Size(65, 37);
            radOther.TabIndex = 22;
            radOther.TabStop = true;
            radOther.Text = "Otro";
            radOther.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Depth = 0;
            lblSex.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSex.Location = new Point(823, 49);
            lblSex.MouseState = MaterialSkin.MouseState.HOVER;
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(40, 19);
            lblSex.TabIndex = 23;
            lblSex.Text = "Sexo:";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Depth = 0;
            lblBirth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBirth.Location = new Point(823, 85);
            lblBirth.MouseState = MaterialSkin.MouseState.HOVER;
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(105, 19);
            lblBirth.TabIndex = 24;
            lblBirth.Text = "Fecha de Nac.:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(946, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(109, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Depth = 0;
            lblProfile.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProfile.Location = new Point(823, 124);
            lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(80, 19);
            lblProfile.TabIndex = 26;
            lblProfile.Text = "Perfil / Rol:";
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Depth = 0;
            chkAdmin.Location = new Point(920, 124);
            chkAdmin.Margin = new Padding(0);
            chkAdmin.MouseLocation = new Point(-1, -1);
            chkAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            chkAdmin.Name = "chkAdmin";
            chkAdmin.ReadOnly = false;
            chkAdmin.Ripple = true;
            chkAdmin.Size = new Size(135, 37);
            chkAdmin.TabIndex = 27;
            chkAdmin.Text = "Administrador";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkManager
            // 
            chkManager.AutoSize = true;
            chkManager.Depth = 0;
            chkManager.Location = new Point(920, 158);
            chkManager.Margin = new Padding(0);
            chkManager.MouseLocation = new Point(-1, -1);
            chkManager.MouseState = MaterialSkin.MouseState.HOVER;
            chkManager.Name = "chkManager";
            chkManager.ReadOnly = false;
            chkManager.Ripple = true;
            chkManager.Size = new Size(89, 37);
            chkManager.TabIndex = 28;
            chkManager.Text = "Gerente";
            chkManager.UseVisualStyleBackColor = true;
            // 
            // chkSeller
            // 
            chkSeller.AutoSize = true;
            chkSeller.Depth = 0;
            chkSeller.Location = new Point(920, 195);
            chkSeller.Margin = new Padding(0);
            chkSeller.MouseLocation = new Point(-1, -1);
            chkSeller.MouseState = MaterialSkin.MouseState.HOVER;
            chkSeller.Name = "chkSeller";
            chkSeller.ReadOnly = false;
            chkSeller.Ripple = true;
            chkSeller.Size = new Size(102, 37);
            chkSeller.TabIndex = 29;
            chkSeller.Text = "Vendedor";
            chkSeller.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(877, 259);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(88, 36);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(1012, 259);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(79, 36);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnProfile, ColumnName, ColumnLastname, ColumnUsername, ColumnDNI, ColumnSex, ColumnBirth, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNationality, ColumnLocality });
            dataGridView1.Location = new Point(27, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1117, 249);
            dataGridView1.TabIndex = 32;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "IdUsuario";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 125;
            // 
            // ColumnProfile
            // 
            ColumnProfile.HeaderText = "idPerfil";
            ColumnProfile.MinimumWidth = 6;
            ColumnProfile.Name = "ColumnProfile";
            ColumnProfile.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnLastname
            // 
            ColumnLastname.HeaderText = "Apellido";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            ColumnLastname.Width = 125;
            // 
            // ColumnUsername
            // 
            ColumnUsername.HeaderText = "Usuario";
            ColumnUsername.MinimumWidth = 6;
            ColumnUsername.Name = "ColumnUsername";
            ColumnUsername.Width = 125;
            // 
            // ColumnDNI
            // 
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.MinimumWidth = 6;
            ColumnDNI.Name = "ColumnDNI";
            ColumnDNI.Width = 125;
            // 
            // ColumnSex
            // 
            ColumnSex.HeaderText = "Sexo";
            ColumnSex.MinimumWidth = 6;
            ColumnSex.Name = "ColumnSex";
            ColumnSex.Width = 125;
            // 
            // ColumnBirth
            // 
            ColumnBirth.HeaderText = "Fecha de Nac.";
            ColumnBirth.MinimumWidth = 6;
            ColumnBirth.Name = "ColumnBirth";
            ColumnBirth.Width = 125;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Width = 125;
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Telefono";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.Width = 125;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Direccion";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.Width = 125;
            // 
            // ColumnNationality
            // 
            ColumnNationality.HeaderText = "Nacionalidad";
            ColumnNationality.MinimumWidth = 6;
            ColumnNationality.Name = "ColumnNationality";
            ColumnNationality.Width = 125;
            // 
            // ColumnLocality
            // 
            ColumnLocality.HeaderText = "Localidad";
            ColumnLocality.MinimumWidth = 6;
            ColumnLocality.Name = "ColumnLocality";
            ColumnLocality.Width = 125;
            // 
            // btnActive
            // 
            btnActive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActive.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnActive.Depth = 0;
            btnActive.HighEmphasis = true;
            btnActive.Icon = null;
            btnActive.Location = new Point(27, 344);
            btnActive.Margin = new Padding(4, 6, 4, 6);
            btnActive.MouseState = MaterialSkin.MouseState.HOVER;
            btnActive.Name = "btnActive";
            btnActive.NoAccentTextColor = Color.Empty;
            btnActive.Size = new Size(82, 36);
            btnActive.TabIndex = 33;
            btnActive.Text = "Activos";
            btnActive.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnActive.UseAccentColor = false;
            btnActive.UseVisualStyleBackColor = true;
            // 
            // btnInactive
            // 
            btnInactive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnInactive.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnInactive.Depth = 0;
            btnInactive.HighEmphasis = true;
            btnInactive.Icon = null;
            btnInactive.Location = new Point(117, 344);
            btnInactive.Margin = new Padding(4, 6, 4, 6);
            btnInactive.MouseState = MaterialSkin.MouseState.HOVER;
            btnInactive.Name = "btnInactive";
            btnInactive.NoAccentTextColor = Color.Empty;
            btnInactive.Size = new Size(97, 36);
            btnInactive.TabIndex = 34;
            btnInactive.Text = "Inactivos";
            btnInactive.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnInactive.UseAccentColor = false;
            btnInactive.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(0, 0);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(10, 10);
            materialCheckbox1.TabIndex = 0;
            materialCheckbox1.Text = "materialCheckbox1";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnInactive);
            Controls.Add(btnActive);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(chkSeller);
            Controls.Add(chkManager);
            Controls.Add(chkAdmin);
            Controls.Add(lblProfile);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblBirth);
            Controls.Add(lblSex);
            Controls.Add(radOther);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(lblLocality);
            Controls.Add(lblNationality);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblDNI);
            Controls.Add(lblLastname);
            Controls.Add(lblName);
            Controls.Add(txtLocality);
            Controls.Add(txtNationality);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtDNI);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Name = "UserView";
            Size = new Size(1213, 655);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtLastname;
        private MaterialSkin.Controls.MaterialTextBox2 txtDNI;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsername;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtPhone;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtNationality;
        private MaterialSkin.Controls.MaterialTextBox2 txtLocality;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblLastname;
        private MaterialSkin.Controls.MaterialLabel lblDNI;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialLabel lblPhone;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblNationality;
        private MaterialSkin.Controls.MaterialLabel lblLocality;
        private MaterialSkin.Controls.MaterialRadioButton radMale;
        private MaterialSkin.Controls.MaterialRadioButton radFemale;
        private MaterialSkin.Controls.MaterialRadioButton radOther;
        private MaterialSkin.Controls.MaterialLabel lblSex;
        private MaterialSkin.Controls.MaterialLabel lblBirth;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialCheckbox chkAdmin;
        private MaterialSkin.Controls.MaterialCheckbox chkManager;
        private MaterialSkin.Controls.MaterialCheckbox chkSeller;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private DataGridView dataGridView1;
        private DataGridViewLinkColumn ColumnId;
        private DataGridViewLinkColumn ColumnProfile;
        private DataGridViewLinkColumn ColumnName;
        private DataGridViewLinkColumn ColumnLastname;
        private DataGridViewLinkColumn ColumnUsername;
        private DataGridViewLinkColumn ColumnDNI;
        private DataGridViewLinkColumn ColumnSex;
        private DataGridViewLinkColumn ColumnBirth;
        private DataGridViewLinkColumn ColumnEmail;
        private DataGridViewLinkColumn ColumnPhone;
        private DataGridViewLinkColumn ColumnAddress;
        private DataGridViewLinkColumn ColumnNationality;
        private DataGridViewLinkColumn ColumnLocality;
        private MaterialSkin.Controls.MaterialButton btnActive;
        private MaterialSkin.Controls.MaterialButton btnInactive;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
    }
}
