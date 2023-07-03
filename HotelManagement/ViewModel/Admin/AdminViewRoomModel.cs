using HotelManagement.Command;
using HotelManagement.Model;
using HotelManagement.Services;
using HotelManagement.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagement.ViewModel.Admin
{
    public class AdminViewRoomModel:ViewModelBase
    {
        public ICommand addNewRoom { get; set; }
        public ICommand editCommand { get; set; }   
        private readonly ObservableCollection<RoomModel> _roomModel;
        public IEnumerable<RoomModel> Room => _roomModel;
        public AdminViewRoomModel(NavigationStore navigationStore)
        {
            _roomModel = new ObservableCollection<RoomModel>();
            _roomModel.Add(new RoomModel(1, "full", "single"));
            _roomModel.Add(new RoomModel(2, "ready", "double"));
            _roomModel.Add(new RoomModel(3, "ready", "single"));
            _roomModel.Add(new RoomModel(4, "full", "double"));

            addNewRoom = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddRoomModel(navigationStore)));
            editCommand = new NavigateCommand(new NavigateService(navigationStore,()=> new AdminEditRoomVM()));
        }
    }
}
