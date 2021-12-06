using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using User.Commands;
using User.Stores;

namespace User.ViewModels.AdminViewModels
{
    //SETTINGS-VIEW MODEL FOR ADMIN
    class Settings_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateSelectDirectoryCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Settings_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.AdminCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateSelectDirectoryCommand = new Commands.AdminCommands.NavigateSelectDirectoryCommand(navigationStore);
        }
    }
}
