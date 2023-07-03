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

namespace HotelManagement.UI.TouristTab
{
    /// <summary>
    /// Interaction logic for DeltailTouristWindow.xaml
    /// </summary>
    public partial class DeltailTouristWindow : Window
    {
        public DeltailTouristWindow()
        {
            InitializeComponent();
        }
        public List<string> SampleData { get; set; }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SampleData = new List<string>
            {
            "Xác nhận",
            "Chưa xác nhận",
            };
            comboBox.ItemsSource = SampleData;
        }
    };

}
