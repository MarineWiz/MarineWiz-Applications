///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: GaugeChart
/// Return Type: System.Double(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using SampleData;

namespace App_Conning
{
    public class GaugeChart5_MainWindow_ViewModel : ViewModelBase
    {
        private GaugeChart5_MainWindow_Model model;
        public Double Value
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

        public GaugeChart5_MainWindow_ViewModel()
        {
            model = new GaugeChart5_MainWindow_Model();
            var timer = TimerManager.GetTimer(1500);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            Value = DataAccessManager.GetDepth();
        }
    }
}