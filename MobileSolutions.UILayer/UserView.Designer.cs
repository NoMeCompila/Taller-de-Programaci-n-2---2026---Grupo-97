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
            lblBirth = new MaterialSkin.Controls.MaterialLabel();
            dtpBirth = new DateTimePicker();
            lblProfile = new MaterialSkin.Controls.MaterialLabel();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            lblUserTitle = new MaterialSkin.Controls.MaterialLabel();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            swtActive = new MaterialSkin.Controls.MaterialSwitch();
            panel1 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnLoc = new MaterialSkin.Controls.MaterialButton();
            btnNat = new MaterialSkin.Controls.MaterialButton();
            btnAddress = new MaterialSkin.Controls.MaterialButton();
            btnCel = new MaterialSkin.Controls.MaterialButton();
            btnEmail = new MaterialSkin.Controls.MaterialButton();
            btnPassword = new MaterialSkin.Controls.MaterialButton();
            btnUser = new MaterialSkin.Controls.MaterialButton();
            btnDni = new MaterialSkin.Controls.MaterialButton();
            btnLastname = new MaterialSkin.Controls.MaterialButton();
            btnName = new MaterialSkin.Controls.MaterialButton();
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
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            picSex = new FontAwesome.Sharp.IconPictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton9 = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            picBirth = new FontAwesome.Sharp.IconPictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            picProfile = new FontAwesome.Sharp.IconPictureBox();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            picUserTitle = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            panel3.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).BeginInit();
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
            txtName.Location = new Point(59, 31);
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
            txtLastname.Location = new Point(61, 106);
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
            txtDNI.Location = new Point(61, 186);
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
            txtUsername.Location = new Point(59, 262);
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
            txtUsername.KeyPress += txtUsername_KeyPress;
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
            txtPassword.Location = new Point(59, 333);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
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
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
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
            txtEmail.Location = new Point(356, 31);
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
            txtPhone.Location = new Point(356, 106);
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
            txtPhone.KeyPress += txtPhone_KeyPress_1;
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
            txtAddress.Location = new Point(356, 186);
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
            txtNationality.Location = new Point(358, 262);
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
            txtLocality.Location = new Point(356, 333);
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
            // lblBirth
            // 
            lblBirth.Anchor = AnchorStyles.Left;
            lblBirth.AutoSize = true;
            lblBirth.Depth = 0;
            lblBirth.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBirth.Location = new Point(61, 19);
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
            dtpBirth.Location = new Point(42, 51);
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
            lblProfile.Location = new Point(204, 26);
            lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 19);
            lblProfile.TabIndex = 26;
            lblProfile.Text = "PERFIL";
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
            btnSave.Location = new Point(509, 138);
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
            btnClear.Location = new Point(509, 193);
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
            // lblUserTitle
            // 
            lblUserTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUserTitle.AutoSize = true;
            lblUserTitle.Depth = 0;
            lblUserTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblUserTitle.Location = new Point(553, 18);
            lblUserTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(283, 72);
            lblUserTitle.TabIndex = 35;
            lblUserTitle.Text = "USUARIOS";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(509, 249);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(88, 36);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(509, 304);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(14, 448);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(102, 37);
            swtActive.TabIndex = 38;
            swtActive.Text = "Activo";
            swtActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(swtActive);
            panel1.Location = new Point(10, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 489);
            panel1.TabIndex = 39;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnLoc);
            materialCard2.Controls.Add(btnNat);
            materialCard2.Controls.Add(btnAddress);
            materialCard2.Controls.Add(btnCel);
            materialCard2.Controls.Add(btnEmail);
            materialCard2.Controls.Add(btnPassword);
            materialCard2.Controls.Add(btnUser);
            materialCard2.Controls.Add(btnDni);
            materialCard2.Controls.Add(btnLastname);
            materialCard2.Controls.Add(btnName);
            materialCard2.Controls.Add(txtEmail);
            materialCard2.Controls.Add(txtName);
            materialCard2.Controls.Add(txtLocality);
            materialCard2.Controls.Add(txtNationality);
            materialCard2.Controls.Add(txtLastname);
            materialCard2.Controls.Add(txtAddress);
            materialCard2.Controls.Add(txtDNI);
            materialCard2.Controls.Add(txtPhone);
            materialCard2.Controls.Add(txtUsername);
            materialCard2.Controls.Add(txtPassword);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(4, 42);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(591, 404);
            materialCard2.TabIndex = 43;
            // 
            // btnLoc
            // 
            btnLoc.Anchor = AnchorStyles.Right;
            btnLoc.AutoSize = false;
            btnLoc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoc.Depth = 0;
            btnLoc.HighEmphasis = true;
            btnLoc.Icon = null;
            btnLoc.Location = new Point(313, 333);
            btnLoc.Margin = new Padding(4);
            btnLoc.MouseState = MaterialSkin.MouseState.HOVER;
            btnLoc.Name = "btnLoc";
            btnLoc.NoAccentTextColor = Color.Empty;
            btnLoc.Size = new Size(38, 38);
            btnLoc.TabIndex = 53;
            btnLoc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLoc.UseAccentColor = false;
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnNat
            // 
            btnNat.Anchor = AnchorStyles.Right;
            btnNat.AutoSize = false;
            btnNat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNat.Depth = 0;
            btnNat.HighEmphasis = true;
            btnNat.Icon = null;
            btnNat.Location = new Point(313, 262);
            btnNat.Margin = new Padding(4);
            btnNat.MouseState = MaterialSkin.MouseState.HOVER;
            btnNat.Name = "btnNat";
            btnNat.NoAccentTextColor = Color.Empty;
            btnNat.Size = new Size(38, 38);
            btnNat.TabIndex = 52;
            btnNat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNat.UseAccentColor = false;
            btnNat.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            btnAddress.Anchor = AnchorStyles.Right;
            btnAddress.AutoSize = false;
            btnAddress.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddress.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddress.Depth = 0;
            btnAddress.HighEmphasis = true;
            btnAddress.Icon = null;
            btnAddress.Location = new Point(313, 186);
            btnAddress.Margin = new Padding(4);
            btnAddress.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddress.Name = "btnAddress";
            btnAddress.NoAccentTextColor = Color.Empty;
            btnAddress.Size = new Size(38, 38);
            btnAddress.TabIndex = 51;
            btnAddress.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddress.UseAccentColor = false;
            btnAddress.UseVisualStyleBackColor = true;
            // 
            // btnCel
            // 
            btnCel.Anchor = AnchorStyles.Right;
            btnCel.AutoSize = false;
            btnCel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCel.Depth = 0;
            btnCel.HighEmphasis = true;
            btnCel.Icon = null;
            btnCel.Location = new Point(313, 106);
            btnCel.Margin = new Padding(4);
            btnCel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCel.Name = "btnCel";
            btnCel.NoAccentTextColor = Color.Empty;
            btnCel.Size = new Size(38, 38);
            btnCel.TabIndex = 50;
            btnCel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCel.UseAccentColor = false;
            btnCel.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            btnEmail.Anchor = AnchorStyles.Right;
            btnEmail.AutoSize = false;
            btnEmail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEmail.Depth = 0;
            btnEmail.HighEmphasis = true;
            btnEmail.Icon = null;
            btnEmail.Location = new Point(313, 31);
            btnEmail.Margin = new Padding(4);
            btnEmail.MouseState = MaterialSkin.MouseState.HOVER;
            btnEmail.Name = "btnEmail";
            btnEmail.NoAccentTextColor = Color.Empty;
            btnEmail.Size = new Size(38, 38);
            btnEmail.TabIndex = 49;
            btnEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEmail.UseAccentColor = false;
            btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            btnPassword.Anchor = AnchorStyles.Right;
            btnPassword.AutoSize = false;
            btnPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPassword.Depth = 0;
            btnPassword.HighEmphasis = true;
            btnPassword.Icon = null;
            btnPassword.Location = new Point(16, 333);
            btnPassword.Margin = new Padding(4);
            btnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            btnPassword.Name = "btnPassword";
            btnPassword.NoAccentTextColor = Color.Empty;
            btnPassword.Size = new Size(38, 38);
            btnPassword.TabIndex = 48;
            btnPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPassword.UseAccentColor = false;
            btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Right;
            btnUser.AutoSize = false;
            btnUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUser.Depth = 0;
            btnUser.HighEmphasis = true;
            btnUser.Icon = null;
            btnUser.Location = new Point(16, 262);
            btnUser.Margin = new Padding(4);
            btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnUser.Name = "btnUser";
            btnUser.NoAccentTextColor = Color.Empty;
            btnUser.Size = new Size(38, 38);
            btnUser.TabIndex = 47;
            btnUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUser.UseAccentColor = false;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnDni
            // 
            btnDni.Anchor = AnchorStyles.Right;
            btnDni.AutoSize = false;
            btnDni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDni.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDni.Depth = 0;
            btnDni.HighEmphasis = true;
            btnDni.Icon = null;
            btnDni.Location = new Point(16, 186);
            btnDni.Margin = new Padding(4);
            btnDni.MouseState = MaterialSkin.MouseState.HOVER;
            btnDni.Name = "btnDni";
            btnDni.NoAccentTextColor = Color.Empty;
            btnDni.Size = new Size(38, 38);
            btnDni.TabIndex = 46;
            btnDni.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDni.UseAccentColor = false;
            btnDni.UseVisualStyleBackColor = true;
            // 
            // btnLastname
            // 
            btnLastname.Anchor = AnchorStyles.Right;
            btnLastname.AutoSize = false;
            btnLastname.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLastname.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLastname.Depth = 0;
            btnLastname.HighEmphasis = true;
            btnLastname.Icon = null;
            btnLastname.Location = new Point(16, 106);
            btnLastname.Margin = new Padding(4);
            btnLastname.MouseState = MaterialSkin.MouseState.HOVER;
            btnLastname.Name = "btnLastname";
            btnLastname.NoAccentTextColor = Color.Empty;
            btnLastname.Size = new Size(38, 38);
            btnLastname.TabIndex = 45;
            btnLastname.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLastname.UseAccentColor = false;
            btnLastname.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            btnName.Anchor = AnchorStyles.Right;
            btnName.AutoSize = false;
            btnName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnName.Depth = 0;
            btnName.HighEmphasis = true;
            btnName.Icon = null;
            btnName.Location = new Point(16, 31);
            btnName.Margin = new Padding(4);
            btnName.MouseState = MaterialSkin.MouseState.HOVER;
            btnName.Name = "btnName";
            btnName.NoAccentTextColor = Color.Empty;
            btnName.Size = new Size(38, 38);
            btnName.TabIndex = 44;
            btnName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnName.UseAccentColor = false;
            btnName.UseVisualStyleBackColor = true;
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
            panel3.Controls.Add(materialCard4);
            panel3.Controls.Add(materialCard3);
            panel3.Controls.Add(materialCard1);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(621, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 489);
            panel3.TabIndex = 41;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(picSex);
            materialCard4.Controls.Add(materialLabel2);
            materialCard4.Controls.Add(materialRadioButton6);
            materialCard4.Controls.Add(materialRadioButton7);
            materialCard4.Controls.Add(materialRadioButton9);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(60, 179);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(380, 106);
            materialCard4.TabIndex = 43;
            // 
            // picSex
            // 
            picSex.BackColor = Color.FromArgb(255, 255, 255);
            picSex.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconChar = FontAwesome.Sharp.IconChar.None;
            picSex.IconColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picSex.Location = new Point(160, 17);
            picSex.Name = "picSex";
            picSex.Size = new Size(32, 32);
            picSex.TabIndex = 43;
            picSex.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(198, 23);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 19);
            materialLabel2.TabIndex = 42;
            materialLabel2.Text = "SEXO";
            // 
            // materialRadioButton6
            // 
            materialRadioButton6.Anchor = AnchorStyles.Left;
            materialRadioButton6.AutoSize = true;
            materialRadioButton6.Depth = 0;
            materialRadioButton6.Location = new Point(151, 52);
            materialRadioButton6.Margin = new Padding(0);
            materialRadioButton6.MouseLocation = new Point(-1, -1);
            materialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton6.Name = "materialRadioButton6";
            materialRadioButton6.Ripple = true;
            materialRadioButton6.Size = new Size(109, 37);
            materialRadioButton6.TabIndex = 20;
            materialRadioButton6.TabStop = true;
            materialRadioButton6.Text = "Masculino";
            materialRadioButton6.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton7
            // 
            materialRadioButton7.Anchor = AnchorStyles.Left;
            materialRadioButton7.AutoSize = true;
            materialRadioButton7.Depth = 0;
            materialRadioButton7.Location = new Point(279, 52);
            materialRadioButton7.Margin = new Padding(0);
            materialRadioButton7.MouseLocation = new Point(-1, -1);
            materialRadioButton7.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton7.Name = "materialRadioButton7";
            materialRadioButton7.Ripple = true;
            materialRadioButton7.Size = new Size(65, 37);
            materialRadioButton7.TabIndex = 22;
            materialRadioButton7.TabStop = true;
            materialRadioButton7.Text = "Otro";
            materialRadioButton7.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton9
            // 
            materialRadioButton9.Anchor = AnchorStyles.Left;
            materialRadioButton9.AutoSize = true;
            materialRadioButton9.Checked = true;
            materialRadioButton9.Depth = 0;
            materialRadioButton9.Location = new Point(29, 52);
            materialRadioButton9.Margin = new Padding(0);
            materialRadioButton9.MouseLocation = new Point(-1, -1);
            materialRadioButton9.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton9.Name = "materialRadioButton9";
            materialRadioButton9.Ripple = true;
            materialRadioButton9.Size = new Size(105, 37);
            materialRadioButton9.TabIndex = 21;
            materialRadioButton9.TabStop = true;
            materialRadioButton9.Text = "Femenino";
            materialRadioButton9.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(picBirth);
            materialCard3.Controls.Add(lblBirth);
            materialCard3.Controls.Add(dtpBirth);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(125, 42);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(228, 100);
            materialCard3.TabIndex = 43;
            // 
            // picBirth
            // 
            picBirth.BackColor = Color.FromArgb(255, 255, 255);
            picBirth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconChar = FontAwesome.Sharp.IconChar.None;
            picBirth.IconColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBirth.Location = new Point(23, 14);
            picBirth.Name = "picBirth";
            picBirth.Size = new Size(32, 32);
            picBirth.TabIndex = 44;
            picBirth.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(picProfile);
            materialCard1.Controls.Add(materialRadioButton1);
            materialCard1.Controls.Add(materialRadioButton2);
            materialCard1.Controls.Add(materialRadioButton3);
            materialCard1.Controls.Add(lblProfile);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(43, 324);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(425, 99);
            materialCard1.TabIndex = 42;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(255, 255, 255);
            picProfile.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            picProfile.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProfile.Location = new Point(168, 18);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(32, 32);
            picProfile.TabIndex = 44;
            picProfile.TabStop = false;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.Anchor = AnchorStyles.Left;
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Checked = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(17, 60);
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
            // materialRadioButton2
            // 
            materialRadioButton2.Anchor = AnchorStyles.Left;
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(181, 60);
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
            materialRadioButton3.Location = new Point(293, 60);
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
            // picUserTitle
            // 
            picUserTitle.BackColor = Color.FromArgb(255, 255, 255);
            picUserTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picUserTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picUserTitle.IconSize = 75;
            picUserTitle.Location = new Point(462, 15);
            picUserTitle.Name = "picUserTitle";
            picUserTitle.Size = new Size(85, 75);
            picUserTitle.TabIndex = 45;
            picUserTitle.TabStop = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picUserTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblUserTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserView";
            Size = new Size(1304, 848);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel lblBirth;
        private DateTimePicker dtpBirth;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel lblUserTitle;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
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
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton6;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton7;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton9;
        private MaterialSkin.Controls.MaterialButton btnName;
        private MaterialSkin.Controls.MaterialButton btnLastname;
        private MaterialSkin.Controls.MaterialButton btnPassword;
        private MaterialSkin.Controls.MaterialButton btnUser;
        private MaterialSkin.Controls.MaterialButton btnDni;
        private MaterialSkin.Controls.MaterialButton btnLoc;
        private MaterialSkin.Controls.MaterialButton btnNat;
        private MaterialSkin.Controls.MaterialButton btnAddress;
        private MaterialSkin.Controls.MaterialButton btnCel;
        private MaterialSkin.Controls.MaterialButton btnEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox picSex;
        private FontAwesome.Sharp.IconPictureBox picProfile;
        private FontAwesome.Sharp.IconPictureBox picBirth;
        private FontAwesome.Sharp.IconPictureBox picUserTitle;
    }
}
