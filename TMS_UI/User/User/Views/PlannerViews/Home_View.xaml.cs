﻿using System;
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
    /// Interaction logic for Home_View.xaml
    /// </summary>
    public partial class Home_View : UserControl
    {
        public Home_View()
        {
            InitializeComponent();
        }
        private void settings_MouseEnter(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.Black;
        }

        private void settings_MouseLeave(object sender, MouseEventArgs e)
        {
            settings.Foreground = Brushes.White;
        }
        private void carrier_MouseEnter(object sender, MouseEventArgs e)
        {
            carrier.Foreground = Brushes.Black;
        }

        private void carrier_MouseLeave(object sender, MouseEventArgs e)
        {
            carrier.Foreground = Brushes.White;
        }

        private void settings_Click()
        {

        }
    }
}
