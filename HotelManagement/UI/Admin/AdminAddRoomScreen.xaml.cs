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

namespace HotelManagement.UI.Admin
{
    /// <summary>
    /// Interaction logic for AdminAddRoomScreen.xaml
    /// </summary>
    public partial class AdminAddRoomScreen : UserControl
    {
        public AdminAddRoomScreen()
        {
            InitializeComponent();

            this.Loaded += AdminAddRoomScreen_Loaded;
        }
        private void AdminAddRoomScreen_Loaded(object sender, RoutedEventArgs e)
        {
            //this.cmbCountryList.DisplayMemberPath = "CountryName";
            //this.cmbCountryList.SelectedValuePath = "CountryCode";

            List<string> regulationID = new List<string>();
            regulationID.Add("vip1");
            regulationID.Add("vip2");
            regulationID.Add("vip2");

            regulationID.Add("vip2");

            this.cmbCountryList.ItemsSource = regulationID;
            this.cmbCountryList.Text = "Choose Country";
        }
    }
}
