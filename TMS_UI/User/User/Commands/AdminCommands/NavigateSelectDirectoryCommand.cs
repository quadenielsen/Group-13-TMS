using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.Commands;

namespace User.Commands.AdminCommands
{
    //NAVIGATE TO ADMIN SELECT DIRECTORY COMMAND
    class NavigateSelectDirectoryCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateSelectDirectoryCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.AdminViewModels.SelectDirectory_ViewModel(_navigationStore);
        }
    }
}
