using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for GuestInfoInputWindow.xaml
    /// </summary>
    public partial class GuestInfoInputWindow : Window
    {
        public ObservableCollection<Guest> guests = new ObservableCollection<Guest>();

        public GuestInfoInputWindow()
        {
            InitializeComponent();
        }

        public GuestInfoInputWindow(int roomId)
        {
            InitializeComponent();
            TitleRoom.Content = "Room " + roomId.ToString();
            //guests = new List<Guest>();
            GuestsListView.ItemsSource = guests;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SetNumOfGuestBtn_Click(object sender, RoutedEventArgs e)
        {
            int numOfGuests = int.Parse(NumberOfGuestsTextBox.Text);

            guests.Clear();

            for (int i = 0; i < numOfGuests; i++)
            {
                guests.Add(new Guest());
            }
            // { PersonalId = "001", Name = "John", Address = "123 Main St", PhoneNumbers = "111-111-1111", FaxNumber = "222-222-2222" }

        }

        private void SubmitGuestsInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
