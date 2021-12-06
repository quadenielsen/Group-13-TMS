using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;

namespace User.ViewModels
{
    //MAIN-VIEW MODEL
    class Main_ViewModel : ViewModelBASE
    {
        //----------------------------------- NAVIGATION STORE --------------------------------------------
        private readonly NavigationStore _navigationStore;

        public ViewModelBASE CurrentViewModel => _navigationStore.CurrentViewModel;

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Main_ViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        //----------------------------------- ON-CURRENT VIEW MODEL CHANGED EVENT --------------------------------------------
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
