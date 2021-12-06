using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.Commands;

namespace User.Commands.AdminCommands
{
    //NAVIGATE TO ADMIN SETTINGS COMMAND
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
            _navigationStore.CurrentViewModel = new ViewModels.AdminViewModels.Settings_ViewModel(_navigationStore);
        }
    }
}
