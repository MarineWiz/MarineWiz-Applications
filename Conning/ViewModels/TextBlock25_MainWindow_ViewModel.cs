///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TextBlock
/// Return Type: System.String(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using SampleData;

namespace App_Conning
{
    public class TextBlock25_MainWindow_ViewModel : ViewModelBase
    {
        private TextBlock18_MainWindow_Model model;
        public String Value
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

        public TextBlock25_MainWindow_ViewModel()
        {
            model = new TextBlock18_MainWindow_Model();
            var timer = TimerManager.GetTimer(2000);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            // Value = DataAccessManager.GetData_RPM();
            Value = DataAccessManager.GetData_RPM().ToString();
        }
    }
}