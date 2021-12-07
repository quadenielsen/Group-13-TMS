using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using User.Commands;
using User.Stores;

namespace User.ViewModels.PlannerViewModels
{
    //CARRIER-VIEW MODEL FOR PLANNER
    class Carrier_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateSettingsCommand { get; }


        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Carrier_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.PlannerCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateSettingsCommand = new Commands.PlannerCommands.NavigateSettingsCommand(navigationStore);
        }
    }
}
