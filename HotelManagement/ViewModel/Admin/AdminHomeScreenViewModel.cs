using HotelManagement.Command;
using HotelManagement.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagement.ViewModel.Admin
{
    public class AdminHomeScreenViewModel:ViewModelBase
    {
        private string _username;
        //private readonly NavigationStore _navigationStore;
        public AdminHomeScreenViewModel(NavigationStore _navigationStore,Func<AdminAddUserViewModel> createAdminAddUserViewModel)
        {
            //Username = "khoa";

            //_submitCommand = new LogOutCommand(this);
            _submitCommand = new NavigateCommand(_navigationStore, createAdminAddUserViewModel);
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public ICommand _submitCommand { get; set; }
    }
}
