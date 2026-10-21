using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MobileSolutions.BusinessLayer.Models;

namespace MobileSolutions.BusinessLayer.Models
{
    public class SaleTicketData
    {
        public string SaleNumber { get; set; } = string.Empty;
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public string SellerName { get; set; } = string.Empty;
        public string SellerUsername { get; set; } = string.Empty;
        public string SellerDni { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerDni { get; set; } = string.Empty;
        public string CustomerVatCondition { get; set; } = "Consumidor Final";
        public string PaymentMethod { get; set; } = "Efectivo";
        public decimal Total { get; set; }
        public List<SaleDetail> Items { get; set; } = new();
    }
}

namespace MobileSolutions.BusinessLayer
{
    public class TicketReportService
    {
        public const string TemplateFileName = "ticketSample.html";
        private static readonly CultureInfo EsArCulture = CreateEsArCulture();

        private static CultureInfo CreateEsArCulture()
        {
            var culture = (CultureInfo)CultureInfo.GetCultureInfo("es-AR").Clone();
            culture.NumberFormat.NumberGroupSeparator = ".";
            culture.NumberFormat.NumberDecimalSeparator = ",";
            culture.NumberFormat.CurrencyGroupSeparator = ".";
            culture.NumberFormat.CurrencyDecimalSeparator = ",";
            return culture;
        }

        /// <summary>
        /// Resuelve la ruta absoluta de ticketSample.html en la raíz de la aplicación/solución.
        /// Lanza FileNotFoundException si el archivo no existe.
        /// </summary>
        public string ResolveTemplatePath(string? customTemplatePath = null)
        {
            if (!string.IsNullOrWhiteSpace(customTemplatePath))
            {
                if (File.Exists(customTemplatePath))
                {
                    return Path.GetFullPath(customTemplatePath);
                }

                throw new FileNotFoundException(
                    $"No se encontró la plantilla de ticket '{TemplateFileName}' en la ruta base del sistema.",
                    TemplateFileName);
            }

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo? current = new DirectoryInfo(baseDir);

            // Buscar la raíz de la solución (donde reside MobileSolutions.slnx)
            while (current != null)
            {
                string slnxCandidate = Path.Combine(current.FullName, "MobileSolutions.slnx");
                if (File.Exists(slnxCandidate))
                {
                    string rootTemplate = Path.Combine(current.FullName, TemplateFileName);
                    if (File.Exists(rootTemplate))
                    {
                        return rootTemplate;
                    }

                    throw new FileNotFoundException(
                        $"No se encontró la plantilla de ticket '{TemplateFileName}' en la ruta base del sistema.",
                        TemplateFileName);
                }

                current = current.Parent;
            }

            // Fallback cuando la aplicación corre desplegada fuera del árbol de la solución
            string baseDirCandidate = Path.Combine(baseDir, TemplateFileName);
            if (File.Exists(baseDirCandidate))
            {
                return baseDirCandidate;
            }

            string workingDirCandidate = Path.Combine(Directory.GetCurrentDirectory(), TemplateFileName);
            if (File.Exists(workingDirCandidate))
            {
                return workingDirCandidate;
            }

            throw new FileNotFoundException(
                $"No se encontró la plantilla de ticket '{TemplateFileName}' en la ruta base del sistema.",
                TemplateFileName);
        }

        /// <summary>
        /// Formatea un importe monetario según la convención local ($ 15.250,00).
        /// </summary>
        public static string FormatCurrency(decimal amount)
        {
            return $"$ {amount.ToString("N2", EsArCulture)}";
        }

        /// <summary>
        /// Escapa únicamente caracteres estructurales HTML (&, <, >, ") preservando intactos los caracteres UTF-8 (tildes, ñ, etc.).
        /// </summary>
        private static string EscapeHtmlPreservingUtf8(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            return input
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;");
        }

        /// <summary>
        /// Genera las filas <tr>...</tr> correspondientes al detalle de productos del carrito.
        /// </summary>
        public string BuildProductRowsHtml(IEnumerable<SaleDetail> items)
        {
            if (items == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var item in items)
            {
                string rawProductName = !string.IsNullOrWhiteSpace(item.ProductName)
                    ? item.ProductName.Trim()
                    : (!string.IsNullOrWhiteSpace(item.BrandName) ? item.BrandName.Trim() : item.ProductCode.Trim());

                string productDisplay = EscapeHtmlPreservingUtf8(rawProductName);
                string unitPriceFormatted = FormatCurrency(item.UnitPrice);
                string subtotalFormatted = FormatCurrency(item.Subtotal);

                sb.AppendLine(
                    $"<tr><td>{productDisplay}</td><td class=\"text-center\">{item.Quantity}</td><td class=\"text-right\">{unitPriceFormatted}</td><td class=\"text-right\">{subtotalFormatted}</td></tr>");
            }

            return sb.ToString().TrimEnd();
        }

