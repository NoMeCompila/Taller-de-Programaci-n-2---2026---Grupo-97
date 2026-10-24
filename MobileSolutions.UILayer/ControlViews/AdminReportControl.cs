using FontAwesome.Sharp;
using MaterialSkin.Controls;
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.UILayer.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MobileSolutions.UILayer
{
    public partial class AdminReportControl : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        private readonly AuditService _auditService;

        private static readonly Color MainBackground = Color.FromArgb(50, 50, 50);
        private static readonly Color CardBackground = Color.FromArgb(60, 60, 60);
        private static readonly Color AlertCardBackground = Color.FromArgb(100, 25, 25);
        private static readonly Color GridRowAlternateColor = Color.FromArgb(48, 48, 48);

        private static readonly Color PositiveColor = Color.FromArgb(102, 187, 106);
        private static readonly Color NegativeColor = Color.FromArgb(239, 83, 80);
        private static readonly Color WarningColor = Color.FromArgb(255, 167, 38);
        private static readonly Color NeutralColor = Color.FromArgb(180, 180, 180);

        private static readonly Color ActiveTabColor = Color.FromArgb(25, 118, 210);
        private static readonly Color InactiveTabColor = Color.FromArgb(46, 46, 46);

        public AdminReportControl()
        {
            InitializeComponent();
            _auditService = new AuditService();

            ConfigureHeaderAndTabs();
            ConfigureDataGrids();

            this.Load += (s, e) => RefreshDashboardData();
        }

        private void ConfigureHeaderAndTabs()
        {
            picTitle.IconChar = IconChar.ShieldHalved;
            picTitle.IconColor = Color.White;

            btnRefresh.Icon = IconChar.Rotate.ToBitmap(Color.White, 20);
            btnRefresh.Click += (s, e) => RefreshDashboardData();

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White, 20);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

            btnTabGovernance.Click += (s, e) => SwitchTab(isPriceAudit: false);
            btnTabPriceAudit.Click += (s, e) => SwitchTab(isPriceAudit: true);

            SwitchTab(isPriceAudit: false);
        }

        private void SwitchTab(bool isPriceAudit)
        {
            if (isPriceAudit)
            {
                pnlGovernanceView.Visible = false;
                pnlPriceAuditView.Visible = true;
                pnlPriceAuditView.BringToFront();

                btnTabPriceAudit.BackColor = ActiveTabColor;
                btnTabPriceAudit.ForeColor = Color.White;
                btnTabPriceAudit.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

                btnTabGovernance.BackColor = InactiveTabColor;
                btnTabGovernance.ForeColor = Color.FromArgb(210, 210, 210);
                btnTabGovernance.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
            else
            {
                pnlPriceAuditView.Visible = false;
                pnlGovernanceView.Visible = true;
                pnlGovernanceView.BringToFront();

                btnTabGovernance.BackColor = ActiveTabColor;
                btnTabGovernance.ForeColor = Color.White;
                btnTabGovernance.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);

                btnTabPriceAudit.BackColor = InactiveTabColor;
                btnTabPriceAudit.ForeColor = Color.FromArgb(210, 210, 210);
                btnTabPriceAudit.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
        }

        private void ConfigureDataGrids()
        {
            // Estilo general para tablas oscuras
            ApplyDarkGridStyle(dgvCriticalEvents);
            ApplyDarkGridStyle(dgvPriceAudit);

            // Columnas para Eventos Críticos (AC2)
            dgvCriticalEvents.Columns.Clear();
            dgvCriticalEvents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y Hora", DataPropertyName = "TimestampFormatted", FillWeight = 18 });
            dgvCriticalEvents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo de Evento", DataPropertyName = "EventType", FillWeight = 20 });
            dgvCriticalEvents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Usuario / Actor", DataPropertyName = "Actor", FillWeight = 18 });
            dgvCriticalEvents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Resultado", DataPropertyName = "Outcome", FillWeight = 14 });
            dgvCriticalEvents.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Detalles", DataPropertyName = "Details", FillWeight = 30 });

            dgvCriticalEvents.CellFormatting += DgvCriticalEvents_CellFormatting;

            // Columnas para Auditoría de Precios (Trigger)
            dgvPriceAudit.Columns.Clear();
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha de Cambio", DataPropertyName = "DateFormatted", FillWeight = 15 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Código", DataPropertyName = "ProductCode", FillWeight = 12 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "ProductName", FillWeight = 23 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio Compra Ant.", DataPropertyName = "OldPurchaseFormatted", FillWeight = 12 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nuevo Compra", DataPropertyName = "NewPurchaseFormatted", FillWeight = 12 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio Venta Ant.", DataPropertyName = "OldSaleFormatted", FillWeight = 13 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nuevo Venta", DataPropertyName = "NewSaleFormatted", FillWeight = 13 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Diferencia $", DataPropertyName = "DiffFormatted", FillWeight = 12 });
            dgvPriceAudit.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Variación %", DataPropertyName = "PercFormatted", FillWeight = 10 });

            dgvPriceAudit.CellFormatting += DgvPriceAudit_CellFormatting;
        }

        private static void ApplyDarkGridStyle(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Color.FromArgb(42, 42, 42);
            grid.DefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 118, 210);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            grid.AlternatingRowsDefaultCellStyle.BackColor = GridRowAlternateColor;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 32, 32);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grid.ColumnHeadersHeight = 35;
            grid.RowTemplate.Height = 28;
            grid.GridColor = Color.FromArgb(65, 65, 65);
        }

        public void RefreshDashboardData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                AdminDashboardMetrics metrics = _auditService.GetDashboardMetrics();
                BackupMaintenanceEvaluation maintenance = _auditService.EvaluateBackupMaintenance(metrics.LastBackupTimestamp);
                List<AuditEvent> criticalEvents = _auditService.GetRecentCriticalEvents(15);
                List<ProductPriceAuditRecord> priceRecords = _auditService.GetProductPriceAuditHistory(100);

                RenderKpiCards(metrics, maintenance);
                RenderCriticalEventsGrid(criticalEvents);
                RenderPriceAuditGrid(priceRecords);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar las métricas de gobernanza: {ex.Message}",
                    "Error al cargar auditoría",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void RenderKpiCards(AdminDashboardMetrics metrics, BackupMaintenanceEvaluation maintenance)
        {
            tlpKpis.SuspendLayout();
            tlpKpis.Controls.Clear();

            // ============================================================
            // FILA 0: AC1 - Auditoría de Acceso y Sesiones
            // ============================================================

            // 1. Usuario con más logins
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.UserCheck,
                "Usuario con Más Logins",
                metrics.MostActiveUser,
                $"{metrics.MostActiveUserLoginCount} inicios de sesión registrados",
                NeutralColor), 0, 0);

            // 2. Cuentas Huérfanas / Inactivas (>30 días)
            Color orphanColor = metrics.OrphanAccountsCount > 0 ? WarningColor : PositiveColor;
            string orphanSubtitle = metrics.OrphanAccountsCount > 0
                ? "Cuentas activas sin login > 30 días o nunca"
                : "Todas las cuentas registran actividad reciente";
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.UserClock,
                "Cuentas Huérfanas / Inactivas",
                metrics.OrphanAccountsCount.ToString(),
                orphanSubtitle,
                orphanColor), 1, 0);

            // 3. Último login registrado
            string lastLoginSubtitle = metrics.LastLoginTimestamp.HasValue
                ? metrics.LastLoginTimestamp.Value.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                : "Sin registros";
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.ClockRotateLeft,
                "Último Login Registrado",
                metrics.LastLoginUser,
                lastLoginSubtitle,
                NeutralColor), 2, 0);

            // 4. Intentos fallidos últimas 24 horas
            Color failedColor = metrics.FailedLoginsLast24Hours > 0 ? NegativeColor : PositiveColor;
            string failedSubtitle = metrics.FailedLoginsLast24Hours > 0
                ? "Intentos rechazados en las últimas 24h"
                : "Sin rechazos en las últimas 24h";
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.UserShield,
                "Intentos Fallidos (24h)",
                metrics.FailedLoginsLast24Hours.ToString(),
                failedSubtitle,
                failedColor), 3, 0);

            // ============================================================
            // FILA 1: AC3 & AC4 - Métricas de BD, DRP y Mantenimiento Semanal
            // ============================================================

            // 5. Tamaño total de base de datos (MB/GB)
            string dbSizeValue = metrics.DatabaseUsedMb >= 1024m
                ? $"{(metrics.DatabaseUsedMb / 1024m):N2} GB"
                : $"{metrics.DatabaseUsedMb:N2} MB";
            string dbAllocatedSubtitle = metrics.DatabaseAllocatedMb >= 1024m
                ? $"De {(metrics.DatabaseAllocatedMb / 1024m):N2} GB asignados en disco"
                : $"De {metrics.DatabaseAllocatedMb:N2} MB asignados en disco";
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.Database,
                "Espacio en Disco SQL",
                dbSizeValue,
                dbAllocatedSubtitle,
                NeutralColor), 0, 1);

            // 6. Total de Backups y Restores
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.FloppyDisk,
                "Backups y Restores Generados",
                $"{metrics.TotalBackups} / {metrics.TotalRestores}",
                $"{metrics.TotalBackups} Backups | {metrics.TotalRestores} Restores históricos",
                NeutralColor), 1, 1);

            // 7. Último Restore Registrado
            string lastRestoreValue = metrics.LastRestoreTimestamp.HasValue
                ? metrics.LastRestoreTimestamp.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)
                : "Sin registros";
            string lastRestoreSubtitle = metrics.LastRestoreTimestamp.HasValue
                ? metrics.LastRestoreTimestamp.Value.ToString("HH:mm:ss", CultureInfo.InvariantCulture)
                : "Aún no se ejecutaron restauraciones";
            tlpKpis.Controls.Add(CreateKpiCard(
                IconChar.RotateLeft,
                "Último Restore Registrado",
                lastRestoreValue,
                lastRestoreSubtitle,
                NeutralColor), 2, 1);

            // 8. Mantenimiento Semanal DRP (AC4)
            if (maintenance.IsWarning)
            {
                tlpKpis.Controls.Add(CreateAlertKpiCard(
                    IconChar.TriangleExclamation,
                    "Mantenimiento DRP Semanal",
                    "Ciclo Vencido",
                    maintenance.AlertMessage,
                    maintenance.StatusDescription), 3, 1);
            }
            else
            {
                tlpKpis.Controls.Add(CreateKpiCard(
                    IconChar.CircleCheck,
                    "Mantenimiento DRP Semanal",
                    $"{maintenance.DaysRemaining} días",
                    maintenance.StatusDescription,
                    PositiveColor), 3, 1);
            }

            tlpKpis.ResumeLayout();
        }

        private Panel CreateKpiCard(
            IconChar icon,
            string title,
            string value,
            string? subtitle,
            Color subtitleColor)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
                Margin = new Padding(6),
                Padding = new Padding(12, 10, 12, 10)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var picIcon = new IconPictureBox
            {
                IconChar = icon,
                IconColor = Color.White,
                IconSize = 26,
                Size = new Size(28, 28),
                BackColor = Color.Transparent,
                Dock = DockStyle.Left,
                TabStop = false
            };

            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.FromArgb(200, 200, 200),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            var lblValue = new Label
            {
                Text = value,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            var lblSubtitle = new Label
            {
                Text = subtitle ?? string.Empty,
                ForeColor = subtitleColor,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            layout.Controls.Add(picIcon, 0, 0);
            layout.Controls.Add(lblTitle, 0, 1);
            layout.Controls.Add(lblValue, 0, 2);
            layout.Controls.Add(lblSubtitle, 0, 3);

            card.Controls.Add(layout);
            return card;
        }

        private Panel CreateAlertKpiCard(
            IconChar icon,
            string title,
            string value,
            string alertMessage,
            string statusDescription)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = AlertCardBackground,
                Margin = new Padding(6),
                Padding = new Padding(12, 8, 12, 8)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var picIcon = new IconPictureBox
            {
                IconChar = icon,
                IconColor = Color.FromArgb(255, 120, 120),
                IconSize = 24,
                Size = new Size(26, 26),
                BackColor = Color.Transparent,
                Dock = DockStyle.Left,
                TabStop = false
            };

            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.FromArgb(255, 200, 200),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            // Mensaje de alerta obligatorio exacto según AC4
            var lblValue = new Label
            {
                Text = alertMessage,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = false
            };

            var lblSubtitle = new Label
            {
                Text = statusDescription,
                ForeColor = Color.FromArgb(255, 180, 180),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };

            layout.Controls.Add(picIcon, 0, 0);
            layout.Controls.Add(lblTitle, 0, 1);
            layout.Controls.Add(lblValue, 0, 2);
            layout.Controls.Add(lblSubtitle, 0, 3);

            card.Controls.Add(layout);
            return card;
        }

        private void RenderCriticalEventsGrid(List<AuditEvent> events)
        {
            var rows = new List<CriticalEventRowView>();

            foreach (var ev in events)
            {
                rows.Add(new CriticalEventRowView
                {
                    TimestampFormatted = ev.Timestamp.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    EventType = ev.EventType,
                    Actor = ev.Actor,
                    Outcome = ev.Outcome,
                    Details = ev.Details ?? string.Empty
                });
            }

            dgvCriticalEvents.DataSource = rows;
        }

        private void RenderPriceAuditGrid(List<ProductPriceAuditRecord> records)
        {
            var rows = new List<PriceAuditRowView>();

            foreach (var r in records)
            {
                string sign = r.SaleDifference >= 0m ? "+" : string.Empty;
                rows.Add(new PriceAuditRowView
                {
                    DateFormatted = r.ChangeDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    ProductCode = r.ProductCode,
                    ProductName = r.ProductName,
                    OldPurchaseFormatted = string.Format(CultureInfo.InvariantCulture, "${0:N2}", r.OldPurchasePrice),
                    NewPurchaseFormatted = string.Format(CultureInfo.InvariantCulture, "${0:N2}", r.NewPurchasePrice),
                    OldSaleFormatted = string.Format(CultureInfo.InvariantCulture, "${0:N2}", r.OldSalePrice),
                    NewSaleFormatted = string.Format(CultureInfo.InvariantCulture, "${0:N2}", r.NewSalePrice),
                    DiffFormatted = $"{sign}${r.SaleDifference:N2}",
                    PercFormatted = $"{sign}{r.PercentageChange:0.#}%",
                    SaleDifferenceRaw = r.SaleDifference
                });
            }

            dgvPriceAudit.DataSource = rows;
        }

        private void DgvCriticalEvents_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dgvCriticalEvents.Columns[e.ColumnIndex].DataPropertyName;

            if (colName == "Outcome" && e.Value != null)
            {
                string outcome = e.Value.ToString() ?? string.Empty;
                if (string.Equals(outcome, "Success", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = PositiveColor;
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else if (string.Equals(outcome, "Failure", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = NegativeColor;
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        }

        private void DgvPriceAudit_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = dgvPriceAudit.Columns[e.ColumnIndex].DataPropertyName;

            if ((colName == "DiffFormatted" || colName == "PercFormatted") && e.RowIndex < dgvPriceAudit.Rows.Count)
            {
                if (dgvPriceAudit.Rows[e.RowIndex].DataBoundItem is PriceAuditRowView item)
                {
                    if (item.SaleDifferenceRaw > 0m)
                    {
                        e.CellStyle.ForeColor = PositiveColor;
                    }
                    else if (item.SaleDifferenceRaw < 0m)
                    {
                        e.CellStyle.ForeColor = NegativeColor;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = NeutralColor;
                    }
                }
            }
        }

        private sealed class CriticalEventRowView
        {
            public string TimestampFormatted { get; set; } = string.Empty;
            public string EventType { get; set; } = string.Empty;
            public string Actor { get; set; } = string.Empty;
            public string Outcome { get; set; } = string.Empty;
            public string Details { get; set; } = string.Empty;
        }

        private sealed class PriceAuditRowView
        {
            public string DateFormatted { get; set; } = string.Empty;
            public string ProductCode { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public string OldPurchaseFormatted { get; set; } = string.Empty;
            public string NewPurchaseFormatted { get; set; } = string.Empty;
            public string OldSaleFormatted { get; set; } = string.Empty;
            public string NewSaleFormatted { get; set; } = string.Empty;
            public string DiffFormatted { get; set; } = string.Empty;
            public string PercFormatted { get; set; } = string.Empty;
            public decimal SaleDifferenceRaw { get; set; }
        }
    }
}
