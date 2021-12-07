using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.Commands;

namespace User.Commands.BuyerCommands
{
    //NAVIGATE TO BUYER CONTRACT COMMAND
    class NavigateContractCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateContractCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.BuyerViewModels.Contract_ViewModel(_navigationStore);
        }
    }
}
