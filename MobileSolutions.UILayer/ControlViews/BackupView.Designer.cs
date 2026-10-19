namespace MobileSolutions.UILayer
{
    partial class BackupView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            pnlBackupContent = new Panel();
            pnlDualAuthCard = new Panel();
            btnTabBackup = new Button();
            btnTabRestore = new Button();
            lblStep1Title = new Label();
            txtAdmin1User = new MaterialSkin.Controls.MaterialTextBox2();
            picStep1UserCheck = new FontAwesome.Sharp.IconPictureBox();
            txtAdmin1Password = new MaterialSkin.Controls.MaterialTextBox2();
            picStep1PassCheck = new FontAwesome.Sharp.IconPictureBox();
            btnConfirmStep1 = new Button();
            picStep1ConfirmCheck = new FontAwesome.Sharp.IconPictureBox();
            lblStep1Completed = new Label();
            lblStep2Title = new Label();
            txtAdmin2User = new MaterialSkin.Controls.MaterialTextBox2();
            txtAdmin2Password = new MaterialSkin.Controls.MaterialTextBox2();
            btnGenerarBackup = new Button();
            pnlRestoreSelector = new Panel();
            txtBackupFilePath = new MaterialSkin.Controls.MaterialTextBox2();
            btnBrowseBak = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            picBackupTitle = new FontAwesome.Sharp.IconPictureBox();
            lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            lblCurrentUser = new MaterialSkin.Controls.MaterialLabel();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            pnlContainer.SuspendLayout();
            pnlBackupContent.SuspendLayout();
            pnlDualAuthCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStep1UserCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStep1PassCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStep1ConfirmCheck).BeginInit();
            pnlRestoreSelector.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBackupTitle).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(50, 50, 50);
            pnlContainer.Controls.Add(pnlBackupContent);
            pnlContainer.Controls.Add(tableLayoutPanel1);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1680, 930);
            pnlContainer.TabIndex = 0;
            // 
            // pnlBackupContent
            // 
            pnlBackupContent.BackColor = Color.FromArgb(50, 50, 50);
            pnlBackupContent.Controls.Add(pnlDualAuthCard);
            pnlBackupContent.Dock = DockStyle.Fill;
            pnlBackupContent.Location = new Point(0, 96);
            pnlBackupContent.Name = "pnlBackupContent";
            pnlBackupContent.Size = new Size(1680, 834);
            pnlBackupContent.TabIndex = 1;
            // 
            // pnlDualAuthCard
            // 
            pnlDualAuthCard.BackColor = Color.FromArgb(46, 46, 46);
            pnlDualAuthCard.Controls.Add(btnTabBackup);
            pnlDualAuthCard.Controls.Add(btnTabRestore);
            pnlDualAuthCard.Controls.Add(lblStep1Title);
            pnlDualAuthCard.Controls.Add(txtAdmin1User);
            pnlDualAuthCard.Controls.Add(picStep1UserCheck);
            pnlDualAuthCard.Controls.Add(txtAdmin1Password);
            pnlDualAuthCard.Controls.Add(picStep1PassCheck);
            pnlDualAuthCard.Controls.Add(btnConfirmStep1);
            pnlDualAuthCard.Controls.Add(picStep1ConfirmCheck);
            pnlDualAuthCard.Controls.Add(lblStep1Completed);
            pnlDualAuthCard.Controls.Add(lblStep2Title);
            pnlDualAuthCard.Controls.Add(txtAdmin2User);
            pnlDualAuthCard.Controls.Add(txtAdmin2Password);
            pnlDualAuthCard.Controls.Add(btnGenerarBackup);
            pnlDualAuthCard.Controls.Add(pnlRestoreSelector);
            pnlDualAuthCard.Location = new Point(610, 137);
            pnlDualAuthCard.Name = "pnlDualAuthCard";
            pnlDualAuthCard.Size = new Size(460, 560);
            pnlDualAuthCard.TabIndex = 0;
            // 
            // btnTabBackup
            // 
            btnTabBackup.BackColor = Color.FromArgb(25, 118, 210);
            btnTabBackup.Cursor = Cursors.Hand;
            btnTabBackup.FlatAppearance.BorderSize = 0;
            btnTabBackup.FlatStyle = FlatStyle.Flat;
            btnTabBackup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTabBackup.ForeColor = Color.White;
            btnTabBackup.Location = new Point(1, 18);
            btnTabBackup.Name = "btnTabBackup";
            btnTabBackup.Size = new Size(229, 42);
            btnTabBackup.TabIndex = 0;
            btnTabBackup.Text = "Backup";
            btnTabBackup.UseVisualStyleBackColor = false;
            // 
            // btnTabRestore
            // 
            btnTabRestore.BackColor = Color.FromArgb(46, 46, 46);
            btnTabRestore.Cursor = Cursors.Hand;
            btnTabRestore.FlatAppearance.BorderSize = 0;
            btnTabRestore.FlatStyle = FlatStyle.Flat;
            btnTabRestore.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnTabRestore.ForeColor = Color.FromArgb(210, 210, 210);
            btnTabRestore.Location = new Point(230, 18);
            btnTabRestore.Name = "btnTabRestore";
            btnTabRestore.Size = new Size(229, 42);
            btnTabRestore.TabIndex = 1;
            btnTabRestore.Text = "Restore";
            btnTabRestore.UseVisualStyleBackColor = false;
            // 
            // lblStep1Title
            // 
            lblStep1Title.AutoSize = true;
            lblStep1Title.BackColor = Color.Transparent;
            lblStep1Title.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStep1Title.ForeColor = Color.White;
            lblStep1Title.Location = new Point(20, 80);
            lblStep1Title.Name = "lblStep1Title";
            lblStep1Title.Size = new Size(267, 18);
            lblStep1Title.TabIndex = 2;
            lblStep1Title.Text = "Paso 1: Credenciales del Administrador";
            // 
            // txtAdmin1User
            // 
            txtAdmin1User.AnimateReadOnly = false;
            txtAdmin1User.BackgroundImageLayout = ImageLayout.None;
            txtAdmin1User.CharacterCasing = CharacterCasing.Normal;
            txtAdmin1User.Depth = 0;
            txtAdmin1User.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdmin1User.HideSelection = true;
            txtAdmin1User.Hint = "Usuario";
            txtAdmin1User.LeadingIcon = null;
            txtAdmin1User.Location = new Point(20, 112);
            txtAdmin1User.MaxLength = 50;
            txtAdmin1User.MouseState = MaterialSkin.MouseState.OUT;
            txtAdmin1User.Name = "txtAdmin1User";
            txtAdmin1User.PasswordChar = '\0';
            txtAdmin1User.PrefixSuffixText = null;
            txtAdmin1User.ReadOnly = false;
            txtAdmin1User.RightToLeft = RightToLeft.No;
            txtAdmin1User.SelectedText = "";
            txtAdmin1User.SelectionLength = 0;
            txtAdmin1User.SelectionStart = 0;
            txtAdmin1User.ShortcutsEnabled = true;
            txtAdmin1User.Size = new Size(390, 48);
            txtAdmin1User.TabIndex = 3;
            txtAdmin1User.TextAlign = HorizontalAlignment.Left;
            txtAdmin1User.TrailingIcon = null;
            txtAdmin1User.UseSystemPasswordChar = false;
            // 
            // picStep1UserCheck
            // 
            picStep1UserCheck.BackColor = Color.Transparent;
            picStep1UserCheck.ForeColor = Color.FromArgb(76, 175, 80);
            picStep1UserCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            picStep1UserCheck.IconColor = Color.FromArgb(76, 175, 80);
            picStep1UserCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picStep1UserCheck.IconSize = 22;
            picStep1UserCheck.Location = new Point(418, 126);
            picStep1UserCheck.Name = "picStep1UserCheck";
            picStep1UserCheck.Size = new Size(22, 22);
            picStep1UserCheck.TabIndex = 4;
            picStep1UserCheck.TabStop = false;
            picStep1UserCheck.Visible = false;
            // 
            // txtAdmin1Password
            // 
            txtAdmin1Password.AnimateReadOnly = false;
            txtAdmin1Password.BackgroundImageLayout = ImageLayout.None;
            txtAdmin1Password.CharacterCasing = CharacterCasing.Normal;
            txtAdmin1Password.Depth = 0;
            txtAdmin1Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdmin1Password.HideSelection = true;
            txtAdmin1Password.Hint = "Contraseña";
            txtAdmin1Password.LeadingIcon = null;
            txtAdmin1Password.Location = new Point(20, 174);
            txtAdmin1Password.MaxLength = 50;
            txtAdmin1Password.MouseState = MaterialSkin.MouseState.OUT;
            txtAdmin1Password.Name = "txtAdmin1Password";
            txtAdmin1Password.PasswordChar = '●';
            txtAdmin1Password.PrefixSuffixText = null;
            txtAdmin1Password.ReadOnly = false;
            txtAdmin1Password.RightToLeft = RightToLeft.No;
            txtAdmin1Password.SelectedText = "";
            txtAdmin1Password.SelectionLength = 0;
            txtAdmin1Password.SelectionStart = 0;
            txtAdmin1Password.ShortcutsEnabled = true;
            txtAdmin1Password.Size = new Size(390, 48);
            txtAdmin1Password.TabIndex = 5;
            txtAdmin1Password.TextAlign = HorizontalAlignment.Left;
            txtAdmin1Password.TrailingIcon = null;
            txtAdmin1Password.UseSystemPasswordChar = true;
            // 
            // picStep1PassCheck
            // 
            picStep1PassCheck.BackColor = Color.Transparent;
            picStep1PassCheck.ForeColor = Color.FromArgb(76, 175, 80);
            picStep1PassCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            picStep1PassCheck.IconColor = Color.FromArgb(76, 175, 80);
            picStep1PassCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picStep1PassCheck.IconSize = 22;
            picStep1PassCheck.Location = new Point(418, 188);
            picStep1PassCheck.Name = "picStep1PassCheck";
            picStep1PassCheck.Size = new Size(22, 22);
            picStep1PassCheck.TabIndex = 6;
            picStep1PassCheck.TabStop = false;
            picStep1PassCheck.Visible = false;
            // 
            // btnConfirmStep1
            // 
            btnConfirmStep1.BackColor = Color.FromArgb(25, 118, 210);
            btnConfirmStep1.Cursor = Cursors.Hand;
            btnConfirmStep1.FlatAppearance.BorderSize = 0;
            btnConfirmStep1.FlatStyle = FlatStyle.Flat;
            btnConfirmStep1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnConfirmStep1.ForeColor = Color.White;
            btnConfirmStep1.Location = new Point(310, 236);
            btnConfirmStep1.Name = "btnConfirmStep1";
            btnConfirmStep1.Size = new Size(100, 34);
            btnConfirmStep1.TabIndex = 7;
            btnConfirmStep1.Text = "Confirmar";
            btnConfirmStep1.UseVisualStyleBackColor = false;
            // 
            // picStep1ConfirmCheck
            // 
            picStep1ConfirmCheck.BackColor = Color.Transparent;
            picStep1ConfirmCheck.ForeColor = Color.FromArgb(76, 175, 80);
            picStep1ConfirmCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            picStep1ConfirmCheck.IconColor = Color.FromArgb(76, 175, 80);
            picStep1ConfirmCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picStep1ConfirmCheck.IconSize = 22;
            picStep1ConfirmCheck.Location = new Point(418, 243);
            picStep1ConfirmCheck.Name = "picStep1ConfirmCheck";
            picStep1ConfirmCheck.Size = new Size(22, 22);
            picStep1ConfirmCheck.TabIndex = 8;
            picStep1ConfirmCheck.TabStop = false;
            picStep1ConfirmCheck.Visible = false;
            // 
            // lblStep1Completed
            // 
            lblStep1Completed.AutoSize = true;
            lblStep1Completed.BackColor = Color.Transparent;
            lblStep1Completed.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStep1Completed.ForeColor = Color.FromArgb(76, 175, 80);
            lblStep1Completed.Location = new Point(368, 274);
            lblStep1Completed.Name = "lblStep1Completed";
            lblStep1Completed.Size = new Size(63, 13);
            lblStep1Completed.TabIndex = 9;
            lblStep1Completed.Text = "Completado";
            lblStep1Completed.Visible = false;
            // 
            // lblStep2Title
            // 
            lblStep2Title.AutoSize = true;
            lblStep2Title.BackColor = Color.Transparent;
            lblStep2Title.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblStep2Title.ForeColor = Color.White;
            lblStep2Title.Location = new Point(20, 310);
            lblStep2Title.Name = "lblStep2Title";
            lblStep2Title.Size = new Size(229, 18);
            lblStep2Title.TabIndex = 10;
            lblStep2Title.Text = "Paso 2: Credenciales del Gerente";
            // 
            // txtAdmin2User
            // 
            txtAdmin2User.AnimateReadOnly = false;
            txtAdmin2User.BackgroundImageLayout = ImageLayout.None;
            txtAdmin2User.CharacterCasing = CharacterCasing.Normal;
            txtAdmin2User.Depth = 0;
            txtAdmin2User.Enabled = false;
            txtAdmin2User.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdmin2User.HideSelection = true;
            txtAdmin2User.Hint = "Usuario";
            txtAdmin2User.LeadingIcon = null;
            txtAdmin2User.Location = new Point(20, 342);
            txtAdmin2User.MaxLength = 50;
            txtAdmin2User.MouseState = MaterialSkin.MouseState.OUT;
            txtAdmin2User.Name = "txtAdmin2User";
            txtAdmin2User.PasswordChar = '\0';
            txtAdmin2User.PrefixSuffixText = null;
            txtAdmin2User.ReadOnly = false;
            txtAdmin2User.RightToLeft = RightToLeft.No;
            txtAdmin2User.SelectedText = "";
            txtAdmin2User.SelectionLength = 0;
            txtAdmin2User.SelectionStart = 0;
            txtAdmin2User.ShortcutsEnabled = true;
            txtAdmin2User.Size = new Size(420, 48);
            txtAdmin2User.TabIndex = 11;
            txtAdmin2User.TextAlign = HorizontalAlignment.Left;
            txtAdmin2User.TrailingIcon = null;
            txtAdmin2User.UseSystemPasswordChar = false;
            // 
            // txtAdmin2Password
            // 
            txtAdmin2Password.AnimateReadOnly = false;
            txtAdmin2Password.BackgroundImageLayout = ImageLayout.None;
            txtAdmin2Password.CharacterCasing = CharacterCasing.Normal;
            txtAdmin2Password.Depth = 0;
            txtAdmin2Password.Enabled = false;
            txtAdmin2Password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAdmin2Password.HideSelection = true;
            txtAdmin2Password.Hint = "Contraseña";
            txtAdmin2Password.LeadingIcon = null;
            txtAdmin2Password.Location = new Point(20, 404);
            txtAdmin2Password.MaxLength = 50;
            txtAdmin2Password.MouseState = MaterialSkin.MouseState.OUT;
            txtAdmin2Password.Name = "txtAdmin2Password";
            txtAdmin2Password.PasswordChar = '●';
            txtAdmin2Password.PrefixSuffixText = null;
            txtAdmin2Password.ReadOnly = false;
            txtAdmin2Password.RightToLeft = RightToLeft.No;
            txtAdmin2Password.SelectedText = "";
            txtAdmin2Password.SelectionLength = 0;
            txtAdmin2Password.SelectionStart = 0;
            txtAdmin2Password.ShortcutsEnabled = true;
            txtAdmin2Password.Size = new Size(420, 48);
            txtAdmin2Password.TabIndex = 12;
            txtAdmin2Password.TextAlign = HorizontalAlignment.Left;
            txtAdmin2Password.TrailingIcon = null;
            txtAdmin2Password.UseSystemPasswordChar = true;
            // 
            // btnGenerarBackup
            // 
            btnGenerarBackup.BackColor = Color.FromArgb(75, 75, 75);
            btnGenerarBackup.Enabled = false;
            btnGenerarBackup.FlatAppearance.BorderSize = 0;
            btnGenerarBackup.FlatStyle = FlatStyle.Flat;
            btnGenerarBackup.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnGenerarBackup.ForeColor = Color.FromArgb(160, 160, 160);
            btnGenerarBackup.Location = new Point(20, 490);
            btnGenerarBackup.Name = "btnGenerarBackup";
            btnGenerarBackup.Size = new Size(420, 40);
            btnGenerarBackup.TabIndex = 13;
            btnGenerarBackup.Text = "Generar Backup";
            btnGenerarBackup.UseVisualStyleBackColor = false;
            // 
            // pnlRestoreSelector
            // 
            pnlRestoreSelector.BackColor = Color.Transparent;
            pnlRestoreSelector.Controls.Add(txtBackupFilePath);
            pnlRestoreSelector.Controls.Add(btnBrowseBak);
            pnlRestoreSelector.Enabled = false;
            pnlRestoreSelector.Location = new Point(20, 484);
            pnlRestoreSelector.Name = "pnlRestoreSelector";
            pnlRestoreSelector.Size = new Size(420, 50);
            pnlRestoreSelector.TabIndex = 14;
            pnlRestoreSelector.Visible = false;
            // 
            // txtBackupFilePath
            // 
            txtBackupFilePath.AnimateReadOnly = false;
            txtBackupFilePath.BackgroundImageLayout = ImageLayout.None;
            txtBackupFilePath.CharacterCasing = CharacterCasing.Normal;
            txtBackupFilePath.Depth = 0;
            txtBackupFilePath.Enabled = false;
            txtBackupFilePath.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBackupFilePath.HideSelection = true;
            txtBackupFilePath.Hint = "Seleccionar archivo .bak...";
            txtBackupFilePath.LeadingIcon = null;
            txtBackupFilePath.Location = new Point(0, 1);
            txtBackupFilePath.MaxLength = 500;
            txtBackupFilePath.MouseState = MaterialSkin.MouseState.OUT;
            txtBackupFilePath.Name = "txtBackupFilePath";
            txtBackupFilePath.PasswordChar = '\0';
            txtBackupFilePath.PrefixSuffixText = null;
            txtBackupFilePath.ReadOnly = true;
            txtBackupFilePath.RightToLeft = RightToLeft.No;
            txtBackupFilePath.SelectedText = "";
            txtBackupFilePath.SelectionLength = 0;
            txtBackupFilePath.SelectionStart = 0;
            txtBackupFilePath.ShortcutsEnabled = true;
            txtBackupFilePath.Size = new Size(362, 48);
            txtBackupFilePath.TabIndex = 0;
            txtBackupFilePath.TabStop = false;
            txtBackupFilePath.TextAlign = HorizontalAlignment.Left;
            txtBackupFilePath.TrailingIcon = null;
            txtBackupFilePath.UseSystemPasswordChar = false;
            // 
            // btnBrowseBak
            // 
            btnBrowseBak.BackColor = Color.FromArgb(75, 75, 75);
            btnBrowseBak.Enabled = false;
            btnBrowseBak.FlatAppearance.BorderSize = 0;
            btnBrowseBak.FlatStyle = FlatStyle.Flat;
            btnBrowseBak.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnBrowseBak.ForeColor = Color.FromArgb(160, 160, 160);
            btnBrowseBak.Location = new Point(370, 1);
            btnBrowseBak.Name = "btnBrowseBak";
            btnBrowseBak.Size = new Size(50, 48);
            btnBrowseBak.TabIndex = 1;
            btnBrowseBak.Text = "...";
            btnBrowseBak.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1680, 96);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(picBackupTitle);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(507, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 90);
            panel1.TabIndex = 0;
            // 
            // picBackupTitle
            // 
            picBackupTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            picBackupTitle.BackColor = Color.Transparent;
            picBackupTitle.IconChar = FontAwesome.Sharp.IconChar.Database;
            picBackupTitle.IconColor = Color.White;
            picBackupTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picBackupTitle.IconSize = 69;
            picBackupTitle.Location = new Point(197, 3);
            picBackupTitle.Margin = new Padding(2, 3, 2, 3);
            picBackupTitle.Name = "picBackupTitle";
            picBackupTitle.Size = new Size(69, 87);
            picBackupTitle.TabIndex = 1;
            picBackupTitle.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTitulo.AutoSize = true;
            lblTitulo.Depth = 0;
            lblTitulo.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            lblTitulo.Location = new Point(289, 15);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Backup";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCurrentUser);
            panel2.Controls.Add(btnLogout);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1179, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 90);
            panel2.TabIndex = 1;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Depth = 0;
            lblCurrentUser.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblCurrentUser.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblCurrentUser.Location = new Point(367, 3);
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
            btnLogout.Location = new Point(367, 35);
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
            // BackupView
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContainer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BackupView";
            Size = new Size(1680, 930);
            pnlContainer.ResumeLayout(false);
            pnlBackupContent.ResumeLayout(false);
            pnlDualAuthCard.ResumeLayout(false);
            pnlDualAuthCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStep1UserCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStep1PassCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStep1ConfirmCheck).EndInit();
            pnlRestoreSelector.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBackupTitle).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel pnlBackupContent;
        private Panel pnlDualAuthCard;
        private Button btnTabBackup;
        private Button btnTabRestore;
        private Label lblStep1Title;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdmin1User;
        private FontAwesome.Sharp.IconPictureBox picStep1UserCheck;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdmin1Password;
        private FontAwesome.Sharp.IconPictureBox picStep1PassCheck;
        private Button btnConfirmStep1;
        private FontAwesome.Sharp.IconPictureBox picStep1ConfirmCheck;
        private Label lblStep1Completed;
        private Label lblStep2Title;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdmin2User;
        private MaterialSkin.Controls.MaterialTextBox2 txtAdmin2Password;
        private Button btnGenerarBackup;
        private Panel pnlRestoreSelector;
        private MaterialSkin.Controls.MaterialTextBox2 txtBackupFilePath;
        private Button btnBrowseBak;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox picBackupTitle;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblCurrentUser;
        private MaterialSkin.Controls.MaterialButton btnLogout;
    }
}
