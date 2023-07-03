using HotelManagement.Stores;
using HotelManagement.ViewModel.Admin;
using HotelManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelManagement.UI.Login
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            Username = "staff";

            InitializeComponent();
        }

        public string Username
        {
            get;set;
        }

        public string pass { get; set; }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(Username =="staff")
            {
                var mainScreen = new MainWindow();
                mainScreen.Show();

                this.Close();
            }
            else if (Username == "admin")
            {
                NavigationStore _navigationStore = new NavigationStore();
                _navigationStore.CurrentViewModel = new AdminMainViewModel();
                var screen = new adminWindow()
                {
                    DataContext = new MainViewModel(_navigationStore)
                };
                screen.Show();
                this.Close();
            }
     

        }
    
    }
}
