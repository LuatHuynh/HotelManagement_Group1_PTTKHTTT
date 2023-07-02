using HotelManagement.UI.BookingTab;
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
            public string BookingDate { get; set; }
            public string CustomerName { get; set; }
            public string Notes { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<TouristInvoice> _touristInvoices;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _touristInvoices = new ObservableCollection<TouristInvoice>()
            {
                new TouristInvoice{InvoiceID =1, RoomID=101, BookingDate= "7/3/2023", CustomerName = "Nguyễn Văn An", Notes = "Không có yêu cầu gì" },
                new TouristInvoice{InvoiceID =2, RoomID=102, BookingDate= "7/3/2023", CustomerName = "Huỳnh Thị Anh", Notes = "Xe đón đến sớm" },
                new TouristInvoice{InvoiceID =3, RoomID=201, BookingDate= "7/3/2023", CustomerName = "La Ti Phong", Notes = "Xe có dù" },
                new TouristInvoice{InvoiceID =4, RoomID=301, BookingDate= "7/3/2023", CustomerName = "Trần Tuấn Kiệt", Notes = "Không có yêu cầu gì" },
                new TouristInvoice{InvoiceID =5, RoomID=402, BookingDate= "7/3/2023", CustomerName = "Võ Khánh Linh", Notes = "Không có yêu cầu gì" },
            };
            touristInvoicesListView.ItemsSource = _touristInvoices;
        }

        private void DetailTourist_Click(object sender, RoutedEventArgs e)
        {
            var screen = new DeltailTouristWindow();

            if (screen.ShowDialog() == true)
            {

            }
            else
            {
                //do nothing
            }
        }
    }
}
