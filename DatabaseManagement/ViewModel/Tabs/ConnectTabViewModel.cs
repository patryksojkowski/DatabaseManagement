using DatabaseManagement.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using CommonServiceLocator;

namespace DatabaseManagement.ViewModel.Tabs
{
    public class ConnectTabViewModel : ViewModelBase
    {
        public ConnectTabViewModel()
        {
            ConnectCommand = new RelayCommand(Connect);
            ConnectionString = @"Server=.\MSSQLSERVER1601;Database=AstronomyDB;Trusted_Connection=True;";
        }

        private string connectionString;
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
                RaisePropertyChanged(nameof(ConnectionString));
            }
        }

        public ICommand ConnectCommand { get; set; }
        private void Connect()
        {
            var mainView = ServiceLocator.Current.GetInstance<MainViewModel>();
            mainView.Title = (mainView.Connected = new DataAccess().Connect(ConnectionString)) ?
                "Database Management (connected)"
                : "Database Management ( not connected)";
        }
    }
}
