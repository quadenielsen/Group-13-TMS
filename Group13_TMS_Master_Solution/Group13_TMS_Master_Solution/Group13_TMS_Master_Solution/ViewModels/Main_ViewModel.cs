//
// FILE          : Main_ViewModel.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains MainView_Model class
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Stores;

namespace User.ViewModels
{
    class Main_ViewModel : ViewModelBASE
    {
        private readonly NavigationStore _navigationStore;

        public ViewModelBASE CurrentViewModel => _navigationStore.CurrentViewModel;

        public Main_ViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
