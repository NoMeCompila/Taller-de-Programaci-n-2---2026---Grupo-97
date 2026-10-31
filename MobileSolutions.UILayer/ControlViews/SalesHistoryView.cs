using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class SalesHistoryView : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        private readonly SaleService _saleService;
        private readonly UserService _userService;
        private readonly TicketReportService _ticketReportService;
        private readonly Bitmap _pdfIcon;
        private bool _isInitializingFilters = false;

        private class SellerComboItem
        {
            public int? UserId { get; set; }
            public string DisplayText { get; set; } = string.Empty;

            public override string ToString() => DisplayText;
        }

        public SalesHistoryView()
        {
            InitializeComponent();
            _saleService = new SaleService();
            _userService = new UserService();
            _ticketReportService = new TicketReportService();
            _pdfIcon = IconChar.FilePdf.ToBitmap(Color.White, 20);

            ConfigureIcons();
            WireEvents();

            Load += SalesHistoryView_Load;
        }

        private void ConfigureIcons()
        {
            btnSearch.Icon = IconChar.Search.ToBitmap(Color.White);
            btnClear.Icon = IconChar.Eraser.ToBitmap(Color.White);
            picHistoryTitle.IconChar = IconChar.History;
            picHistoryTitle.IconColor = Color.White;
            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
        }

        private void WireEvents()
        {
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
            btnSearch.Click += BtnSearch_Click;
            btnClear.Click += BtnClear_Click;
            txtFilterSaleNumber.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; ExecuteSearch(); } };
            txtFilterClient.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; ExecuteSearch(); } };

            dgvSales.SelectionChanged += DgvSales_SelectionChanged;
            dgvSales.CellContentClick += DgvSales_CellContentClick;
            dgvSales.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvSales.Columns[e.ColumnIndex].Name == "colAcciones")
                {
                    dgvSales.Cursor = Cursors.Hand;
                }
            };
            dgvSales.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvSales.Columns[e.ColumnIndex].Name == "colAcciones")
                {
                    dgvSales.Cursor = Cursors.Default;
                }
            };
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible)
            {
                InitializeViewControls();
                ExecuteSearch();
            }
        }

        private void SalesHistoryView_Load(object? sender, EventArgs e)
        {
            splitContainer.SplitterDistance = Math.Max(120, (int)(splitContainer.Height * 0.6));
            InitializeViewControls();
            ExecuteSearch();
        }

        private void InitializeViewControls()
        {
            _isInitializingFilters = true;
            try
            {
                DateTime today = DateTime.Today;
                dtpDateFrom.Value = new DateTime(today.Year, today.Month, 1);
                dtpDateTo.Value = today;

                txtFilterSaleNumber.Text = string.Empty;
                txtFilterClient.Text = string.Empty;

                ConfigureSellerFilterByRole();
            }
            finally
            {
                _isInitializingFilters = false;
            }
        }

        private void ConfigureSellerFilterByRole()
        {
            cboFilterSeller.Items.Clear();

            bool isSeller = CurrentSession.IsAuthenticated &&
                            CurrentSession.ProfileName.Equals("Vendedor", StringComparison.OrdinalIgnoreCase);

            if (isSeller)
            {
                var personalItem = new SellerComboItem
                {
                    UserId = CurrentSession.UserId,
                    DisplayText = !string.IsNullOrWhiteSpace(CurrentSession.Username)
                        ? CurrentSession.Username
                        : $"{CurrentSession.Name} {CurrentSession.Lastname}".Trim()
                };

                cboFilterSeller.Items.Add(personalItem);
                cboFilterSeller.SelectedIndex = 0;
                cboFilterSeller.Enabled = false;
            }
            else
            {
                cboFilterSeller.Enabled = true;
                cboFilterSeller.Items.Add(new SellerComboItem { UserId = null, DisplayText = "Todos" });

                try
                {
                    List<User> users = _userService.GetActiveUsers();
                    foreach (var user in users.OrderBy(u => u.Username))
                    {
                        cboFilterSeller.Items.Add(new SellerComboItem
                        {
                            UserId = user.UserId,
                            DisplayText = user.Username
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al cargar la lista de vendedores: {ex.Message}",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                cboFilterSeller.SelectedIndex = 0;
            }

            cboFilterSeller.Invalidate();
            cboFilterSeller.Refresh();
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            InitializeViewControls();
            ExecuteSearch();
        }

        private void ExecuteSearch()
        {
            if (_isInitializingFilters) return;

            DateTime startDate = dtpDateFrom.Value.Date;
            DateTime endDate = dtpDateTo.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show(
                    "La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.",
                    "Rango de Fechas Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string saleNumber = txtFilterSaleNumber.Text.Trim();
            string clientName = txtFilterClient.Text.Trim();

            int? selectedSellerId = null;
            if (cboFilterSeller.SelectedItem is SellerComboItem selectedItem)
            {
                selectedSellerId = selectedItem.UserId;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                List<SaleHeader> sales = _saleService.GetSalesHistory(
                    startDate,
                    endDate,
                    saleNumber,
                    clientName,
                    selectedSellerId);

                PopulateSalesGrid(sales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al consultar el historial de ventas: {ex.Message}",
                    "Error de Consulta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void PopulateSalesGrid(List<SaleHeader> sales)
        {
            dgvSales.Rows.Clear();
            dgvSaleDetails.Rows.Clear();

            foreach (var sale in sales)
            {
                int rowIndex = dgvSales.Rows.Add(
                    sale.SaleNumber,
                    sale.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                    $"{sale.CustomerName} {sale.CustomerLastname}".Trim(),
                    sale.UserUsername,
                    sale.PaymentTypeName,
                    $"${sale.TotalSale:N2}",
                    _pdfIcon
                );

                dgvSales.Rows[rowIndex].Tag = sale;
            }

            if (dgvSales.Rows.Count > 0)
            {
                dgvSales.ClearSelection();
                dgvSales.Rows[0].Selected = true;
                LoadSelectedSaleDetails();
            }
        }

        private void DgvSales_SelectionChanged(object? sender, EventArgs e)
        {
            LoadSelectedSaleDetails();
        }

        private void LoadSelectedSaleDetails()
        {
            if (dgvSales.SelectedRows.Count == 0)
            {
                dgvSaleDetails.Rows.Clear();
                return;
            }

            var selectedRow = dgvSales.SelectedRows[0];
            int saleId = 0;
            if (selectedRow.Tag is SaleHeader sale)
            {
                saleId = sale.SaleId;
            }
            else if (selectedRow.Tag is int id)
            {
                saleId = id;
            }

            if (saleId > 0)
            {
                try
                {
                    List<SaleDetail> details = _saleService.GetSaleDetailsBySaleId(saleId);
                    dgvSaleDetails.Rows.Clear();

                    foreach (var item in details)
                    {
                        dgvSaleDetails.Rows.Add(
                            item.ProductCode,
                            item.ProductName,
                            item.Quantity,
                            $"${item.UnitPrice:N2}",
                            $"${item.Subtotal:N2}"
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error al cargar los detalles de la venta: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvSaleDetails.Rows.Clear();
            }
        }

        private void DgvSales_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvSales.Columns[e.ColumnIndex].Name == "colAcciones")
            {
                var selectedRow = dgvSales.Rows[e.RowIndex];
                SaleHeader? sale = selectedRow.Tag as SaleHeader;

                if (sale == null)
                {
                    string saleNumberStr = selectedRow.Cells["colNumeroVenta"].Value?.ToString() ?? string.Empty;
                    MessageBox.Show(
                        $"No se pudieron obtener los datos de la venta {saleNumberStr}.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                ImprimirTicketVenta(sale);
            }
        }

        private void ImprimirTicketVenta(SaleHeader sale)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                List<SaleDetail> details = _saleService.GetSaleDetailsBySaleId(sale.SaleId);
                if (details == null || details.Count == 0)
                {
                    MessageBox.Show(
                        "La venta seleccionada no contiene productos en el detalle.",
                        "Venta Sin Detalle",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string sellerName = sale.SellerFullName;
                string sellerUsername = sale.UserUsername;
                string sellerDni = sale.SellerDni;

                if (string.IsNullOrWhiteSpace(sellerDni) || string.IsNullOrWhiteSpace(sellerName))
                {
                    var user = _userService.GetUserByIdOrUsername(sale.UserId, sale.UserUsername);
                    if (user != null)
                    {
                        if (string.IsNullOrWhiteSpace(sellerDni)) sellerDni = user.Dni;
                        if (string.IsNullOrWhiteSpace(sellerName)) sellerName = $"{user.Name} {user.Lastname}".Trim();
                        if (string.IsNullOrWhiteSpace(sellerUsername)) sellerUsername = user.Username;
                    }
                }

                if (string.IsNullOrWhiteSpace(sellerDni))
                {
                    sellerDni = CurrentSession.Dni;
                }

                var ticketData = new SaleTicketData
                {
                    SaleNumber = sale.SaleNumber,
                    SaleDate = sale.SaleDate != DateTime.MinValue ? sale.SaleDate : DateTime.Now,
                    SellerName = !string.IsNullOrWhiteSpace(sellerName) ? sellerName : (!string.IsNullOrWhiteSpace(sellerUsername) ? sellerUsername : "-"),
                    SellerUsername = !string.IsNullOrWhiteSpace(sellerUsername) ? sellerUsername : "-",
                    SellerDni = !string.IsNullOrWhiteSpace(sellerDni) ? sellerDni : "-",
                    CustomerName = sale.CustomerFullName,
                    CustomerDni = sale.CustomerDni,
                    CustomerVatCondition = "Consumidor Final",
                    PaymentMethod = !string.IsNullOrWhiteSpace(sale.PaymentTypeName) ? sale.PaymentTypeName : "Efectivo",
                    Total = sale.TotalSale > 0 ? sale.TotalSale : details.Sum(d => d.Subtotal),
                    Items = details
                };

                var result = _ticketReportService.GenerateSaleTicketPdf(ticketData);
                AbrirVistaPreviaOImpresionPdf(result.PdfFilePath, ticketData);
            }
            catch (System.IO.FileNotFoundException fnfEx)
            {
                _ticketReportService.LogError(fnfEx);
                MessageBox.Show(
                    "No se encontró la plantilla de ticket 'ticketSample.html' en la ruta base del sistema.",
                    "Plantilla No Encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _ticketReportService.LogError(ex);
                MessageBox.Show(
                    $"Ocurrió un error al generar o abrir el ticket PDF: {ex.Message}",
                    "Error de Impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void AbrirVistaPreviaOImpresionPdf(string pdfFilePath, SaleTicketData ticketData)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = pdfFilePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                _ticketReportService.LogError(ex);
                MostrarDialogoVistaPreviaImpresion(ticketData);
            }
        }

        private void MostrarDialogoVistaPreviaImpresion(SaleTicketData ticketData)
        {
            using var printDocument = new System.Drawing.Printing.PrintDocument();
            printDocument.DocumentName = $"Ticket_{ticketData.SaleNumber}";
            printDocument.PrintPage += (s, ev) =>
            {
                if (ev.Graphics == null) return;

                using var titleFont = new Font("Segoe UI", 14F, FontStyle.Bold);
                using var sectionFont = new Font("Segoe UI", 10F, FontStyle.Bold);
                using var regularFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);

                float x = 40f;
                float y = 40f;

                ev.Graphics.DrawString("MOBILE SOLUTIONS - PUNTO DE VENTA", titleFont, Brushes.Black, x, y);
                y += 28f;
                ev.Graphics.DrawString($"Comprobante de Venta: {ticketData.SaleNumber}", sectionFont, Brushes.Black, x, y);
                y += 20f;
                ev.Graphics.DrawString($"Fecha de emisión: {ticketData.SaleDate:dd/MM/yyyy}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DATOS DEL VENDEDOR Y TRANSACCIÓN", sectionFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"N° Venta: {ticketData.SaleNumber}  |  Fecha: {ticketData.SaleDate:dd/MM/yyyy}", regularFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"Vendedor: {ticketData.SellerName} ({ticketData.SellerUsername}) - DNI: {ticketData.SellerDni}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DATOS DEL CLIENTE", sectionFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"Cliente: {ticketData.CustomerName}", regularFont, Brushes.Black, x, y);
                y += 18f;
                ev.Graphics.DrawString($"DNI / CUIT: {ticketData.CustomerDni}  |  Condición IVA: {ticketData.CustomerVatCondition}", regularFont, Brushes.Black, x, y);
                y += 26f;

                ev.Graphics.DrawString("DETALLE DE LA COMPRA", sectionFont, Brushes.Black, x, y);
                y += 20f;

                foreach (var item in ticketData.Items)
                {
                    string prod = !string.IsNullOrWhiteSpace(item.ProductName) ? item.ProductName : item.BrandName;
                    string line = $"{prod}  |  Cant: {item.Quantity}  |  Unit: {TicketReportService.FormatCurrency(item.UnitPrice)}  |  Subtotal: {TicketReportService.FormatCurrency(item.Subtotal)}";
                    ev.Graphics.DrawString(line, regularFont, Brushes.Black, x, y);
                    y += 18f;
                }

                y += 14f;
                ev.Graphics.DrawString($"Método de Pago: {ticketData.PaymentMethod}", sectionFont, Brushes.Black, x, y);
                y += 22f;
                ev.Graphics.DrawString($"MONTO TOTAL ABONADO: {TicketReportService.FormatCurrency(ticketData.Total)}", titleFont, Brushes.Black, x, y);
                ev.HasMorePages = false;
            };

            using var previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent
            };

            previewDialog.ShowDialog(this);
        }
    }
}