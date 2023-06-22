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
using static HotelManagement.UI.BookingTab.MakingReservation;

namespace HotelManagement.UI.BookingTab
{
    /// <summary>
    /// Interaction logic for BookingTab.xaml
    /// </summary>
    public partial class ReservationCards : UserControl
    {
        public ReservationCards()
        {
            InitializeComponent();
        }

        public class ReservationCard : INotifyPropertyChanged
        {
            public int CardID { get; set; }
            public int InvoiceID { get; set; }
            public int RoomID { get; set; }
            public DateTime ArrivalDate { get; set; }
            public DateTime DepartureDate { get; set; }
            public string Status { get; set; }
            public string Notes { get; set; }

            public event PropertyChangedEventHandler? PropertyChanged;
        }


        ObservableCollection<ReservationCard> reservationCards;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            reservationCards = new ObservableCollection<ReservationCard>()
            {
                new ReservationCard { CardID = 1, InvoiceID = 1001, RoomID = 101, 
                    ArrivalDate = DateTime.Now.AddDays(1), DepartureDate = DateTime.Now.AddDays(3), Status = "Confirmed", Notes = "No special notes" },
                new ReservationCard { CardID = 2, InvoiceID = 1002, RoomID = 102, 
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 3, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 4, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 5, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 6, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 7, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 8, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 9, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                new ReservationCard { CardID = 10, InvoiceID = 1002, RoomID = 102,
                    ArrivalDate = DateTime.Now.AddDays(2), DepartureDate = DateTime.Now.AddDays(4), Status = "Pending", Notes = "Requires extra bed" },
                // Thêm các đối tượng ReservationCard khác vào đây nếu cần
            };
            reservationCardsListView.ItemsSource = reservationCards;
            curP.Text = "3";
            totalP.Text = "5";
        }

        private void EditDetailReservationCardsBtn_Click(object sender, RoutedEventArgs e)
        {
            var screen = new DetailReservationCardWindow();

            if (screen.ShowDialog() == true)
            {

            }
            else
            {
                //do nothing
            }
        }

        private void DetailReservationCardsBtn_Click(object sender, RoutedEventArgs e)
        {
            var screen = new DetailReservationCardWindow();

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
