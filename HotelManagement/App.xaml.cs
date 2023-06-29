using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HotelManagement.Stores;
using HotelManagement.ViewModel;
using HotelManagement.ViewModel.Admin;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new AdminMainViewModel();
            MainWindow = new MainWindow() {
                DataContext = new MainViewModel(_navigationStore)
            
            };
            //MainWindow.Show();
            base.OnStartup(e);
        }
}
}
