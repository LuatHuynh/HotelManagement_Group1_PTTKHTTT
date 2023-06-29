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
using System.Windows.Shapes;

namespace GiaoDien01
{
    /// <summary>
    /// Interaction logic for DSQuyDinh.xaml
    /// </summary>
    public partial class DSQuyDinh : Window
    {
        //private List<RoomData> roomDataList; // Danh sách dữ liệu phòng


        public DSQuyDinh()
        {
            InitializeComponent();

            // Tạo dữ liệu mẫu
            /* roomDataList = GenerateRoomData(30);*/ // Tạo 30 bộ dữ liệu phòng
        }

        //// Class đại diện cho dữ liệu phòng
        //public class RoomData
        //{
        //    public string RoomCode { get; set; }
        //    public string RoomTypes { get; set; }
        //    public double RoomPrice { get; set; }
        //    public string Description { get; set; }
        //}

        //// Hàm tạo dữ liệu mẫu
        //private List<RoomData> GenerateRoomData(int count)
        //{
        //    List<RoomData> roomDataList = new List<RoomData>();

        //    Random random = new Random();

        //    for (int i = 0; i < count; i++)
        //    {
        //        RoomData roomData = new RoomData();
        //        roomData.RoomCode = "Room " + (i + 1);
        //        roomData.RoomTypes = "Type " + (i + 1);
        //        roomData.RoomPrice = random.Next(100, 1000);
        //        roomData.Description = "Description " + (i + 1);
        //        roomDataList.Add(roomData);
        //    }

        //    return roomDataList;
        //}

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            //// Tạo dữ liệu mẫu mới
            //List<RoomData> roomDataList = GenerateRoomData(10);

            //// Xóa dữ liệu cũ trong ListView
            //roomTypeListView.ItemsSource = null;

            //// Gán dữ liệu mới cho ListView
            //roomTypeListView.ItemsSource = roomDataList;
        }

        //private void roomTypeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // Kiểm tra xem có mục nào được chọn không
        //    if (roomTypeListView.SelectedItem != null)
        //    {
        //        // Lấy dữ liệu của mục được chọn
        //        RoomData selectedRoom = (RoomData)roomTypeListView.SelectedItem;

        //        // Hiển thị thông tin phòng được chọn
        //        MessageBox.Show($"Selected Room: {selectedRoom.RoomCode}\nRoom Type: {selectedRoom.RoomTypes}\nRoom Price: {selectedRoom.RoomPrice}\nDescription: {selectedRoom.Description}");
        //    }
        //}



    }
}

