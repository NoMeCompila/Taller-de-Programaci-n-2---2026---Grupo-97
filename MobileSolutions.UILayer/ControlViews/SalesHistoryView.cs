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

                dgvSales.Rows[rowIndex].Tag = sale.SaleId;
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
            if (selectedRow.Tag is int saleId && saleId > 0)
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
                string saleNumber = dgvSales.Rows[e.RowIndex].Cells["colNumeroVenta"].Value?.ToString() ?? string.Empty;
                MessageBox.Show(
                    $"Comprobante de Venta: {saleNumber}\n\nLa descarga e impresión del comprobante en PDF estará disponible en el módulo de facturación y reportes.",
                    "Comprobante de Venta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
