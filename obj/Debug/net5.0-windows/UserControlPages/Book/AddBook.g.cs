#pragma checksum "..\..\..\..\..\UserControlPages\Book\AddBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A39D27EA24698127DC8B9302D9DD793E4F4BEA64"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book;
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


namespace Projekt_Tomasz_Roznowski_BookCatalog.UserControlPages.Book {
    
    
    /// <summary>
    /// AddBook
    /// </summary>
    public partial class AddBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookTitle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BookGenre;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BookAuthor;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookLang;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BookFormat;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookDesc;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBookBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Projekt-Tomasz-Roznowski-BookCatalog;component/usercontrolpages/book/addbook.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
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
            this.BookTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BookGenre = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.BookAuthor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.BookLang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BookFormat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BookDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddBookBTN = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\UserControlPages\Book\AddBook.xaml"
            this.AddBookBTN.Click += new System.Windows.RoutedEventHandler(this.AddBookBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

