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
    public class AdminViewRoomModel:ViewModelBase
    {
        public ICommand addNewRoom { get; set; }

        public AdminViewRoomModel(NavigationStore navigationStore)
        {

            addNewRoom = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddRoomModel(navigationStore)));
        }
    }
}
