using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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

namespace HotelManagement.UI.ServiceTab
{
    /// <summary>
    /// Interaction logic for Function.xaml
    /// </summary>
    public partial class Function : UserControl
    {
        public Function()
        {
            InitializeComponent();
        }

        public class Cost : INotifyPropertyChanged
        {
            public string _totalCost;
            public string TotalCost
            {
                get { return _totalCost; } 
                
                set
                {
                    _totalCost = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
                }
            }
            public event PropertyChangedEventHandler? PropertyChanged;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
