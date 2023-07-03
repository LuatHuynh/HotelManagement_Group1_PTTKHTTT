using HotelManagement.Stores;
using HotelManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Services
{
   public  class NavigateWithParamService<TParameter>
    {
        private readonly NavigationStore _navigationStore;

        private readonly Func<TParameter, ViewModelBase> _createViewModel;

        public NavigateWithParamService(NavigationStore navigationStore, Func<TParameter, ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}
