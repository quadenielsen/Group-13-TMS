using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace User
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {

        private TMSUser tmsuser;
        private ObservableCollection<Carrier> carriers;

        public AdminWindow()
        {
            InitializeComponent();

            tmsuser = new TMSUser("admin");
            carriers = tmsuser.Carriers;
            DG1.DataContext = carriers;
        }

        private void DG1_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
        }
    }
}