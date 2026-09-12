using System;
using System.Drawing;
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
    public partial class ManagerReportControl : UserControl
    {
        private static readonly Color FondoPrincipal = Color.FromArgb(50, 50, 50);
        private static readonly Color FondoTarjeta = Color.FromArgb(60, 60, 60);
        private static readonly Color FondoCabeceraTabla = Color.FromArgb(13, 71, 161); // Blue900
        private static readonly Color ColorSeleccionTabla = Color.FromArgb(21, 101, 192); // Blue800

        private DataGridView dgvStockAlerts;
        private DataGridView dgvTopSellers;

        public ManagerReportControl()
        {
            InitializeComponent();
            ConfigurarLayout();
        }

        private void ConfigurarLayout()
        {
            BackColor = FondoPrincipal;

            var tlpPrincipal = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = FondoPrincipal,
                Margin = Padding.Empty,
                Padding = new Padding(12, 12, 12, 12)
            };

            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

            tlpPrincipal.Controls.Add(CrearFilaKpis(), 0, 0);
            tlpPrincipal.Controls.Add(CrearFilaGraficos(), 0, 1);
            tlpPrincipal.Controls.Add(CrearFilaTablas(), 0, 2);

            Controls.Add(tlpPrincipal);
        }

        #region Fila 1 - KPIs

        private TableLayoutPanel CrearFilaKpis()
        {
            var tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = FondoPrincipal,
                Margin = Padding.Empty
            };

            for (int i = 0; i < 4; i++)
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            tlp.Controls.Add(CrearTarjetaKpi(IconChar.DollarSign, "Ingresos Totales", "$0.00"), 0, 0);
            tlp.Controls.Add(CrearTarjetaKpi(IconChar.ChartLine, "Ganancia Neta", "$0.00"), 1, 0);
            tlp.Controls.Add(CrearTarjetaKpi(IconChar.Percent, "Margen Promedio", "0%"), 2, 0);
            tlp.Controls.Add(CrearTarjetaKpi(IconChar.BoxOpen, "Unidades Vendidas", "0"), 3, 0);

            return tlp;
        }

        private Panel CrearTarjetaKpi(IconChar icono, string titulo, string valor)
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
                RowCount = 3,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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

            layout.Controls.Add(picIcono, 0, 0);
            layout.Controls.Add(lblTitulo, 0, 1);
            layout.Controls.Add(lblValor, 0, 2);

            card.Controls.Add(layout);
            return card;
        }

        #endregion

        #region Fila 2 - Gráficos

        private TableLayoutPanel CrearFilaGraficos()
        {
            var tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = FondoPrincipal,
                Margin = Padding.Empty
            };

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            tlp.Controls.Add(CrearCajaGrafico(CrearCartesianTop5(), "Top 5 Productos más vendidos"), 0, 0);
            tlp.Controls.Add(CrearCajaGrafico(CrearPieMarcas(), "Ventas por Marca"), 1, 0);

            return tlp;
        }

        private Panel CrearCajaGrafico(Control grafico, string titulo)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = FondoTarjeta,
                Margin = new Padding(6)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var lblTitulo = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = titulo,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                ForeColor = Color.White,
                Font = new Font("Roboto", 11F, FontStyle.Regular)
            };

            grafico.Dock = DockStyle.Fill;

            layout.Controls.Add(lblTitulo, 0, 0);
            layout.Controls.Add(grafico, 0, 1);

            card.Controls.Add(layout);
            return card;
        }

        private CartesianChart CrearCartesianTop5()
        {
            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = FondoTarjeta,
                Background = new System.Windows.Media.SolidColorBrush(WpfColor.FromRgb(60, 60, 60)),
                LegendLocation = LegendLocation.Right,

                Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Title = "Unidades",
                        Values = new ChartValues<double> { 40, 60, 40, 20, 40 }
                    }
                },

                AxisX = new AxesCollection
                {
                    new LiveCharts.Wpf.Axis
                    {
                        Title = "Productos",
                        Labels = new[] { "Galaxy A14", "Iphone 11", "Moto E3", "Huawei Nova 15", "Iphone 14" },
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
                },
                AxisY = new AxesCollection
                {
                    new LiveCharts.Wpf.Axis
                    {
                        Title = "Unidades",
                        MinValue = 0,
                        MaxValue = 100,
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
                Dock = DockStyle.Fill,
                BackColor = FondoTarjeta,
                LegendLocation = LegendLocation.Right,
                Series = new SeriesCollection
                {
                    new PieSeries { Title = "Samsung", Values = new ChartValues<double> { 20 } },
                    new PieSeries { Title = "Huawei", Values = new ChartValues<double> { 10 } },
                    new PieSeries { Title = "Iphone", Values = new ChartValues<double> { 50 } },
                    new PieSeries { Title = "Motorola", Values = new ChartValues<double> { 20 } }
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

        #region Fila 3 - Tablas

        private TableLayoutPanel CrearFilaTablas()
        {
            var tlp = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = FondoPrincipal,
                Margin = Padding.Empty
            };

            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            dgvStockAlerts = CrearDgvStockAlerts();
            dgvTopSellers = CrearDgvTopSellers();

            tlp.Controls.Add(CrearCajaTabla(dgvStockAlerts, "Alertas de Stock"), 0, 0);
            tlp.Controls.Add(CrearCajaTabla(dgvTopSellers, "Top Sellers"), 1, 0);

            return tlp;
        }

        private Panel CrearCajaTabla(DataGridView dgv, string titulo)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = FondoTarjeta,
                Margin = new Padding(6)
            };

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 2,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var lblTitulo = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = titulo,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(8, 0, 0, 0),
                ForeColor = Color.White,
                Font = new Font("Roboto", 11F, FontStyle.Regular)
            };

            dgv.Dock = DockStyle.Fill;

            layout.Controls.Add(lblTitulo, 0, 0);
            layout.Controls.Add(dgv, 0, 1);

            card.Controls.Add(layout);
            return card;
        }

        private DataGridView CrearDgvStockAlerts()
        {
            var dgv = CrearDataGridView();
            AgregarColumna(dgv, "Producto", "Producto");
            AgregarColumna(dgv, "StockActual", "Stock Actual");
            AgregarColumna(dgv, "StockMinimo", "Stock Mínimo");
            AgregarColumna(dgv, "Estado", "Estado");
            return dgv;
        }

        private DataGridView CrearDgvTopSellers()
        {
            var dgv = CrearDataGridView();
            AgregarColumna(dgv, "Producto", "Producto");
            AgregarColumna(dgv, "Marca", "Marca");
            AgregarColumna(dgv, "Unidades", "Unidades");
            AgregarColumna(dgv, "Ingresos", "Ingresos");
            return dgv;
        }

        private DataGridView CrearDataGridView()
        {
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = FondoPrincipal,
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(70, 70, 70),
                EnableHeadersVisualStyles = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ScrollBars = ScrollBars.Vertical
            };

            dgv.ColumnHeadersHeight = 38;
            dgv.RowTemplate.Height = 34;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = FondoCabeceraTabla;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = FondoCabeceraTabla;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.BackColor = FondoPrincipal;
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccionTabla;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);

            return dgv;
        }

        private void AgregarColumna(DataGridView dgv, string nombre, string encabezado)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = nombre,
                HeaderText = encabezado,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        #endregion
    }
}