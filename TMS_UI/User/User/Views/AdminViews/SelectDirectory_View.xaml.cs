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

namespace User.Views.AdminViews
{
    /// <summary>
    /// Interaction logic for SelectDirectory_View.xaml
    /// </summary>
    public partial class SelectDirectory_View : UserControl
    {
        Admin admin;
        ObservableCollection<Carrier> carriers;
        ObservableCollection<Depot> depots;
        ObservableCollection<City> cities;
        Logger logger = new Logger();

        public SelectDirectory_View()
        {
            InitializeComponent();
            logger.Log("Program Started");

            try
            {
                admin = new Admin();
                carriers = admin.Carriers;
                depots = admin.Depots;
                cities = admin.Cities;
                Carriers.DataContext = carriers;
                Routes.DataContext = cities;

            }
            catch (Exception ex)
            {
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }

        }



        private void btnUpdate_Table_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CarrierData.IsSelected == true)
                {
                    admin.Carriers = carriers;
                    admin.Depots = depots;
                    string status;
                    status = admin.UpdateCarrierData();
                    Status.Text = status;
                }

            }
            catch (Exception ex)
            {
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }
        }




        private void Carriers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Carrier test = new Carrier();
            try
            {
                if (Carriers.SelectedItem.GetType() == test.GetType() && Carriers.SelectedItem != null)
                {
                    Carrier currentCarrier = (Carrier)Carriers.SelectedItem;
                    Depots.DataContext = currentCarrier.Depots;

                }
            }
            catch (Exception ex)
            {
                logger.Log(ex.Message + ex.StackTrace + ex.TargetSite + ex.Source);
            }
        }



        private void Depots_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {
            Depot depot = (Depot)e.NewItem;
            Carrier carrier = (Carrier)Carriers.SelectedItem;
            depot.CarrierName = carrier.CarrierName;
            Depots.CurrentItem = depot;
        }



        private void ChooseLoggerFilepath_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                string filepath = ofd.FileName;       //Get Filepath chosen by user
                logger.ChangeFilepath(filepath);       //Change Filepath of logger
                logger.Log("Logger Filepath changed.");

                //Show filepath of Log File in Textbox
                FilepathText.Text = filepath;

                // Show contents of Log File in Textbox
                LogFileText.Text = File.ReadAllText(filepath);

                //Change app config settings
                AppConfigClass.SetAppConfig("logpath", filepath);

            }

        }

        private void ViewLogFile_Click(object sender, RoutedEventArgs e)
        {
            // Get the current filepath for the logger and display contents in textbox
            string filepath = logger.GetFilepath();

            //Show filepath of Log File in Textbox
            FilepathText.Text = filepath;

            // Show contents of Log File in Textbox
            LogFileText.Text = File.ReadAllText(filepath);
        }

        private void IpText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PortText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IpText.Text != "" && PortText.Text != "" && UsernameText.Text != "" && PasswordText.Text != "" && CMPbutton.IsChecked == true)
            {
                //Assuming data is valid, can add more validation later

                //Change app config settings
                AppConfigClass.SetAppConfig("CMPip", IpText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("CMPport", PortText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("CMPusername", UsernameText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("CMPpassword", PasswordText.Text);
            }


            if (IpText.Text != "" && PortText.Text != "" && UsernameText.Text != "" && PasswordText.Text != "" && TMSbutton.IsChecked == true)
            {
                //Assuming data is valid, can add more validation later

                //Change app config settings
                AppConfigClass.SetAppConfig("TMSip", IpText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("TMSport", PortText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("TMSusername", UsernameText.Text);

                //Change app config settings
                AppConfigClass.SetAppConfig("TMSpassword", PasswordText.Text);
            }

            //Error message if form not fully filled out
            else
            {
                Error.Visibility = Visibility.Visible;
            }
        }

        private void home_MouseEnter(object sender, MouseEventArgs e)
        {
            Home.Foreground = Brushes.Black;
        }

        private void home_MouseLeave(object sender, MouseEventArgs e)
        {
            Home.Foreground = Brushes.White;
        }

        private void settings_MouseEnter(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.Black;
        }

        private void settings_MouseLeave(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.White;
        }
    }
}
