using HotelManagement.Command;
using HotelManagement.Entities;
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
    public class AdminViewRegulationModel:ViewModelBase
    {
        public ICommand addNewRegulation { get; set; }
        public ICommand editCommand{ get; set; }
        private readonly ObservableCollection<RegulationModel> _regulationModel;
        public IEnumerable<RegulationModel> Regulation => _regulationModel;
        public ICommand delete { get; set; }
        

        public AdminViewRegulationModel(NavigationStore navigationStore)
        {
              editCommand = new NavigateCommand(new NavigateService(navigationStore, () => new  AdminEditRegulationVM(navigationStore)));
            delete = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddRegulationModel(navigationStore)));
            addNewRegulation = new NavigateCommand(new NavigateService(navigationStore, () => new AdminAddRegulationModel(navigationStore)));
            _regulationModel = new ObservableCollection<RegulationModel>();
            _regulationModel.Add(new RegulationModel(1, "Vip-single", "no description", 2500));
            _regulationModel.Add(new RegulationModel(2, "Vip-double", "no description", 2500));
            _regulationModel.Add(new RegulationModel(3, "Reg-single", "no description", 2500));
            _regulationModel.Add(new RegulationModel(4, "Reg-Double", "no description", 2500));
            _regulationModel.Add(new RegulationModel(5, "Vip-single", "no description", 2500));
        }
    }
}
