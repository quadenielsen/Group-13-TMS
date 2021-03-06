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
    //SETTINGS-VIEW MODEL FOR BUYER
    class Settings_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateContractCommand { get; }

        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Settings_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.BuyerCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateContractCommand = new Commands.BuyerCommands.NavigateContractCommand(navigationStore);
        }
    }
}
