using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

using User.Commands;
using User.Stores;

namespace User.ViewModels.BuyerViewModels
{
    //CONTRACT-VIEW MODEL FOR BUYER
    class Contract_ViewModel : ViewModelBASE
    {
        //----------------------------------- COMMANDS --------------------------------------------
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigateSettingsCommand { get; }


        //----------------------------------- CONSTRUCTOR --------------------------------------------
        public Contract_ViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new Commands.BuyerCommands.NavigateHomeCommand(navigationStore);
            NavigateLoginCommand = new Commands.NavigateLoginCommand(navigationStore);
            NavigateSettingsCommand = new Commands.BuyerCommands.NavigateSettingsCommand(navigationStore);
        }
    }
}
