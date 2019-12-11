using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using MarineWizSupporter.DataSupporter;

namespace App_Conning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#region TextBlock16 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock16.DataContext = new TextBlock16_MainWindow_ViewModel();
            TextBlock16.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock16 Binding Auto-generation by MarineWiz.
#region TextBlock17 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock17.DataContext = new TextBlock17_MainWindow_ViewModel();
            TextBlock17.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock17 Binding Auto-generation by MarineWiz.
#region TextBlock19 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock19.DataContext = new TextBlock19_MainWindow_ViewModel();
            TextBlock19.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock19 Binding Auto-generation by MarineWiz.
#region TextBlock18 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock18.DataContext = TextBlock19.DataContext;
            TextBlock18.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock18 Binding Auto-generation by MarineWiz.
#region TextBlock21 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock21.DataContext = new TextBlock21_MainWindow_ViewModel();
            TextBlock21.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock21 Binding Auto-generation by MarineWiz.
#region TextBlock20 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock20.DataContext = new TextBlock20_MainWindow_ViewModel();
            TextBlock20.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock20 Binding Auto-generation by MarineWiz.
#region TextBlock28 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock28.DataContext = new TextBlock28_MainWindow_ViewModel();
            TextBlock28.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock28 Binding Auto-generation by MarineWiz.
#region AngularGaugeChart0 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            AngularGaugeChart0.DataContext = new AngularGaugeChart0_MainWindow_ViewModel();
            AngularGaugeChart0.SetBinding(MarineWizSupporter.UISupporter.AngularGaugeChart.ValueProperty, new Binding("Value"));
#endregion AngularGaugeChart0 Binding Auto-generation by MarineWiz.
#region AngularGaugeChart1 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            AngularGaugeChart1.DataContext = new AngularGaugeChart1_MainWindow_ViewModel();
            AngularGaugeChart1.SetBinding(MarineWizSupporter.UISupporter.AngularGaugeChart.ValueProperty, new Binding("Value"));
#endregion AngularGaugeChart1 Binding Auto-generation by MarineWiz.
#region ConstantChangesChart0 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            ConstantChangesChart0.DataContext = new ConstantChangesChart0_MainWindow_ViewModel();
            ConstantChangesChart0.DataTooltip = null;
            var ConstantChangesChart0_axis = new Axis{LabelFormatter = value => new DateTime((long)value).ToString("mm:ss"), Unit = TimeSpan.TicksPerSecond};
            ConstantChangesChart0_axis.Separator.Step = TimeSpan.FromSeconds(1).Ticks;
            ConstantChangesChart0_axis.SetBinding(LiveCharts.Wpf.Axis.MaxValueProperty, new Binding("AxisMax"));
            ConstantChangesChart0_axis.SetBinding(LiveCharts.Wpf.Axis.MinValueProperty, new Binding("AxisMin"));
            var ConstantChangesChart0_series = new LineSeries();
            ConstantChangesChart0_series.SetBinding(LiveCharts.Wpf.LineSeries.ValuesProperty, new Binding("Value"));
            ConstantChangesChart0.AxisX.Add(ConstantChangesChart0_axis);
            ConstantChangesChart0.Series.Add(ConstantChangesChart0_series);
            ConstantChangesChart0.Series.Configuration = LiveCharts.Configurations.Mappers.Xy<MeasureModel>().X(model => model.DateTime.Ticks).Y(model => model.Value);
#endregion ConstantChangesChart0 Binding Auto-generation by MarineWiz.
#region GaugeChart2 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            GaugeChart2.DataContext = new GaugeChart2_MainWindow_ViewModel();
            GaugeChart2.SetBinding(MarineWizSupporter.UISupporter.GaugeChart.ValueProperty, new Binding("Value"));
#endregion GaugeChart2 Binding Auto-generation by MarineWiz.
#region GaugeChart3 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            GaugeChart3.DataContext = new GaugeChart3_MainWindow_ViewModel();
            GaugeChart3.SetBinding(MarineWizSupporter.UISupporter.GaugeChart.ValueProperty, new Binding("Value"));
#endregion GaugeChart3 Binding Auto-generation by MarineWiz.
#region GaugeChart4 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            GaugeChart4.DataContext = new GaugeChart4_MainWindow_ViewModel();
            GaugeChart4.SetBinding(MarineWizSupporter.UISupporter.GaugeChart.ValueProperty, new Binding("Value"));
