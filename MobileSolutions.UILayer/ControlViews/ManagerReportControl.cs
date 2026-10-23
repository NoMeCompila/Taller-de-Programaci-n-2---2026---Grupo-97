using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin.Controls;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using PieChart = LiveCharts.WinForms.PieChart;
using WpfBrushes = System.Windows.Media.Brushes;
using WpfColor = System.Windows.Media.Color;
using WpfFontFamily = System.Windows.Media.FontFamily;

using MobileSolutions.BusinessLayer;
using MobileSolutions.BusinessLayer.Models;
using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class ManagerReportControl : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        private readonly ManagerReportService _managerReportService;

        private static readonly Color MainBackground = Color.FromArgb(50, 50, 50);
        private static readonly Color CardBackground = Color.FromArgb(60, 60, 60);
        private static readonly Color ComboBackground = Color.FromArgb(45, 45, 45);
        private static readonly Color PositiveSubtitleColor = Color.FromArgb(102, 187, 106);
        private static readonly Color NegativeSubtitleColor = Color.FromArgb(239, 83, 80);
        private static readonly Color NeutralSubtitleColor = Color.FromArgb(180, 180, 180);

        private CartesianChart? _chartEvolucion;
        private CartesianChart? _chartTopProductos;
        private PieChart? _chartSellerDistribution;

        public ManagerReportControl()
        {
            InitializeComponent();
            _managerReportService = new ManagerReportService();

            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);

            btnFilter.Click += (s, e) => RefreshReportData();
            btnClearFilter.Click += BtnClearFilter_Click;

            InitializeDatePickers();
            ConfigureLayout();
        }

        private void InitializeDatePickers()
        {
            DateTime now = DateTime.Now;
            dtpDateFrom.Value = new DateTime(now.Year, now.Month, 1);
            dtpDateTo.Value = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));
        }

        private void BtnClearFilter_Click(object? sender, EventArgs e)
        {
            InitializeDatePickers();
            RefreshReportData();
        }

        private void ConfigureLayout()
        {
            BackColor = MainBackground;
            RefreshReportData();
        }

        public void RefreshReportData()
        {
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

            ManagerReport report;

            try
            {
                Cursor = Cursors.WaitCursor;
                report = _managerReportService.GetManagerPerformanceReport(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar las métricas gerenciales: {ex.Message}",
                    "Error al cargar reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                report = new ManagerReport();
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            RenderKpiCards(report);
            RenderCharts(report);
        }

        #region KPIs (6 Tarjetas Estándar)

        private void RenderKpiCards(ManagerReport report)
        {
            tlpKpis.SuspendLayout();
            tlpKpis.Controls.Clear();

            var kpi = report.KpiSummary ?? new ManagerKpiSummary();

            // 1. Recaudación del período
            var (revenueSubtitle, revenueSubtitleColor) = FormatMonthComparisonSubtitle(
                kpi.TotalRevenue,
                kpi.PreviousMonthRevenue);

            string paymentBreakdownSubtitle =
                $"Efec: {FormatCurrency(kpi.CashTotal)} | Transf: {FormatCurrency(kpi.TransferTotal)}";

            // 2. Recaudación del Año
            string yearSubtitle = $"Ventas activas en período: {kpi.TotalSalesCount}";

            // 3. Tasa de Cancelación / Devolución
            string cancellationSubtitle = kpi.TotalInitiatedSales > 0
                ? $"{kpi.CancelledSalesCount} canceladas de {kpi.TotalInitiatedSales} totales"
                : "Sin ventas iniciadas";

            Color cancellationColor = kpi.CancellationRate > 10m
                ? NegativeSubtitleColor
                : (kpi.CancellationRate > 0m ? Color.FromArgb(255, 183, 77) : PositiveSubtitleColor);

            // 4. Ranking Vendedores (Extremos con ComboBox)
            bool hasTopSellers = report.TopSellersByCount != null && report.TopSellersByCount.Count > 0;
            var topSellerItems = hasTopSellers
                ? report.TopSellersByCount!.Select(s => $"{s.DisplayText} ({s.SalesCount} v.)").ToList()
                : new List<string> { "Sin ventas" };
            string topSellerHeader = hasTopSellers
                ? $"▲ Más ({report.TopSellersByCount!.Count}) — {report.TopSellersByCount[0].SalesCount} v.:"
                : "▲ Más (0):";

            bool hasBottomSellers = report.BottomSellersByCount != null && report.BottomSellersByCount.Count > 0;
            var bottomSellerItems = hasBottomSellers
                ? report.BottomSellersByCount!.Select(s => $"{s.DisplayText} ({s.SalesCount} v.)").ToList()
                : new List<string> { "Sin vendedores activos" };
            string bottomSellerHeader = hasBottomSellers
                ? $"▼ Menos ({report.BottomSellersByCount!.Count}) — {report.BottomSellersByCount[0].SalesCount} v.:"
                : "▼ Menos (0):";

            // 5. Ranking Celulares (Extremos con ComboBox)
            bool hasMostSoldProducts = report.MostSoldProducts != null && report.MostSoldProducts.Count > 0;
            var mostSoldProductItems = hasMostSoldProducts
                ? report.MostSoldProducts!.Select(p => p.DisplayText).ToList()
                : new List<string> { "Sin ventas" };
            string mostSoldProductHeader = hasMostSoldProducts
                ? $"▲ Más ({report.MostSoldProducts!.Count}) — {report.MostSoldProducts[0].UnitsSold} u.:"
                : "▲ Más (0):";

            bool hasLeastSoldProducts = report.LeastSoldProducts != null && report.LeastSoldProducts.Count > 0;
            var leastSoldProductItems = hasLeastSoldProducts
                ? report.LeastSoldProducts!.Select(p => p.DisplayText).ToList()
                : new List<string> { "Sin celulares activos" };
            string leastSoldProductHeader = hasLeastSoldProducts
                ? $"▼ Menos ({report.LeastSoldProducts!.Count}) — {report.LeastSoldProducts[0].UnitsSold} u.:"
                : "▼ Menos (0):";

            // 6. Ranking Marcas (Extremos con ComboBox)
            bool hasMostSoldBrands = report.MostSoldBrands != null && report.MostSoldBrands.Count > 0;
            var mostSoldBrandItems = hasMostSoldBrands
                ? report.MostSoldBrands!.Select(b => b.DisplayText).ToList()
                : new List<string> { "Sin ventas" };
            string mostSoldBrandHeader = hasMostSoldBrands
                ? $"▲ Más ({report.MostSoldBrands!.Count}) — {report.MostSoldBrands[0].UnitsSold} u.:"
                : "▲ Más (0):";

            bool hasLeastSoldBrands = report.LeastSoldBrands != null && report.LeastSoldBrands.Count > 0;
            var leastSoldBrandItems = hasLeastSoldBrands
                ? report.LeastSoldBrands!.Select(b => b.DisplayText).ToList()
                : new List<string> { "Sin marcas activas" };
            string leastSoldBrandHeader = hasLeastSoldBrands
                ? $"▼ Menos ({report.LeastSoldBrands!.Count}) — {report.LeastSoldBrands[0].UnitsSold} u.:"
                : "▼ Menos (0):";

            // Columna 0: Recaudado Período
            tlpKpis.Controls.Add(
                CreateKpiCard(
                    IconChar.Wallet,
                    "Total Recaudado",
                    FormatCurrency(kpi.TotalRevenue),
                    revenueSubtitle,
                    revenueSubtitleColor),
                0, 0);

            // Columna 1: Recaudado Año
            tlpKpis.Controls.Add(
                CreateKpiCard(
                    IconChar.CalendarAlt,
                    "Total Anual",
                    FormatCurrency(kpi.YearRevenue),
                    yearSubtitle,
                    NeutralSubtitleColor),
                1, 0);

            // Columna 2: Tasa de Cancelaciones
            tlpKpis.Controls.Add(
                CreateKpiCard(
                    IconChar.Ban,
                    "Tasa Cancelaciones",
                    $"{kpi.CancellationRate:0.##}%",
                    cancellationSubtitle,
                    cancellationColor),
                2, 0);

            // Columna 3: Ranking Vendedores
            tlpKpis.Controls.Add(
                CreateExtremesKpiCard(
                    IconChar.UserGroup,
                    "Ranking Vendedores",
                    topSellerHeader,
                    topSellerItems,
                    bottomSellerHeader,
                    bottomSellerItems),
                3, 0);

            // Columna 4: Ranking Celulares
            tlpKpis.Controls.Add(
                CreateExtremesKpiCard(
                    IconChar.MobileScreenButton,
                    "Ranking Celulares",
                    mostSoldProductHeader,
                    mostSoldProductItems,
                    leastSoldProductHeader,
                    leastSoldProductItems),
                4, 0);

            // Columna 5: Ranking Marcas
            tlpKpis.Controls.Add(
                CreateExtremesKpiCard(
                    IconChar.Tags,
                    "Ranking Marcas",
                    mostSoldBrandHeader,
                    mostSoldBrandItems,
                    leastSoldBrandHeader,
                    leastSoldBrandItems),
                5, 0);

            tlpKpis.ResumeLayout();
        }

        private static string FormatCurrency(decimal amount)
        {
            return string.Format(CultureInfo.InvariantCulture, "${0:N2}", amount);
        }

        private static (string Text, Color Color) FormatMonthComparisonSubtitle(decimal currentRevenue, decimal previousRevenue)
        {
            if (previousRevenue <= 0m)
            {
                if (currentRevenue > 0m)
                {
                    return ("+100% vs. mes anterior", PositiveSubtitleColor);
                }

                return ("0% vs. mes anterior", NeutralSubtitleColor);
            }

            decimal variation = ((currentRevenue - previousRevenue) / previousRevenue) * 100m;
            string sign = variation >= 0m ? "+" : string.Empty;
            Color color = variation > 0m
                ? PositiveSubtitleColor
                : variation < 0m
                    ? NegativeSubtitleColor
                    : NeutralSubtitleColor;

            return ($"{sign}{variation:0.#}% vs. mes anterior", color);
        }

        private Panel CreateKpiCard(
            IconChar icon,
            string title,
            string value,
            string? subtitle = null,
            Color? subtitleColor = null)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
                Margin = new Padding(6),
                Padding = new Padding(10, 8, 10, 8)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var picIcon = new IconPictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                IconChar = icon,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 30
            };

            var lblTitle = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = title,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(190, 190, 190),
                Font = new Font("Roboto", 11F, FontStyle.Regular)
            };

            var lblValue = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = value,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Roboto", 16F, FontStyle.Bold)
            };

            var lblSubtitle = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = subtitle ?? string.Empty,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = subtitleColor ?? PositiveSubtitleColor,
                BackColor = Color.Transparent,
                Font = new Font("Roboto", 8.5F, FontStyle.Regular)
            };

            layout.Controls.Add(picIcon, 0, 0);
            layout.Controls.Add(lblTitle, 0, 1);
            layout.Controls.Add(lblValue, 0, 2);
            layout.Controls.Add(lblSubtitle, 0, 3);

            card.Controls.Add(layout);
            return card;
        }

        private Panel CreateExtremesKpiCard(
            IconChar icon,
            string title,
            string mostSoldHeader,
            IReadOnlyList<string> mostSoldItems,
            string leastSoldHeader,
            IReadOnlyList<string> leastSoldItems)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
                Margin = new Padding(6),
                Padding = new Padding(8, 6, 8, 6)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var headerPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var picIcon = new IconPictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                IconChar = icon,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 22
            };

            var lblTitle = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = title,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Roboto", 10F, FontStyle.Bold)
            };

            headerPanel.Controls.Add(picIcon, 0, 0);
            headerPanel.Controls.Add(lblTitle, 1, 0);

            var mostRow = CreateExtremeComboRow(
                mostSoldHeader,
                PositiveSubtitleColor,
                mostSoldItems);

            var leastRow = CreateExtremeComboRow(
                leastSoldHeader,
                NegativeSubtitleColor,
                leastSoldItems);

            layout.Controls.Add(headerPanel, 0, 0);
            layout.Controls.Add(mostRow, 0, 1);
            layout.Controls.Add(leastRow, 0, 2);

            card.Controls.Add(layout);
            return card;
        }

        private static Panel CreateExtremeComboRow(
            string labelText,
            Color labelColor,
            IReadOnlyList<string> items)
        {
            var container = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 2, 0, 2)
            };

            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            container.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var lbl = new Label
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = labelText,
                TextAlign = ContentAlignment.BottomLeft,
                ForeColor = labelColor,
                BackColor = Color.Transparent,
                Font = new Font("Roboto", 8F, FontStyle.Bold)
            };

            var comboFont = new Font("Roboto", 8.5F, FontStyle.Regular);
            int maxItemWidth = 220;

            foreach (var item in items)
            {
                int textWidth = TextRenderer.MeasureText(item, comboFont).Width + 32;
                if (textWidth > maxItemWidth)
                {
                    maxItemWidth = textWidth;
                }
            }

            var cbo = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                BackColor = ComboBackground,
                ForeColor = Color.White,
                Font = comboFont,
                IntegralHeight = false,
                MaxDropDownItems = 8,
                DropDownWidth = maxItemWidth
            };

            foreach (var item in items)
            {
                cbo.Items.Add(item);
            }

            if (cbo.Items.Count > 0)
            {
                cbo.SelectedIndex = 0;
            }

            container.Controls.Add(lbl, 0, 0);
            container.Controls.Add(cbo, 0, 1);
            return container;
        }

        #endregion

        #region Gráficos LiveCharts (Evolución de Recaudación y Distribución por Vendedor)

        private void RenderCharts(ManagerReport report)
        {
            // 1. Gráfico de Evolución
            if (_chartEvolucion != null)
            {
                pnlEvolucion.Controls.Remove(_chartEvolucion);
                _chartEvolucion.Dispose();
            }

            _chartEvolucion = CreateRevenueEvolutionChart(report.RevenueEvolution);
            _chartEvolucion.Dock = DockStyle.Fill;
            _chartEvolucion.Margin = new Padding(8);
            pnlEvolucion.Controls.Add(_chartEvolucion);
            pnlEvolucion.Controls.SetChildIndex(_chartEvolucion, 0);

            // 2. Gráfico Top 5 Productos
            if (_chartTopProductos != null)
            {
                pnlTopProductos.Controls.Remove(_chartTopProductos);
                _chartTopProductos.Dispose();
            }

            var top5 = report.MostSoldProducts?.Take(5).ToList();
            _chartTopProductos = CreateTopProductsChart(top5);
            _chartTopProductos.Dock = DockStyle.Fill;
            _chartTopProductos.Margin = new Padding(8);
            pnlTopProductos.Controls.Add(_chartTopProductos);
            pnlTopProductos.Controls.SetChildIndex(_chartTopProductos, 0);

            // 3. Gráfico de Distribución de Ventas por Vendedor (Pie/Donut)
            if (_chartSellerDistribution != null)
            {
                pnlSellerDistribution.Controls.Remove(_chartSellerDistribution);
                _chartSellerDistribution.Dispose();
            }

            _chartSellerDistribution = CreateSellerDistributionPieChart(report.SellerDistribution);
            _chartSellerDistribution.Dock = DockStyle.Fill;
            _chartSellerDistribution.Margin = new Padding(8);
            pnlSellerDistribution.Controls.Add(_chartSellerDistribution);
            pnlSellerDistribution.Controls.SetChildIndex(_chartSellerDistribution, 0);
        }

        private CartesianChart CreateRevenueEvolutionChart(List<RevenueTimelinePoint>? points)
        {
            var chart = new CartesianChart
            {
                BackColor = CardBackground,
                Background = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(60, 60, 60)),
                LegendLocation = LegendLocation.Right
            };

            var validPoints = points ?? new List<RevenueTimelinePoint>();

            var labels = validPoints.Select(p => p.PeriodLabel).ToArray();
            var values = new ChartValues<double>(validPoints.Select(p => (double)p.Revenue));
            double maxRevenue = values.Count > 0 ? values.Max() : 0;
            double yAxisMax = maxRevenue > 0 ? Math.Ceiling(maxRevenue * 1.15) : 1000;

            var columnSeries = new ColumnSeries
            {
                Title = "Recaudación ($)",
                Values = values,
                MaxColumnWidth = 36,
                Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(66, 165, 245)),
                Foreground = WpfBrushes.White,
                FontFamily = new WpfFontFamily("Roboto"),
                FontSize = 11
            };

            var lineSeries = new LineSeries
            {
                Title = "Tendencia",
                Values = values,
                LineSmoothness = 0.35,
                PointGeometrySize = 6,
                PointGeometry = DefaultGeometries.Circle,
                StrokeThickness = 2,
                Fill = System.Windows.Media.Brushes.Transparent,
                Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(255, 167, 38)),
                PointForeground = WpfBrushes.White,
                FontFamily = new WpfFontFamily("Roboto"),
                FontSize = 11
            };

            chart.Series = new SeriesCollection { columnSeries, lineSeries };

            chart.AxisX = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Período",
                    Labels = labels,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 10,
                    Separator = new Separator
                    {
                        Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(75, 75, 75)),
                        StrokeThickness = 1,
                        Step = 1
                    }
                }
            };

            chart.AxisY = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Facturación ($)",
                    MinValue = 0,
                    MaxValue = yAxisMax,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
                    LabelFormatter = value => value.ToString("$#,##0", CultureInfo.InvariantCulture),
                    Separator = new Separator
                    {
                        Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(75, 75, 75)),
                        StrokeThickness = 1
                    }
                }
            };

            var legend = chart.DefaultLegend as DefaultLegend;
            if (legend != null)
            {
                legend.Foreground = WpfBrushes.White;
                legend.FontFamily = new WpfFontFamily("Roboto");
            }

            return chart;
        }

        private static string FormatProductChartLabel(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                return "Sin nombre";
            }

            string clean = productName.Trim();
            if (clean.Length <= 14)
            {
                return clean;
            }

            string[] words = clean.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length >= 2)
            {
                int splitIndex = words.Length >= 3 ? words.Length - 1 : 1;
                string firstLine = string.Join(" ", words.Take(splitIndex));
                string secondLine = string.Join(" ", words.Skip(splitIndex));
                return $"{firstLine}\n{secondLine}";
            }

            return clean;
        }

        private CartesianChart CreateTopProductsChart(List<ProductRankingItem>? topProducts)
        {
            var chart = new CartesianChart
            {
                BackColor = CardBackground,
                Background = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(60, 60, 60)),
                LegendLocation = LegendLocation.None
            };

            var validProducts = topProducts != null && topProducts.Count > 0
                ? topProducts
                : new List<ProductRankingItem>
                {
                    new ProductRankingItem { ProductName = "Sin ventas", UnitsSold = 0 }
                };

            var unitValues = new ChartValues<double>(validProducts.Select(p => (double)p.UnitsSold));
            var labels = validProducts.Select(p => FormatProductChartLabel(p.ProductName)).ToArray();
            double maxUnits = validProducts.Max(p => (double)p.UnitsSold);
            double yAxisMax = maxUnits > 0 ? Math.Ceiling(maxUnits * 1.2) : 5;

            chart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Unidades",
                    Values = unitValues,
                    MaxColumnWidth = 42,
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(38, 198, 218)),
                    Foreground = WpfBrushes.White,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11
                }
            };

            chart.AxisX = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Productos",
                    Labels = labels,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 10,
                    Separator = new Separator
                    {
                        Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(75, 75, 75)),
                        StrokeThickness = 1,
                        Step = 1
                    }
                }
            };

            chart.AxisY = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Unidades",
                    MinValue = 0,
                    MaxValue = yAxisMax,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
                    LabelFormatter = value => value.ToString("0", CultureInfo.InvariantCulture),
                    Separator = new Separator
                    {
                        Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(75, 75, 75)),
                        StrokeThickness = 1
                    }
                }
            };

            return chart;
        }

        private PieChart CreateSellerDistributionPieChart(List<SellerDistributionItem>? distribution)
        {
            var chart = new PieChart
            {
                BackColor = CardBackground,
                LegendLocation = LegendLocation.Right,
                InnerRadius = 40
            };

            WpfColor[] palette =
            {
                WpfColor.FromRgb(66, 165, 245),
                WpfColor.FromRgb(38, 198, 218),
                WpfColor.FromRgb(77, 182, 172),
                WpfColor.FromRgb(171, 71, 188),
                WpfColor.FromRgb(255, 167, 38),
                WpfColor.FromRgb(239, 83, 80)
            };

            var seriesCollection = new SeriesCollection();

            if (distribution != null && distribution.Count > 0)
            {
                for (int i = 0; i < distribution.Count; i++)
                {
                    var item = distribution[i];
                    var color = palette[i % palette.Length];

                    seriesCollection.Add(new PieSeries
                    {
                        Title = item.DisplayName,
                        Values = new ChartValues<double> { item.SalesCount },
                        Fill = new System.Windows.Media.SolidColorBrush(color),
                        Foreground = WpfBrushes.White,
                        FontFamily = new WpfFontFamily("Roboto"),
                        DataLabels = true
                    });
                }
            }
            else
            {
                seriesCollection.Add(new PieSeries
                {
                    Title = "Sin ventas",
                    Values = new ChartValues<double> { 1 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(95, 95, 95)),
                    Foreground = WpfBrushes.White,
                    FontFamily = new WpfFontFamily("Roboto"),
                    DataLabels = false
                });
            }

            chart.Series = seriesCollection;

            var legend = chart.DefaultLegend as DefaultLegend;
            if (legend != null)
            {
                legend.Foreground = WpfBrushes.White;
                legend.FontFamily = new WpfFontFamily("Roboto");
            }

            return chart;
        }

        #endregion
    }
}
