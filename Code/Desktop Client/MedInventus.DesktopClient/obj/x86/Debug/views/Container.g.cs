﻿#pragma checksum "..\..\..\..\views\Container.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EA72AEAF549193318890000BD2269ECE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
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


namespace agkik.desktopclient.views {
    
    
    /// <summary>
    /// Container
    /// </summary>
    public partial class Container : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 104 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnManageBankAccount;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonShowInvoice;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonInventory;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonCustomer;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonReports;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonUserProfile;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnManage;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton buttonLogout;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\..\views\Container.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmContent;
        
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
            System.Uri resourceLocater = new System.Uri("/agkik.desktopclient;component/views/container.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\Container.xaml"
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
            
            #line 4 "..\..\..\..\views\Container.xaml"
            ((agkik.desktopclient.views.Container)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnManageBankAccount = ((System.Windows.Controls.RadioButton)(target));
            
            #line 104 "..\..\..\..\views\Container.xaml"
            this.btnManageBankAccount.Checked += new System.Windows.RoutedEventHandler(this.btnManageBankAccount_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonShowInvoice = ((System.Windows.Controls.RadioButton)(target));
            
            #line 116 "..\..\..\..\views\Container.xaml"
            this.buttonShowInvoice.Checked += new System.Windows.RoutedEventHandler(this.buttonShowInvoice_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonInventory = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.buttonCustomer = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.buttonReports = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.buttonUserProfile = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.btnManage = ((System.Windows.Controls.RadioButton)(target));
            
            #line 177 "..\..\..\..\views\Container.xaml"
            this.btnManage.Click += new System.Windows.RoutedEventHandler(this.btnManage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.buttonLogout = ((System.Windows.Controls.RadioButton)(target));
            
            #line 189 "..\..\..\..\views\Container.xaml"
            this.buttonLogout.Click += new System.Windows.RoutedEventHandler(this.buttonLogout_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.frmContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
