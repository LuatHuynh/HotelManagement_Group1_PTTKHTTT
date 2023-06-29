using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ListService.xaml
    /// </summary>
    public partial class ListService : UserControl
    {
        public ListService()
        {
            InitializeComponent();
        }

        public class ServiceProduct : INotifyPropertyChanged
        {
            public string Name { get; set; }
            public string UnitPrice { get; set; }
            public event PropertyChangedEventHandler? PropertyChanged;
        }

        ObservableCollection<ServiceProduct> _serviceProducts;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _serviceProducts = new ObservableCollection<ServiceProduct>()
            { 
                new ServiceProduct{Name="banh mi", UnitPrice="10000"},
                new ServiceProduct{Name="nuoc ngot", UnitPrice="20000"},
                new ServiceProduct{Name="bup phe", UnitPrice="200000"},
                new ServiceProduct{Name="so pa", UnitPrice="400000"},
                new ServiceProduct{Name="massage tam quat", UnitPrice="300000"},
                new ServiceProduct{Name="trai cay", UnitPrice="20000"},
            };
            comboBox.ItemsSource = _serviceProducts;
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DecrementButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void IncrementButton_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBox quantity = (TextBox)FindName("Quantity");
        //    if (quantity != null && quantity.Text < qauntity.Maximum)
        //    {
        //        quantity.Value += 1;
        //    }
        //}

        //private void DecrementButton_Click(object sender, RoutedEventArgs e)
        //{
        //    TextBox qauntity = (TextBox)FindName("Quantity");
        //    if (qauntity != null && qauntity.Text > qauntity.Maximum)
        //    {
        //        qauntity.Value -= 1;
        //    }
        //}
    }
}
