using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.ViewModels;

namespace User.Commands.BuyerCommands
{
    //NAVIGATE TO BUYER HOME COMMAND
    class NavigateHomeCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateHomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.BuyerViewModels.Home_ViewModel(_navigationStore);
        }
    }
}
