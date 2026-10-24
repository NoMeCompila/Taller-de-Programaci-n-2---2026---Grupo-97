using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.DataLayer;
using System;
using System.Collections.Generic;

namespace MobileSolutions.BusinessLayer
{
    public class BackupMaintenanceEvaluation
    {
        public bool IsWarning { get; set; }
        public int DaysRemaining { get; set; }
        public string AlertMessage { get; set; } = string.Empty;
        public string StatusDescription { get; set; } = string.Empty;
    }

    public class AuditService
    {
        private readonly AuditDal _auditDal;

        public AuditService()
        {
            _auditDal = new AuditDal();
        }

        public AuditService(AuditDal auditDal)
        {
            _auditDal = auditDal;
        }

        /// <summary>
        /// Registra un evento de auditoría en el sistema.
        /// </summary>
        public bool RecordEvent(string eventType, string actor, string outcome, string? details = null)
        {
            if (string.IsNullOrWhiteSpace(eventType)) return false;
            string effectiveActor = string.IsNullOrWhiteSpace(actor) ? "Sistema" : actor.Trim();
            string effectiveOutcome = string.IsNullOrWhiteSpace(outcome) ? "Success" : outcome.Trim();

            return _auditDal.RecordAuditEvent(eventType.Trim(), effectiveActor, effectiveOutcome, details?.Trim());
        }

        /// <summary>
        /// Obtiene todas las métricas consolidadas del dashboard administrativo.
        /// </summary>
        public AdminDashboardMetrics GetDashboardMetrics()
        {
            return _auditDal.GetAdminDashboardMetrics();
        }

        /// <summary>
        /// Obtiene los últimos N eventos críticos del log de auditoría (AC2).
        /// </summary>
        public List<AuditEvent> GetRecentCriticalEvents(int count = 15)
        {
            return _auditDal.GetLastCriticalAuditEvents(count);
        }

        /// <summary>
        /// Obtiene el historial de auditoría de precios generado por el trigger de SQL Server.
        /// </summary>
        public List<ProductPriceAuditRecord> GetProductPriceAuditHistory(int count = 100)
        {
            return _auditDal.GetProductPriceAuditHistory(count);
        }

        /// <summary>
        /// Evalúa la regla de mantenimiento semanal de Backup (AC4).
        /// Si transcurrieron más de 7 días del último backup o no hay registros, activa el estado de advertencia rojo.
        /// Si está dentro de los 7 días, calcula los días restantes para el siguiente ciclo.
        /// </summary>
        public BackupMaintenanceEvaluation EvaluateBackupMaintenance(DateTime? lastBackupTimestamp, DateTime? referenceDate = null)
        {
            DateTime now = referenceDate ?? DateTime.Now;

            // Caso sin backups registrados
            if (!lastBackupTimestamp.HasValue)
            {
                return new BackupMaintenanceEvaluation
                {
                    IsWarning = true,
                    DaysRemaining = 0,
                    AlertMessage = "Alerta: Se superó el ciclo de 1 semana sin pruebas de restauración",
                    StatusDescription = "Sin registros de backup en el sistema"
                };
            }

            TimeSpan elapsed = now - lastBackupTimestamp.Value;

            // Si la fecha del backup es futura por desfasaje de reloj, se asume 7 días restantes
            if (elapsed.TotalSeconds < 0)
            {
                return new BackupMaintenanceEvaluation
                {
                    IsWarning = false,
                    DaysRemaining = 7,
                    AlertMessage = string.Empty,
                    StatusDescription = "7 días restantes para la próxima prueba"
                };
            }

            if (elapsed.TotalDays > 7.0)
            {
                int expiredDays = (int)Math.Floor(elapsed.TotalDays - 7.0);
                string expiredText = expiredDays <= 1 ? "1 día" : $"{expiredDays} días";

                return new BackupMaintenanceEvaluation
                {
                    IsWarning = true,
                    DaysRemaining = 0,
                    AlertMessage = "Alerta: Se superó el ciclo de 1 semana sin pruebas de restauración",
                    StatusDescription = $"Vencido hace {expiredText}"
                };
            }

            // Dentro del período de 7 días
            int daysRemaining = Math.Max(0, 7 - (int)Math.Floor(elapsed.TotalDays));
            string daysText = daysRemaining == 1 ? "1 día restante" : $"{daysRemaining} días restantes";

            return new BackupMaintenanceEvaluation
            {
                IsWarning = false,
                DaysRemaining = daysRemaining,
                AlertMessage = string.Empty,
                StatusDescription = $"{daysText} para la próxima prueba"
            };
        }
    }
}
