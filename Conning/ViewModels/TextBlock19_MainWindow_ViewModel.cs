///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TextBlock
/// Return Type: System.String(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using System.Linq;
using SampleData;
using System.Collections.Generic;
using MarineWizSupporter.DataSupporter;

namespace App_Conning
{
    public class TextBlock19_MainWindow_ViewModel : ViewModelBase
    {
        /******* 사용자 작성 코드  ***************************************************************/        
        private int i = 0;
        private List<MarkerData> list;
        /******* 사용자 작성 코드  ***************************************************************/
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

        public TextBlock19_MainWindow_ViewModel()
        {
            model = new TextBlock16_MainWindow_Model();
            var timer = TimerManager.GetTimer(2000);
            timer.Tick += SetBindingData;
            timer.Start();
        }

        public void SetBindingData(object sender, EventArgs e)
        {
            /******* 사용자 작성 코드  ***************************************************************/
            if (list == null)
                list = new List<MarkerData>(SampleData.DataAccessManager.GetLatAndLong());
                
            if (i >= list.Count())
                i = 0;
            Value = list[i].Lat.ToString();
            /******* 사용자 작성 코드  ***************************************************************/
        }
    }
}