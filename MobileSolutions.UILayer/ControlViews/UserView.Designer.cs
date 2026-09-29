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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            picUserTitle = new FontAwesome.Sharp.IconPictureBox();
            panel7 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            picBirth = new FontAwesome.Sharp.IconPictureBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            picSex = new FontAwesome.Sharp.IconPictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton9 = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            picProfile = new FontAwesome.Sharp.IconPictureBox();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            lblProfile = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            btnReactivate = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            icoBtnReactivate = new FontAwesome.Sharp.IconButton();
            icoBtnUpdate = new FontAwesome.Sharp.IconButton();
            icoBtnClear = new FontAwesome.Sharp.IconButton();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            iconBtnDelete = new FontAwesome.Sharp.IconButton();
            icoBtnSave = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
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
            txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
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
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).BeginInit();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).BeginInit();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            materialCard2.SuspendLayout();
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
            txtName.Location = new Point(84, 11);
            txtName.Margin = new Padding(2);
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
            txtName.Size = new Size(191, 48);
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
            txtLastname.Location = new Point(86, 91);
            txtLastname.Margin = new Padding(2);
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
            txtLastname.Size = new Size(192, 48);
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
            txtDNI.Location = new Point(86, 176);
            txtDNI.Margin = new Padding(2);
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
            txtDNI.Size = new Size(194, 48);
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
            txtUsername.Location = new Point(84, 257);
            txtUsername.Margin = new Padding(2);
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
            txtUsername.Size = new Size(194, 48);
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
            txtPassword.Location = new Point(84, 333);
            txtPassword.Margin = new Padding(2);
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
            txtPassword.Size = new Size(194, 48);
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
            txtEmail.Location = new Point(356, 11);
            txtEmail.Margin = new Padding(2);
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
            txtEmail.Size = new Size(190, 48);
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
            txtPhone.Location = new Point(356, 91);
            txtPhone.Margin = new Padding(2);
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
            txtPhone.Size = new Size(192, 48);
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
            txtAddress.Location = new Point(356, 176);
            txtAddress.Margin = new Padding(2);
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
            txtAddress.Size = new Size(190, 48);
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
            txtNationality.Location = new Point(357, 257);
            txtNationality.Margin = new Padding(2);
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
            txtNationality.Size = new Size(190, 48);
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
            txtLocality.Margin = new Padding(2);
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
            txtLocality.Size = new Size(190, 48);
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
            lblBirth.Location = new Point(199, 29);
            lblBirth.Margin = new Padding(2, 0, 2, 0);
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
            dtpBirth.Location = new Point(183, 68);
            dtpBirth.Margin = new Padding(2);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(140, 33);
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
            btnClear.Location = new Point(35, 94);
            btnClear.Margin = new Padding(4);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(114, 35);
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
            lblUserTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblUserTitle.AutoSize = true;
            lblUserTitle.Depth = 0;
            lblUserTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblUserTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblUserTitle.Location = new Point(289, 15);
            lblUserTitle.Margin = new Padding(2, 0, 2, 0);
            lblUserTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(226, 58);
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
            swtActive.Location = new Point(1018, 21);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(110, 37);
            swtActive.TabIndex = 38;
            swtActive.Text = "Activos";
            swtActive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel6, 1, 0);
            tableLayoutPanel2.Controls.Add(panel7, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1680, 96);
            tableLayoutPanel2.TabIndex = 57;
            // 
            // panel6
            // 
            panel6.Controls.Add(picUserTitle);
            panel6.Controls.Add(lblUserTitle);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(507, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(666, 90);
            panel6.TabIndex = 0;
            // 
            // picUserTitle
            // 
            picUserTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picUserTitle.BackColor = Color.FromArgb(255, 255, 255);
            picUserTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picUserTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picUserTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picUserTitle.IconSize = 69;
            picUserTitle.Location = new Point(197, 3);
            picUserTitle.Margin = new Padding(2, 3, 2, 3);
            picUserTitle.Name = "picUserTitle";
            picUserTitle.Size = new Size(69, 87);
            picUserTitle.TabIndex = 45;
            picUserTitle.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblCurrentUser);
            panel7.Controls.Add(btnLogout);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(1179, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(498, 90);
            panel7.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(95, 10);
            lblCurrentUser.MouseState = MaterialSkin.MouseState.HOVER;
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(79, 24);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "[Usuario]";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(336, 6);
            btnLogout.Margin = new Padding(10);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(131, 36);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9047623F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.8452377F));
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(materialCard2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 168);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.085865F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.914135F));
            tableLayoutPanel1.Size = new Size(1680, 762);
            tableLayoutPanel1.TabIndex = 56;
            // 
            // panel4
            // 
            panel4.Controls.Add(materialCard3);
            panel4.Controls.Add(materialCard4);
            panel4.Controls.Add(materialCard1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(696, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 411);
            panel4.TabIndex = 44;
            // 
            // materialCard3
            // 
            materialCard3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialCard3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(picBirth);
            materialCard3.Controls.Add(lblBirth);
            materialCard3.Controls.Add(dtpBirth);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(8, 6);
            materialCard3.Margin = new Padding(13, 15, 13, 15);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(13, 15, 13, 15);
            materialCard3.Size = new Size(507, 118);
            materialCard3.TabIndex = 43;
            // 
            // picBirth
            // 
            picBirth.BackColor = Color.FromArgb(255, 255, 255);
            picBirth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconChar = FontAwesome.Sharp.IconChar.None;
            picBirth.IconColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBirth.IconSize = 30;
            picBirth.Location = new Point(165, 18);
            picBirth.Margin = new Padding(2, 3, 2, 3);
            picBirth.Name = "picBirth";
            picBirth.Size = new Size(30, 34);
            picBirth.TabIndex = 44;
            picBirth.TabStop = false;
            // 
            // materialCard4
            // 
            materialCard4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialCard4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(picSex);
            materialCard4.Controls.Add(materialLabel2);
            materialCard4.Controls.Add(materialRadioButton6);
            materialCard4.Controls.Add(materialRadioButton7);
            materialCard4.Controls.Add(materialRadioButton9);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(8, 133);
            materialCard4.Margin = new Padding(13, 15, 13, 15);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(13, 15, 13, 15);
            materialCard4.Size = new Size(507, 125);
            materialCard4.TabIndex = 43;
            // 
            // picSex
            // 
            picSex.BackColor = Color.FromArgb(255, 255, 255);
            picSex.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconChar = FontAwesome.Sharp.IconChar.None;
            picSex.IconColor = Color.FromArgb(222, 0, 0, 0);
            picSex.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picSex.IconSize = 30;
            picSex.Location = new Point(197, 9);
            picSex.Margin = new Padding(2, 3, 2, 3);
            picSex.Name = "picSex";
            picSex.Size = new Size(30, 34);
            picSex.TabIndex = 43;
            picSex.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.Left;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(231, 23);
            materialLabel2.Margin = new Padding(2, 0, 2, 0);
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
            materialRadioButton6.Location = new Point(176, 61);
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
            materialRadioButton7.Location = new Point(335, 61);
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
            materialRadioButton9.Location = new Point(26, 61);
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
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(picProfile);
            materialCard1.Controls.Add(materialRadioButton1);
            materialCard1.Controls.Add(materialRadioButton2);
            materialCard1.Controls.Add(materialRadioButton3);
            materialCard1.Controls.Add(lblProfile);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(8, 269);
            materialCard1.Margin = new Padding(13, 15, 13, 15);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(13, 15, 13, 15);
            materialCard1.Size = new Size(507, 125);
            materialCard1.TabIndex = 42;
            // 
            // picProfile
            // 
            picProfile.BackColor = Color.FromArgb(255, 255, 255);
            picProfile.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconChar = FontAwesome.Sharp.IconChar.None;
            picProfile.IconColor = Color.FromArgb(222, 0, 0, 0);
            picProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picProfile.IconSize = 30;
            picProfile.Location = new Point(176, 14);
            picProfile.Margin = new Padding(2, 3, 2, 3);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(30, 34);
            picProfile.TabIndex = 44;
            picProfile.TabStop = false;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.Anchor = AnchorStyles.Left;
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Checked = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(15, 73);
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
            materialRadioButton2.Location = new Point(183, 73);
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
            materialRadioButton3.Location = new Point(317, 73);
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
            // lblProfile
            // 
            lblProfile.Anchor = AnchorStyles.Left;
            lblProfile.AutoSize = true;
            lblProfile.Depth = 0;
            lblProfile.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblProfile.Location = new Point(220, 22);
            lblProfile.Margin = new Padding(2, 0, 2, 0);
            lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(52, 19);
            lblProfile.TabIndex = 26;
            lblProfile.Text = "PERFIL";
            lblProfile.Click += lblProfile_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(btnReactivate);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(icoBtnReactivate);
            panel3.Controls.Add(icoBtnUpdate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(icoBtnClear);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(iconBtnDelete);
            panel3.Controls.Add(icoBtnSave);
            panel3.Location = new Point(1295, 43);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 330);
            panel3.TabIndex = 55;
            // 
            // btnReactivate
            // 
            btnReactivate.Anchor = AnchorStyles.Right;
            btnReactivate.AutoSize = false;
            btnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReactivate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReactivate.Depth = 0;
            btnReactivate.Enabled = false;
            btnReactivate.HighEmphasis = true;
            btnReactivate.Icon = null;
            btnReactivate.Location = new Point(114, 172);
            btnReactivate.Margin = new Padding(4);
            btnReactivate.MouseState = MaterialSkin.MouseState.HOVER;
            btnReactivate.Name = "btnReactivate";
            btnReactivate.NoAccentTextColor = Color.Empty;
            btnReactivate.Size = new Size(114, 35);
            btnReactivate.TabIndex = 56;
            btnReactivate.Text = "Reactivar";
            btnReactivate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReactivate.UseAccentColor = false;
            btnReactivate.UseVisualStyleBackColor = true;
            btnReactivate.Visible = false;
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
            btnUpdate.Location = new Point(35, 261);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(114, 35);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // icoBtnReactivate
            // 
            icoBtnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnReactivate.BackColor = Color.RoyalBlue;
            icoBtnReactivate.Enabled = false;
            icoBtnReactivate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnReactivate.ForeColor = SystemColors.Control;
            icoBtnReactivate.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            icoBtnReactivate.IconColor = Color.White;
            icoBtnReactivate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnReactivate.IconSize = 60;
            icoBtnReactivate.Location = new Point(104, 94);
            icoBtnReactivate.Margin = new Padding(2, 3, 2, 3);
            icoBtnReactivate.Name = "icoBtnReactivate";
            icoBtnReactivate.Size = new Size(137, 128);
            icoBtnReactivate.TabIndex = 57;
            icoBtnReactivate.Text = "BUTTON";
            icoBtnReactivate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnReactivate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnReactivate.UseVisualStyleBackColor = false;
            icoBtnReactivate.Visible = false;
            // 
            // icoBtnUpdate
            // 
            icoBtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnUpdate.BackColor = Color.RoyalBlue;
            icoBtnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnUpdate.ForeColor = SystemColors.Control;
            icoBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            icoBtnUpdate.IconColor = Color.White;
            icoBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnUpdate.IconSize = 60;
            icoBtnUpdate.Location = new Point(24, 177);
            icoBtnUpdate.Margin = new Padding(2, 3, 2, 3);
            icoBtnUpdate.Name = "icoBtnUpdate";
            icoBtnUpdate.Size = new Size(137, 128);
            icoBtnUpdate.TabIndex = 46;
            icoBtnUpdate.Text = "BUTTON";
            icoBtnUpdate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnUpdate.UseVisualStyleBackColor = false;
            // 
            // icoBtnClear
            // 
            icoBtnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnClear.BackColor = Color.RoyalBlue;
            icoBtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnClear.ForeColor = SystemColors.Control;
            icoBtnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            icoBtnClear.IconColor = Color.White;
            icoBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnClear.IconSize = 60;
            icoBtnClear.Location = new Point(24, 18);
            icoBtnClear.Margin = new Padding(2, 3, 2, 3);
            icoBtnClear.Name = "icoBtnClear";
            icoBtnClear.Size = new Size(137, 128);
            icoBtnClear.TabIndex = 45;
            icoBtnClear.Text = "BUTTON";
            icoBtnClear.TextAlign = ContentAlignment.BottomCenter;
            icoBtnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnClear.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(178, 261);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(114, 35);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            btnSave.Location = new Point(178, 100);
            btnSave.Margin = new Padding(4);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(114, 35);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // iconBtnDelete
            // 
            iconBtnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            iconBtnDelete.BackColor = Color.RoyalBlue;
            iconBtnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconBtnDelete.ForeColor = SystemColors.Control;
            iconBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconBtnDelete.IconColor = Color.White;
            iconBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnDelete.IconSize = 60;
            iconBtnDelete.Location = new Point(166, 177);
            iconBtnDelete.Margin = new Padding(2, 3, 2, 3);
            iconBtnDelete.Name = "iconBtnDelete";
            iconBtnDelete.Size = new Size(137, 128);
            iconBtnDelete.TabIndex = 47;
            iconBtnDelete.Text = "BUTTON";
            iconBtnDelete.TextAlign = ContentAlignment.BottomCenter;
            iconBtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            iconBtnDelete.UseVisualStyleBackColor = false;
            // 
            // icoBtnSave
            // 
            icoBtnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnSave.BackColor = Color.RoyalBlue;
            icoBtnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnSave.ForeColor = SystemColors.Control;
            icoBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            icoBtnSave.IconColor = Color.White;
            icoBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnSave.IconSize = 60;
            icoBtnSave.Location = new Point(166, 18);
            icoBtnSave.Margin = new Padding(2, 3, 2, 3);
            icoBtnSave.Name = "icoBtnSave";
            icoBtnSave.Size = new Size(137, 128);
            icoBtnSave.TabIndex = 44;
            icoBtnSave.Text = "BUTTON";
            icoBtnSave.TextAlign = ContentAlignment.BottomCenter;
            icoBtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnSave.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(panel5, 3);
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(dtgUsers);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(swtActive);
            panel5.Location = new Point(3, 425);
            panel5.Name = "panel5";
            panel5.Size = new Size(1674, 334);
            panel5.TabIndex = 56;
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
            btnSearch.Location = new Point(691, 18);
            btnSearch.Margin = new Padding(4);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(34, 41);
            btnSearch.TabIndex = 54;
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
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
            dtgUsers.Location = new Point(0, 65);
            dtgUsers.Margin = new Padding(2);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.RowHeadersWidth = 51;
            dtgUsers.Size = new Size(1674, 269);
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
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Bottom;
            txtSearch.AnimateReadOnly = false;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.HelperText = "Buscar por...";
            txtSearch.HideSelection = true;
            txtSearch.Hint = "Buscar";
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(731, 13);
            txtSearch.Margin = new Padding(2);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.ReadOnly = false;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(278, 48);
            txtSearch.TabIndex = 54;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.None;
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
            materialCard2.Location = new Point(61, 15);
            materialCard2.Margin = new Padding(13, 15, 13, 15);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(13, 15, 13, 15);
            materialCard2.Size = new Size(570, 387);
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
            btnLoc.Location = new Point(316, 333);
            btnLoc.Margin = new Padding(4);
            btnLoc.MouseState = MaterialSkin.MouseState.HOVER;
            btnLoc.Name = "btnLoc";
            btnLoc.NoAccentTextColor = Color.Empty;
            btnLoc.Size = new Size(34, 41);
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
            btnNat.Location = new Point(316, 257);
            btnNat.Margin = new Padding(4);
            btnNat.MouseState = MaterialSkin.MouseState.HOVER;
            btnNat.Name = "btnNat";
            btnNat.NoAccentTextColor = Color.Empty;
            btnNat.Size = new Size(34, 41);
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
            btnAddress.Location = new Point(316, 176);
            btnAddress.Margin = new Padding(4);
            btnAddress.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddress.Name = "btnAddress";
            btnAddress.NoAccentTextColor = Color.Empty;
            btnAddress.Size = new Size(34, 41);
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
            btnCel.Location = new Point(316, 91);
            btnCel.Margin = new Padding(4);
            btnCel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCel.Name = "btnCel";
            btnCel.NoAccentTextColor = Color.Empty;
            btnCel.Size = new Size(34, 41);
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
            btnEmail.Location = new Point(316, 11);
            btnEmail.Margin = new Padding(4);
            btnEmail.MouseState = MaterialSkin.MouseState.HOVER;
            btnEmail.Name = "btnEmail";
            btnEmail.NoAccentTextColor = Color.Empty;
            btnEmail.Size = new Size(34, 41);
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
            btnPassword.Location = new Point(44, 333);
            btnPassword.Margin = new Padding(4);
            btnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            btnPassword.Name = "btnPassword";
            btnPassword.NoAccentTextColor = Color.Empty;
            btnPassword.Size = new Size(34, 41);
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
            btnUser.Location = new Point(44, 257);
            btnUser.Margin = new Padding(4);
            btnUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnUser.Name = "btnUser";
            btnUser.NoAccentTextColor = Color.Empty;
            btnUser.Size = new Size(34, 41);
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
            btnDni.Location = new Point(44, 176);
            btnDni.Margin = new Padding(4);
            btnDni.MouseState = MaterialSkin.MouseState.HOVER;
            btnDni.Name = "btnDni";
            btnDni.NoAccentTextColor = Color.Empty;
            btnDni.Size = new Size(34, 41);
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
            btnLastname.Location = new Point(44, 91);
            btnLastname.Margin = new Padding(4);
            btnLastname.MouseState = MaterialSkin.MouseState.HOVER;
            btnLastname.Name = "btnLastname";
            btnLastname.NoAccentTextColor = Color.Empty;
            btnLastname.Size = new Size(34, 41);
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
            btnName.Location = new Point(44, 11);
            btnName.Margin = new Padding(4);
            btnName.MouseState = MaterialSkin.MouseState.HOVER;
            btnName.Name = "btnName";
            btnName.NoAccentTextColor = Color.Empty;
            btnName.Size = new Size(34, 41);
            btnName.TabIndex = 44;
            btnName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnName.UseAccentColor = false;
            btnName.UseVisualStyleBackColor = true;
            // 
            // UserView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(2);
            Name = "UserView";
            Size = new Size(1680, 930);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserTitle).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).EndInit();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            materialCard2.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton icoBtnSave;
        private FontAwesome.Sharp.IconButton icoBtnClear;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private FontAwesome.Sharp.IconButton iconBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnUpdate;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private FontAwesome.Sharp.IconPictureBox picProfile;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialButton btnReactivate;
        private FontAwesome.Sharp.IconButton icoBtnReactivate;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
    }
}
