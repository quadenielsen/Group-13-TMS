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
    //HOME-VIEW MODEL FOR PLANNER
    class Home_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateSettingsCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Home_ViewModel(NavigationStore navigationStore)
        {
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateSettingsCommand = new Commands.PlannerCommands.NavigateSettingsCommand(navigationStore);
        }
    }
}
