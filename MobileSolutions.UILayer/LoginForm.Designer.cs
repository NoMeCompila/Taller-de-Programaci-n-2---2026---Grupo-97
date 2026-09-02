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
            btnExit = new FontAwesome.Sharp.IconButton();
            picBanner = new PictureBox();
            picLogo = new PictureBox();
            picBG = new PictureBox();
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
            txtUser.Hint = "Usuario";
            txtUser.LeadingIcon = null;
            txtUser.Location = new Point(442, 431);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.MaxLength = 50;
            txtUser.MouseState = MaterialSkin.MouseState.OUT;
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(371, 50);
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
            txtPassword.Location = new Point(442, 532);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(371, 50);
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
            btnLogin.Location = new Point(592, 639);
            btnLogin.Margin = new Padding(5, 8, 5, 8);
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
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 255, 255, 255);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(244, 67, 54);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnExit.IconColor = Color.FromArgb(244, 67, 54);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 24;
            btnExit.Location = new Point(1150, 49);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 32);
            btnExit.TabIndex = 8;
            btnExit.Text = " Salir";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // picBanner
            // 
            picBanner.BackgroundImage = Properties.Resources.logo_mobile_solutions_dark;
            picBanner.BackgroundImageLayout = ImageLayout.Zoom;
            picBanner.BorderStyle = BorderStyle.FixedSingle;
            picBanner.Location = new Point(275, 135);
            picBanner.Margin = new Padding(3, 4, 3, 4);
            picBanner.Name = "picBanner";
            picBanner.Size = new Size(706, 223);
            picBanner.TabIndex = 5;
            picBanner.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(515, 717);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(227, 245);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // picBG
            // 
            picBG.BackgroundImageLayout = ImageLayout.Stretch;
            picBG.Dock = DockStyle.Fill;
            picBG.Image = (Image)resources.GetObject("picBG.Image");
            picBG.Location = new Point(3, 85);
            picBG.Margin = new Padding(3, 4, 3, 4);
            picBG.Name = "picBG";
            picBG.Size = new Size(1251, 911);
            picBG.SizeMode = PictureBoxSizeMode.StretchImage;
            picBG.TabIndex = 7;
            picBG.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 1000);
            Controls.Add(picLogo);
            Controls.Add(picBanner);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(picBG);
            ForeColor = SystemColors.Window;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Padding = new Padding(3, 85, 3, 4);
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
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
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox picBanner;
        private PictureBox picLogo;
        private PictureBox picBG;
    }
}

