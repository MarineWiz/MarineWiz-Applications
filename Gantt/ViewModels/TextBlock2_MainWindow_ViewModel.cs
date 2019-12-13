///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TextBlock
/// Return Type: System.String(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;

namespace Application_Gantt
{
    public class TextBlock2_MainWindow_ViewModel : ViewModelBase
    {
        private TextBlock2_MainWindow_Model model;
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

        public TextBlock2_MainWindow_ViewModel()
        {
            model = new TextBlock2_MainWindow_Model();
            var timer = new DispatcherTimer{Interval = TimeSpan.FromMilliseconds(1000)};
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            Value = DateTime.Now.ToString();
        }
    }
}