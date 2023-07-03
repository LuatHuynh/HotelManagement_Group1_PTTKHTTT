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
    public class AdminViewUserModel : ViewModelBase
    {
        public ICommand addNewUser { get; set; }
        public ICommand editCommand { get; set; }
        private readonly ObservableCollection<StaffModel> _StaffModel;
        public IEnumerable<StaffModel> Regulation => _StaffModel;
        public AdminViewUserModel(NavigationStore navigationStore)
        {
            _StaffModel= new ObservableCollection<StaffModel>();
            _StaffModel.Add(new StaffModel(1, "Nguyen Quoc Khoa","0969486906" ,"20120511","admin1","123KHoa", "Binh Duong", "Admin"));
            _StaffModel.Add(new StaffModel(2, "Nguyen Quoc Duy", "0969423406", "20120513", "user1", "165user", "TP HCM", "Staff"));
            _StaffModel.Add(new StaffModel(3, "Nguyen Van Kha", "0961236904", "20120513", "user2", "123user", "TP HCM", "Staff"));
            _StaffModel.Add(new StaffModel(4, "Lam Hong Thanh", "0961236904", "20120513", "user3", "123user", "TP HCM", "Staff"));
            _StaffModel.Add(new StaffModel(5, "Huynh Luat", "0961236904", "249523231", "admin2", "123admin", "TP HCM", "Admin"));
            addNewUser = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddUserViewModel(navigationStore)));
            editCommand=new NavigateCommand(new NavigateService(navigationStore, ()=> new AdminEditUserVM()));   
        }
    }
}
