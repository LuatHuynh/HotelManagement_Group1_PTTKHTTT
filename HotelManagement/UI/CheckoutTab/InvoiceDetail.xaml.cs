using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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
    /// Interaction logic for InvoiceDetail.xaml
    /// </summary>
    public partial class InvoiceDetail : Window
    {
        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Gán dữ liệu vào các ô TextBox 
            txtName.Text = "Nguyễn Văn A"; 
            txtRoomID.Text = "1"; 
            txtService.Text = "Buffe"; 
            txtTotal.Text = "580.000";
            

        }

        private void btnCreateFeedbackForm_Click(object sender, RoutedEventArgs e)
        {
            CreateFeedbackForm feedBack = new CreateFeedbackForm();
            feedBack.Show();
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnExtend_Click(object sender, RoutedEventArgs e)
        {

            //Do something
            Extend  extend = new Extend();
            extend.Show();


        }
    }
}
