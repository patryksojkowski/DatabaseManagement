using GalaSoft.MvvmLight;
using GalaSoft;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using DatabaseManagement.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace DatabaseManagement.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            TabItems = new ObservableCollection<TabItem>
            {
                new TabItem { Header = "Connect", Content = new Views.ConnectTab() }
            };
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private ObservableCollection<TabItem> tabItems;
        public ObservableCollection<TabItem> TabItems
        {
            get
            {
                return tabItems;
            }
            set
            {
                tabItems = value;
                RaisePropertyChanged(nameof(TabItems));
            }
        }
        private bool connected;

        public bool Connected
        {
            get {
                return connected;
            }
            set {
                if (connected = value)
                {
                    TabItems.Add((new TabItem { Header = "AddTab", Content = new Views.AddTab() }));
                    TabItems.Add((new TabItem { Header = "FindTab", Content = new Views.FindTab() }));
                } else
                {
                    TabItems.RemoveAt(1);
                    TabItems.RemoveAt(1);
                }
            }
        }


    }
}