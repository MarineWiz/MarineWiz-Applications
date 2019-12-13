///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: TrackingMap
/// Return Type: MarineWizSupporter.DataSupporter.MarkerData(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using System.Collections.Generic;
using SampleData;
using MarineWizSupporter.DataSupporter;

namespace Application_Map
{
    public class StaticMap0_MainWindow_ViewModel : ViewModelBase
    {
        /******* 사용자 작성 코드 ***************************************************************/
        public DispatcherTimer Timer { get; set; }
        private List<MarkerData> ulsan;
        private List<MarkerData> hyundai;
        private string currentPath;
        private int i = 0;
        /******* 사용자 작성 코드 ***************************************************************/
        
        private StaticMap0_MainWindow_Model model;
        public MarkerData Value
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

        public StaticMap0_MainWindow_ViewModel()
        {
            /******* 사용자 작성 코드 ***************************************************************/
            currentPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/");
            ulsan = new List<MarkerData>(DataAccessManager.GetUlsanDowntownGPSData());
            hyundai = new List<MarkerData>(DataAccessManager.GetHyundaiIndustryGPSData());
            /******* 사용자 작성 코드 ***************************************************************/
            
            model = new StaticMap0_MainWindow_Model();
            Timer = new DispatcherTimer{Interval = TimeSpan.FromMilliseconds(1500)};
            Timer.Tick += SetBindingData;
            // Timer.Start();
        }

        /******* 사용자 작성 코드 ***************************************************************/
        public void SetBindingData(object sender, EventArgs e) => AddMarker();
        
        public void StartTracking() => Timer.Start();
        
        public void StopTracking() => Timer.Stop();
        
        public void AddMarker() 
        {
            if ( i >= 25 )
            {
                i = 0;
                MainWindow.Instance.MapClear();
            }
            
            Value = new MarkerData(ulsan[i].Lat, ulsan[i].Lon, false, currentPath + "/holder1.png");
            Value = new MarkerData(ulsan[i + 50].Lat, ulsan[i].Lon, false, currentPath + "/holder2.png");
            MainWindow.Instance.TextBlock6.Text = ulsan[i].Lat.ToString();
            MainWindow.Instance.TextBlock7.Text = ulsan[i].Lon.ToString();
            
            Value = new MarkerData(hyundai[i].Lat, hyundai[i].Lon, false, currentPath + "/icon_worker.png");
            Value = new MarkerData(hyundai[i + 25].Lat, hyundai[i + 25].Lon, false, currentPath + "/icon_freight.png");
            Value = new MarkerData(hyundai[i + 50].Lat, hyundai[i + 50].Lon, false, currentPath + "/icon_temp.png");
            Value = new MarkerData(hyundai[i + 75].Lat, hyundai[i + 75].Lon, false, currentPath + "/icon_crane.png");
            MainWindow.Instance.TextBlock9.Text = hyundai[i].Lat.ToString();
            MainWindow.Instance.TextBlock11.Text = hyundai[i].Lon.ToString();
            
            i++;
        }
        /******* 사용자 작성 코드 ***************************************************************/
    }
}