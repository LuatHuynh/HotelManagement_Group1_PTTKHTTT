using System;
using System.Collections.Generic;
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

namespace HotelManagement.UI.RoomRegulationTab
{
    /// <summary>
    /// Interaction logic for RoomRegulation.xaml
    /// </summary>
    public partial class RoomRegulation : UserControl
    {
        public class RoomData
        {
            public int RoomTypeID { get; set; }
            public string RoomTypeName { get; set; }
            public double RoomPrice { get; set; }
            public string Description { get; set; }
        }

        private List<RoomData> roomDataList; // Danh sách dữ liệu phòng


        public RoomRegulation()
        {
            InitializeComponent();


        }



        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            // Load data from database or any other source
            roomDataList = LoadRoomTypesFromDatabase();

            // Bind the roomTypes list to the ListView
            roomTypeListView.ItemsSource = roomDataList;
        }

        private List<RoomData> LoadRoomTypesFromDatabase()
        {
            // Simulate loading data from database
            List<RoomData> roomDataList = new List<RoomData>
            {
                new RoomData { RoomTypeID = 1, RoomTypeName = "Phòng Standard", RoomPrice = 100.000, Description = "Phòng tiêu chuẩn" },
                new RoomData { RoomTypeID = 2, RoomTypeName = "Phòng Deluxe", RoomPrice = 150.000, Description = "Phòng cao cấp" },
                new RoomData { RoomTypeID = 3, RoomTypeName = "Phòng Suite", RoomPrice = 200.000, Description = "Phòng hạng sang" },
                new RoomData { RoomTypeID = 4, RoomTypeName = "Phòng Family", RoomPrice = 180.000, Description = "Phòng gia đình" },
                new RoomData { RoomTypeID = 5, RoomTypeName = "Phòng Superior", RoomPrice = 120.000, Description = "Phòng ưu việt" }
            };

            return roomDataList;
        }
    }
}
