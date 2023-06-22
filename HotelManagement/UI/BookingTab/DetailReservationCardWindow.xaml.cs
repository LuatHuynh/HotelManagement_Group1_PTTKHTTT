using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static HotelManagement.UI.BookingTab.MakingReservation;

namespace HotelManagement.UI.BookingTab
{
    /// <summary>
    /// Interaction logic for DetailReservationCardWindow.xaml
    /// </summary>
    public partial class DetailReservationCardWindow : Window
    {
        public ObservableCollection<Guest> guests = new ObservableCollection<Guest>();
        public DetailReservationCardWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                guests.Add(new Guest() { PersonalId = "001", Name = "John", Address = "123 Main St", PhoneNumbers = "111-111-1111", FaxNumber = "222-222-2222" });
            }
            GuestsListView.ItemsSource = guests;
        }

        private void OKBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }


    }
}
