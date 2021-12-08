//
// FILE          : NavigationStore.csd
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the NavigationStore class
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.ViewModels;

namespace User.Stores
{
    class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBASE _currentViewModel;
        public ViewModelBASE CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        // CURRENT VIEW MODEL AND VIEW CHANGED EVENT
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
