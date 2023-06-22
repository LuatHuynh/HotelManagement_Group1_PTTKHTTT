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
    public class AdminViewRegulationModel:ViewModelBase
    {
        public ICommand addNewRegulation { get; set; }

        public AdminViewRegulationModel(NavigationStore navigationStore)
        {

            addNewRegulation = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddRegulationModel(navigationStore)));
        }
    }
}
