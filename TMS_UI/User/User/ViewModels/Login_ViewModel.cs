using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using User.Commands;
using User.Stores;

namespace User.ViewModels
{
    //LOGIN-VIEW MODEL
    class Login_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateAdminHomeCommand { get; }
        public ICommand NavigateBuyerHomeCommand { get; }
        public ICommand NavigatePlannerHomeCommand { get; }

        /* Command to navigate to ADMIN/BUYER/PLANNER based on login credentials on login scren */
        public ICommand NavigateUserHomeCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Login_ViewModel(NavigationStore navigationStore)
        {
            NavigateAdminHomeCommand = new Commands.AdminCommands.NavigateHomeCommand(navigationStore);
            NavigateBuyerHomeCommand = new Commands.BuyerCommands.NavigateHomeCommand(navigationStore);
            NavigatePlannerHomeCommand = new Commands.PlannerCommands.NavigateHomeCommand(navigationStore);
        }
    }
}
