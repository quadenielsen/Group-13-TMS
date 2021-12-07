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

namespace User.Views.PlannerViews
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
        private void home_MouseEnter(object sender, MouseEventArgs e)
        {
            home.Foreground = Brushes.Black;
        }

        private void home_MouseLeave(object sender, MouseEventArgs e)
        {
            home.Foreground = Brushes.White;
        }

        private void carrier_MouseEnter(object sender, MouseEventArgs e)
        {
            carrier.Foreground = Brushes.Black;
        }

        private void carrier_MouseLeave(object sender, MouseEventArgs e)
        {
            carrier.Foreground = Brushes.White;
        }

        private void settingsGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            User.ViewModels.Main_ViewModel a = Window.GetWindow(this).DataContext as User.ViewModels.Main_ViewModel;
            if ((string)userid.Content == string.Empty)
            {
                userid.Content = "USERID: " + a.username;
            }

            if ((string)password.Content == string.Empty)
            {
                password.Content = "PASSWORD: " + a.password;
            }
        }
    }
}
