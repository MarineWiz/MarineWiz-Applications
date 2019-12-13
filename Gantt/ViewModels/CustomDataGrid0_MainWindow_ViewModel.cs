///////////////////////////////////////////////////////////////////////////////////////
/// Generated Class File by MarineWiz SDK, DO NOT Modify or Remove this comments //////
/// Component: CustomDataGrid
/// Return Type: System.Data.DataTable(Value)
///////////////////////////////////////////////////////////////////////////////////////
using System.Windows.Threading;
using System;
using System.Data;

namespace Application_Gantt
{
    public class CustomDataGrid0_MainWindow_ViewModel : ViewModelBase
    {
        private CustomDataGrid0_MainWindow_Model model;
        public DataTable Value
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

        public CustomDataGrid0_MainWindow_ViewModel()
        {
            model = new CustomDataGrid0_MainWindow_Model();
            // Value = /* TODO */ ;
        }
    }
}