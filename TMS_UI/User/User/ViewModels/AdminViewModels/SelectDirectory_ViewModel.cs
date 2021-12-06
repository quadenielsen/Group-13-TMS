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
    //SELECTDIRECTORY-VIEW MODEL FOR ADMIN
    class SelectDirectory_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public SelectDirectory_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.AdminCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
        }
    }
}
