﻿#pragma checksum "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA6BA406C34BDE0627723666D7EA6CE2558938CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Author;
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


namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Author {
    
    
    /// <summary>
    /// AddAuthor
    /// </summary>
    public partial class AddAuthor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuthorName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuthorSurname;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuthorDate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuthorDesc;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAuthorBTN;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projekt-Tomasz-Roznowski-BookCatalog;component/usercontrolpages/author/addauthor" +
                    ".xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AuthorName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AuthorSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AuthorDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AuthorDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddAuthorBTN = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\..\UserControlPages\Author\AddAuthor.xaml"
            this.AddAuthorBTN.Click += new System.Windows.RoutedEventHandler(this.AddAuthorBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

