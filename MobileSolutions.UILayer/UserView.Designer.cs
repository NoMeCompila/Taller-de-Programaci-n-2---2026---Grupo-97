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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnClear = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            lblUserTitle = new MaterialSkin.Controls.MaterialLabel();
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
            ColumnProfile = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastname = new DataGridViewTextBoxColumn();
            ColumnUsername = new DataGridViewTextBoxColumn();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnSex = new DataGridViewTextBoxColumn();
            ColumnBirth = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnNationality = new DataGridViewTextBoxColumn();
            ColumnLocality = new DataGridViewTextBoxColumn();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            picSex = new FontAwesome.Sharp.IconPictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton9 = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            picBirth = new FontAwesome.Sharp.IconPictureBox();
            iconBtn = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            picUserTitle = new FontAwesome.Sharp.IconPictureBox();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblProfile = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            picProfile = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
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
            txtName.Location = new Point(67, 22);
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
            txtLastname.Location = new Point(70, 122);
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
            txtDNI.Location = new Point(70, 229);
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
            txtDNI.Size = new Size(242, 48);
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
            txtUsername.Location = new Point(67, 330);
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
            txtUsername.Size = new Size(242, 48);
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
            txtPassword.Location = new Point(67, 425);
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
            txtPassword.Size = new Size(242, 48);
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
            txtEmail.Location = new Point(407, 22);
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
            txtPhone.Location = new Point(407, 122);
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
            txtAddress.Location = new Point(407, 229);
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
            txtNationality.Location = new Point(409, 330);
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
            txtLocality.Location = new Point(407, 425);
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
            lblBirth.Location = new Point(72, 18);
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
            dtpBirth.Location = new Point(33, 65);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(174, 39);
            dtpBirth.TabIndex = 25;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(1266, 227);
            btnClear.Margin = new Padding(5, 5, 5, 5);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(143, 44);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.TextAlign = ContentAlignment.BottomCenter;
            btnClear.TextImageRelation = TextImageRelation.ImageAboveText;
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
            lblUserTitle.Anchor = AnchorStyles.Top;
            lblUserTitle.AutoSize = true;
            lblUserTitle.Depth = 0;
            lblUserTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblUserTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblUserTitle.Location = new Point(701, 0);
            lblUserTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(283, 72);
            lblUserTitle.TabIndex = 35;
            lblUserTitle.Text = "USUARIOS";
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(1052, 659);
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
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(dtgUsers);
            panel1.Controls.Add(swtActive);
            panel1.Controls.Add(materialTextBox21);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(materialCard4);
            panel1.Controls.Add(lblUserTitle);
            panel1.Controls.Add(materialCard3);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(iconBtn);
            panel1.Controls.Add(picUserTitle);
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1640, 1193);
            panel1.TabIndex = 39;
            // 
            // materialCard2
            // 
            materialCard2.AutoSize = true;
            materialCard2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            materialCard2.Location = new Point(5, 110);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(675, 500);
            materialCard2.TabIndex = 43;
            materialCard2.Paint += materialCard2_Paint;
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
            btnLoc.Location = new Point(358, 425);
            btnLoc.Margin = new Padding(5, 5, 5, 5);
            btnLoc.MouseState = MaterialSkin.MouseState.HOVER;
            btnLoc.Name = "btnLoc";
            btnLoc.NoAccentTextColor = Color.Empty;
            btnLoc.Size = new Size(43, 51);
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
            btnNat.Location = new Point(358, 330);
            btnNat.Margin = new Padding(5, 5, 5, 5);
            btnNat.MouseState = MaterialSkin.MouseState.HOVER;
            btnNat.Name = "btnNat";
            btnNat.NoAccentTextColor = Color.Empty;
            btnNat.Size = new Size(43, 51);
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
            btnAddress.Location = new Point(358, 229);
            btnAddress.Margin = new Padding(5, 5, 5, 5);
            btnAddress.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddress.Name = "btnAddress";
            btnAddress.NoAccentTextColor = Color.Empty;
            btnAddress.Size = new Size(43, 51);
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
            btnCel.Location = new Point(358, 122);
            btnCel.Margin = new Padding(5, 5, 5, 5);
            btnCel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCel.Name = "btnCel";
            btnCel.NoAccentTextColor = Color.Empty;
            btnCel.Size = new Size(43, 51);
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
            btnEmail.Location = new Point(358, 22);
            btnEmail.Margin = new Padding(5, 5, 5, 5);
            btnEmail.MouseState = MaterialSkin.MouseState.HOVER;
            btnEmail.Name = "btnEmail";
            btnEmail.NoAccentTextColor = Color.Empty;
            btnEmail.Size = new Size(43, 51);
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
            btnPassword.Location = new Point(18, 425);
            btnPassword.Margin = new Padding(5, 5, 5, 5);
            btnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            btnPassword.Name = "btnPassword";
            btnPassword.NoAccentTextColor = Color.Empty;
            btnPassword.Size = new Size(43, 51);
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
            btnUser.Location = new Point(18, 330);
            btnUser.Margin = new Padding(5, 5, 5, 5);
            btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnUser.Name = "btnUser";
            btnUser.NoAccentTextColor = Color.Empty;
            btnUser.Size = new Size(43, 51);
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
            btnDni.Location = new Point(18, 229);
            btnDni.Margin = new Padding(5, 5, 5, 5);
            btnDni.MouseState = MaterialSkin.MouseState.HOVER;
            btnDni.Name = "btnDni";
            btnDni.NoAccentTextColor = Color.Empty;
            btnDni.Size = new Size(43, 51);
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
            btnLastname.Location = new Point(18, 122);
            btnLastname.Margin = new Padding(5, 5, 5, 5);
            btnLastname.MouseState = MaterialSkin.MouseState.HOVER;
            btnLastname.Name = "btnLastname";
            btnLastname.NoAccentTextColor = Color.Empty;
            btnLastname.Size = new Size(43, 51);
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
            btnName.Location = new Point(18, 22);
            btnName.Margin = new Padding(5, 5, 5, 5);
            btnName.MouseState = MaterialSkin.MouseState.HOVER;
            btnName.Name = "btnName";
            btnName.NoAccentTextColor = Color.Empty;
            btnName.Size = new Size(43, 51);
            btnName.TabIndex = 44;
            btnName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnName.UseAccentColor = false;
            btnName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1640, 1197);
            panel2.TabIndex = 40;
            // 
            // dtgUsers
            // 
            dtgUsers.AllowUserToOrderColumns = true;
            dtgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsers.BackgroundColor = Color.MidnightBlue;
            dtgUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsers.Columns.AddRange(new DataGridViewColumn[] { ColumnProfile, ColumnName, ColumnLastname, ColumnUsername, ColumnDNI, ColumnSex, ColumnBirth, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNationality, ColumnLocality });
            dtgUsers.Dock = DockStyle.Bottom;
            dtgUsers.GridColor = SystemColors.InactiveCaptionText;
            dtgUsers.Location = new Point(0, 710);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.RowHeadersWidth = 51;
            dtgUsers.Size = new Size(1640, 483);
            dtgUsers.TabIndex = 33;
            // 
            // ColumnProfile
            // 
            ColumnProfile.HeaderText = "Perfil";
            ColumnProfile.MinimumWidth = 6;
            ColumnProfile.Name = "ColumnProfile";
            ColumnProfile.Resizable = DataGridViewTriState.True;
            ColumnProfile.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Resizable = DataGridViewTriState.True;
            ColumnName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnLastname
            // 
            ColumnLastname.HeaderText = "Apellido";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            ColumnLastname.Resizable = DataGridViewTriState.True;
            ColumnLastname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnUsername
            // 
            ColumnUsername.HeaderText = "Usuario";
            ColumnUsername.MinimumWidth = 6;
            ColumnUsername.Name = "ColumnUsername";
            ColumnUsername.Resizable = DataGridViewTriState.True;
            ColumnUsername.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDNI
            // 
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.MinimumWidth = 6;
            ColumnDNI.Name = "ColumnDNI";
            ColumnDNI.Resizable = DataGridViewTriState.True;
            ColumnDNI.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSex
            // 
            ColumnSex.HeaderText = "Sexo";
            ColumnSex.MinimumWidth = 6;
            ColumnSex.Name = "ColumnSex";
            ColumnSex.Resizable = DataGridViewTriState.True;
            ColumnSex.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnBirth
            // 
            ColumnBirth.HeaderText = "Fecha de Nac.";
            ColumnBirth.MinimumWidth = 6;
            ColumnBirth.Name = "ColumnBirth";
            ColumnBirth.Resizable = DataGridViewTriState.True;
            ColumnBirth.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.Resizable = DataGridViewTriState.True;
            ColumnEmail.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Teléfono";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.Resizable = DataGridViewTriState.True;
            ColumnPhone.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Dirección";
            ColumnAddress.MinimumWidth = 6;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.Resizable = DataGridViewTriState.True;
            ColumnAddress.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNationality
            // 
            ColumnNationality.HeaderText = "Nacionalidad";
            ColumnNationality.MinimumWidth = 6;
            ColumnNationality.Name = "ColumnNationality";
            ColumnNationality.Resizable = DataGridViewTriState.True;
            ColumnNationality.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnLocality
            // 
            ColumnLocality.HeaderText = "Localidad";
            ColumnLocality.MinimumWidth = 6;
            ColumnLocality.Name = "ColumnLocality";
            ColumnLocality.Resizable = DataGridViewTriState.True;
            ColumnLocality.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // materialCard4
            // 
            materialCard4.AutoSize = true;
            materialCard4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(picSex);
            materialCard4.Controls.Add(materialLabel2);
            materialCard4.Controls.Add(materialRadioButton6);
            materialCard4.Controls.Add(materialRadioButton7);
            materialCard4.Controls.Add(materialRadioButton9);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(701, 277);
            materialCard4.Margin = new Padding(16, 19, 16, 19);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(16, 19, 16, 19);
            materialCard4.Size = new Size(400, 110);
            materialCard4.TabIndex = 43;
            // 
            // picSex
            // 
            picSex.BackColor = Color.FromArgb(255, 255, 255);
            picSex.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconChar = FontAwesome.Sharp.IconChar.None;
            picSex.IconColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picSex.IconSize = 37;
            picSex.Location = new Point(157, 7);
            picSex.Margin = new Padding(3, 4, 3, 4);
            picSex.Name = "picSex";
            picSex.Size = new Size(37, 43);
            picSex.TabIndex = 43;
            picSex.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(200, 19);
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
            materialRadioButton6.Location = new Point(173, 54);
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
            materialRadioButton7.Location = new Point(319, 54);
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
            materialRadioButton9.Location = new Point(33, 54);
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
            materialCard3.AutoSize = true;
            materialCard3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(picBirth);
            materialCard3.Controls.Add(lblBirth);
            materialCard3.Controls.Add(dtpBirth);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(701, 132);
            materialCard3.Margin = new Padding(16, 19, 16, 19);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16, 19, 16, 19);
            materialCard3.Size = new Size(241, 126);
            materialCard3.TabIndex = 43;
            // 
            // picBirth
            // 
            picBirth.BackColor = Color.FromArgb(255, 255, 255);
            picBirth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconChar = FontAwesome.Sharp.IconChar.None;
            picBirth.IconColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBirth.IconSize = 37;
            picBirth.Location = new Point(27, 5);
            picBirth.Margin = new Padding(3, 4, 3, 4);
            picBirth.Name = "picBirth";
            picBirth.Size = new Size(37, 43);
            picBirth.TabIndex = 44;
            picBirth.TabStop = false;
            // 
            // iconBtn
            // 
            iconBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconBtn.BackColor = Color.RoyalBlue;
            iconBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtn.ForeColor = SystemColors.Control;
            iconBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconBtn.IconColor = Color.White;
            iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtn.IconSize = 60;
            iconBtn.Location = new Point(1429, 132);
            iconBtn.Margin = new Padding(3, 4, 3, 4);
            iconBtn.Name = "iconBtn";
            iconBtn.Size = new Size(171, 160);
            iconBtn.TabIndex = 44;
            iconBtn.Text = "BUTTON";
            iconBtn.TextAlign = ContentAlignment.BottomCenter;
            iconBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            iconBtn.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton1.BackColor = Color.RoyalBlue;
            iconButton1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 60;
            iconButton1.Location = new Point(1252, 132);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(171, 160);
            iconButton1.TabIndex = 45;
            iconButton1.Text = "BUTTON";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // picUserTitle
            // 
            picUserTitle.Anchor = AnchorStyles.Top;
            picUserTitle.BackColor = Color.FromArgb(255, 255, 255);
            picUserTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picUserTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picUserTitle.IconSize = 97;
            picUserTitle.Location = new Point(577, 0);
            picUserTitle.Margin = new Padding(3, 4, 3, 4);
            picUserTitle.Name = "picUserTitle";
            picUserTitle.Size = new Size(97, 100);
            picUserTitle.TabIndex = 45;
            picUserTitle.TabStop = false;
            // 
            // materialTextBox21
            // 
            materialTextBox21.Anchor = AnchorStyles.Bottom;
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HelperText = "Buscar por...";
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Buscar";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(688, 654);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(347, 48);
            materialTextBox21.TabIndex = 54;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom;
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(637, 651);
            btnSearch.Margin = new Padding(5, 5, 5, 5);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(43, 51);
            btnSearch.TabIndex = 54;
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // iconButton3
            // 
            iconButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton3.BackColor = Color.RoyalBlue;
            iconButton3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.Control;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 60;
            iconButton3.Location = new Point(1429, 331);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(171, 160);
            iconButton3.TabIndex = 47;
            iconButton3.Text = "BUTTON";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconButton2.BackColor = Color.RoyalBlue;
            iconButton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = SystemColors.Control;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 60;
            iconButton2.Location = new Point(1252, 328);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(171, 160);
            iconButton2.TabIndex = 46;
            iconButton2.Text = "BUTTON";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(1445, 227);
            btnSave.Margin = new Padding(5);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(143, 44);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.Enabled = false;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(1266, 422);
            btnUpdate.Margin = new Padding(5);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(143, 44);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.Enabled = false;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(1445, 422);
            btnDelete.Margin = new Padding(5);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(143, 44);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // materialCard1
            // 
            materialCard1.AutoSize = true;
            materialCard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(picProfile);
            materialCard1.Controls.Add(materialRadioButton1);
            materialCard1.Controls.Add(materialRadioButton2);
            materialCard1.Controls.Add(materialRadioButton3);
            materialCard1.Controls.Add(lblProfile);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(701, 415);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(453, 139);
            materialCard1.TabIndex = 42;
            // 
            // lblProfile
            // 
            lblProfile.Anchor = AnchorStyles.Left;
            lblProfile.AutoSize = true;
            lblProfile.Depth = 0;
            lblProfile.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProfile.Location = new Point(231, 28);
            lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 19);
            lblProfile.TabIndex = 26;
            lblProfile.Text = "PERFIL";
            lblProfile.Click += lblProfile_Click;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.Anchor = AnchorStyles.Left;
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(335, 83);
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
            // materialRadioButton2
            // 
            materialRadioButton2.Anchor = AnchorStyles.Left;
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(207, 83);
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
            // materialRadioButton1
            // 
            materialRadioButton1.Anchor = AnchorStyles.Left;
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Checked = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(19, 83);
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
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(255, 255, 255);
            picProfile.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            picProfile.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProfile.IconSize = 37;
            picProfile.Location = new Point(185, 14);
            picProfile.Margin = new Padding(3, 4, 3, 4);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(37, 43);
            picProfile.TabIndex = 44;
            picProfile.TabStop = false;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserView";
            Size = new Size(1640, 1197);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialLabel lblUserTitle;
        private MaterialSkin.Controls.MaterialSwitch swtActive;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgUsers;
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
        private FontAwesome.Sharp.IconPictureBox picBirth;
        private FontAwesome.Sharp.IconPictureBox picUserTitle;
        private DataGridViewTextBoxColumn ColumnProfile;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnUsername;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnSex;
        private DataGridViewTextBoxColumn ColumnBirth;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnNationality;
        private DataGridViewTextBoxColumn ColumnLocality;
        private FontAwesome.Sharp.IconButton iconBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private FontAwesome.Sharp.IconPictureBox picProfile;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}
