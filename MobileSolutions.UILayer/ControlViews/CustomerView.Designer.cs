namespace MobileSolutions.UILayer
{
    partial class CustomerView
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
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox2();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            txtNationality = new MaterialSkin.Controls.MaterialTextBox2();
            txtLocality = new MaterialSkin.Controls.MaterialTextBox2();
            lblBirth = new MaterialSkin.Controls.MaterialLabel();
            dtpBirth = new DateTimePicker();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            lblCustomerTitle = new MaterialSkin.Controls.MaterialLabel();
            btnDelete = new MaterialSkin.Controls.MaterialButton();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            swtActive = new MaterialSkin.Controls.MaterialSwitch();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnLoc = new MaterialSkin.Controls.MaterialButton();
            btnNat = new MaterialSkin.Controls.MaterialButton();
            btnAddress = new MaterialSkin.Controls.MaterialButton();
            btnCel = new MaterialSkin.Controls.MaterialButton();
            btnEmail = new MaterialSkin.Controls.MaterialButton();
            btnDni = new MaterialSkin.Controls.MaterialButton();
            btnLastname = new MaterialSkin.Controls.MaterialButton();
            btnName = new MaterialSkin.Controls.MaterialButton();
            dtgCustomers = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastname = new DataGridViewTextBoxColumn();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnSex = new DataGridViewTextBoxColumn();
            ColumnBirth = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnNationality = new DataGridViewTextBoxColumn();
            ColumnLocality = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            picSex = new FontAwesome.Sharp.IconPictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            radMale = new MaterialSkin.Controls.MaterialRadioButton();
            radOther = new MaterialSkin.Controls.MaterialRadioButton();
            radFemale = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            picBirth = new FontAwesome.Sharp.IconPictureBox();
            picCustomerTitle = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            btnReactivate = new MaterialSkin.Controls.MaterialButton();
            icoBtnReactivate = new FontAwesome.Sharp.IconButton();
            icoBtnUpdate = new FontAwesome.Sharp.IconButton();
            icoBtnClear = new FontAwesome.Sharp.IconButton();
            icoBtnDelete = new FontAwesome.Sharp.IconButton();
            icoBtnSave = new FontAwesome.Sharp.IconButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel6 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            panel3.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerTitle).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
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
            txtName.Location = new Point(186, 60);
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
            txtLastname.Location = new Point(189, 135);
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
            txtDNI.Location = new Point(189, 215);
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
            txtEmail.Location = new Point(483, 60);
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
            txtPhone.Location = new Point(483, 135);
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
            txtPhone.KeyPress += txtPhone_KeyPress;
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
            txtAddress.Location = new Point(483, 215);
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
            txtNationality.Location = new Point(189, 291);
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
            txtLocality.Location = new Point(189, 362);
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
            lblBirth.Location = new Point(151, 14);
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
            dtpBirth.Location = new Point(122, 56);
            dtpBirth.Margin = new Padding(3, 2, 3, 2);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(153, 33);
            dtpBirth.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(257, 171);
            btnSave.Margin = new Padding(4);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(126, 33);
            btnSave.TabIndex = 30;
            btnSave.Text = "Guardar";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(90, 171);
            btnClear.Margin = new Padding(4);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(126, 33);
            btnClear.TabIndex = 31;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Depth = 0;
            lblCustomerTitle.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCustomerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblCustomerTitle.Location = new Point(269, 0);
            lblCustomerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(216, 58);
            lblCustomerTitle.TabIndex = 35;
            lblCustomerTitle.Text = "CLIENTES";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSize = false;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDelete.Depth = 0;
            btnDelete.HighEmphasis = true;
            btnDelete.Icon = null;
            btnDelete.Location = new Point(257, 305);
            btnDelete.Margin = new Padding(4);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.NoAccentTextColor = Color.Empty;
            btnDelete.Size = new Size(126, 33);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Eliminar";
            btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDelete.UseAccentColor = false;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(90, 305);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(126, 33);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Modificar";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // swtActive
            // 
            swtActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            swtActive.AutoSize = true;
            swtActive.Checked = true;
            swtActive.CheckState = CheckState.Checked;
            swtActive.Depth = 0;
            swtActive.Location = new Point(1016, 39);
            swtActive.Margin = new Padding(0);
            swtActive.MouseLocation = new Point(-1, -1);
            swtActive.MouseState = MaterialSkin.MouseState.HOVER;
            swtActive.Name = "swtActive";
            swtActive.Ripple = true;
            swtActive.Size = new Size(102, 37);
            swtActive.TabIndex = 38;
            swtActive.Text = "Activo";
            swtActive.UseVisualStyleBackColor = true;
            swtActive.CheckedChanged += swtActive_CheckedChanged;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnLoc);
            materialCard2.Controls.Add(btnNat);
            materialCard2.Controls.Add(btnAddress);
            materialCard2.Controls.Add(btnCel);
            materialCard2.Controls.Add(btnEmail);
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
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(711, 420);
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
            btnLoc.Location = new Point(143, 362);
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
            btnNat.Location = new Point(143, 291);
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
            btnAddress.Location = new Point(441, 215);
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
            btnCel.Location = new Point(441, 135);
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
            btnEmail.Location = new Point(441, 60);
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
            // btnDni
            // 
            btnDni.Anchor = AnchorStyles.Right;
            btnDni.AutoSize = false;
            btnDni.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDni.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDni.Depth = 0;
            btnDni.HighEmphasis = true;
            btnDni.Icon = null;
            btnDni.Location = new Point(143, 215);
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
            btnLastname.Location = new Point(143, 135);
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
            btnName.Location = new Point(143, 60);
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
            // dtgCustomers
            // 
            dtgCustomers.AllowUserToOrderColumns = true;
            dtgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCustomers.BackgroundColor = Color.MidnightBlue;
            dtgCustomers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastname, ColumnDNI, ColumnSex, ColumnBirth, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNationality, ColumnLocality });
            dtgCustomers.Dock = DockStyle.Bottom;
            dtgCustomers.GridColor = SystemColors.InactiveCaptionText;
            dtgCustomers.Location = new Point(0, 96);
            dtgCustomers.Margin = new Padding(3, 2, 3, 2);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 51;
            dtgCustomers.Size = new Size(1674, 275);
            dtgCustomers.TabIndex = 33;
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
            // panel3
            // 
            panel3.Controls.Add(materialCard4);
            panel3.Controls.Add(materialCard3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(742, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(465, 442);
            panel3.TabIndex = 41;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(picSex);
            materialCard4.Controls.Add(materialLabel2);
            materialCard4.Controls.Add(radMale);
            materialCard4.Controls.Add(radOther);
            materialCard4.Controls.Add(radFemale);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(29, 191);
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
            picSex.Location = new Point(134, 4);
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
            materialLabel2.Location = new Point(193, 10);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(41, 19);
            materialLabel2.TabIndex = 42;
            materialLabel2.Text = "SEXO";
            // 
            // radMale
            // 
            radMale.Anchor = AnchorStyles.Left;
            radMale.AutoSize = true;
            radMale.Depth = 0;
            radMale.Location = new Point(151, 52);
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
            // radOther
            // 
            radOther.Anchor = AnchorStyles.Left;
            radOther.AutoSize = true;
            radOther.Depth = 0;
            radOther.Location = new Point(279, 52);
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
            // radFemale
            // 
            radFemale.Anchor = AnchorStyles.Left;
            radFemale.AutoSize = true;
            radFemale.Checked = true;
            radFemale.Depth = 0;
            radFemale.Location = new Point(29, 52);
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
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(picBirth);
            materialCard3.Controls.Add(lblBirth);
            materialCard3.Controls.Add(dtpBirth);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(29, 65);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(380, 105);
            materialCard3.TabIndex = 43;
            // 
            // picBirth
            // 
            picBirth.Anchor = AnchorStyles.None;
            picBirth.BackColor = Color.FromArgb(255, 255, 255);
            picBirth.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconChar = FontAwesome.Sharp.IconChar.None;
            picBirth.IconColor = Color.FromArgb(222, 0, 0, 0);
            picBirth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBirth.Location = new Point(113, 3);
            picBirth.Name = "picBirth";
            picBirth.Size = new Size(32, 32);
            picBirth.TabIndex = 44;
            picBirth.TabStop = false;
            // 
            // picCustomerTitle
            // 
            picCustomerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picCustomerTitle.BackColor = Color.FromArgb(255, 255, 255);
            picCustomerTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picCustomerTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picCustomerTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picCustomerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picCustomerTitle.IconSize = 70;
            picCustomerTitle.Location = new Point(180, 0);
            picCustomerTitle.Name = "picCustomerTitle";
            picCustomerTitle.Size = new Size(83, 70);
            picCustomerTitle.TabIndex = 45;
            picCustomerTitle.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.Controls.Add(btnReactivate);
            panel4.Controls.Add(icoBtnReactivate);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(btnClear);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(icoBtnUpdate);
            panel4.Controls.Add(icoBtnClear);
            panel4.Controls.Add(icoBtnDelete);
            panel4.Controls.Add(icoBtnSave);
            panel4.Location = new Point(1213, 2);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 444);
            panel4.TabIndex = 57;
            // 
            // btnReactivate
            // 
            btnReactivate.Anchor = AnchorStyles.None;
            btnReactivate.AutoSize = false;
            btnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReactivate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReactivate.Depth = 0;
            btnReactivate.Enabled = false;
            btnReactivate.HighEmphasis = true;
            btnReactivate.Icon = null;
            btnReactivate.Location = new Point(176, 234);
            btnReactivate.Margin = new Padding(4);
            btnReactivate.MouseState = MaterialSkin.MouseState.HOVER;
            btnReactivate.Name = "btnReactivate";
            btnReactivate.NoAccentTextColor = Color.Empty;
            btnReactivate.Size = new Size(114, 35);
            btnReactivate.TabIndex = 59;
            btnReactivate.Text = "Reactivar";
            btnReactivate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReactivate.UseAccentColor = false;
            btnReactivate.UseVisualStyleBackColor = true;
            btnReactivate.Visible = false;
            btnReactivate.Click += btnReactivate_Click;
            // 
            // icoBtnReactivate
            // 
            icoBtnReactivate.Anchor = AnchorStyles.None;
            icoBtnReactivate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnReactivate.BackColor = Color.RoyalBlue;
            icoBtnReactivate.Enabled = false;
            icoBtnReactivate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnReactivate.ForeColor = SystemColors.Control;
            icoBtnReactivate.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            icoBtnReactivate.IconColor = Color.White;
            icoBtnReactivate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnReactivate.IconSize = 60;
            icoBtnReactivate.Location = new Point(164, 158);
            icoBtnReactivate.Margin = new Padding(2, 3, 2, 3);
            icoBtnReactivate.Name = "icoBtnReactivate";
            icoBtnReactivate.Size = new Size(137, 128);
            icoBtnReactivate.TabIndex = 58;
            icoBtnReactivate.Text = "BUTTON";
            icoBtnReactivate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnReactivate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnReactivate.UseVisualStyleBackColor = false;
            icoBtnReactivate.Visible = false;
            // 
            // icoBtnUpdate
            // 
            icoBtnUpdate.Anchor = AnchorStyles.None;
            icoBtnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnUpdate.BackColor = Color.RoyalBlue;
            icoBtnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnUpdate.ForeColor = SystemColors.Control;
            icoBtnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            icoBtnUpdate.IconColor = Color.White;
            icoBtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnUpdate.IconSize = 60;
            icoBtnUpdate.Location = new Point(80, 227);
            icoBtnUpdate.Name = "icoBtnUpdate";
            icoBtnUpdate.Size = new Size(150, 120);
            icoBtnUpdate.TabIndex = 46;
            icoBtnUpdate.Text = "BUTTON";
            icoBtnUpdate.TextAlign = ContentAlignment.BottomCenter;
            icoBtnUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnUpdate.UseVisualStyleBackColor = false;
            // 
            // icoBtnClear
            // 
            icoBtnClear.Anchor = AnchorStyles.None;
            icoBtnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnClear.BackColor = Color.RoyalBlue;
            icoBtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnClear.ForeColor = SystemColors.Control;
            icoBtnClear.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            icoBtnClear.IconColor = Color.White;
            icoBtnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnClear.IconSize = 60;
            icoBtnClear.Location = new Point(80, 101);
            icoBtnClear.Name = "icoBtnClear";
            icoBtnClear.Size = new Size(150, 120);
            icoBtnClear.TabIndex = 45;
            icoBtnClear.Text = "BUTTON";
            icoBtnClear.TextAlign = ContentAlignment.BottomCenter;
            icoBtnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnClear.UseVisualStyleBackColor = false;
            // 
            // icoBtnDelete
            // 
            icoBtnDelete.Anchor = AnchorStyles.None;
            icoBtnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnDelete.BackColor = Color.RoyalBlue;
            icoBtnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnDelete.ForeColor = SystemColors.Control;
            icoBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            icoBtnDelete.IconColor = Color.White;
            icoBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnDelete.IconSize = 60;
            icoBtnDelete.Location = new Point(246, 227);
            icoBtnDelete.Name = "icoBtnDelete";
            icoBtnDelete.Size = new Size(150, 120);
            icoBtnDelete.TabIndex = 47;
            icoBtnDelete.Text = "BUTTON";
            icoBtnDelete.TextAlign = ContentAlignment.BottomCenter;
            icoBtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnDelete.UseVisualStyleBackColor = false;
            // 
            // icoBtnSave
            // 
            icoBtnSave.Anchor = AnchorStyles.None;
            icoBtnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            icoBtnSave.BackColor = Color.RoyalBlue;
            icoBtnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            icoBtnSave.ForeColor = SystemColors.Control;
            icoBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            icoBtnSave.IconColor = Color.White;
            icoBtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icoBtnSave.IconSize = 60;
            icoBtnSave.Location = new Point(246, 101);
            icoBtnSave.Name = "icoBtnSave";
            icoBtnSave.Size = new Size(150, 120);
            icoBtnSave.TabIndex = 44;
            icoBtnSave.Text = "BUTTON";
            icoBtnSave.TextAlign = ContentAlignment.BottomCenter;
            icoBtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            icoBtnSave.UseVisualStyleBackColor = false;
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
            txtSearch.Location = new Point(709, 27);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
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
            txtSearch.Size = new Size(304, 48);
            txtSearch.TabIndex = 58;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
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
            btnSearch.Location = new Point(664, 37);
            btnSearch.Margin = new Padding(4);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(38, 38);
            btnSearch.TabIndex = 59;
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.9880943F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.0357151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.97619F));
            tableLayoutPanel1.Controls.Add(materialCard2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3030319F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6969681F));
            tableLayoutPanel1.Size = new Size(1680, 830);
            tableLayoutPanel1.TabIndex = 60;
            // 
            // panel5
            // 
            tableLayoutPanel1.SetColumnSpan(panel5, 3);
            panel5.Controls.Add(dtgCustomers);
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(swtActive);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 456);
            panel5.Name = "panel5";
            panel5.Size = new Size(1674, 371);
            panel5.TabIndex = 58;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel6, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1680, 83);
            tableLayoutPanel2.TabIndex = 61;
            // 
            // panel2
            // 
            panel2.Controls.Add(picCustomerTitle);
            panel2.Controls.Add(lblCustomerTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(507, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 77);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblCurrentUser);
            panel6.Controls.Add(btnLogout);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(1179, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(498, 77);
            panel6.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(366, 1);
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
            btnLogout.Location = new Point(366, 31);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
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
            // CustomerView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerView";
            Size = new Size(1680, 930);
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            panel3.ResumeLayout(false);
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerTitle).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtName;
        private MaterialSkin.Controls.MaterialTextBox2 txtLastname;
        private MaterialSkin.Controls.MaterialTextBox2 txtDNI;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtPhone;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtNationality;
        private MaterialSkin.Controls.MaterialTextBox2 txtLocality;
        private MaterialSkin.Controls.MaterialLabel lblBirth;
        private DateTimePicker dtpBirth;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialLabel lblCustomerTitle;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialSwitch swtActive;
        private DataGridView dtgCustomers;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialRadioButton radMale;
        private MaterialSkin.Controls.MaterialRadioButton radOther;
        private MaterialSkin.Controls.MaterialRadioButton radFemale;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialButton btnName;
        private MaterialSkin.Controls.MaterialButton btnLastname;
        private MaterialSkin.Controls.MaterialButton btnDni;
        private MaterialSkin.Controls.MaterialButton btnLoc;
        private MaterialSkin.Controls.MaterialButton btnNat;
        private MaterialSkin.Controls.MaterialButton btnAddress;
        private MaterialSkin.Controls.MaterialButton btnCel;
        private MaterialSkin.Controls.MaterialButton btnEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox picSex;
        private FontAwesome.Sharp.IconPictureBox picBirth;
        private FontAwesome.Sharp.IconPictureBox picCustomerTitle;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton icoBtnUpdate;
        private FontAwesome.Sharp.IconButton icoBtnClear;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnSave;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnLogout;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
        private FontAwesome.Sharp.IconButton icoBtnReactivate;
        private MaterialSkin.Controls.MaterialButton btnReactivate;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnSex;
        private DataGridViewTextBoxColumn ColumnBirth;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnNationality;
        private DataGridViewTextBoxColumn ColumnLocality;
    }
}

