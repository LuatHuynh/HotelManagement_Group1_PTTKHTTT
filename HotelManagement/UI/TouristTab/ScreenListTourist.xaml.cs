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
using static HotelManagement.UI.ServiceTab.ScreenListService;

namespace HotelManagement.UI.TouristTab
{
    /// <summary>
    /// Interaction logic for ScreenListTourist.xaml
    /// </summary>
    public partial class ScreenListTourist : UserControl
    {
        public ScreenListTourist()
        {
            InitializeComponent();
        }
        public class TouristInvoice : INotifyPropertyChanged
        {
            public int InvoiceID { get; set; }
            public int RoomID { get; set; }
            public DateTime BookingDate { get; set; }
            public string CustomerName { get; set; }
            public string Notes { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<TouristInvoice> _touristInvoices;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _touristInvoices = new ObservableCollection<TouristInvoice>()
            {
                new TouristInvoice{InvoiceID =1, RoomID=1, BookingDate= DateTime.Now.AddDays(1), CustomerName = "Nguyễn Văn An", Notes = "Không có yêu cầu gì" },
                new TouristInvoice{InvoiceID =2, RoomID=1, BookingDate= DateTime.Now.AddDays(2), CustomerName = "Huỳnh Thị Anh", Notes = "Xe đón đến sớm" },
                new TouristInvoice{InvoiceID =3, RoomID=2, BookingDate= DateTime.Now.AddDays(1), CustomerName = "La Ti Phong", Notes = "Xe có dù" },
                new TouristInvoice{InvoiceID =4, RoomID=3, BookingDate= DateTime.Now.AddDays(1), CustomerName = "Trần Tuấn Kiệt", Notes = "Không có yêu cầu gì" },
                new TouristInvoice{InvoiceID =5, RoomID=4, BookingDate= DateTime.Now.AddDays(1), CustomerName = "Võ Khánh Linh", Notes = "Anh tài xế đẹp trai" },
                new TouristInvoice{InvoiceID =6, RoomID=4, BookingDate= DateTime.Now.AddDays(2), CustomerName = "Bùi Ngọc Thảo", Notes = "Không có yêu cầu gì" },
                new TouristInvoice{InvoiceID =7, RoomID=4, BookingDate= DateTime.Now.AddDays(3), CustomerName = "Nguyễn Quốc Khoa", Notes = "Không có yêu cầu gì" },
            };
            touristInvoicesListView.ItemsSource = _touristInvoices;
        }
    }
}
