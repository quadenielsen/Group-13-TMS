using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TMSObjectLibrary;
using TMSUserLibrary;
using SQLConnectorLibrary;
using System.Configuration;
using System.IO;
using Microsoft.Win32;

namespace User.Views.BuyerViews
{
    
    
    /// <summary>
    /// Interaction logic for Contract_View.xaml
    /// </summary>
    public partial class Contract_View : UserControl
    {
        Buyer buyer;
        ObservableCollection<Contract> contracts;
        Logger logger = new Logger();
        public Contract_View()
        {
            InitializeComponent();
            try
            {
                buyer = new Buyer();
                contracts = buyer.Contracts;
                Contracts.DataContext = contracts;
            }
            catch(Exception ex)
            {
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }
        }

        private void settings_MouseEnter(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.Black;
        }

        private void settings_MouseLeave(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.White;
        }

        private void home_MouseEnter(object sender, MouseEventArgs e)
        {
            Home.Foreground = Brushes.Black;
        }

        private void home_MouseLeave(object sender, MouseEventArgs e)
        {
            Home.Foreground = Brushes.White;
        }
    }
}
