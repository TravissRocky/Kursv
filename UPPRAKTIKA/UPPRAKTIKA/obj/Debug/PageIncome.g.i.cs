﻿#pragma checksum "..\..\PageIncome.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4D6348D127162BD291343C399EFA776C8F58859D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using UPPRAKTIKA;
using UPPRAKTIKA.Commands;
using UPPRAKTIKA.Model;
using UPPRAKTIKA.ValidationRules;


namespace UPPRAKTIKA {
    
    
    /// <summary>
    /// PageIncome
    /// </summary>
    public partial class PageIncome : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 89 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar ToolBar1;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Undo;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Find;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar ToolBar2;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame BorderFind;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\PageIncome.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridFind;
        
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
            System.Uri resourceLocater = new System.Uri("/UPPRAKTIKA;component/pageincome.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageIncome.xaml"
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
            
            #line 12 "..\..\PageIncome.xaml"
            ((UPPRAKTIKA.PageIncome)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 40 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.UndoCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 41 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.UndoCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 45 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.EditCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 46 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.EditCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.FindCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 49 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.FindCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 53 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.SaveCommandBinding_CanExecute);
            
            #line default
            #line hidden
            
            #line 54 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 56 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.DeleteCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 57 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.DeleteCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 59 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommandBinding_Executed);
            
            #line default
            #line hidden
            
            #line 60 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.NewCommandBinding_CanExecute);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 63 "..\..\PageIncome.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.RefreshCommandBinding_Executed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ToolBar1 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 10:
            this.Undo = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.Add = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.Edit = ((System.Windows.Controls.Button)(target));
            return;
            case 13:
            this.Find = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.Save = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.Delete = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.ToolBar2 = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 17:
            this.DataGridEmployee = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 18:
            this.BorderFind = ((System.Windows.Controls.Frame)(target));
            return;
            case 19:
            this.gridFind = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

