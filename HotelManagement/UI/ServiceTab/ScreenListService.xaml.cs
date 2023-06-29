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
            public int InvoiceID { get; set; }
            public int RoomID { get; set; }
            public DateTime BookingDate { get; set; }
            public string Status { get; set; }
            public string Notes { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<ServiceInvoice> _serviceInvoices;  
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _serviceInvoices = new ObservableCollection<ServiceInvoice>()
            { 
                new ServiceInvoice{InvoiceID =1, RoomID=1, BookingDate= DateTime.Now.AddDays(1), Status = "Chưa sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =2, RoomID=1, BookingDate= DateTime.Now.AddDays(2), Status = "Đã sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =3, RoomID=2, BookingDate= DateTime.Now.AddDays(1), Status = "Chưa sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =4, RoomID=3, BookingDate= DateTime.Now.AddDays(1), Status = "Đã sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =5, RoomID=4, BookingDate= DateTime.Now.AddDays(1), Status = "Đã sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =6, RoomID=4, BookingDate= DateTime.Now.AddDays(2), Status = "Chưa sử dụng", Notes = "Không có yêu cầu gì" },
                new ServiceInvoice{InvoiceID =7, RoomID=4, BookingDate= DateTime.Now.AddDays(3), Status = "Chưa sử dụng", Notes = "Không có yêu cầu gì" },
            };
            serviceInvoicesListView.ItemsSource = _serviceInvoices;
        }
    }
}
