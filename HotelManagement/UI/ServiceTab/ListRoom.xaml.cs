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
    /// Interaction logic for ListRoom.xaml
    /// </summary>
    public partial class ListRoom : UserControl
    {
        public ListRoom()
        {
            InitializeComponent();
        }

        public class Room : INotifyPropertyChanged
        {
            public int RoomID { get; set; }
            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<Room> _rooms;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _rooms = new ObservableCollection<Room>()
            {
                new Room{RoomID=101},
                new Room{RoomID=102},
                new Room{RoomID=301},
                new Room{RoomID=401},
            };
            RoomsListView.ItemsSource = _rooms;
        }

        private void ChooseRoom_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
