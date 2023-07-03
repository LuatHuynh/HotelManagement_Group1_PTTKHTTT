using HotelManagement.Entities;
using HotelManagement.Model;
using HotelManagement.Services;
using HotelManagement.ViewModel;
using HotelManagement.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Command
{
    class EditRegulationCommand : CommandBase
    {
        private readonly NavigateWithParamService<RegulationModel> navigateWithParamService;
        private readonly AdminViewRegulationModel viewModelBase;
        public EditRegulationCommand(NavigateWithParamService<RegulationModel> navigateWithParamService)
        {
            this.navigateWithParamService = navigateWithParamService;
           
        }

        public override void Execute(object? parameter)
        { 
            navigateWithParamService.Navigate((RegulationModel)parameter);
        }
      
    }
}
