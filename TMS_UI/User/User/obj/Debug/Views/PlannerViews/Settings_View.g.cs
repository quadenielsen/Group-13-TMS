﻿#pragma checksum "..\..\..\..\Views\PlannerViews\Settings_View.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B8E6FD4B81BCF7A338CB24E7D4F472F06F5BEC392D03FA847FAA00C1C16823A7"
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
using User.Views.PlannerViews;


namespace User.Views.PlannerViews {
    
    
    /// <summary>
    /// Settings_View
    /// </summary>
    public partial class Settings_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid settingsGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label password;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label role;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button home;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button carrier;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/User;component/views/plannerviews/settings_view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.settingsGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 11 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
            this.settingsGrid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.settingsGrid_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.userid = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.password = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.role = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.home = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
            this.home.MouseEnter += new System.Windows.Input.MouseEventHandler(this.home_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
            this.home.MouseLeave += new System.Windows.Input.MouseEventHandler(this.home_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.carrier = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
            this.carrier.MouseEnter += new System.Windows.Input.MouseEventHandler(this.carrier_MouseEnter);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\Views\PlannerViews\Settings_View.xaml"
            this.carrier.MouseLeave += new System.Windows.Input.MouseEventHandler(this.carrier_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
