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

using MobileSolutions.UILayer.Contracts;

namespace MobileSolutions.UILayer
{
    public partial class ManagerReportControl : UserControl, ILogoutSupport
    {
        public event EventHandler? LogoutRequested;

        private static readonly Color MainBackground = Color.FromArgb(50, 50, 50);
        private static readonly Color CardBackground = Color.FromArgb(60, 60, 60);
        private static readonly Color TableHeaderBackground = Color.FromArgb(13, 71, 161);
        private static readonly Color TableSelectionColor = Color.FromArgb(21, 101, 192);

        private DataGridView dgvStockAlerts;
        private DataGridView dgvTopSellers;

        public ManagerReportControl()
        {
            InitializeComponent();
            btnLogout.Icon = IconChar.RightFromBracket.ToBitmap(Color.White);
            btnLogout.Click += (s, e) => LogoutRequested?.Invoke(this, EventArgs.Empty);
            ConfigureLayout();
        }

        private void ConfigureLayout()
        {
            BackColor = MainBackground;

            tlpKpis.Controls.Add(CreateKpiCard(IconChar.DollarSign, "Ingresos Totales", "$0.00"), 0, 0);
            tlpKpis.Controls.Add(CreateKpiCard(IconChar.ChartLine, "Ganancia Neta", "$0.00"), 1, 0);
            tlpKpis.Controls.Add(CreateKpiCard(IconChar.Percent, "Margen Promedio", "0%"), 2, 0);
            tlpKpis.Controls.Add(CreateKpiCard(IconChar.BoxOpen, "Unidades Vendidas", "0"), 3, 0);

            var chartTop5 = CreateTop5CartesianChart();
            chartTop5.Dock = DockStyle.Fill;
            chartTop5.Margin = new Padding(8);
            pnlTopProductos.Controls.Add(chartTop5);
            pnlTopProductos.Controls.SetChildIndex(chartTop5, 0);

            var chartMarcas = CreateBrandsPieChart();
            chartMarcas.Dock = DockStyle.Fill;
            chartMarcas.Margin = new Padding(8);
            pnlMarcas.Controls.Add(chartMarcas);
            pnlMarcas.Controls.SetChildIndex(chartMarcas, 0);

            dgvStockAlerts = CreateStockAlertsGrid();
            dgvStockAlerts.Dock = DockStyle.Fill;
            dgvStockAlerts.Margin = new Padding(8);
            pnlStockAlerts.Controls.Add(dgvStockAlerts);
            pnlStockAlerts.Controls.SetChildIndex(dgvStockAlerts, 0);

            dgvTopSellers = CreateTopSellersGrid();
            dgvTopSellers.Dock = DockStyle.Fill;
            dgvTopSellers.Margin = new Padding(8);
            pnlTopSellers.Controls.Add(dgvTopSellers);
            pnlTopSellers.Controls.SetChildIndex(dgvTopSellers, 0);
        }

        #region KPIs

        private Panel CreateKpiCard(IconChar icon, string title, string value)
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
                RowCount = 3,
                BackColor = Color.Transparent,
                Margin = Padding.Empty
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var picIcon = new IconPictureBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                IconChar = icon,
                IconColor = Color.White,
                IconFont = IconFont.Auto,
                IconSize = 34
            };

            var lblTitle = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = title,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(190, 190, 190),
                Font = new Font("Roboto", 12F, FontStyle.Regular)
            };

            var lblValue = new MaterialLabel
            {
                Dock = DockStyle.Fill,
                AutoSize = false,
                Text = value,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Roboto", 20F, FontStyle.Bold)
            };

            layout.Controls.Add(picIcon, 0, 0);
            layout.Controls.Add(lblTitle, 0, 1);
            layout.Controls.Add(lblValue, 0, 2);

            card.Controls.Add(layout);
            return card;
        }

        #endregion

        #region Charts

        private CartesianChart CreateTop5CartesianChart()
        {
            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
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

        private PieChart CreateBrandsPieChart()
        {
            var chart = new PieChart
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
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

        #region Tables

        private DataGridView CreateStockAlertsGrid()
        {
            var dgv = CreateBaseDataGridView();
            AddColumn(dgv, "Producto", "Producto");
            AddColumn(dgv, "StockActual", "Stock Actual");
            AddColumn(dgv, "StockMinimo", "Stock Mínimo");
            AddColumn(dgv, "Estado", "Estado");
            return dgv;
        }

        private DataGridView CreateTopSellersGrid()
        {
            var dgv = CreateBaseDataGridView();
            AddColumn(dgv, "Producto", "Producto");
            AddColumn(dgv, "Marca", "Marca");
            AddColumn(dgv, "Unidades", "Unidades");
            AddColumn(dgv, "Ingresos", "Ingresos");
            return dgv;
        }

        private DataGridView CreateBaseDataGridView()
        {
            var dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = MainBackground,
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

            dgv.ColumnHeadersDefaultCellStyle.BackColor = TableHeaderBackground;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = TableHeaderBackground;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.BackColor = MainBackground;
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = TableSelectionColor;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Roboto", 10F, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(58, 58, 58);

            return dgv;
        }

        private void AddColumn(DataGridView dgv, string name, string headerText)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        #endregion
    }
}
