using Fluent;
using HotelManagement.UI.BookingTab;
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
    }
}