        /// <summary>
        /// Carga ticketSample.html en UTF-8 y reemplaza todos los marcadores dinámicos con los datos de la venta.
        /// </summary>
        public string BuildTicketHtml(SaleTicketData data, string? customTemplatePath = null)
        {
            ValidateTicketData(data);

            string templatePath = ResolveTemplatePath(customTemplatePath);
            string templateContent = File.ReadAllText(templatePath, Encoding.UTF8);

            decimal calculatedTotal = data.Total > 0 ? data.Total : data.Items.Sum(i => i.Subtotal);
            string formattedDate = data.SaleDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string formattedTotal = FormatCurrency(calculatedTotal);
            string productRowsHtml = BuildProductRowsHtml(data.Items);

            string vatCondition = string.IsNullOrWhiteSpace(data.CustomerVatCondition)
                ? "Consumidor Final"
                : data.CustomerVatCondition.Trim();

            string html = templateContent
                .Replace("#VENTA_NUMERO#", EscapeHtmlPreservingUtf8(data.SaleNumber.Trim()))
                .Replace("#FECHA#", EscapeHtmlPreservingUtf8(formattedDate))
                .Replace("#VENDEDOR_NOMBRE#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.SellerName) ? "-" : data.SellerName.Trim()))
                .Replace("#VENDEDOR_USUARIO#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.SellerUsername) ? "-" : data.SellerUsername.Trim()))
                .Replace("#VENDEDOR_DNI#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.SellerDni) ? "-" : data.SellerDni.Trim()))
                .Replace("#CLIENTE_NOMBRE#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.CustomerName) ? "-" : data.CustomerName.Trim()))
                .Replace("#CLIENTE_DNI#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.CustomerDni) ? "-" : data.CustomerDni.Trim()))
                .Replace("#CLIENTE_CONDICION_IVA#", EscapeHtmlPreservingUtf8(vatCondition))
                .Replace("#FILAS_PRODUCTOS#", productRowsHtml)
                .Replace("#METODO_PAGO#", EscapeHtmlPreservingUtf8(string.IsNullOrWhiteSpace(data.PaymentMethod) ? "Efectivo" : data.PaymentMethod.Trim()))
                .Replace("#TOTAL#", EscapeHtmlPreservingUtf8(formattedTotal));

            return html;
        }

        /// <summary>
        /// Genera el archivo HTML procesado (UTF-8) y el documento PDF listo para vista previa o impresión.
        /// </summary>
        public (string HtmlFilePath, string PdfFilePath, string HtmlContent) GenerateSaleTicketPdf(
            SaleTicketData data,
            string? customTemplatePath = null)
        {
            string htmlContent = BuildTicketHtml(data, customTemplatePath);

            string outputDirectory = Path.Combine(Path.GetTempPath(), "MobileSolutions_Tickets");
            Directory.CreateDirectory(outputDirectory);

            string safeSaleNumber = SanitizeFileName(data.SaleNumber);
            string htmlFilePath = Path.Combine(outputDirectory, $"Ticket_{safeSaleNumber}.html");
            string pdfFilePath = Path.Combine(outputDirectory, $"Ticket_{safeSaleNumber}.pdf");

            File.WriteAllText(htmlFilePath, htmlContent, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

            if (File.Exists(pdfFilePath))
            {
                try
                {
                    File.Delete(pdfFilePath);
                }
                catch
                {
                    // Si está abierto en otro visor, usar nombre con marca de tiempo
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    pdfFilePath = Path.Combine(outputDirectory, $"Ticket_{safeSaleNumber}_{timestamp}.pdf");
                }
            }

            bool convertedByEdge = TryConvertHtmlToPdfWithEdge(htmlFilePath, pdfFilePath);
            if (!convertedByEdge || !File.Exists(pdfFilePath) || new FileInfo(pdfFilePath).Length == 0)
            {
                GenerateFallbackPdfDocument(data, pdfFilePath);
            }

            return (htmlFilePath, pdfFilePath, htmlContent);
        }

        private static void ValidateTicketData(SaleTicketData? data)
        {
            if (data == null ||
                string.IsNullOrWhiteSpace(data.SaleNumber) ||
                data.Items == null ||
                data.Items.Count == 0)
            {
                throw new InvalidOperationException(
                    "Debe registrar o seleccionar una venta válida con al menos un producto antes de imprimir el ticket.");
            }
        }

        private static string SanitizeFileName(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "SIN_NUMERO";
            }

            char[] invalidChars = Path.GetInvalidFileNameChars();
            var sb = new StringBuilder(input.Length);
            foreach (char c in input.Trim())
            {
                sb.Append(invalidChars.Contains(c) ? '_' : c);
            }

            return sb.ToString();
        }

        private static bool TryConvertHtmlToPdfWithEdge(string htmlFilePath, string pdfFilePath)
        {
            try
            {
                string? edgeExecutable = FindEdgeExecutable();
                if (string.IsNullOrWhiteSpace(edgeExecutable))
                {
                    return false;
                }

                string htmlUri = new Uri(htmlFilePath).AbsoluteUri;
                var startInfo = new ProcessStartInfo
                {
                    FileName = edgeExecutable,
                    Arguments = $"--headless --disable-gpu --no-pdf-header-footer --print-to-pdf=\"{pdfFilePath}\" \"{htmlUri}\"",
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                };

                using var process = Process.Start(startInfo);
                if (process == null)
                {
                    return false;
                }

                if (!process.WaitForExit(8000))
                {
                    try { process.Kill(entireProcessTree: true); } catch { }
                    return false;
                }

                return File.Exists(pdfFilePath) && new FileInfo(pdfFilePath).Length > 0;
            }
            catch
            {
                return false;
            }
        }

        private static string? FindEdgeExecutable()
        {
            string[] candidates =
            {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft", "Edge", "Application", "msedge.exe"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Microsoft", "Edge", "Application", "msedge.exe"),
                @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
                @"C:\Program Files\Microsoft\Edge\Application\msedge.exe"
            };

            foreach (string candidate in candidates)
            {
                if (!string.IsNullOrWhiteSpace(candidate) && File.Exists(candidate))
                {
                    return candidate;
                }
            }

            return null;
        }

        /// <summary>
        /// Genera un archivo PDF 1.4 nativo con todos los datos del comprobante cuando Edge Headless no está disponible.
        /// Soporta caracteres acentuados y eñes mediante codificación WinAnsi (ISO-8859-1 / Windows-1252).
        /// </summary>
        private static void GenerateFallbackPdfDocument(SaleTicketData data, string pdfFilePath)
        {
            decimal calculatedTotal = data.Total > 0 ? data.Total : data.Items.Sum(i => i.Subtotal);
            string formattedDate = data.SaleDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            string formattedTotal = FormatCurrency(calculatedTotal);
            string vatCondition = string.IsNullOrWhiteSpace(data.CustomerVatCondition) ? "Consumidor Final" : data.CustomerVatCondition.Trim();

            var contentStreamBuilder = new StringBuilder();
            contentStreamBuilder.AppendLine("BT");

            int y = 780;
            AppendPdfTextLine(contentStreamBuilder, "F2", 18, 50, y, "MOBILE SOLUTIONS - PUNTO DE VENTA");
            y -= 20;
            AppendPdfTextLine(contentStreamBuilder, "F2", 12, 50, y, $"COMPROBANTE DE VENTA: {data.SaleNumber}");
            y -= 16;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, $"Fecha de emisión: {formattedDate}");
            y -= 24;

            AppendPdfTextLine(contentStreamBuilder, "F2", 11, 50, y, "DATOS DEL VENDEDOR Y TRANSACCIÓN");
            y -= 16;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, $"N° Venta: {data.SaleNumber}    |    Fecha: {formattedDate}");
            y -= 14;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, $"Vendedor: {data.SellerName}    |    Usuario: {data.SellerUsername}    |    DNI: {data.SellerDni}");
            y -= 24;

            AppendPdfTextLine(contentStreamBuilder, "F2", 11, 50, y, "DATOS DEL CLIENTE");
            y -= 16;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, $"Cliente: {data.CustomerName}");
            y -= 14;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, $"DNI / CUIT: {data.CustomerDni}    |    Condición IVA: {vatCondition}");
            y -= 24;

