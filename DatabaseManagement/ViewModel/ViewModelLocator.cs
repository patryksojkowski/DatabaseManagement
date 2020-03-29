using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using DatabaseManagement.ViewModel.Tabs;

namespace DatabaseManagement.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<AddTabViewModel>();
            SimpleIoc.Default.Register<FindTabViewModel>();
            SimpleIoc.Default.Register<ConnectTabViewModel>();
        }

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();
        public AddTabViewModel AddTabViewModel => ServiceLocator.Current.GetInstance<AddTabViewModel>();
        public FindTabViewModel FindTabViewModel => ServiceLocator.Current.GetInstance<FindTabViewModel>();
        public ConnectTabViewModel ConnectTabViewModel => ServiceLocator.Current.GetInstance<ConnectTabViewModel>();
    }
}