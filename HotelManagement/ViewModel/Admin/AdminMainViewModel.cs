using HotelManagement.Command;
using HotelManagement.Services;
using HotelManagement.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            UserManagement = new NavigateCommand(new NavigateService(_navigationStore, () => new AdminViewUserModel(_navigationStore)));
            Home = new NavigateCommand(new NavigateService(_navigationStore, () => new AdminHomeScreenViewModel(_navigationStore, createAdminAddUserViewModel)));
            Room = new NavigateCommand(new NavigateService(_navigationStore, () => new AdminViewRoomModel(_navigationStore)));
            Regulation = new NavigateCommand(new NavigateService(_navigationStore, () => new AdminViewRegulationModel(_navigationStore)));
            Service = new NavigateCommand(new NavigateService(_navigationStore, () => new AdminViewServiceViewModel(_navigationStore)));
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
            return new AdminAddUserViewModel(_navigationStore);
        }

        public ICommand UserManagement { get; set; }
        public ICommand Room { get; set; }
        public ICommand Home { get; set; }
        public ICommand Regulation { get; set; }
        public ICommand Service { get; set; } 
    }
}
