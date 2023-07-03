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

namespace HotelManagement.UI.StaffInfoTab
{
    /// <summary>
    /// Interaction logic for StaffInfo.xaml
    /// </summary>
    public partial class StaffInfo : UserControl
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Gán dữ liệu vào các ô TextBox và ComboBox
            txtStaffID.Text = "1"; // Giả sử dữ liệu cho ô "Staff ID"
            pId.Text = "1234567"; // Giả sử dữ liệu cho ô "Personal Indentification"
            phoneNumber.Text = "0987654321"; // Giả sử dữ liệu cho ô "Telephone number"
            address.Text = "123 Đường NVC, Q5, TP HCM"; // Giả sử dữ liệu cho ô "Address"
            position.SelectedIndex = 0; // Giả sử dữ liệu cho ô "Position" là lựa chọn đầu tiên trong danh sách ComboBoxItem
        }

        private bool isEditing = false; // Biến kiểm tra trạng thái đang chỉnh sửa

        private void UpdateInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (isEditing)
            {
                // Hoàn tất cập nhật dữ liệu sau khi chỉnh sửa
                // Lưu dữ liệu hoặc thực hiện các thao tác khác tùy vào yêu cầu của bạn

                // Sau khi hoàn tất cập nhật, đặt trạng thái chỉnh sửa về false
                isEditing = false;

                // Đặt IsReadOnly thành true cho các ô TextBox và ComboBox trừ ô "Staff ID"
                pId.IsReadOnly = true;
                phoneNumber.IsReadOnly = true;
                address.IsReadOnly = true;
                position.IsReadOnly = true;

                // Thay đổi giao diện nút "Edit Information" để người dùng biết rằng dữ liệu đã được cập nhật
                UpdateInfoButton.Content = "Edit Information";
            }
            else
            {
                // Cho phép chỉnh sửa dữ liệu bằng cách đặt IsReadOnly thành false cho các ô TextBox và ComboBox trừ ô "Staff ID"
                pId.IsReadOnly = false;
                phoneNumber.IsReadOnly = false;
                address.IsReadOnly = false;
                position.IsReadOnly = false;

                // Thay đổi giao diện nút "Edit Information" để người dùng biết rằng họ đang chỉnh sửa dữ liệu
                UpdateInfoButton.Content = "Save Information";

                // Đặt trạng thái chỉnh sửa thành true
                isEditing = true;
            }
        }

        private void ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();

        }
    }
}
