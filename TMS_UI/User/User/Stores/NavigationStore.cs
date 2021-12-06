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
