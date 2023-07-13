using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HotelManagement.UI.BookingTab
{
    /// <summary>
    /// Interaction logic for MakingReservation.xaml
    /// </summary>
    public partial class MakingReservation : UserControl
    {
        public MakingReservation()
        {
            InitializeComponent();
        }
        ObservableCollection<Room> rooms;
        ObservableCollection<RoomChoosen> roomsChoosen;
        public DateTime from;
        public DateTime to;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            rooms = new ObservableCollection<Room>()
            {
                new Room() { Id = 1, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 2, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 3, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 4, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 5, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 6, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 7, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 8, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 9, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 10, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 11, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 12, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 13, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 14, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 15, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 16, Description = "1 single bed", Status = "Available", Price = 100, Type = "Standard" },
                new Room() { Id = 3, Description = "1 double bed", Status = "Available", Price = 200, Type = "VIP" },
                new Room() { Id = 4, Description = "2 single bed", Status = "Available", Price = 200, Type = "VIP" },
            };

            // Tạo các TabItem và thêm các phòng vào TabControl dựa trên loại phòng
            foreach (var roomType in rooms.GroupBy(r => r.Type))
            {
                TabItem tabItem = new TabItem();
                tabItem.Header = roomType.Key;

                ListView listView = new ListView();
                listView.ItemsSource = roomType.ToList();
                listView.ItemTemplate = (DataTemplate)roomTabControl.FindResource("RoomTemplate");

                tabItem.Content = listView;
                roomTabControl.Items.Add(tabItem);
            }

            roomsChoosen = new ObservableCollection<RoomChoosen>();
            RoomsChoosenListView.ItemsSource = roomsChoosen;
        }

        public class Room
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public double Price { get; set; }
            public string Type { get; set; }
        }

        public class RoomChoosen
        {
            public int Id { get; set; }
            public double Price { get; set; }
            public int Days { get; set; }
            public double TotalPrice { get; set; }
            public string Type { get; set; }
            public List<Guest> guests { get; set; }
        }

        public class Guest
        {
            public string PersonalId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumbers { get; set; }
            public string FaxNumber { get; set; }
        }

        private void SelectRoomBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SearchFromForRoomTextBox.Text.Length == 0 || SearchToForRoomTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill arrival date and departure date", "error");
                return;
            }
            string format = "d/M/yyyy";
            bool isParsearrivalDate = DateTime.TryParseExact(SearchFromForRoomTextBox.Text, format,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out from);
            bool isDepartureDate = DateTime.TryParseExact(SearchToForRoomTextBox.Text, format,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out to);
            //MessageBox.Show(SearchFromForRoomTextBox.Text);
            //MessageBox.Show(from.ToString());
            if (!(isParsearrivalDate & isDepartureDate))
            {
                MessageBox.Show("Please fill right format of arrival date and departure date", "error");
                return;
            }
            if (from > to)
            {
                MessageBox.Show("Date from must be greater than date to", "error");
            }
            Button button = (Button)sender;
            Room selectedRoom = (Room)button.CommandParameter;
            if (selectedRoom != null)
            {
                //MessageBox.Show(selectedRoom.Id.ToString());
                if (roomsChoosen.Any(r => r.Id == selectedRoom.Id))
                {
                    MessageBox.Show("This room has been selected!", "error");
                    return;
                }
                RoomChoosen roomChoosen = new RoomChoosen();
                roomChoosen.Id = selectedRoom.Id;
                roomChoosen.Price = selectedRoom.Price;
                roomChoosen.Days = to.Day - from.Day + 1;
                roomChoosen.TotalPrice = roomChoosen.Days * roomChoosen.Price;
                roomChoosen.Type = selectedRoom.Type;
                roomsChoosen.Add(roomChoosen);
                if (roomsChoosen.Count() > 1)
                {
                    LeaderLabel.Visibility = Visibility.Visible;
                    LeaderTextBox.Visibility = Visibility.Visible;
                }
                CountAndSetTotalPrice();
            }
        }

        private void RemoveRoomSelectedBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            RoomChoosen selectedRoom = (RoomChoosen)button.CommandParameter;
            if (selectedRoom != null)
            {
                roomsChoosen.Remove(selectedRoom);
                if (roomsChoosen.Count() == 1)
                {
                    LeaderLabel.Visibility = Visibility.Collapsed;
                    LeaderTextBox.Visibility = Visibility.Collapsed;
                }
                CountAndSetTotalPrice();
            }
        }

        private T? FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            int count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                if (child is T result)
                    return result;
                else
                {
                    T? descendant = FindVisualChild<T>(child);
                    if (descendant != null)
                        return descendant;
                }
            }
            return null;
        }

        private void AddGuestsInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Image? image = FindVisualChild<Image>(button);


            RoomChoosen selectedRoom = (RoomChoosen)button.CommandParameter;
            if (selectedRoom != null)
            {
                var screen = new GuestInfoInputWindow(selectedRoom.Id);

                if (screen.ShowDialog() == true)
                {
                    List<Guest> guests = new List<Guest>(screen.guests);
                    if (guests.Count() > 0)
                    {
                        selectedRoom.guests = guests;
                        image!.Source = new BitmapImage(new Uri("/Imgs/tick.png", UriKind.Relative));
                    }
                    else
                    {
                        image!.Source = new BitmapImage(new Uri("/Imgs/add.png", UriKind.Relative));
                    }
                }
                else
                {
                    //do nothing
                }
            }
        }

        private void CountAndSetTotalPrice()
        {
            double total = 0;
            if (roomsChoosen.Count() == 0)
            {
                TotalPriceLabel.Content = string.Empty;
                return;
            }
            total = roomsChoosen.Sum(r => r.TotalPrice);
            TotalPriceLabel.Content = total.ToString();
        }
    }
}
