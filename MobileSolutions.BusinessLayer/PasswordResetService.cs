using System;
using System.Diagnostics;
using System.Security.Cryptography;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace MobileSolutions.BusinessLayer
{
    /// <summary>
    /// Servicio de generación y envío de tokens OTP de recuperación de contraseña.
    /// Utiliza MailKit y MimeKit para comunicación SMTP segura.
    /// </summary>
    public static class PasswordResetService
    {
        private static string? _smtpUser;
        private static string? _smtpPass;

        // Configuración SMTP configurable (lee de variables de entorno por defecto)
        public static string SmtpHost { get; set; } = "smtp.gmail.com";
        public static int SmtpPort { get; set; } = 587;

        public static string SmtpUser
        {
            get => _smtpUser
                   ?? Environment.GetEnvironmentVariable("SMTP_USER")
                   ?? Environment.GetEnvironmentVariable("SMTP_USER", EnvironmentVariableTarget.User)
                   ?? "your-email@gmail.com";
            set => _smtpUser = value;
        }

        public static string SmtpPass
        {
            get => _smtpPass
                   ?? Environment.GetEnvironmentVariable("SMTP_PASS")
                   ?? Environment.GetEnvironmentVariable("SMTP_PASS", EnvironmentVariableTarget.User)
                   ?? "";
            set => _smtpPass = value;
        }

        public static string FromName { get; set; } = "MobileSolutions";

        /// <summary>
        /// Genera un token numérico OTP de 6 dígitos criptográficamente seguro [100000 - 999999].
        /// </summary>
        public static string GenerateNumericOtp()
        {
            return RandomNumberGenerator.GetInt32(100000, 1000000).ToString("D6");
        }

        /// <summary>
        /// Envía el código de recuperación por correo electrónico en formato HTML.
        /// </summary>
        public static (bool Success, string? ErrorMessage) SendResetOtpEmail(string targetEmail, string otpCode)
        {
            // Registro en consola de depuración para desarrollo y auditoría local
            Debug.WriteLine($"[PasswordResetService] Generado OTP {otpCode} para {targetEmail}");

            if (string.IsNullOrWhiteSpace(SmtpPass) || SmtpUser == "your-email@gmail.com")
            {
                return (false, "Credenciales SMTP no configuradas. Por favor configure las variables de entorno del sistema SMTP_USER y SMTP_PASS.");
            }

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(FromName, SmtpUser.Trim()));
                message.To.Add(new MailboxAddress("", targetEmail.Trim()));
                message.Subject = "Código de Recuperación de Contraseña - Mobile Solutions";

                message.Body = new TextPart("html")
                {
                    Text = $@"
                        <div style='font-family: Arial, sans-serif; max-width: 480px; padding: 24px; border: 1px solid #e0e0e0; border-radius: 8px;'>
                            <h2 style='color: #1976D2; margin-top: 0;'>Mobile Solutions</h2>
                            <p style='color: #333333; font-size: 15px;'>Recibimos una solicitud para restablecer tu contraseña de acceso.</p>
                            <p style='color: #333333; font-size: 14px;'>Utiliza el siguiente código de verificación de 6 dígitos:</p>
                            <div style='background-color: #f5f5f5; padding: 18px; text-align: center; border-radius: 6px; margin: 20px 0;'>
                                <span style='font-size: 32px; font-weight: bold; letter-spacing: 6px; color: #0D47A1;'>{otpCode}</span>
                            </div>
                            <p style='color: #757575; font-size: 12px;'>Este código es válido por 15 minutos. Si no solicitaste este cambio, puedes ignorar este mensaje de forma segura.</p>
                        </div>"
                };

                using var client = new SmtpClient();
                client.Connect(SmtpHost, SmtpPort, SecureSocketOptions.StartTls);
                client.Authenticate(SmtpUser.Trim(), SmtpPass.Replace(" ", "").Trim());
                client.Send(message);
                client.Disconnect(true);

                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}

