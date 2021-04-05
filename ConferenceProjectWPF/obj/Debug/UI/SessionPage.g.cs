﻿#pragma checksum "..\..\..\UI\SessionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "474D82DAD2965449D3C448B202A7305D8C46985D683813A1384E5ED8742AB45C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ConferenceProjectWPF.UI;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace ConferenceProjectWPF.UI {
    
    
    /// <summary>
    /// SessionPage
    /// </summary>
    public partial class SessionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 56 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid sessionGrid;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost MyDialogHost;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 245 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 290 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost deletePopUp;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost createDialogHost;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 370 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newPhoneTextBox;
        
        #line default
        #line hidden
        
        
        #line 383 "..\..\..\UI\SessionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newEmailTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ConferenceProjectWPF;component/ui/sessionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\SessionPage.xaml"
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
            
            #line 48 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_open_createTimeSlot);
            
            #line default
            #line hidden
            return;
            case 2:
            this.sessionGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.MyDialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 6:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 269 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_confirm_edit);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 274 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_cancel_edit);
            
            #line default
            #line hidden
            return;
            case 11:
            this.deletePopUp = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 12:
            
            #line 310 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_confirm_delete);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 317 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_cancel_delete);
            
            #line default
            #line hidden
            return;
            case 14:
            this.createDialogHost = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 15:
            this.newNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.newPhoneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.newEmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            
            #line 411 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_confirm_creation);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 417 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_cancel_creation);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 147 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_open_edit);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 171 "..\..\..\UI\SessionPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_open_delete);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

