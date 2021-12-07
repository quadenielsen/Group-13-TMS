using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using User.Commands;
using User.Stores;

namespace User.ViewModels.BuyerViewModels
{
    //HOME-VIEW MODEL FOR BUYER
    class Home_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateSettingsCommand { get; }
        public ICommand NavigateContractCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Home_ViewModel(NavigationStore navigationStore)
        {
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateSettingsCommand = new Commands.BuyerCommands.NavigateSettingsCommand(navigationStore);
            NavigateContractCommand = new Commands.BuyerCommands.NavigateContractCommand(navigationStore);
        }
    }
}
