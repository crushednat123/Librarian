﻿#pragma checksum "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7958A7BA2EC82A005ACD6CAB1DA4FD32370DB0B577B8652E57D5F30EBBFC279B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Pages.PageStudent.Pages;
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


namespace Library.Pages.PageStudent.Pages {
    
    
    /// <summary>
    /// DocumentElectroinkExtraditionPage
    /// </summary>
    public partial class DocumentElectroinkExtraditionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridDate;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DocumentViewer doc;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding btnPrint;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding btnCopy;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbId;
        
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
            System.Uri resourceLocater = new System.Uri("/Library;component/pages/pagestudent/pages/documentelectroinkextraditionpage.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
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
            
            #line 9 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
            ((Library.Pages.PageStudent.Pages.DocumentElectroinkExtraditionPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.gridDate = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.doc = ((System.Windows.Controls.DocumentViewer)(target));
            return;
            case 4:
            this.btnPrint = ((System.Windows.Input.CommandBinding)(target));
            
            #line 15 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
            this.btnPrint.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.btnPrint_CanExecute);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCopy = ((System.Windows.Input.CommandBinding)(target));
            
            #line 16 "..\..\..\..\..\Pages\PageStudent\Pages\DocumentElectroinkExtraditionPage.xaml"
            this.btnCopy.CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.btnCopy_CanExecute);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbId = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

