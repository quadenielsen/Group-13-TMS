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
        volatile bool addingNewRow = false;
        public SelectDirectory_View()
        {
            InitializeComponent();

            Logger.ClearLog();
            try
            {
                admin = new Admin();
                carriers = admin.Carriers;
                depots = admin.Depots;
                Carriers.DataContext = carriers;

            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
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

                    admin.UpdateCarrierData();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
        }



        private void Carriers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Carrier test = new Carrier();
            try
            {
                if (Carriers.SelectedItem.GetType() == test.GetType() && Carriers.SelectedItem != null && addingNewRow == false)
                {
                    Carrier currentCarrier = (Carrier)Carriers.SelectedItem;
                    Depots.DataContext = currentCarrier.Depots;

                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }

        }

        private void Depots_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

        }

        private void Depots_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {
            Depot depot = (Depot)e.NewItem;
            Carrier carrier = (Carrier)Carriers.SelectedItem;
            depot.CarrierName = carrier.CarrierName;
        }
    }
}
