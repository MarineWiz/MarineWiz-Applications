using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Data;
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
using System.ComponentModel;
using System.Xml.Linq;
using LiveCharts;
using LiveCharts.Wpf;
using MarineWizSupporter.DataSupporter;
using MarineWizSupporter.UISupporter;

namespace Application_Gantt
{
    public partial class MainWindow : Window
    {
        private void File_Load_XML_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "XML file (*.xml)|*.xml";
            if (openDialog.ShowDialog() == true)
            {
                GanttChart0.Value = File.ReadAllText(openDialog.FileName);
                SetDataTable(null, null);
            }
        }
        
        private void File_Save_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML file (*.xml)|*.xml";
            if (saveDialog.ShowDialog() == true)
                File.WriteAllText(saveDialog.FileName, GanttChart0.GetTasks().ToString());
        }
        
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            var started = DatePicker0.SelectedDate.Value.Date;
            var ended = DatePicker1.SelectedDate.Value.Date;
            if (DateTime.Compare(started, ended) > 0)
            {
                MessageBox.Show("The start date cannot come before the end date.", "WARNING", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var task = new XElement("Task", new XAttribute("Task", TextBox0.Text), new XElement("Start", started.ToShortDateString()), new XElement("End", ended.ToShortDateString()));
            var tasks = GanttChart0.GetTasks();
            tasks.Add(task);
            GanttChart0.Value = tasks.ToString();
            SetDataTable(null, null);
        }

        public void SetDataTable(object sender, RoutedEventArgs e)
        {
            var table = new DataTable();
            table.Columns.Add(new DataColumn("개발내용")
            {ReadOnly = true});
            table.Columns.Add(new DataColumn("시작일")
            {ReadOnly = true});
            table.Columns.Add(new DataColumn("종료일")
            {ReadOnly = true});
            table.Columns.Add(new DataColumn("남은기간")
            {ReadOnly = true});
            foreach (var item in GanttChart0.GetTasks().Elements("Task"))
            {
                var remain = (DateTime.Parse(item.Element("End").Value) - DateTime.Now).Days;
                var remainStr = remain.ToString();
                if (remain < 0)
                    remainStr = "Expired";
                table.Rows.Add(new string[]{item.Attribute("Task").Value, item.Element("Start").Value, item.Element("End").Value, remainStr});
            }

            ((CustomDataGrid0_MainWindow_ViewModel)CustomDataGrid0.DataContext).Value = table;
        }

        public MainWindow()
        {
            InitializeComponent();
            DatePicker0.SelectedDate = DateTime.Now;
            DatePicker1.SelectedDate = DateTime.Now;
            Button0.Click += Button0_Click;
            File_Exit_MenuItem.Click += (sender, e) => Application.Current.Shutdown();
            Help_About____MenuItem.Click += (sender, e) => new HelpInformationWindow().Show();
            File_Load_XML_MenuItem.Click += File_Load_XML_MenuItem_Click;
            File_Save_MenuItem.Click += File_Save_MenuItem_Click;
#region CustomDataGrid0 Binding Auto-generation by MarineWiz. DO NOT modify and delete this line.
            CustomDataGrid0.DataContext = new CustomDataGrid0_MainWindow_ViewModel();
            CustomDataGrid0.SetBinding(MarineWizSupporter.UISupporter.CustomDataGrid.ItemsSourceProperty, new Binding("Value"));
#endregion CustomDataGrid0 Binding Auto-generation by MarineWiz.
            GanttChart0.Loaded += SetDataTable;
        }
    }
}