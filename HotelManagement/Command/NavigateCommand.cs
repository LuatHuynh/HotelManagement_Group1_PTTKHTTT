using HotelManagement.Services;
using HotelManagement.Stores;
using HotelManagement.ViewModel;
using HotelManagement.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace HotelManagement.Command
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigateService _navigateService;

        public NavigateCommand(NavigateService navigateService)
        {
            _navigateService = navigateService;
        }

        public override void Execute(object? parameter)
        {
         
            _navigateService.Navigate();
        }
    }
}
