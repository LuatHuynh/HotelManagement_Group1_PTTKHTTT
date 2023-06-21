using HotelManagement.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.ViewModel.Admin
{
    class AdminMainViewModel:ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public AdminMainViewModel()
          
        {
            _navigationStore = new NavigationStore(); 
            test = "concac";
            _navigationStore.CurrentViewModel = new AdminHomeScreenViewModel();
            Console.WriteLine(CurrentAdminViewModel);
          
        }

        public ViewModelBase CurrentAdminViewModel => _navigationStore.CurrentViewModel;
        public string test { get; set; }

    }
}
