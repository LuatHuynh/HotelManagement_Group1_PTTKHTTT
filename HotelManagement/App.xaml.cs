using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using HotelManagement.DbContexts;
using HotelManagement.Stores;
using HotelManagement.ViewModel;
using HotelManagement.ViewModel.Admin;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        const string connectionStr = "Server=localhost;Database=myDataBase;Encrypt=True; Trusted_Connection=True;TrustServerCertificate=True;";
        public App()
        {
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlServer(connectionStr).Options;

            HotelManagementDBContext dbContext = new HotelManagementDBContext(options);
            dbContext.Database.Migrate();
            _navigationStore.CurrentViewModel = new AdminMainViewModel();

            MainWindow = new MainWindow() {
                DataContext = new MainViewModel(_navigationStore)
            
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
}
}
