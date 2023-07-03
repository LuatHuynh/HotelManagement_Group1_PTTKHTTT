using HotelManagement.Command;
using HotelManagement.Entities;
using HotelManagement.Model;
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
    public class AdminEditRegulationVM:ViewModelBase
    {

        public string _userIDNo;
        public string _name;
        public string _userName;
        public string _password;
        public string _phone;
        public string _address;
        public string UserIDNo
        {
            get { return _userIDNo; }
            set
            {
                _userIDNo = value;
                OnPropertyChanged(nameof(UserIDNo));
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _userIDNo = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value; OnPropertyChanged(nameof(Password));
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value; OnPropertyChanged(nameof(Phone));
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                _address = value; OnPropertyChanged(nameof(Address));
            }
        }
        public ICommand viewRegulationList { get; set; }

        public AdminEditRegulationVM(NavigationStore navigationStore)
        {

         viewRegulationList = new NavigateCommand(new NavigateService(navigationStore, () => new AdminViewRegulationModel(navigationStore)));
        }
    }
}
