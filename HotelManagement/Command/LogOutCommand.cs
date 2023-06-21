using HotelManagement.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagement.Command
{
    public class LogOutCommand : CommandBase
    {
    
        private readonly AdminHomeScreenViewModel _adminHomeScreenViewModel;

        public LogOutCommand( AdminHomeScreenViewModel adminHomeScreenViewModel)
        {
      
            _adminHomeScreenViewModel = adminHomeScreenViewModel;
            //_adminHomeScreenViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        //private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        //{
        //    if(e.PropertyName== nameof(AdminHomeScreenViewModel.Username))
        //    {
        //        OnCanExcuteChanged();
        //    }
        //}

        //public override bool CanExecute(object? parameter)
        //{
        //    return !String.IsNullOrEmpty(_adminHomeScreenViewModel.Username);
        //}

        public override void Execute(object? parameter)
        {
            MessageBox.Show(_adminHomeScreenViewModel.Username);
        }
 
    }
}
