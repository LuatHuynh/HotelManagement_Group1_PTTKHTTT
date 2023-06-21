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
            _navigationStore.CurrentViewModel = new AdminHomeScreenViewModel(_navigationStore,createAdminAddUserViewModel);
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentAdminViewModel));
        }

        public ViewModelBase CurrentAdminViewModel => _navigationStore.CurrentViewModel;
        public string test { get; set; }
        
        private AdminHomeScreenViewModel creaetAdminHomeScreenViewModel()
        {
            return new AdminHomeScreenViewModel(_navigationStore, createAdminAddUserViewModel);
        }
        private AdminAddUserViewModel createAdminAddUserViewModel()
        {
            return new AdminAddUserViewModel();
        }
    }
}
