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
            radMale = new MaterialSkin.Controls.MaterialRadioButton();
            radFemale = new MaterialSkin.Controls.MaterialRadioButton();
            radOther = new MaterialSkin.Controls.MaterialRadioButton();
            lblSex = new MaterialSkin.Controls.MaterialLabel();
            lblBirth = new MaterialSkin.Controls.MaterialLabel();
            dtpBirth = new DateTimePicker();
            lblProfile = new MaterialSkin.Controls.MaterialLabel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            swtActive = new MaterialSkin.Controls.MaterialSwitch();
            panel1 = new Panel();
            panel2 = new Panel();
            dtgUsers = new DataGridView();
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
            panel3 = new Panel();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Right;
            txtName.AnimateReadOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "Nombre";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(48, 63);
            txtName.Margin = new Padding(3, 2, 3, 2);
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
            txtName.Size = new Size(209, 48);
            txtName.TabIndex = 0;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // txtLastname
            // 
            txtLastname.Anchor = AnchorStyles.Right;
            txtLastname.AnimateReadOnly = false;
            txtLastname.BackgroundImageLayout = ImageLayout.None;
            txtLastname.CharacterCasing = CharacterCasing.Normal;
            txtLastname.Depth = 0;
            txtLastname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLastname.HideSelection = true;
            txtLastname.Hint = "Apellido";
            txtLastname.LeadingIcon = null;
            txtLastname.Location = new Point(50, 138);
            txtLastname.Margin = new Padding(3, 2, 3, 2);
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
            txtLastname.Size = new Size(210, 48);
            txtLastname.TabIndex = 1;
            txtLastname.TabStop = false;
            txtLastname.TextAlign = HorizontalAlignment.Left;
            txtLastname.TrailingIcon = null;
            txtLastname.UseSystemPasswordChar = false;
            txtLastname.KeyPress += txtLastname_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.Right;
            txtDNI.AnimateReadOnly = false;
            txtDNI.BackgroundImageLayout = ImageLayout.None;
            txtDNI.CharacterCasing = CharacterCasing.Normal;
            txtDNI.Depth = 0;
            txtDNI.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDNI.HideSelection = true;
            txtDNI.Hint = "DNI";
            txtDNI.LeadingIcon = null;
            txtDNI.Location = new Point(50, 218);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
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
            txtDNI.Size = new Size(212, 48);
            txtDNI.TabIndex = 2;
            txtDNI.TabStop = false;
            txtDNI.TextAlign = HorizontalAlignment.Left;
            txtDNI.TrailingIcon = null;
            txtDNI.UseSystemPasswordChar = false;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Right;
            txtUsername.AnimateReadOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.CharacterCasing = CharacterCasing.Normal;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HideSelection = true;
            txtUsername.Hint = "Usuario";
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(48, 294);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
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
            txtUsername.Size = new Size(212, 48);
            txtUsername.TabIndex = 3;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Right;
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(48, 365);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
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
            txtPassword.Size = new Size(212, 48);
            txtPassword.TabIndex = 4;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(347, 63);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
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
            txtEmail.Size = new Size(208, 48);
            txtEmail.TabIndex = 5;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Right;
            txtPhone.AnimateReadOnly = false;
            txtPhone.BackgroundImageLayout = ImageLayout.None;
            txtPhone.CharacterCasing = CharacterCasing.Normal;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.HideSelection = true;
            txtPhone.Hint = "Teléfono";
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(347, 138);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
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
            txtPhone.Size = new Size(210, 48);
            txtPhone.TabIndex = 6;
            txtPhone.TabStop = false;
            txtPhone.TextAlign = HorizontalAlignment.Left;
            txtPhone.TrailingIcon = null;
            txtPhone.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Right;
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Dirección";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(347, 218);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
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
            txtAddress.Size = new Size(208, 48);
            txtAddress.TabIndex = 7;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtNationality
            // 
            txtNationality.Anchor = AnchorStyles.Right;
            txtNationality.AnimateReadOnly = false;
            txtNationality.BackgroundImageLayout = ImageLayout.None;
            txtNationality.CharacterCasing = CharacterCasing.Normal;
            txtNationality.Depth = 0;
            txtNationality.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNationality.HideSelection = true;
            txtNationality.Hint = "Nacionalidad";
            txtNationality.LeadingIcon = null;
            txtNationality.Location = new Point(349, 294);
            txtNationality.Margin = new Padding(3, 2, 3, 2);
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
            txtNationality.Size = new Size(208, 48);
            txtNationality.TabIndex = 8;
            txtNationality.TabStop = false;
            txtNationality.TextAlign = HorizontalAlignment.Left;
            txtNationality.TrailingIcon = null;
            txtNationality.UseSystemPasswordChar = false;
            // 
            // txtLocality
            // 
            txtLocality.Anchor = AnchorStyles.Right;
            txtLocality.AnimateReadOnly = false;
            txtLocality.BackgroundImageLayout = ImageLayout.None;
            txtLocality.CharacterCasing = CharacterCasing.Normal;
            txtLocality.Depth = 0;
            txtLocality.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLocality.HideSelection = true;
            txtLocality.Hint = "Localidad";
            txtLocality.LeadingIcon = null;
            txtLocality.Location = new Point(347, 365);
            txtLocality.Margin = new Padding(3, 2, 3, 2);
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
            txtLocality.Size = new Size(208, 48);
            txtLocality.TabIndex = 9;
            txtLocality.TabStop = false;
            txtLocality.TextAlign = HorizontalAlignment.Left;
            txtLocality.TrailingIcon = null;
            txtLocality.UseSystemPasswordChar = false;
            // 
            // radMale
            // 
            radMale.Anchor = AnchorStyles.Left;
            radMale.AutoSize = true;
            radMale.Depth = 0;
            radMale.Location = new Point(173, 229);
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
            radFemale.Anchor = AnchorStyles.Left;
            radFemale.AutoSize = true;
            radFemale.Depth = 0;
            radFemale.Location = new Point(45, 229);
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
            radOther.Anchor = AnchorStyles.Left;
            radOther.AutoSize = true;
            radOther.Depth = 0;
            radOther.Location = new Point(310, 229);
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
            lblSex.Anchor = AnchorStyles.Left;
            lblSex.AutoSize = true;
            lblSex.Depth = 0;
            lblSex.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSex.Location = new Point(206, 193);
            lblSex.MouseState = MaterialSkin.MouseState.HOVER;
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(40, 19);
            lblSex.TabIndex = 23;
            lblSex.Text = "Sexo:";
            // 
            // lblBirth
            // 
            lblBirth.Anchor = AnchorStyles.Left;
            lblBirth.AutoSize = true;
            lblBirth.Depth = 0;
            lblBirth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBirth.Location = new Point(152, 92);
            lblBirth.MouseState = MaterialSkin.MouseState.HOVER;
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(150, 19);
            lblBirth.TabIndex = 24;
            lblBirth.Text = "Fecha de Nacimiento";
            // 
            // dtpBirth
            // 
            dtpBirth.Anchor = AnchorStyles.Left;
            dtpBirth.CalendarFont = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirth.CalendarMonthBackground = SystemColors.HighlightText;
            dtpBirth.Cursor = Cursors.Hand;
            dtpBirth.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.ImeMode = ImeMode.NoControl;
            dtpBirth.Location = new Point(149, 121);
            dtpBirth.Margin = new Padding(3, 2, 3, 2);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(153, 33);
            dtpBirth.TabIndex = 25;
            // 
            // lblProfile
            // 
            lblProfile.Anchor = AnchorStyles.Left;
            lblProfile.AutoSize = true;
            lblProfile.Depth = 0;
            lblProfile.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProfile.Location = new Point(184, 338);
            lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(80, 19);
            lblProfile.TabIndex = 26;
            lblProfile.Text = "Perfil / Rol:";
            lblProfile.Click += lblProfile_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(554, 138);
            btnSave.Margin = new Padding(4);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(88, 36);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(554, 204);
            btnClear.Margin = new Padding(4);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(79, 36);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
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
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(621, 48);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(125, 19);
            materialLabel1.TabIndex = 35;
            materialLabel1.Text = "Datos Personales";
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(554, 262);
            materialButton1.Margin = new Padding(4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(88, 36);
            materialButton1.TabIndex = 37;
            materialButton1.Text = "Eliminar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Right;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(554, 338);
            materialButton2.Margin = new Padding(4);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(99, 36);
            materialButton2.TabIndex = 36;
            materialButton2.Text = "Modificar";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(48, 491);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(173, 37);
            swtActive.TabIndex = 38;
            swtActive.Text = "materialSwitch1";
            swtActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(swtActive);
            panel1.Controls.Add(txtLastname);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtNationality);
            panel1.Controls.Add(txtLocality);
            panel1.Location = new Point(10, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 532);
            panel1.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(dtgUsers);
            panel2.Location = new Point(0, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 205);
            panel2.TabIndex = 40;
            // 
            // dtgUsers
            // 
            dtgUsers.AllowUserToOrderColumns = true;
            dtgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsers.BackgroundColor = Color.MidnightBlue;
            dtgUsers.BorderStyle = BorderStyle.None;
            dtgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsers.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnProfile, ColumnName, ColumnLastname, ColumnUsername, ColumnDNI, ColumnSex, ColumnBirth, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNationality, ColumnLocality });
            dtgUsers.Dock = DockStyle.Fill;
            dtgUsers.GridColor = SystemColors.InactiveCaptionText;
            dtgUsers.Location = new Point(0, 0);
            dtgUsers.Margin = new Padding(3, 2, 3, 2);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.RowHeadersWidth = 51;
            dtgUsers.Size = new Size(1304, 205);
            dtgUsers.TabIndex = 33;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "IdUsuario";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            // 
            // ColumnProfile
            // 
            ColumnProfile.HeaderText = "idPerfil";
            ColumnProfile.MinimumWidth = 6;
            ColumnProfile.Name = "ColumnProfile";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            // 
            // ColumnLastname
            // 
            ColumnLastname.HeaderText = "Apellido";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            // 
            // ColumnUsername
            // 
            ColumnUsername.HeaderText = "Usuario";
            ColumnUsername.MinimumWidth = 6;
            ColumnUsername.Name = "ColumnUsername";
            // 
            // ColumnDNI
            // 
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.MinimumWidth = 6;
            ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnSex
            // 
            ColumnSex.HeaderText = "Sexo";
            ColumnSex.MinimumWidth = 6;
            ColumnSex.Name = "ColumnSex";
            // 
            // ColumnBirth
            // 
            ColumnBirth.HeaderText = "Fecha de Nac.";
            ColumnBirth.MinimumWidth = 6;
            ColumnBirth.Name = "ColumnBirth";
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Telefono";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Direccion";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnNationality
            // 
            ColumnNationality.HeaderText = "Nacionalidad";
            ColumnNationality.MinimumWidth = 6;
            ColumnNationality.Name = "ColumnNationality";
            // 
            // ColumnLocality
            // 
            ColumnLocality.HeaderText = "Localidad";
            ColumnLocality.MinimumWidth = 6;
            ColumnLocality.Name = "ColumnLocality";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.Controls.Add(materialRadioButton1);
            panel3.Controls.Add(materialSwitch1);
            panel3.Controls.Add(radMale);
            panel3.Controls.Add(materialRadioButton2);
            panel3.Controls.Add(radFemale);
            panel3.Controls.Add(materialButton1);
            panel3.Controls.Add(materialRadioButton3);
            panel3.Controls.Add(radOther);
            panel3.Controls.Add(materialButton2);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(lblProfile);
            panel3.Controls.Add(lblSex);
            panel3.Controls.Add(lblBirth);
            panel3.Controls.Add(dtpBirth);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(621, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(683, 532);
            panel3.TabIndex = 41;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.Anchor = AnchorStyles.Left;
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(33, 376);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(135, 37);
            materialRadioButton1.TabIndex = 39;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "Administrador";
            materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            materialSwitch1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            materialSwitch1.AutoSize = true;
            materialSwitch1.Checked = true;
            materialSwitch1.CheckState = CheckState.Checked;
            materialSwitch1.Depth = 0;
            materialSwitch1.Location = new Point(48, 923);
            materialSwitch1.Margin = new Padding(0);
            materialSwitch1.MouseLocation = new Point(-1, -1);
            materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch1.Name = "materialSwitch1";
            materialSwitch1.Ripple = true;
            materialSwitch1.Size = new Size(173, 37);
            materialSwitch1.TabIndex = 38;
            materialSwitch1.Text = "materialSwitch1";
            materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.Anchor = AnchorStyles.Left;
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(193, 376);
            materialRadioButton2.Margin = new Padding(0);
            materialRadioButton2.MouseLocation = new Point(-1, -1);
            materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton2.Name = "materialRadioButton2";
            materialRadioButton2.Ripple = true;
            materialRadioButton2.Size = new Size(89, 37);
            materialRadioButton2.TabIndex = 40;
            materialRadioButton2.TabStop = true;
            materialRadioButton2.Text = "Gerente";
            materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.Anchor = AnchorStyles.Left;
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(310, 376);
            materialRadioButton3.Margin = new Padding(0);
            materialRadioButton3.MouseLocation = new Point(-1, -1);
            materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton3.Name = "materialRadioButton3";
            materialRadioButton3.Ripple = true;
            materialRadioButton3.Size = new Size(102, 37);
            materialRadioButton3.TabIndex = 41;
            materialRadioButton3.TabStop = true;
            materialRadioButton3.Text = "Vendedor";
            materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(materialLabel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserView";
            Size = new Size(1304, 848);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRadioButton radMale;
        private MaterialSkin.Controls.MaterialRadioButton radFemale;
        private MaterialSkin.Controls.MaterialRadioButton radOther;
        private MaterialSkin.Controls.MaterialLabel lblSex;
        private MaterialSkin.Controls.MaterialLabel lblBirth;
        private DateTimePicker dtpBirth;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialSwitch swtActive;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgUsers;
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
        private Panel panel3;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
    }
}
