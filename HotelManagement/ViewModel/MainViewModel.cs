using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Stores;
using HotelManagement.UI.Admin;
using HotelManagement.ViewModel.Admin;
namespace HotelManagement.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase _currentViewModel => _navigationStore.CurrentViewModel;

    }
}
