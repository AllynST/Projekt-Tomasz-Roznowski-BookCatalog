﻿#pragma checksum "..\..\..\..\..\UserControlPages\User\EditUserData.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568DD5C5507278BD8A0B5225A965927B72032994"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.User;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.User {
    
    
    /// <summary>
    /// EditUserData
    /// </summary>
    public partial class EditUserData : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreatedBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditAccount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projekt-Tomasz-Roznowski-BookCatalog;component/usercontrolpages/user/edituserdat" +
                    "a.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UsernameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SurnameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CreatedBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.PasswordBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EditAccount = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\UserControlPages\User\EditUserData.xaml"
            this.EditAccount.Click += new System.Windows.RoutedEventHandler(this.EditAccount_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

