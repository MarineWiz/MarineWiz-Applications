///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TextBlock
/// Return Type: System.String(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;

namespace App_Conning
{
    public class TextBlock17_MainWindow_ViewModel : ViewModelBase
    {
        private TextBlock16_MainWindow_Model model;
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

        public TextBlock17_MainWindow_ViewModel()
        {
            model = new TextBlock16_MainWindow_Model();
            var timer = TimerManager.GetTimer(500);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            /******* 사용자 작성 코드  ***************************************************************/
            Value = DateTime.Now.ToString("HH:mm:ss");
            /******* 사용자 작성 코드  ***************************************************************/
        }
    }
}