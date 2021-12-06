﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using User.Stores;

namespace User.Commands
{
    //NAVIGATE TO LOGIN SCREEN COMMAND
    class NavigateLoginCommand : CommandBASE
    {
        //NAVIGATION STORE
        private readonly NavigationStore _navigationStore;

        //CONSTRUCTOR
        public NavigateLoginCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.Login_ViewModel(_navigationStore);
        }
    }
}
