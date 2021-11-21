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
using ConnectToDatabase;
using UserClasses;

namespace AdminWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConnectToDatabase.Admin admin;
        ObservableCollection<Carrier> carriers;

        public MainWindow()
        {
            InitializeComponent();

            admin = new ConnectToDatabase.Admin();
            carriers = admin.Carriers;
            DG1.DataContext = carriers;
        }

        private void btnUpdate_Table_Click(object sender, RoutedEventArgs e)
        {
            if (CarrierData.IsSelected == true)
            {
                
            }
        }
    }
}
