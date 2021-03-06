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

using User.Users.Maintenance;
using SQLConnectorLibrary;

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
                User.ViewModels.Main_ViewModel a = Window.GetWindow(this).DataContext as User.ViewModels.Main_ViewModel;
                a.username = userNameTB.Text;
                a.password = passWordTB.Text;

                SQLConnector connector = new SQLConnector("localhost", "OMNI_TMS_13", "root", "justin19987"); 
                List<List<string>> retrivedData = null;
                bool b = connector.RetrieveFromColumns("systemUser", "username, userPassword, userRole", out retrivedData);

                bool checkUsername = false;
                bool checkPassword = false;
                //int index;
                foreach(string username in retrivedData[0])
                {
                    if (username == a.username)
                    {
                        checkUsername = true;
                        if (a.password == retrivedData[1][retrivedData[0].IndexOf(username)])
                        {
                            checkPassword = true;
                        }
                    }
                }


                if(checkPassword && checkUsername)
                {
                    if(retrivedData[2][retrivedData[0].IndexOf(a.username)] == "admin")
                    {
                        command = new User.Commands.AdminCommands.NavigateHomeCommand(a._navigationStore);
                    }
                    else if (retrivedData[2][retrivedData[0].IndexOf(a.username)] == "buyer")
                    {
                        command = new User.Commands.BuyerCommands.NavigateHomeCommand(a._navigationStore);
                    }
                    else if (retrivedData[2][retrivedData[0].IndexOf(a.username)] == "planner")
                    {
                        command = new User.Commands.PlannerCommands.NavigateHomeCommand(a._navigationStore);
                    }
                    submitBtn.Command = command;
                }
                else
                {
                    if (failedLogin == false)
                    {
                        command = submitBtn.Command;
                        failedLogin = true;
                    }
                    submitBtn.Command = null;
                    MessageBox.Show("UserName and password do not match");
                    userNameTB.Clear();
                    passWordTB.Clear();
                }
            }
        }
    }
}