#endregion GaugeChart4 Binding Auto-generation by MarineWiz.
#region GaugeChart5 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            GaugeChart5.DataContext = new GaugeChart5_MainWindow_ViewModel();
            GaugeChart5.SetBinding(MarineWizSupporter.UISupporter.GaugeChart.ValueProperty, new Binding("Value"));
#endregion GaugeChart5 Binding Auto-generation by MarineWiz.
#region TextBlock18 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock18.DataContext = new TextBlock18_MainWindow_ViewModel();
            TextBlock18.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock18 Binding Auto-generation by MarineWiz.
#region TextBlock23 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock23.DataContext = AngularGaugeChart1.DataContext;
            TextBlock23.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock23 Binding Auto-generation by MarineWiz.
#region TextBlock22 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock22.DataContext = AngularGaugeChart0.DataContext;
            TextBlock22.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock22 Binding Auto-generation by MarineWiz.
#region ColumnChartBase0 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            ColumnChartBase0.DataContext = new ColumnChartBase0_MainWindow_ViewModel();
            // var ColumnChartBase0_column = new ColumnSeries();
            var ColumnChartBase0_column = new RowSeries();
            ColumnChartBase0.Series.Add(ColumnChartBase0_column);
            ColumnChartBase0_column.SetBinding(LiveCharts.Wpf.ColumnSeries.ValuesProperty, new Binding("Value"));
#endregion ColumnChartBase0 Binding Auto-generation by MarineWiz.
#region ColumnChartBase1 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            ColumnChartBase1.DataContext = new ColumnChartBase1_MainWindow_ViewModel();
            // var ColumnChartBase1_column = new ColumnSeries();
            var ColumnChartBase1_column = new RowSeries();
            ColumnChartBase1.Series.Add(ColumnChartBase1_column);
            ColumnChartBase1_column.SetBinding(LiveCharts.Wpf.ColumnSeries.ValuesProperty, new Binding("Value"));
#endregion ColumnChartBase1 Binding Auto-generation by MarineWiz.
#region ColumnChartBase2 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            ColumnChartBase2.DataContext = new ColumnChartBase2_MainWindow_ViewModel();
            // var ColumnChartBase2_column = new ColumnSeries();
            var ColumnChartBase2_column = new RowSeries();
            ColumnChartBase2.Series.Add(ColumnChartBase2_column);
            ColumnChartBase2_column.SetBinding(LiveCharts.Wpf.ColumnSeries.ValuesProperty, new Binding("Value"));
#endregion ColumnChartBase2 Binding Auto-generation by MarineWiz.
#region TextBlock25 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            TextBlock25.DataContext = new TextBlock25_MainWindow_ViewModel();
            TextBlock25.SetBinding(System.Windows.Controls.TextBlock.TextProperty, new Binding("Value"));
#endregion TextBlock25 Binding Auto-generation by MarineWiz.

            /******* 사용자 작성 코드  ***************************************************************/
            ConstantChangesChart0_series.Fill = Brushes.LightGray;
            ConstantChangesChart0_series.StrokeThickness = 2;
            AngularGaugeChart0.Sections.Add(new AngularSection{FromValue = 0, ToValue = 150, Fill = new SolidColorBrush(Color.FromRgb(247, 166, 37))});
            AngularGaugeChart0.Sections.Add(new AngularSection{FromValue = 150, ToValue = 200, Fill = new SolidColorBrush(Color.FromRgb(254, 57, 57))});
            AngularGaugeChart1.Sections.Add(new AngularSection{FromValue = 0, ToValue = 150, Fill = new SolidColorBrush(Color.FromRgb(247, 166, 37))});
            AngularGaugeChart1.Sections.Add(new AngularSection{FromValue = 150, ToValue = 200, Fill = new SolidColorBrush(Color.FromRgb(254, 57, 57))});
            ColumnChartBase0.AxisX.Add(new Axis{MaxValue = 270, MinValue = -270});
            ColumnChartBase1.AxisX.Add(new Axis{MaxValue = 8000, MinValue = -4000});
            ColumnChartBase2.AxisX.Add(new Axis{MaxValue = 300, MinValue = -300});
            /******* 사용자 작성 코드  ***************************************************************/
        }
    }
}