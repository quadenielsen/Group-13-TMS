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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace User.Views.AdminViews
{
    /// <summary>
    /// Interaction logic for Settings_View.xaml
    /// </summary>
    public partial class Settings_View : UserControl
    {
        public Settings_View()
        {
            InitializeComponent();
        }
        private void datatables_MouseEnter(object sender, MouseEventArgs e)
        {
            datatables.Foreground = Brushes.Black;
        }

        private void datatables_MouseLeave(object sender, MouseEventArgs e)
        {
            datatables.Foreground = Brushes.White;
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
