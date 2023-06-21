using HotelManagement.Command;
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
        public AdminHomeScreenViewModel()
        {
            //Username = "khoa";

            _submitCommand = new LogOutCommand(this);
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
