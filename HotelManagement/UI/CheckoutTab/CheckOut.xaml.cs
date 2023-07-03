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

namespace HotelManagement.UI.CheckoutTab
{
    /// <summary>
    /// Interaction logic for CheckOut.xaml
    /// </summary>
    public partial class CheckOut : UserControl
    {
        public class RoomData
        {
            public int RoomTypeID { get; set; }
            public string RoomTypeName { get; set; }
            public double RoomPrice { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
        }

        private List<RoomData> roomDataList; // Danh sách dữ liệu phòng


        public CheckOut()
        {
            InitializeComponent();

            // Tạo dữ liệu mẫu
            /* roomDataList = GenerateRoomData(30);*/ // Tạo 30 bộ dữ liệu phòng
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
                new RoomData { RoomTypeID = 1, RoomTypeName = "Phòng Standard", RoomPrice = 100.00, Description = "Phòng tiêu chuẩn", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 3, RoomTypeName = "Phòng Deluxe", RoomPrice = 150.00, Description = "Phòng cao cấp" , Status = "Cho thuê"},
                new RoomData { RoomTypeID = 5, RoomTypeName = "Phòng Suite", RoomPrice = 200.00, Description = "Phòng hạng sang", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 6, RoomTypeName = "Phòng Family", RoomPrice = 180.00, Description = "Phòng gia đình", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 7, RoomTypeName = "Phòng Superior", RoomPrice = 120.00, Description = "Phòng ưu việt", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 9, RoomTypeName = "Phòng Standard", RoomPrice = 100.00, Description = "Phòng tiêu chuẩn", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 11, RoomTypeName = "Phòng Deluxe", RoomPrice = 150.00, Description = "Phòng cao cấp" , Status = "Cho thuê"},
                new RoomData { RoomTypeID = 13, RoomTypeName = "Phòng Suite", RoomPrice = 200.00, Description = "Phòng hạng sang", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 14, RoomTypeName = "Phòng Family", RoomPrice = 180.00, Description = "Phòng gia đình", Status = "Cho thuê" },
                new RoomData { RoomTypeID = 15, RoomTypeName = "Phòng Superior", RoomPrice = 120.00, Description = "Phòng ưu việt", Status = "Cho thuê" }
            };

            return roomDataList;
        }
        private void btnViewDetails_Click(object sender, RoutedEventArgs e)
        {

            //Do something
            InvoiceDetail detailView = new InvoiceDetail();
            detailView.Show();


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cbbSearch.SelectedItem is ComboBoxItem selectedItem)
            {
                if (int.TryParse(selectedItem.Content.ToString(), out int selectedRoomCode))
                {
                    // Lọc danh sách phòng dựa trên mã phòng được chọn
                    var filteredRooms = roomTypeListView.Items.Cast<RoomData>()
                        .Where(room => room.RoomTypeID == selectedRoomCode)
                        .ToList();

                    // Cập nhật ItemsSource của ListView với danh sách phòng đã lọc
                    roomTypeListView.ItemsSource = filteredRooms;
                }
            }
        }


    }
}
