// Updated by XamlIntelliSenseFileGenerator 2021-12-07 11:49:41 AM
#pragma checksum "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC467E59A2018CF29A629D996230F6DB244CF955895B3E307C909254E23CE91F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using User.Views.AdminViews;


namespace User.Views.AdminViews
{


    /// <summary>
    /// SelectDirectory_View
    /// </summary>
    public partial class SelectDirectory_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 32 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;

#line default
#line hidden


#line 33 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settings;

#line default
#line hidden


#line 67 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Data_Editing_Tabs;

#line default
#line hidden


#line 70 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem CarrierData;

#line default
#line hidden


#line 86 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Carriers;

#line default
#line hidden


#line 95 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Depots;

#line default
#line hidden


#line 105 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem RouteTable;

#line default
#line hidden


#line 106 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Routes;

#line default
#line hidden


#line 122 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FilepathText;

#line default
#line hidden


#line 123 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogFileText;

#line default
#line hidden


#line 129 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate_Table;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/User;component/views/adminviews/selectdirectory_view.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Home = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.Home.MouseEnter += new System.Windows.Input.MouseEventHandler(this.home_MouseEnter);

#line default
#line hidden

#line 32 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.Home.MouseLeave += new System.Windows.Input.MouseEventHandler(this.home_MouseLeave);

#line default
#line hidden
                    return;
                case 2:
                    this.settings = ((System.Windows.Controls.Button)(target));

#line 33 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.settings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.settings_MouseEnter);

#line default
#line hidden

#line 33 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.settings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.settings_MouseLeave);

#line default
#line hidden
                    return;
                case 3:
                    this.Data_Editing_Tabs = ((System.Windows.Controls.TabControl)(target));
                    return;
                case 4:
                    this.CarrierData = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 5:
                    this.Carriers = ((System.Windows.Controls.DataGrid)(target));

#line 86 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.Carriers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Carriers_SelectionChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.Depots = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 7:
                    this.RouteTable = ((System.Windows.Controls.TabItem)(target));
                    return;
                case 8:
                    this.Routes = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 9:

#line 120 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChooseLoggerFilepath_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.FilepathText = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 11:
                    this.LogFileText = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 12:

#line 124 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewLogFile_Click);

#line default
#line hidden
                    return;
                case 13:
                    this.btnUpdate_Table = ((System.Windows.Controls.Button)(target));

#line 129 "..\..\..\..\Views\AdminViews\SelectDirectory_View.xaml"
                    this.btnUpdate_Table.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Table_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.RadioButton TMSbutton;
        internal System.Windows.Controls.RadioButton CMPbutton;
        internal System.Windows.Controls.TextBox IpText;
        internal System.Windows.Controls.TextBox PortText;
        internal System.Windows.Controls.Label Error;
        internal System.Windows.Controls.TextBox UsernameText;
        internal System.Windows.Controls.TextBox PasswordText;
    }
}

