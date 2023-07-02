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
using static HotelManagement.UI.ServiceTab.ListInvoiceService;

namespace HotelManagement.UI.ServiceTab
{
    /// <summary>
    /// Interaction logic for ListInvoiceService.xaml
    /// </summary>
    public partial class ListInvoiceService : UserControl
    {
        public ListInvoiceService()
        {
            InitializeComponent();
        }
        public class InvoiceService : INotifyPropertyChanged
        {
            public string InvoiceServiceID { get; set; }
            public string Status { get; set; }
            public double TotalMoney { get; set; }  
            public DateTime CreateAt { get; set; }
            public int RoomID { get; set; }
            public string ServiceID { get; set; }
            public event PropertyChangedEventHandler? PropertyChanged;
        }

        ObservableCollection<InvoiceService> _invoices;   
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _invoices = new ObservableCollection<InvoiceService> { 
                new InvoiceService{InvoiceServiceID="I01", Status="Đã sử dụng", 
                    TotalMoney=20000, CreateAt=DateTime.Now.AddDays(1), RoomID=101, ServiceID="SV02"}, 
                new InvoiceService{InvoiceServiceID="I02", Status="Chưa sử dụng", 
                    TotalMoney=44000, CreateAt=DateTime.Now.AddDays(3), RoomID=101, ServiceID="SV01"}, 
                new InvoiceService{InvoiceServiceID="I04", Status="Đã sử dụng", 
                    TotalMoney=66000, CreateAt=DateTime.Now.AddDays(5), RoomID=201, ServiceID="SV06"}, 
                new InvoiceService{InvoiceServiceID="I05", Status="Đã sử dụng", 
                    TotalMoney=256000, CreateAt=DateTime.Now.AddDays(2), RoomID=201, ServiceID="SV04"}, 
                new InvoiceService{InvoiceServiceID="I06", Status="Chưa sử dụng", 
                    TotalMoney=320000, CreateAt=DateTime.Now.AddDays(6), RoomID=101, ServiceID="SV03"},
            };
            ListInvoicesService.ItemsSource = _invoices;
        }
    }
}
