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
            panel1 = new Panel();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnLoc = new MaterialSkin.Controls.MaterialButton();
            btnNat = new MaterialSkin.Controls.MaterialButton();
            btnAddress = new MaterialSkin.Controls.MaterialButton();
            btnCel = new MaterialSkin.Controls.MaterialButton();
            btnEmail = new MaterialSkin.Controls.MaterialButton();
            btnDni = new MaterialSkin.Controls.MaterialButton();
            btnLastname = new MaterialSkin.Controls.MaterialButton();
            btnName = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            dtgCustomers = new DataGridView();
            ColumnId = new DataGridViewLinkColumn();
            ColumnName = new DataGridViewLinkColumn();
            ColumnLastname = new DataGridViewLinkColumn();
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
            radMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            radOtro = new MaterialSkin.Controls.MaterialRadioButton();
            radFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            picBirth = new FontAwesome.Sharp.IconPictureBox();
            picCustomerTitle = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            panel3.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).BeginInit();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerTitle).BeginInit();
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
            // txtNationality (reubicado al lado izquierdo, fila 4)
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
            txtNationality.Location = new Point(61, 262);
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
            // txtLocality (reubicado al lado izquierdo, fila 5)
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
            txtLocality.Location = new Point(61, 333);
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
            // lblCustomerTitle
            // 
            lblCustomerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Depth = 0;
            lblCustomerTitle.Font = new Font("Roboto Light", 60F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCustomerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            lblCustomerTitle.Location = new Point(553, 18);
            lblCustomerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(283, 72);
            lblCustomerTitle.TabIndex = 35;
            lblCustomerTitle.Text = "CLIENTES";
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
            materialCard2.Location = new Point(4, 42);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(591, 404);
            materialCard2.TabIndex = 43;
            // 
            // btnLoc (reubicado al lado izquierdo, fila 5)
            // 
            btnLoc.Anchor = AnchorStyles.Right;
            btnLoc.AutoSize = false;
            btnLoc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoc.Depth = 0;
            btnLoc.HighEmphasis = true;
            btnLoc.Icon = null;
            btnLoc.Location = new Point(16, 333);
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
            // btnNat (reubicado al lado izquierdo, fila 4)
            // 
            btnNat.Anchor = AnchorStyles.Right;
            btnNat.AutoSize = false;
            btnNat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNat.Depth = 0;
            btnNat.HighEmphasis = true;
            btnNat.Icon = null;
            btnNat.Location = new Point(16, 262);
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
            panel2.Controls.Add(dtgCustomers);
            panel2.Location = new Point(0, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 205);
            panel2.TabIndex = 40;
            // 
            // dtgCustomers
            // 
            dtgCustomers.AllowUserToOrderColumns = true;
            dtgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCustomers.BackgroundColor = Color.MidnightBlue;
            dtgCustomers.BorderStyle = BorderStyle.None;
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnLastname, ColumnDNI, ColumnSex, ColumnBirth, ColumnEmail, ColumnPhone, ColumnAddress, ColumnNationality, ColumnLocality });
            dtgCustomers.Dock = DockStyle.Fill;
            dtgCustomers.GridColor = SystemColors.InactiveCaptionText;
            dtgCustomers.Location = new Point(0, 0);
            dtgCustomers.Margin = new Padding(3, 2, 3, 2);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 51;
            dtgCustomers.Size = new Size(1304, 205);
            dtgCustomers.TabIndex = 33;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "IdCliente";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
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
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(621, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 489);
            panel3.TabIndex = 41;
            // 
            // materialCard4 (Sexo)
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(picSex);
            materialCard4.Controls.Add(materialLabel2);
            materialCard4.Controls.Add(radMasculino);
            materialCard4.Controls.Add(radOtro);
            materialCard4.Controls.Add(radFemenino);
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
            // radMasculino
            // 
            radMasculino.Anchor = AnchorStyles.Left;
            radMasculino.AutoSize = true;
            radMasculino.Depth = 0;
            radMasculino.Location = new Point(151, 52);
            radMasculino.Margin = new Padding(0);
            radMasculino.MouseLocation = new Point(-1, -1);
            radMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            radMasculino.Name = "radMasculino";
            radMasculino.Ripple = true;
            radMasculino.Size = new Size(109, 37);
            radMasculino.TabIndex = 20;
            radMasculino.TabStop = true;
            radMasculino.Text = "Masculino";
            radMasculino.UseVisualStyleBackColor = true;
            // 
            // radOtro
            // 
            radOtro.Anchor = AnchorStyles.Left;
            radOtro.AutoSize = true;
            radOtro.Depth = 0;
            radOtro.Location = new Point(279, 52);
            radOtro.Margin = new Padding(0);
            radOtro.MouseLocation = new Point(-1, -1);
            radOtro.MouseState = MaterialSkin.MouseState.HOVER;
            radOtro.Name = "radOtro";
            radOtro.Ripple = true;
            radOtro.Size = new Size(65, 37);
            radOtro.TabIndex = 22;
            radOtro.TabStop = true;
            radOtro.Text = "Otro";
            radOtro.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            radFemenino.Anchor = AnchorStyles.Left;
            radFemenino.AutoSize = true;
            radFemenino.Checked = true;
            radFemenino.Depth = 0;
            radFemenino.Location = new Point(29, 52);
            radFemenino.Margin = new Padding(0);
            radFemenino.MouseLocation = new Point(-1, -1);
            radFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            radFemenino.Name = "radFemenino";
            radFemenino.Ripple = true;
            radFemenino.Size = new Size(105, 37);
            radFemenino.TabIndex = 21;
            radFemenino.TabStop = true;
            radFemenino.Text = "Femenino";
            radFemenino.UseVisualStyleBackColor = true;
            // 
            // materialCard3 (Fecha de Nacimiento)
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
            // picCustomerTitle
            // 
            picCustomerTitle.BackColor = Color.FromArgb(255, 255, 255);
            picCustomerTitle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            picCustomerTitle.IconChar = FontAwesome.Sharp.IconChar.None;
            picCustomerTitle.IconColor = Color.FromArgb(222, 0, 0, 0);
            picCustomerTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picCustomerTitle.IconSize = 75;
            picCustomerTitle.Location = new Point(462, 15);
            picCustomerTitle.Name = "picCustomerTitle";
            picCustomerTitle.Size = new Size(85, 75);
            picCustomerTitle.TabIndex = 45;
            picCustomerTitle.TabStop = false;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picCustomerTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblCustomerTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerView";
            Size = new Size(1304, 848);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSex).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBirth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomerTitle).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgCustomers;
        private DataGridViewLinkColumn ColumnId;
        private DataGridViewLinkColumn ColumnName;
        private DataGridViewLinkColumn ColumnLastname;
        private DataGridViewLinkColumn ColumnDNI;
        private DataGridViewLinkColumn ColumnSex;
        private DataGridViewLinkColumn ColumnBirth;
        private DataGridViewLinkColumn ColumnEmail;
        private DataGridViewLinkColumn ColumnPhone;
        private DataGridViewLinkColumn ColumnAddress;
        private DataGridViewLinkColumn ColumnNationality;
        private DataGridViewLinkColumn ColumnLocality;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialRadioButton radMasculino;
        private MaterialSkin.Controls.MaterialRadioButton radOtro;
        private MaterialSkin.Controls.MaterialRadioButton radFemenino;
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
    }
}

