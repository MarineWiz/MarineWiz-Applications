///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: ColumnChartBase
/// Return Type: LiveCharts.ChartValues`1[System.Double](Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using SampleData;
using LiveCharts;

namespace App_Conning
{
    public class ColumnChartBase2_MainWindow_ViewModel : ViewModelBase
    {
        private ColumnChartBase2_MainWindow_Model model;
        public ChartValues<Double> Value
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

        public ColumnChartBase2_MainWindow_ViewModel()
        {
            model = new ColumnChartBase2_MainWindow_Model();
            var timer = TimerManager.GetTimer(3000);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            /******* 사용자 작성 코드  ***************************************************************/
            if (Value == null)
                Value = new ChartValues<double>();
            Value.Clear();
            Value.Add(DataAccessManager.GetDepth());
            /******* 사용자 작성 코드  ***************************************************************/
        }
    }
}