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

namespace User.Views.PlannerViews
{
    /// <summary>
    /// Interaction logic for Carrier_View.xaml
    /// </summary>
    public partial class Carrier_View : UserControl
    {
        Planner planner;
        ObservableCollection<Carrier> carriers;
        Logger logger = new Logger();
        
        public Carrier_View()
        {
            InitializeComponent();
            logger.Log("Program Started");

            try
            {
                planner = new Planner();
                carriers = planner.Carriers;
                PCarrier.DataContext = carriers;
                
            }
            catch (Exception ex)
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
            home.Foreground = Brushes.Black;
        }

        private void home_MouseLeave(object sender, MouseEventArgs e)
        {
            home.Foreground = Brushes.White;
        }
    }
}
