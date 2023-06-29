using Fluent;
using HotelManagement.UI.BookingTab;
using HotelManagement.UI.CheckoutTab;
using HotelManagement.UI.RoomRegulationTab;
using HotelManagement.UI.StaffInfoTab;
using HotelManagement.UI.ServiceTab;
using HotelManagement.UI.TouristTab;
using System.ComponentModel;
using System.Windows;

namespace HotelManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ReservationCards();
        }

        private void ReservationCardsTab(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new ReservationCards();
        }

        private void MakingReservationTabs(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new MakingReservation();
        }

        private void CheckOutTab(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new CheckOut();
        }

        private void RoomRegulationTab(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new RoomRegulation();
        }

        private void StaffInfoTab(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new StaffInfo();
        }
        private void AddServiceClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new ScreenServiceProduct();
        }

        private void ViewListInvoiceClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new ScreenListService();
        }

        private void AddTouristClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new ScreenAddTourist();
        }

        private void ViewListTouristClick(object sender, RoutedEventArgs e)
        {
            MainContent.Content = null;
            MainContent.Content = new ScreenListTourist();
        }
    }
}
