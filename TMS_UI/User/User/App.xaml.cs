using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using User.ViewModels;
using User.Stores;

namespace User
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
            
            // Initial VIEW and VIEW MODEL is LOGIN screen
            navigationStore.CurrentViewModel = new Login_ViewModel(navigationStore);

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new Main_ViewModel(navigationStore)
            };
            mainWindow.Title = "TMS";
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
