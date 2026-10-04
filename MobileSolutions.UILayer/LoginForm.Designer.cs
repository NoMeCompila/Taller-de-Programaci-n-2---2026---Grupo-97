namespace MobileSolutions.UILayer
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUser = new MaterialSkin.Controls.MaterialTextBox();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            picBanner = new PictureBox();
            picLogo = new PictureBox();
            picBG = new PictureBox();
            lblForgotMyPassword = new MaterialSkin.Controls.MaterialLabel();
            txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            txtCode = new MaterialSkin.Controls.MaterialTextBox();
            btnSendEmail = new MaterialSkin.Controls.MaterialButton();
            btnConfirm = new MaterialSkin.Controls.MaterialButton();
            txtNewPassword = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)picBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBG).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.AnimateReadOnly = false;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Depth = 0;
            txtUser.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUser.Hint = "Usuario / Correo";
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(387, 284);
            txtUser.MaxLength = 50;
            txtUser.MouseState = MaterialSkin.MouseState.OUT;
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(325, 50);
            txtUser.TabIndex = 0;
            txtUser.Text = "";
            txtUser.TrailingIcon = null;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.Hint = "Contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(387, 353);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(325, 50);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(520, 423);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(64, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += materialButton1_Click;
            // 
            // picBanner
            // 
            picBanner.BackgroundImage = Properties.Resources.logo_mobile_solutions_dark;
            picBanner.BackgroundImageLayout = ImageLayout.Zoom;
            picBanner.BorderStyle = BorderStyle.FixedSingle;
            picBanner.Location = new Point(241, 101);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(618, 168);
            picBanner.TabIndex = 5;
            picBanner.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(457, 484);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(199, 184);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // picBG
            // 
            picBG.BackColor = Color.Transparent;
            picBG.BackgroundImageLayout = ImageLayout.Stretch;
            picBG.Dock = DockStyle.Fill;
            picBG.Image = (Image)resources.GetObject("picBG.Image");
            picBG.Location = new Point(3, 64);
            picBG.Name = "picBG";
            picBG.Size = new Size(1238, 1033);
            picBG.SizeMode = PictureBoxSizeMode.StretchImage;
            picBG.TabIndex = 7;
            picBG.TabStop = false;
            // 
            // lblForgotMyPassword
            // 
            lblForgotMyPassword.AutoSize = true;
            lblForgotMyPassword.Cursor = Cursors.Hand;
            lblForgotMyPassword.Depth = 0;
            lblForgotMyPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblForgotMyPassword.Location = new Point(483, 680);
            lblForgotMyPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lblForgotMyPassword.Name = "lblForgotMyPassword";
            lblForgotMyPassword.Size = new Size(152, 19);
            lblForgotMyPassword.TabIndex = 8;
            lblForgotMyPassword.Text = "Olvidé Mi Contraseña";
            lblForgotMyPassword.Click += lblForgotMyPassword_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.AnimateReadOnly = false;
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Depth = 0;
            txtCorreo.Enabled = false;
            txtCorreo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCorreo.Hint = "Correo";
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(387, 722);
            txtCorreo.MaxLength = 50;
            txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            txtCorreo.Multiline = false;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(325, 50);
            txtCorreo.TabIndex = 9;
            txtCorreo.Text = "";
            txtCorreo.TrailingIcon = null;
            txtCorreo.Visible = false;
            // 
            // txtCode
            // 
            txtCode.AnimateReadOnly = false;
            txtCode.BorderStyle = BorderStyle.None;
            txtCode.Depth = 0;
            txtCode.Enabled = false;
            txtCode.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCode.Hint = "Código";
            txtCode.LeadingIcon = null;
            txtCode.Location = new Point(387, 805);
            txtCode.MaxLength = 50;
            txtCode.MouseState = MaterialSkin.MouseState.OUT;
            txtCode.Multiline = false;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(325, 50);
            txtCode.TabIndex = 10;
            txtCode.Text = "";
            txtCode.TrailingIcon = null;
            txtCode.Visible = false;
            // 
            // btnSendEmail
            // 
            btnSendEmail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSendEmail.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSendEmail.Depth = 0;
            btnSendEmail.Enabled = false;
            btnSendEmail.HighEmphasis = true;
            btnSendEmail.Icon = null;
            btnSendEmail.Location = new Point(719, 736);
            btnSendEmail.Margin = new Padding(4, 6, 4, 6);
            btnSendEmail.MouseState = MaterialSkin.MouseState.HOVER;
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.NoAccentTextColor = Color.Empty;
            btnSendEmail.Size = new Size(73, 36);
            btnSendEmail.TabIndex = 11;
            btnSendEmail.Text = "Enviar";
            btnSendEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSendEmail.UseAccentColor = false;
            btnSendEmail.UseVisualStyleBackColor = true;
            btnSendEmail.Visible = false;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AnimateReadOnly = false;
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Depth = 0;
            txtNewPassword.Enabled = false;
            txtNewPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNewPassword.Hint = "Nueva Contraseña";
            txtNewPassword.LeadingIcon = null;
            txtNewPassword.Location = new Point(387, 888);
            txtNewPassword.MaxLength = 50;
            txtNewPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtNewPassword.Multiline = false;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Password = true;
            txtNewPassword.Size = new Size(325, 50);
            txtNewPassword.TabIndex = 11;
            txtNewPassword.Text = "";
            txtNewPassword.TrailingIcon = null;
            txtNewPassword.Visible = false;
            // 
            // btnConfirm
            // 
            btnConfirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirm.Depth = 0;
            btnConfirm.Enabled = false;
            btnConfirm.HighEmphasis = true;
            btnConfirm.Icon = null;
            btnConfirm.Location = new Point(719, 902);
            btnConfirm.Margin = new Padding(4, 6, 4, 6);
            btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.NoAccentTextColor = Color.Empty;
            btnConfirm.Size = new Size(105, 36);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirmar";
            btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirm.UseAccentColor = false;
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1244, 1100);
            Controls.Add(txtNewPassword);
            Controls.Add(btnConfirm);
            Controls.Add(btnSendEmail);
            Controls.Add(txtCode);
            Controls.Add(txtCorreo);
            Controls.Add(lblForgotMyPassword);
            Controls.Add(picLogo);
            Controls.Add(picBanner);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(picBG);
            ForeColor = SystemColors.Window;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)picBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtUser;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private PictureBox picBanner;
        private PictureBox picLogo;
        private PictureBox picBG;
        private MaterialSkin.Controls.MaterialLabel lblForgotMyPassword;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox txtCode;
        private MaterialSkin.Controls.MaterialButton btnSendEmail;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialTextBox txtNewPassword;
    }
}

