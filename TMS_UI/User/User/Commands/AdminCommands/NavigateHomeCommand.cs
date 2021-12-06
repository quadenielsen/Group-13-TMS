﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;
using User.ViewModels;

namespace User.Commands.AdminCommands
{
    //NAVIGATE TO ADMIN HOME COMMAND
    class NavigateHomeCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateHomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.AdminViewModels.Home_ViewModel(_navigationStore);
        }
    }
}
