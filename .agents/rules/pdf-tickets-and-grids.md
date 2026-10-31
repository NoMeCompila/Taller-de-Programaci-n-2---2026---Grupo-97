# Reglas de Generación de Tickets PDF e Íconos en DataGridView

1. **Flujo Único de Impresión de Tickets (`TicketReportService`)**:
   - Siempre utilizar `TicketReportService.GenerateSaleTicketPdf(SaleTicketData)` junto con la plantilla `ticketSample.html`.
   - El comportamiento estándar al imprimir o descargar un ticket es generar el PDF en segundo plano y abrirlo inmediatamente en el visor predeterminado del sistema mediante `Process.Start(new ProcessStartInfo { FileName = pdfFilePath, UseShellExecute = true })`, manteniendo un fallback a `PrintPreviewDialog` en caso de error al abrir el visor externo.

2. **Datos del Vendedor en Reimpresiones Históricas (Multi-Rol)**:
   - Al generar un ticket desde vistas de consulta o historial (donde puede operar tanto un `Gerente` como un `Vendedor`), los datos del vendedor (`SellerName`, `SellerUsername`, `SellerDni`) deben obtenerse de la venta registrada (`SaleHeader` / consulta a `UserService` por el `UserId` de la venta) y **nunca** de `CurrentSession`.

3. **Íconos de `FontAwesome.Sharp` en `DataGridViewImageColumn`**:
   - Para acciones de impresión/descarga de tickets PDF en grillas, usar `IconChar.FilePdf.ToBitmap(...)`.
   - Configurar siempre `ImageLayout = DataGridViewImageCellLayout.Normal` en la columna (`DataGridViewImageColumn`) para conservar la proporción y nitidez del ícono sin estiramiento (`Zoom`).
