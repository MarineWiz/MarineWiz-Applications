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

namespace Application_Map
{
    public partial class MainWindow : Window
    {
        /******* 사용자 작성 코드  ***************************************************************/
        public static MainWindow Instance
        {
            get;
            private set;
        }

        private void Button0_Click(object sender, RoutedEventArgs e) => MapClear();
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = (StaticMap0_MainWindow_ViewModel)StaticMap0.DataContext;
            dataContext.StartTracking();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = (StaticMap0_MainWindow_ViewModel)StaticMap0.DataContext;
            dataContext.StopTracking();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            var lat = Convert.ToDouble(TextBox0.Text);
            var lon = Convert.ToDouble(TextBox1.Text);
            ((StaticMap0_MainWindow_ViewModel)StaticMap0.DataContext).Value = new MarkerData(lat, lon, true);
            TextBlock6.Text = TextBox0.Text;
            TextBlock7.Text = TextBox1.Text;
        }

        public void MapClear() => StaticMap0.RemoveAllMarker();
        /******* 사용자 작성 코드 ***************************************************************/
        public MainWindow()
        {
            InitializeComponent();
            /******* 사용자 작성 코드  ***************************************************************/
            Instance = this;
            File_Exit_MenuItem.Click += (sender, e) => Application.Current.Shutdown();
            /******* 사용자 작성 코드  ***************************************************************/
            Button4.Click += Button4_Click;
            Button2.Click += Button2_Click;
            Button1.Click += Button1_Click;
            Button0.Click += Button0_Click;
#region StaticMap0 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            StaticMap0.DataContext = new StaticMap0_MainWindow_ViewModel();
            StaticMap0.SetBinding(MarineWizSupporter.UISupporter.StaticMap.ValueProperty, new Binding("Value"));
#endregion StaticMap0 Binding Auto-generation by MarineWiz.
        }
    }
}