﻿using HotelManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Stores
{
   public class NavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { 
                _currentViewModel = value;
                OnCurentViewModelChanged();
            }
        }
        public event Action CurrentViewModelChanged;
        private void OnCurentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
