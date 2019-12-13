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
    public class TextBlock28_MainWindow_ViewModel : ViewModelBase
    {
        private TextBlock28_MainWindow_Model model;
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

        public TextBlock28_MainWindow_ViewModel()
        {
            model = new TextBlock28_MainWindow_Model();
            var timer = TimerManager.GetTimer(1500);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            // Value = DataAccessManager.GetWidth();
            Value = DataAccessManager.GetWidth().ToString();
        }
    }
}