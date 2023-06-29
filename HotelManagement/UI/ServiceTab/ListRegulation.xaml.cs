using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using static HotelManagement.UI.ServiceTab.ListRegulation;

namespace HotelManagement.UI.ServiceTab
{
    /// <summary>
    /// Interaction logic for ListRegulation.xaml
    /// </summary>
    public partial class ListRegulation : UserControl
    {
        public ListRegulation()
        {
            InitializeComponent();
        }

        public class Regulation : INotifyPropertyChanged
        {
            public int RegulationID { get; set; }
            public string RegulationName { get; set; }
            public int RegulationValue { get; set; }
            public string RegulationDetail { get; set; }  
            public event PropertyChangedEventHandler? PropertyChanged;
        }
        ObservableCollection<Regulation> _regulations;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _regulations = new ObservableCollection<Regulation>()
            { 
                new Regulation{RegulationID=1, RegulationName="QD1.1",RegulationValue=5,RegulationDetail="abc" },
            };
        }
    }
}
