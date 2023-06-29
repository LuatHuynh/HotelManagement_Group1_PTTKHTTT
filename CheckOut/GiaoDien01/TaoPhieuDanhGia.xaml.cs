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
    /// Interaction logic for TaoPhieuDanhGia.xaml
    /// </summary>
    public partial class TaoPhieuDanhGia : Window
    {
        public TaoPhieuDanhGia()
        {
            InitializeComponent();
        }
        private void btnStar_Click(object sender, RoutedEventArgs e)
        {
            // Xác định Button được nhấp
            Button clickedButton = (Button)sender;

            // Lấy số thứ tự của Button (tương ứng với số ngôi sao)
            int starRating = int.Parse(clickedButton.Name.Replace("btnStar", ""));

            // Đánh dấu các ngôi sao
            MarkStars(starRating);
        }

        private void MarkStars(int starCount)
        {
            // Đặt tất cả các Button thành ngôi sao không được đánh dấu
            btnStar1.Content = "☆";
            btnStar2.Content = "☆";
            btnStar3.Content = "☆";
            btnStar4.Content = "☆";
            btnStar5.Content = "☆";

            // Đặt các Button ứng với mức độ hài lòng được đánh dấu thành ngôi sao được đánh dấu
            for (int i = 1; i <= starCount; i++)
            {
                Button starButton = (Button)FindName("btnStar" + i);
                starButton.Content = "★";
            }
        }

        //private void txtName(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}
        //private void txtCMND(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}
        //private void txtSDT(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}
        //private void txtMaPhong(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}
        //private void txtLoaiPhong(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}
        //private void txtCmt(object sender, RoutedEventArgs e)
        //{
        //    Do Something
        //}

        private void btnLuuPhieu_Click(object sender, RoutedEventArgs e)
        {
            //Do Something
        }

    }
}

