using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin.Controls;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class BackupView : UserControl, ILogoutSupport
    {
        private static readonly Color CardBgColor = Color.FromArgb(46, 46, 46);
        private static readonly Color CardBorderColor = Color.FromArgb(115, 115, 115);
        private static readonly Color ActiveBlueColor = Color.FromArgb(25, 118, 210);
        private static readonly Color ActiveTabAccentColor = Color.FromArgb(100, 181, 246);
        private static readonly Color InactiveTabLineColor = Color.FromArgb(80, 80, 80);
        private static readonly Color InactiveTabTextColor = Color.FromArgb(210, 210, 210);
        private static readonly Color ConfirmedButtonBgColor = Color.FromArgb(96, 96, 96);
        private static readonly Color ConfirmedButtonFgColor = Color.FromArgb(185, 185, 185);
        private static readonly Color DisabledActionBgColor = Color.FromArgb(75, 75, 75);
        private static readonly Color DisabledActionFgColor = Color.FromArgb(160, 160, 160);

        public event EventHandler? LogoutRequested;
        public event EventHandler? Step1Confirmed;
        public event EventHandler? BackupActionRequested;
        public event EventHandler<string>? RestoreFileSelected;

        public bool IsRestoreMode { get; private set; }
        public bool IsStep1Confirmed { get; private set; }
        public string Admin1Username => txtAdmin1User.Text.Trim();
        public string Admin2Username => txtAdmin2User.Text.Trim();
        public string SelectedBackupFilePath => txtBackupFilePath.Text.Trim();

        public BackupView()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(50, 50, 50);
            this.picBackupTitle.IconChar = IconChar.Database;
            this.picBackupTitle.IconColor = Color.White;
            this.picBackupTitle.BackColor = Color.Transparent;
            this.btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            this.btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

            ConfigureDualAuthUi();
            SwitchToBackupTab();
        }

        private void ConfigureDualAuthUi()
        {
            pnlBackupContent.Resize += (s, e) => CenterDualAuthCard();
            this.Load += (s, e) => CenterDualAuthCard();

            pnlDualAuthCard.Paint += PnlDualAuthCard_Paint;
            btnTabBackup.Paint += TabButton_Paint;
            btnTabRestore.Paint += TabButton_Paint;
            btnConfirmStep1.Paint += FlatActionButton_Paint;
            btnGenerarBackup.Paint += FlatActionButton_Paint;
            btnBrowseBak.Paint += FlatActionButton_Paint;

            btnTabBackup.Click += (s, e) => SwitchToBackupTab();
            btnTabRestore.Click += (s, e) => SwitchToRestoreTab();
            btnConfirmStep1.Click += (s, e) => ConfirmStep1();
            btnGenerarBackup.Click += (s, e) => BackupActionRequested?.Invoke(this, EventArgs.Empty);
            btnBrowseBak.Click += (s, e) => BrowseBackupFile();

            CenterDualAuthCard();
        }

        private void CenterDualAuthCard()
        {
            if (pnlBackupContent == null || pnlDualAuthCard == null)
            {
                return;
            }

            int x = Math.Max(20, (pnlBackupContent.ClientSize.Width - pnlDualAuthCard.Width) / 2);
            int y = Math.Max(20, (pnlBackupContent.ClientSize.Height - pnlDualAuthCard.Height) / 2);
            pnlDualAuthCard.Location = new Point(x, y);
        }

        public void SwitchToBackupTab()
        {
            IsRestoreMode = false;
            UpdateTabVisuals();
            btnGenerarBackup.Visible = true;
            pnlRestoreSelector.Visible = false;
            ResetDualAuthState();
        }

        public void SwitchToRestoreTab()
        {
            IsRestoreMode = true;
            UpdateTabVisuals();
            btnGenerarBackup.Visible = false;
            pnlRestoreSelector.Visible = true;
            ResetDualAuthState();
        }

        public void ResetDualAuthState()
        {
            IsStep1Confirmed = false;

            txtAdmin1User.Text = string.Empty;
            txtAdmin1Password.Text = string.Empty;
            txtAdmin1User.Enabled = true;
            txtAdmin1Password.Enabled = true;

            picStep1UserCheck.Visible = false;
            picStep1PassCheck.Visible = false;
            picStep1ConfirmCheck.Visible = false;
            lblStep1Completed.Visible = false;

            btnConfirmStep1.Enabled = true;
            btnConfirmStep1.BackColor = ActiveBlueColor;
            btnConfirmStep1.ForeColor = Color.White;
            btnConfirmStep1.Cursor = Cursors.Hand;
            btnConfirmStep1.Invalidate();

            txtAdmin2User.Text = string.Empty;
            txtAdmin2Password.Text = string.Empty;
            txtAdmin2User.Enabled = false;
            txtAdmin2Password.Enabled = false;

            btnGenerarBackup.Enabled = false;
            btnGenerarBackup.BackColor = DisabledActionBgColor;
            btnGenerarBackup.ForeColor = DisabledActionFgColor;
            btnGenerarBackup.Cursor = Cursors.Default;
            btnGenerarBackup.Invalidate();

            txtBackupFilePath.Text = string.Empty;
            txtBackupFilePath.Enabled = false;
            pnlRestoreSelector.Enabled = false;

            btnBrowseBak.Enabled = false;
            btnBrowseBak.BackColor = DisabledActionBgColor;
            btnBrowseBak.ForeColor = DisabledActionFgColor;
            btnBrowseBak.Cursor = Cursors.Default;
            btnBrowseBak.Invalidate();
        }

        public void ConfirmStep1()
        {
            if (string.IsNullOrWhiteSpace(txtAdmin1User.Text) || string.IsNullOrWhiteSpace(txtAdmin1Password.Text))
            {
                MaterialMessageBox.Show(
                    "Por favor complete el usuario y contraseña del Primer Administrador.",
                    "Campos Requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            IsStep1Confirmed = true;

            txtAdmin1User.Enabled = false;
            txtAdmin1Password.Enabled = false;

            picStep1UserCheck.Visible = true;
            picStep1PassCheck.Visible = true;
            picStep1ConfirmCheck.Visible = true;
            lblStep1Completed.Visible = true;

            btnConfirmStep1.Enabled = false;
            btnConfirmStep1.BackColor = ConfirmedButtonBgColor;
            btnConfirmStep1.ForeColor = ConfirmedButtonFgColor;
            btnConfirmStep1.Cursor = Cursors.Default;
            btnConfirmStep1.Invalidate();

            txtAdmin2User.Enabled = true;
            txtAdmin2Password.Enabled = true;
            txtAdmin2User.Focus();

            btnGenerarBackup.Enabled = true;
            btnGenerarBackup.BackColor = ActiveBlueColor;
            btnGenerarBackup.ForeColor = Color.White;
            btnGenerarBackup.Cursor = Cursors.Hand;
            btnGenerarBackup.Invalidate();

            pnlRestoreSelector.Enabled = true;
            txtBackupFilePath.Enabled = true;
            btnBrowseBak.Enabled = true;
            btnBrowseBak.BackColor = ActiveBlueColor;
            btnBrowseBak.ForeColor = Color.White;
            btnBrowseBak.Cursor = Cursors.Hand;
            btnBrowseBak.Invalidate();

            Step1Confirmed?.Invoke(this, EventArgs.Empty);
        }

        private void BrowseBackupFile()
        {
            if (!IsStep1Confirmed)
            {
                return;
            }

            using var dialog = new OpenFileDialog
            {
                Filter = "SQL Server Backup (*.bak)|*.bak|All Files (*.*)|*.*",
                Title = "Seleccionar archivo de Backup (.bak)",
                CheckFileExists = true,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                txtBackupFilePath.Text = dialog.FileName;
                RestoreFileSelected?.Invoke(this, dialog.FileName);
            }
        }

        private void UpdateTabVisuals()
        {
            if (!IsRestoreMode)
            {
                btnTabBackup.BackColor = ActiveBlueColor;
                btnTabBackup.ForeColor = Color.White;
                btnTabRestore.BackColor = CardBgColor;
                btnTabRestore.ForeColor = InactiveTabTextColor;
            }
            else
            {
                btnTabBackup.BackColor = CardBgColor;
                btnTabBackup.ForeColor = InactiveTabTextColor;
                btnTabRestore.BackColor = ActiveBlueColor;
                btnTabRestore.ForeColor = Color.White;
            }

            btnTabBackup.Invalidate();
            btnTabRestore.Invalidate();
        }

        private void PnlDualAuthCard_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, pnlDualAuthCard.Width - 1, pnlDualAuthCard.Height - 1);
            using GraphicsPath path = CreateRoundedRectanglePath(rect, 10);
            using Pen borderPen = new Pen(CardBorderColor, 1f);
            e.Graphics.DrawPath(borderPen, path);
        }

        private void TabButton_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Button btn)
            {
                return;
            }

            bool isActive = (btn == btnTabBackup && !IsRestoreMode) || (btn == btnTabRestore && IsRestoreMode);
            if (isActive)
            {
                using SolidBrush accentBrush = new SolidBrush(ActiveTabAccentColor);
                e.Graphics.FillRectangle(accentBrush, 0, btn.Height - 3, btn.Width, 3);
            }
            else
            {
                using Pen linePen = new Pen(InactiveTabLineColor, 1f);
                e.Graphics.DrawLine(linePen, 0, btn.Height - 1, btn.Width, btn.Height - 1);
            }
        }

        private void FlatActionButton_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Button btn)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(pnlDualAuthCard.BackColor);

            Rectangle rect = new Rectangle(0, 0, btn.Width - 1, btn.Height - 1);
            using GraphicsPath path = CreateRoundedRectanglePath(rect, 4);
            using SolidBrush bgBrush = new SolidBrush(btn.BackColor);
            e.Graphics.FillPath(bgBrush, path);

            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                btn.ClientRectangle,
                btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}

