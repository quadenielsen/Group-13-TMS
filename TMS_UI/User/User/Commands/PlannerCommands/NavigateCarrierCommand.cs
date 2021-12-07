using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.Commands;

namespace User.Commands.PlannerCommands
{
    //NAVIGATE TO BUYER CONTRACT COMMAND
    class NavigateCarrierCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateCarrierCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.PlannerViewModels.Carrier_ViewModel(_navigationStore);
        }
    }
}
