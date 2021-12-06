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
    //HOME-VIEW MODEL FOR ADMIN
    class Home_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateSelectDirectoryCommand { get; }
        public ICommand NavigateSettingsCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Home_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.AdminCommands.NavigateHomeCommand(navigationStore);
            NavigateSelectDirectoryCommand = new Commands.AdminCommands.NavigateSelectDirectoryCommand(navigationStore);
            NavigateSettingsCommand = new Commands.AdminCommands.NavigateSettingsCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
        }
    }
}
