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
    public class AdminViewUserModel : ViewModelBase
    {
        public ICommand addNewUser { get; set; }

        public AdminViewUserModel(NavigationStore navigationStore)
        {

            addNewUser = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddUserViewModel(navigationStore)));
        }
    }
}
