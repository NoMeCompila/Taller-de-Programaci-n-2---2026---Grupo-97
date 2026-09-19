using System;
using System.Drawing;
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

namespace MobileSolutions.UILayer
{
    public partial class SellerReportControl : UserControl
    {
        private static readonly Color FondoPrincipal = Color.FromArgb(50, 50, 50);
        private static readonly Color FondoTarjeta = Color.FromArgb(60, 60, 60);
        private static readonly Color ColorSubtituloPositivo = Color.FromArgb(102, 187, 106);
        private static readonly Color ColorSeparadorEjes = Color.FromArgb(75, 75, 75);

        public SellerReportControl()
        {
            InitializeComponent();
            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            ConfigurarLayout();
        }

        private void ConfigurarLayout()
        {
            BackColor = FondoPrincipal;

            tlpKpis.Controls.Add(CrearTarjetaKpi(IconChar.Wallet, "Facturación Mes", "$23,680.00", "+12% vs. mes anterior"), 0, 0);
            tlpKpis.Controls.Add(CrearTarjetaKpi(IconChar.Receipt, "Volumen de Ventas", "35 tickets"), 1, 0);
            tlpKpis.Controls.Add(CrearTarjetaKpi(IconChar.HandHoldingUsd, "Ticket Promedio", "$676.57"), 2, 0);
            tlpKpis.Controls.Add(CrearTarjetaKpi(IconChar.Trophy, "Venta Más Alta", "$1,800.00"), 3, 0);

            var chartEvolucion = CrearChartEvolucionMensual();
            chartEvolucion.Dock = DockStyle.Fill;
            chartEvolucion.Margin = new Padding(8);
            pnlEvolucion.Controls.Add(chartEvolucion);
            pnlEvolucion.Controls.SetChildIndex(chartEvolucion, 0);

            var chartTopProductos = CrearChartTopProductos();
            chartTopProductos.Dock = DockStyle.Fill;
            chartTopProductos.Margin = new Padding(8);
            pnlTopProductos.Controls.Add(chartTopProductos);
            pnlTopProductos.Controls.SetChildIndex(chartTopProductos, 0);

            var chartMarcas = CrearPieMarcas();
            chartMarcas.Dock = DockStyle.Fill;
            chartMarcas.Margin = new Padding(8);
            pnlMarcas.Controls.Add(chartMarcas);
            pnlMarcas.Controls.SetChildIndex(chartMarcas, 0);
        }

        #region KPIs

        private Panel CrearTarjetaKpi(IconChar icono, string titulo, string valor, string? subtitulo = null)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = FondoTarjeta,
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

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var picIcono = new IconPictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                IconChar = icono,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 34
            };

            var lblTitulo = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = titulo,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(190, 190, 190),
                Font = new Font("Roboto", 12F, FontStyle.Regular)
            };

            var lblValor = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = valor,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Roboto", 20F, FontStyle.Bold)
            };

            var lblSubtitulo = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = subtitulo ?? string.Empty,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = ColorSubtituloPositivo,
                Font = new Font("Roboto", 9F, FontStyle.Regular)
            };

            layout.Controls.Add(picIcono, 0, 0);
            layout.Controls.Add(lblTitulo, 0, 1);
            layout.Controls.Add(lblValor, 0, 2);
            layout.Controls.Add(lblSubtitulo, 0, 3);

            card.Controls.Add(layout);
            return card;
        }

        #endregion

        #region Evolución Temporal

        private CartesianChart CrearChartEvolucionMensual()
        {
            var chart = new CartesianChart
            {
                BackColor = FondoTarjeta,
                Background = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(60, 60, 60)),
                LegendLocation = LegendLocation.Right
            };

            var lineSeries = new LineSeries
            {
                Title = "Facturación diaria",
                Values = new ChartValues<double>
                {
                    780, 0, 420, 960, 540, 1150, 1420, 880, 620, 1310,
                    1180, 1340, 1510, 1680, 1290, 760, 1630, 1750, 1360, 990,
                    1210, 1460, 1800, 1560, 1120, 1480, 1610, 1700, 1420, 1580, 1320
                },
                LineSmoothness = 0.35,
                PointGeometrySize = 5,
                PointGeometry = DefaultGeometries.Circle,
                StrokeThickness = 2,
                Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromArgb(80, 66, 165, 245)),
                Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(66, 165, 245)),
                PointForeground = WpfBrushes.White,
                FontFamily = new WpfFontFamily("Roboto"),
                FontSize = 11
            };

            chart.Series = new SeriesCollection { lineSeries };

            chart.AxisX = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Días del mes",
                    Labels = new[]
                    {
                        "1", "2", "3", "4", "5", "6", "7", "8", "9", "10",
                        "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
                        "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"
                    },
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    MinValue = 1,
                    MaxValue = 31,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
                    Separator = new Separator
                    {
                        Stroke = new System.Windows.Media.SolidColorBrush(WpfColor.FromArgb(120, 75, 75, 75)),
                        StrokeThickness = 1,
                        Step = 3
                    }
                }
            };

            chart.AxisY = new AxesCollection
            {
                new LiveCharts.Wpf.Axis
                {
                    Title = "Facturación ($)",
                    MinValue = 0,
                    MaxValue = 2000,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
                    LabelFormatter = value => value.ToString("$0"),
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

        #endregion

        #region Distribución Analítica

        private CartesianChart CrearChartTopProductos()
        {
            var chart = new CartesianChart
            {
                BackColor = FondoTarjeta,
                Background = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(60, 60, 60)),
                LegendLocation = LegendLocation.Right
            };

            chart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Unidades",
                    Values = new ChartValues<double> { 12, 10, 8, 5, 4 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(66, 165, 245)),
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
                    Labels = new[] { "iPhone 14", "Galaxy A14", "iPhone 11", "Moto E3", "Huawei Nova 15" },
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
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
                    MaxValue = 15,
                    Foreground = WpfBrushes.White,
                    ShowLabels = true,
                    FontFamily = new WpfFontFamily("Roboto"),
                    FontSize = 11,
                    LabelFormatter = value => value.ToString("0"),
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

        private PieChart CrearPieMarcas()
        {
            var chart = new PieChart
            {
                BackColor = FondoTarjeta,
                LegendLocation = LegendLocation.Right,
                InnerRadius = 40
            };

            chart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Apple",
                    Values = new ChartValues<double> { 51 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(66, 165, 245)),
                    Foreground = WpfBrushes.White,
                    FontFamily = new WpfFontFamily("Roboto")
                },
                new PieSeries
                {
                    Title = "Samsung",
                    Values = new ChartValues<double> { 26 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(38, 198, 218))
                },
                new PieSeries
                {
                    Title = "Motorola",
                    Values = new ChartValues<double> { 13 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(77, 182, 172))
                },
                new PieSeries
                {
                    Title = "Huawei",
                    Values = new ChartValues<double> { 10 },
                    Fill = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(171, 71, 188))
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

        #endregion
    }
}
