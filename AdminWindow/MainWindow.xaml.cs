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
        User user;
        ObservableCollection<Carrier> carriers;

        public MainWindow()
        {
            InitializeComponent();

            user = new User("planner");
             carriers = user.Carriers;
            DG1.DataContext = carriers;
        }

        private void DG1_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            carriers[carriers.Count - 1].CarrierID = 5;
        }
    }
}
