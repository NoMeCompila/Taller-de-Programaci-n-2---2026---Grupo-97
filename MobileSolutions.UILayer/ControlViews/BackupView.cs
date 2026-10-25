using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
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
        public event EventHandler<string>? BackupDestinationSelected;
        public event EventHandler<string>? RestoreFileSelected;

        /// <summary>
        /// Punto de extensión para conectar la lógica real de Backup contra la base de datos
        /// (recibe el directorio destino y el nombre de archivo generado).
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<string, string>? BackupDatabaseAction { get; set; }

        /// <summary>
        /// Punto de extensión para validar las credenciales de Administrador en el Paso 1 contra la base de datos.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<string, string, (bool IsValid, string Message)>? ValidateStep1CredentialsFunc { get; set; }

        /// <summary>
        /// Punto de extensión para conectar la lógica real de Restore con Validación Cruzada (Cross-Auth).
        /// Parámetros: backupFilePath, admin1Username, admin1Password, admin2Username, admin2Password.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<string, string, string, string, string>? RestoreDatabaseAction { get; set; }

        /// <summary>
        /// Punto de extensión para consultar las fechas de Último Backup y Último Restore.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Func<(DateTime? LastBackup, DateTime? LastRestore)>? GetBackupRestoreStatusFunc { get; set; }

        public bool IsRestoreMode { get; private set; }
        public bool IsStep1Confirmed { get; private set; }
        public string Admin1Username => txtAdmin1User.Text.Trim();
        public string Admin2Username => txtAdmin2User.Text.Trim();
        public string SelectedBackupDestinationPath => txtBackupDestinationPath.Text.Trim();
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
            this.Load += (s, e) =>
            {
                CenterDualAuthCard();
                RefreshAuditMetrics();
            };

            btnTabBackup.UseVisualStyleBackColor = false;
            btnTabRestore.UseVisualStyleBackColor = false;

            pnlDualAuthCard.Paint += PnlDualAuthCard_Paint;
            btnTabBackup.Paint += TabButton_Paint;
            btnTabRestore.Paint += TabButton_Paint;
            btnConfirmStep1.Paint += FlatActionButton_Paint;
            btnBrowseBackupPath.Paint += FlatActionButton_Paint;
            btnGenerarBackup.Paint += FlatActionButton_Paint;
            btnBrowseBak.Paint += FlatActionButton_Paint;
            btnEjecutarRestore.Paint += FlatActionButton_Paint;

            btnTabBackup.Click += (s, e) => SwitchToBackupTab();
            btnTabRestore.Click += (s, e) => SwitchToRestoreTab();
            btnConfirmStep1.Click += (s, e) => ConfirmStep1();
            btnBrowseBackupPath.Click += (s, e) => BrowseBackupDestinationFolder();
            btnGenerarBackup.Click += (s, e) => ExecuteBackup();
            btnBrowseBak.Click += (s, e) => BrowseBackupFile();
            btnEjecutarRestore.Click += (s, e) => ExecuteRestore();

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

            SetDualAuthCredentialsVisible(false);
            pnlRestoreSelector.Visible = false;
            btnEjecutarRestore.Visible = false;

            pnlStatusInfo.Location = new Point(20, 360);

            pnlBackupSelector.Visible = true;
            pnlBackupSelector.Enabled = true;
            txtBackupDestinationPath.Enabled = true;
            txtBackupDestinationPath.Text = string.Empty;

            btnBrowseBackupPath.Enabled = true;
            btnBrowseBackupPath.BackColor = ActiveBlueColor;
            btnBrowseBackupPath.ForeColor = Color.White;
            btnBrowseBackupPath.Cursor = Cursors.Hand;
            btnBrowseBackupPath.Invalidate();

            btnGenerarBackup.Visible = true;
            btnGenerarBackup.Enabled = true;
            btnGenerarBackup.BackColor = ActiveBlueColor;
            btnGenerarBackup.ForeColor = Color.White;
            btnGenerarBackup.Cursor = Cursors.Hand;
            btnGenerarBackup.Invalidate();
        }

        public void SwitchToRestoreTab()
        {
            IsRestoreMode = true;
            UpdateTabVisuals();

            pnlBackupSelector.Visible = false;
            btnGenerarBackup.Visible = false;

            SetDualAuthCredentialsVisible(true);
            pnlRestoreSelector.Visible = true;
            btnEjecutarRestore.Visible = true;

            pnlStatusInfo.Location = new Point(20, 595);

            ResetDualAuthState();
        }

        private void SetDualAuthCredentialsVisible(bool visible)
        {
            lblStep1Title.Visible = visible;
            txtAdmin1User.Visible = visible;
            txtAdmin1Password.Visible = visible;
            btnConfirmStep1.Visible = visible;
            lblStep2Title.Visible = visible;
            txtAdmin2User.Visible = visible;
            txtAdmin2Password.Visible = visible;

            if (!visible)
            {
                picStep1UserCheck.Visible = false;
                picStep1PassCheck.Visible = false;
                picStep1ConfirmCheck.Visible = false;
                lblStep1Completed.Visible = false;
            }
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

            txtBackupFilePath.Text = string.Empty;
            txtBackupFilePath.Enabled = false;
            pnlRestoreSelector.Enabled = false;

            btnBrowseBak.Enabled = false;
            btnBrowseBak.BackColor = DisabledActionBgColor;
            btnBrowseBak.ForeColor = DisabledActionFgColor;
            btnBrowseBak.Cursor = Cursors.Default;
            btnBrowseBak.Invalidate();

            btnEjecutarRestore.Enabled = false;
            btnEjecutarRestore.BackColor = DisabledActionBgColor;
            btnEjecutarRestore.ForeColor = DisabledActionFgColor;
            btnEjecutarRestore.Cursor = Cursors.Default;
            btnEjecutarRestore.Invalidate();
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

            // Validación de credenciales de Administrador contra base de datos (Paso 1)
            if (ValidateStep1CredentialsFunc != null)
            {
                var validation = ValidateStep1CredentialsFunc(txtAdmin1User.Text.Trim(), txtAdmin1Password.Text);
                if (!validation.IsValid)
                {
                    MaterialMessageBox.Show(
                        validation.Message,
                        "Validación del Administrador Fallida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
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

            pnlRestoreSelector.Enabled = true;
            txtBackupFilePath.Enabled = true;
            btnBrowseBak.Enabled = true;
            btnBrowseBak.BackColor = ActiveBlueColor;
            btnBrowseBak.ForeColor = Color.White;
            btnBrowseBak.Cursor = Cursors.Hand;
            btnBrowseBak.Invalidate();

            btnEjecutarRestore.Enabled = true;
            btnEjecutarRestore.BackColor = ActiveBlueColor;
            btnEjecutarRestore.ForeColor = Color.White;
            btnEjecutarRestore.Cursor = Cursors.Hand;
            btnEjecutarRestore.Invalidate();

            Step1Confirmed?.Invoke(this, EventArgs.Empty);
        }

        private void BrowseBackupDestinationFolder()
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Seleccionar carpeta destino para el archivo de Backup (.bak)",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = true
            };

            if (dialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            {
                txtBackupDestinationPath.Text = dialog.SelectedPath;
                BackupDestinationSelected?.Invoke(this, dialog.SelectedPath);
            }
        }

        /// <summary>
        /// Construye el nombre del archivo de backup con el formato:
        /// "MobileSolution-dd-MM-yyyy-HH-mm-ss.ff.bak"
        /// </summary>
        public static string BuildBackupFileName(DateTime? timestamp = null)
        {
            DateTime now = timestamp ?? DateTime.Now;
            return $"MobileSolution-{now.ToString("dd-MM-yyyy-HH-mm-ss.ff", CultureInfo.InvariantCulture)}.bak";
        }

        /// <summary>
        /// Construye el mensaje de confirmación de backup con el formato:
        /// "\"MobileSolution-dd-MM-yyyy-HH-mm-ss.ff.bak\" generado correctamente"
        /// </summary>
        public static string BuildBackupSuccessMessage(DateTime? timestamp = null)
        {
            string backupFileName = BuildBackupFileName(timestamp);
            return $"\"{backupFileName}\" generado correctamente";
        }

        public void ExecuteBackup()
        {
            if (string.IsNullOrWhiteSpace(SelectedBackupDestinationPath))
            {
                MaterialMessageBox.Show(
                    "Por favor seleccione una ruta destino antes de generar el backup.",
                    "Ruta Requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string backupFileName = BuildBackupFileName();

                ExecuteDatabaseBackup(SelectedBackupDestinationPath, backupFileName);
                BackupActionRequested?.Invoke(this, EventArgs.Empty);

                string actor = !string.IsNullOrWhiteSpace(Admin1Username)
                    ? Admin1Username
                    : (!string.IsNullOrWhiteSpace(MobileSolutions.BusinessLayer.CurrentSession.Username)
                        ? MobileSolutions.BusinessLayer.CurrentSession.Username
                        : "Administrador");

                new MobileSolutions.BusinessLayer.AuditService().RecordEvent(
                    "Backup Created",
                    actor,
                    "Success",
                    $"Archivo generado: {backupFileName}");

                RefreshAuditMetrics();

                MaterialMessageBox.Show(
                    $"\"{backupFileName}\" generado correctamente",
                    "Backup Generado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(
                    $"Error al generar el backup: {ex.Message}",
                    "Error de Backup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método preparado para la integración con la capa de negocio / base de datos.
        /// </summary>
        protected virtual void ExecuteDatabaseBackup(string destinationDirectory, string backupFileName)
        {
            BackupDatabaseAction?.Invoke(destinationDirectory, backupFileName);
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

        /// <summary>
        /// Ejecuta la restauración de la base de datos tras verificar la doble autorización cruzada (Cross-Auth).
        /// </summary>
        public void ExecuteRestore()
        {
            if (!IsStep1Confirmed)
            {
                MaterialMessageBox.Show(
                    "Debe confirmar el Paso 1 (Credenciales del Administrador) antes de continuar.",
                    "Paso Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdmin2User.Text) || string.IsNullOrWhiteSpace(txtAdmin2Password.Text))
            {
                MaterialMessageBox.Show(
                    "Por favor complete el usuario y contraseña del Segundo Autorizador (Gerente).",
                    "Campos Requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(SelectedBackupFilePath))
            {
                MaterialMessageBox.Show(
                    "Por favor seleccione un archivo de backup (.bak) para restaurar.",
                    "Archivo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MaterialMessageBox.Show(
                "ADVERTENCIA: ¿Está seguro que desea restaurar la base de datos?\n\n" +
                $"Archivo origen: {Path.GetFileName(SelectedBackupFilePath)}\n\n" +
                "Esta acción reemplazará la base de datos actual con el contenido del respaldo y no se puede deshacer.",
                "Confirmación de Restauración",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                if (RestoreDatabaseAction != null)
                {
                    RestoreDatabaseAction.Invoke(
                        SelectedBackupFilePath,
                        Admin1Username,
                        txtAdmin1Password.Text,
                        Admin2Username,
                        txtAdmin2Password.Text);
                }
                else
                {
                    var backupService = new MobileSolutions.BusinessLayer.BackupService();
                    backupService.RestoreDatabase(
                        SelectedBackupFilePath,
                        Admin1Username,
                        txtAdmin1Password.Text,
                        Admin2Username,
                        txtAdmin2Password.Text);
                }

                // Registrar auditoría post-restore para que persista en la base recién restaurada
                try
                {
                    new MobileSolutions.BusinessLayer.AuditService().RecordEvent(
                        "Database Restored",
                        $"{Admin1Username} (Co-autorizó: {Admin2Username})",
                        "Success",
                        $"Restaurado desde: {Path.GetFileName(SelectedBackupFilePath)}");
                }
                catch
                {
                }

                RefreshAuditMetrics();
                ResetDualAuthState();

                MaterialMessageBox.Show(
                    "La base de datos ha sido restaurada correctamente y se encuentra disponible para su uso inmediato.",
                    "Restauración Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                try
                {
                    new MobileSolutions.BusinessLayer.AuditService().RecordEvent(
                        "Database Restored",
                        $"{Admin1Username} (Co-autorizó: {Admin2Username})",
                        "Failure",
                        $"Error: {ex.Message}");
                }
                catch
                {
                }

                MaterialMessageBox.Show(
                    $"Error al restaurar la base de datos: {ex.Message}",
                    "Error de Restauración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Consulta y actualiza en pantalla las fechas de Último Backup y Último Restore.
        /// </summary>
        public void RefreshAuditMetrics()
        {
            try
            {
                DateTime? lastBackup = null;
                DateTime? lastRestore = null;

                if (GetBackupRestoreStatusFunc != null)
                {
                    var status = GetBackupRestoreStatusFunc();
                    lastBackup = status.LastBackup;
                    lastRestore = status.LastRestore;
                }
                else
                {
                    var metrics = new MobileSolutions.BusinessLayer.AuditService().GetDashboardMetrics();
                    lastBackup = metrics.LastBackupTimestamp;
                    lastRestore = metrics.LastRestoreTimestamp;
                }

                lblLastBackupInfo.Text = lastBackup.HasValue
                    ? $"Último Backup: {lastBackup.Value.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}"
                    : "Último Backup: Sin registros";

                lblLastRestoreInfo.Text = lastRestore.HasValue
                    ? $"Último Restore: {lastRestore.Value.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)}"
                    : "Último Restore: Sin registros";
            }
            catch
            {
                lblLastBackupInfo.Text = "Último Backup: No disponible";
                lblLastRestoreInfo.Text = "Último Restore: No disponible";
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
