using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using User.Commands;
using User.Stores;

namespace User.ViewModels.PlannerViewModels
{
    class Settings_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Settings_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.PlannerCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
        }
    }
}
