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
    public class AdminViewServiceViewModel:ViewModelBase
    {
        private readonly ObservableCollection<ServiceModel> _regulationModel;
        public IEnumerable<ServiceModel> Regulation => _regulationModel;
        public ICommand addNewService { get; set; }
        public ICommand editCommand { get; set; }   
        public AdminViewServiceViewModel(NavigationStore navigationStore)
        {
            editCommand = new NavigateCommand(new NavigateService(navigationStore, () => new AdminEditServiceVM()));
            addNewService = new NavigateCommand(new NavigateService(navigationStore,()=> new AdminAddServiceVM(navigationStore)));
            _regulationModel = new ObservableCollection<ServiceModel>();
            _regulationModel.Add(new ServiceModel(1, "Cleaning", "domestic",1,30000));
            _regulationModel.Add(new ServiceModel(2, "Cocktail", "drinks", 1, 50000));
            _regulationModel.Add(new ServiceModel(3, "Breakfast", "food", 1, 60000));
            _regulationModel.Add(new ServiceModel(5, "Swimming", "sport", 1, 60000));

        }

  
        
    }
}
