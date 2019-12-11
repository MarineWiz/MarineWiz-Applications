///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: ConstantChangesChart
/// Return Type: LiveCharts.ChartValues`1[MarineWizSupporter.DataSupporter.MeasureModel](Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using SampleData;
using MarineWizSupporter.DataSupporter;
using LiveCharts;

namespace App_Conning
{
    public class ConstantChangesChart0_MainWindow_ViewModel : ViewModelBase
    {
        private ConstantChangesChart0_MainWindow_Model model;
        public Double AxisMax
        {
            get
            {
                return model.AxisMax;
            }

            set
            {
                model.AxisMax = value;
                OnPropertyChanged();
            }
        }

        public Double AxisMin
        {
            get
            {
                return model.AxisMin;
            }

            set
            {
                model.AxisMin = value;
                OnPropertyChanged();
            }
        }

        public ChartValues<MeasureModel> Value
        {
            get
            {
                return model.Value;
            }

            set
            {
                model.Value = value;
                OnPropertyChanged();
            }
        }

        public ConstantChangesChart0_MainWindow_ViewModel()
        {
            model = new ConstantChangesChart0_MainWindow_Model();
            Value = new ChartValues<MeasureModel>();
            AxisMax = DateTime.Now.Ticks + TimeSpan.FromSeconds(1).Ticks;
            // AxisMin = Datetime.Now.Ticks - TimeSpan.FromSeconds(12).Ticks;
            AxisMin = DateTime.Now.Ticks - TimeSpan.FromSeconds(6).Ticks;
            var timer = TimerManager.GetTimer(1000);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            Value.Add(new MeasureModel{DateTime = now, Value = DataAccessManager.GetData_Depth()});
            AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks;
            //AxisMin = now.Ticks - TimeSpan.FromSeconds(12).Ticks;
            AxisMin = now.Ticks - TimeSpan.FromSeconds(6).Ticks;
            if (Value.Count > 50)
                Value.RemoveAt(0);
        }
    }
}