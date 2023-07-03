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
    public class AdminAddServiceVM:ViewModelBase

    {
        public ICommand addNewService { get; set; }

        public AdminAddServiceVM(NavigationStore navigationStore)
        {

            addNewService = new NavigateCommand(new NavigateService(navigationStore, () => new AdminViewServiceViewModel(navigationStore)));
        }

    }
}
