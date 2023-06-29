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
    /// Interaction logic for InforUser.xaml
    /// </summary>
    public partial class InforUser : Window
    {
        public InforUser() //string maNhanVien, string cmnd, string sdt, string diaChi, string chucVu
        {
            InitializeComponent();

            //txtMaNhanVien.Text = maNhanVien;
            //txtCMND.Text = cmnd;
            //txtSDT.Text = sdt;
            //txtDiaChi.Text = diaChi;
            //txtChucVu.Text = chucVu;
        }
        private void UpdateInfoButton_Click(object sender, RoutedEventArgs e)
        {
            //// Update information here
            //// For example:
            //string HoTen = txtHoTen.Text;
            //string CMND = txtCMND.Text;
            //string SDT = txtSDT.Text;
            //string DiaChi = txtDiaChi.Text;

            //ComboBoxItem? selectedPositionItem = cbbChucVu.SelectedItem as ComboBoxItem;
            //string? ChucVu = selectedPositionItem?.Content.ToString();

            // Now you can use these variables to update the information in your database or wherever it is stored
        }

        //private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Handle change password logic here
        //    MessageBox.Show("Đổi mật khẩu");
        //}
    }
}

