﻿#pragma checksum "..\..\..\..\Views\BuyerViews\Home_View.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E00D71123BD1FA52A2E94B445C4233F32FFFD5BD8153BFB08213B31DC890CDC"
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
using User.Views.BuyerViews;


namespace User.Views.BuyerViews {
    
    
    /// <summary>
    /// Home_View
    /// </summary>
    public partial class Home_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button contract;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button settings;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox customerContracts;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button getContractsBtn;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox completedorders;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button geninvoceBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/User;component/views/buyerviews/home_view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
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
            this.contract = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
            this.contract.MouseEnter += new System.Windows.Input.MouseEventHandler(this.contract_MouseEnter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
            this.contract.MouseLeave += new System.Windows.Input.MouseEventHandler(this.contract_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.settings = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
            this.settings.MouseEnter += new System.Windows.Input.MouseEventHandler(this.settings_MouseEnter);
            
            #line default
            #line hidden
            
            #line 34 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
            this.settings.MouseLeave += new System.Windows.Input.MouseEventHandler(this.settings_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.customerContracts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.getContractsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\Views\BuyerViews\Home_View.xaml"
            this.getContractsBtn.Click += new System.Windows.RoutedEventHandler(this.getContractsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.completedorders = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.geninvoceBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

