using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.Commands;

namespace User.Commands.BuyerCommands
{
    //NAVIGATE TO BUYER SETTINGS COMMAND

    class NavigateSettingsCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateSettingsCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.BuyerViewModels.Settings_ViewModel(_navigationStore);
        }
    }
}