            AppendPdfTextLine(contentStreamBuilder, "F2", 11, 50, y, "DETALLE DE LA COMPRA");
            y -= 16;
            AppendPdfTextLine(contentStreamBuilder, "F2", 10, 50, y, "Producto / Concepto                          Cant.      Unitario          Subtotal");
            y -= 12;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, "----------------------------------------------------------------------------------------");
            y -= 14;

            foreach (var item in data.Items)
            {
                string rawProductName = !string.IsNullOrWhiteSpace(item.ProductName)
                    ? item.ProductName.Trim()
                    : (!string.IsNullOrWhiteSpace(item.BrandName) ? item.BrandName.Trim() : item.ProductCode.Trim());

                string unitPriceStr = FormatCurrency(item.UnitPrice);
                string subtotalStr = FormatCurrency(item.Subtotal);
                string line = $"{ rawProductName,-38}   {item.Quantity,5}   {unitPriceStr,14}   {subtotalStr,15}";
                AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, line);
                y -= 14;
                if (y < 100)
                {
                    break;
                }
            }

            y -= 10;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, "----------------------------------------------------------------------------------------");
            y -= 20;
            AppendPdfTextLine(contentStreamBuilder, "F2", 11, 50, y, $"Método de Pago: {data.PaymentMethod}");
            y -= 18;
            AppendPdfTextLine(contentStreamBuilder, "F2", 14, 50, y, $"MONTO TOTAL ABONADO: {formattedTotal}");
            y -= 28;
            AppendPdfTextLine(contentStreamBuilder, "F1", 10, 50, y, "¡Muchas gracias por su compra! Comprobante digital no fiscal generado con Mobile Solutions POS.");

            contentStreamBuilder.AppendLine("ET");

            byte[] contentBytes = EncodeWinAnsi(contentStreamBuilder.ToString());

            using var fs = new FileStream(pdfFilePath, FileMode.Create, FileAccess.Write, FileShare.Read);
            using var bw = new BinaryWriter(fs, Encoding.ASCII);

            void WriteAscii(string text) => bw.Write(Encoding.ASCII.GetBytes(text));

            var offsets = new List<long>();
            WriteAscii("%PDF-1.4\n");

            // Obj 1: Catalog
            offsets.Add(fs.Position);
            WriteAscii("1 0 obj\n<< /Type /Catalog /Pages 2 0 R >>\nendobj\n");

            // Obj 2: Pages
            offsets.Add(fs.Position);
            WriteAscii("2 0 obj\n<< /Type /Pages /Kids [3 0 R] /Count 1 >>\nendobj\n");

            // Obj 3: Page
            offsets.Add(fs.Position);
            WriteAscii("3 0 obj\n<< /Type /Page /Parent 2 0 R /MediaBox [0 0 595 842] /Resources << /Font << /F1 4 0 R /F2 5 0 R >> >> /Contents 6 0 R >>\nendobj\n");

            // Obj 4: Font Regular
            offsets.Add(fs.Position);
            WriteAscii("4 0 obj\n<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica /Encoding /WinAnsiEncoding >>\nendobj\n");

            // Obj 5: Font Bold
            offsets.Add(fs.Position);
            WriteAscii("5 0 obj\n<< /Type /Font /Subtype /Type1 /BaseFont /Helvetica-Bold /Encoding /WinAnsiEncoding >>\nendobj\n");

            // Obj 6: Content Stream
            offsets.Add(fs.Position);
            WriteAscii($"6 0 obj\n<< /Length {contentBytes.Length} >>\nstream\n");
            bw.Write(contentBytes);
            WriteAscii("\nendstream\nendobj\n");

            long xrefPosition = fs.Position;
            WriteAscii($"xref\n0 {offsets.Count + 1}\n");
            WriteAscii("0000000000 65535 f \n");
            foreach (long offset in offsets)
            {
                WriteAscii($"{offset:D10} 00000 n \n");
            }

            WriteAscii($"trailer\n<< /Size {offsets.Count + 1} /Root 1 0 R >>\nstartxref\n{xrefPosition}\n%%EOF\n");
        }

        private static void AppendPdfTextLine(StringBuilder sb, string fontKey, int fontSize, int x, int y, string text)
        {
            string escaped = (text ?? string.Empty)
                .Replace("\\", "\\\\")
                .Replace("(", "\\(")
                .Replace(")", "\\)");

            sb.AppendLine($"/{fontKey} {fontSize} Tf");
            sb.AppendLine($"1 0 0 1 {x} {y} Tm");
            sb.AppendLine($"({escaped}) Tj");
        }

        private static byte[] EncodeWinAnsi(string text)
        {
            Encoding latin1 = Encoding.GetEncoding("ISO-8859-1");
            return latin1.GetBytes(text);
        }

        /// <summary>
        /// Registra errores técnicos internamente sin interrumpir el flujo de la aplicación.
        /// </summary>
        public void LogError(Exception ex)
        {
            try
            {
                string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR en generación de Ticket: {ex.GetType().FullName} - {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
                Debug.WriteLine(logMessage);

                string logDir = Path.Combine(Path.GetTempPath(), "MobileSolutions_Tickets");
                Directory.CreateDirectory(logDir);
                string logFilePath = Path.Combine(logDir, "ticket_errors.log");
                File.AppendAllText(logFilePath, logMessage, Encoding.UTF8);
            }
            catch
            {
                // No propagar errores de logging
            }
        }
    }
}
