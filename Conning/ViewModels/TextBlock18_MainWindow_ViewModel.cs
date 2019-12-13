///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TextBlock
/// Return Type: System.String(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using System.Collections.Generic;
using MarineWizSupporter.DataSupporter;
using SampleData;

namespace App_Conning
{
    public class TextBlock18_MainWindow_ViewModel : ViewModelBase
    {
        /******* 사용자 작성 코드  ***************************************************************/
        private List<MarkerData> list;
        private int i = 0;
        /******* 사용자 작성 코드  ***************************************************************/
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

        public TextBlock18_MainWindow_ViewModel()
        {
            model = new TextBlock18_MainWindow_Model();
            var timer = TimerManager.GetTimer(2000);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            /******* 사용자 작성 코드  ***************************************************************/
            if (list == null)
                list = new List<MarkerData>(DataAccessManager.GetLatAndLong());
                
            if (i >= list.Count)
                i = 0;
            Value = list[i].Lon.ToString();
            /******* 사용자 작성 코드  ***************************************************************/
        }
    }
}