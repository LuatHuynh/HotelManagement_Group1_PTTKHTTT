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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HotelManagement.UI.Admin
{
    /// <summary>
    /// Interaction logic for AdminMainScreen.xaml
    /// </summary>
    public partial class AdminMainScreen : UserControl
    {
    
        public AdminMainScreen()
        {

      
            InitializeComponent();

        }



        private void dragApplication(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Window parentWindow = Window.GetWindow(this);
                parentWindow.DragMove();

            }
        }
    }
}
