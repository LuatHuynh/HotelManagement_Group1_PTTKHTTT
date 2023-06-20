using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.UI.Admin;
using HotelManagement.ViewModel.Admin;
namespace HotelManagement.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        public ViewModelBase _currentViewModel { get; set; }
        public MainViewModel()
        {
            _currentViewModel= new AdminHomeScreenViewModel();

        }
    }
}
