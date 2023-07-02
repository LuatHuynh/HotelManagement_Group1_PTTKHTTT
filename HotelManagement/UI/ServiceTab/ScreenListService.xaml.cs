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
    /// Interaction logic for ScreenListService.xaml
    /// </summary>
    public partial class ScreenListService : UserControl
    {
        public ScreenListService()
        {
            InitializeComponent();
        }
        public class ServiceInvoice : INotifyPropertyChanged
        {
            public string InvoiceID { get; set; }
            public int RoomID { get; set; }
            public string BookingDate { get; set; }
            public string Status { get; set; }
            public string ServiceName { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<ServiceInvoice> _serviceInvoices;  
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _serviceInvoices = new ObservableCollection<ServiceInvoice>()
            { 
                new ServiceInvoice{InvoiceID = "ID01", RoomID=101, BookingDate= "7/3/2023", Status = "Đã sử dụng", ServiceName = "Trái cây" },
                //new ServiceInvoice{InvoiceID = "ID02", RoomID=101, BookingDate= "7/5/2023", Status = "Chưa sử dụng", ServiceName = "Nước ngọt" },
                new ServiceInvoice{InvoiceID = "ID04", RoomID=201, BookingDate= "7/7/2023", Status = "Đã sử dụng", ServiceName = "Goft" },
                new ServiceInvoice{InvoiceID = "ID05", RoomID=201, BookingDate= "7/4/2023", Status = "Đã sử dụng", ServiceName = "Bánh mì" },
                new ServiceInvoice{InvoiceID = "ID06", RoomID=101, BookingDate= "7/8/2023", Status = "Chưa sử dụng", ServiceName = "Buffet" },
             };
            serviceInvoicesListView.ItemsSource = _serviceInvoices;
        }
    }
}
