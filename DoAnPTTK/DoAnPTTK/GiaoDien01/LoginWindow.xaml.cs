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

namespace GiaoDien01
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
        //Xử lí chữ mờ ở ô nhập liệu Username
        private void txtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Nhập tên đăng nhập...")
            {
                txtUsername.Text = string.Empty;
                txtUsername.Foreground = Brushes.Black;
            }
        }

        private void txtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                txtUsername.Text = "Nhập tên đăng nhập...";
                txtUsername.Foreground = Brushes.Gray;
            }
        }

        //Xử lí chữ mờ ở ô nhập liệu Password
        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "Nhập mật khẩu...")
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
                passwordBox.Password = "Nhập mật khẩu...";
                passwordBox.Foreground = Brushes.Gray;
            }
        }

        //
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
