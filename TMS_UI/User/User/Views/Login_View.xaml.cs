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
using System.Windows.Input;

using User.Users.Maintenance;

namespace User.Views
{
    /// <summary>
    /// Interaction logic for Login_View.xaml
    /// </summary>
    public partial class Login_View : UserControl
    {
        public ICommand command;
        public bool failedLogin = false;
        public Login_View()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = Window.GetWindow(this);
            myWindow.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool status = ValidateUser.ValidateCredentials(userNameTB.Text, passWordTB.Text);
            if(status == false)
            {
                if(failedLogin == false)
                {
                    command = submitBtn.Command;
                    failedLogin = true;
                }
                submitBtn.Command = null;
                MessageBox.Show("That is an invalid pair of Credentials");
                userNameTB.Clear();
                passWordTB.Clear();
            }
            else
            {
                if(failedLogin == true)
                {
                    submitBtn.Command = command;
                }
                //SQL function here

            }
        }
    }
}
