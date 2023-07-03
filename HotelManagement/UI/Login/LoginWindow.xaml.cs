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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

namespace HotelManagement.UI.Login
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            //Username = "staff";

            InitializeComponent();
        }

        public string Username
        {
            get;set;
        }

        public string pass { get; set; }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string Username = txtUsername.Text;

            // Kiểm tra xem chuỗi nhập vào có khớp với mẫu "staff/admin" + "ID" hay không
            Regex regex = new Regex(@"^(staff|admin)(\d+)$");
            Match match = regex.Match(Username);

            if (match.Success)
            {
                string userType = match.Groups[1].Value; // "staff" hoặc "admin"
                int userID = Int32.Parse(match.Groups[2].Value); // ID (số nguyên)

                if (userType == "staff")
                {
                    var mainScreen = new MainWindow();
                    mainScreen.Show();

                    this.Close();
                }
                else if (userType == "admin")
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
            else
            {
                warning.Foreground = Brushes.Red;
                MessageBox.Show("Invalid Username");              
            }


        }
    
    }
}
