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
using static HotelManagement.UI.ServiceTab.Function;

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
                new ServiceProduct{Name="Bánh mì", UnitPrice="10000"},
                new ServiceProduct{Name="Nước ngọt", UnitPrice="20000"},
                new ServiceProduct{Name="Buffet", UnitPrice="200000"},
                new ServiceProduct{Name="Goft", UnitPrice="400000"},
                new ServiceProduct{Name="Xông hơi", UnitPrice="300000"},
                new ServiceProduct{Name="Trái cây", UnitPrice="20000"},
            };
            comboBox.ItemsSource = _serviceProducts;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int _unitPrice = int.Parse(unitPrice.Text.Trim());
            int _quantity = int.Parse(Quantity.Text.Trim());
            
        }
    }
}
