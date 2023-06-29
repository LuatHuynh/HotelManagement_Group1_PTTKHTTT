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
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var mainScreen = new MainWindow();
            mainScreen.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = string.Empty;
                txtUsername.Foreground = Brushes.Black;
            }
        }

        private void txtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Username...";
                txtUsername.Foreground = Brushes.Gray;
            }
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "Password...")
            {
                passwordBox.Password = string.Empty;
                passwordBox.Foreground = Brushes.Black;
            }
        }

        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrEmpty(passwordBox.Password))
            {
                passwordBox.Password = "Password...";
                passwordBox.Foreground = Brushes.Gray;
            }
        }
    }
}
