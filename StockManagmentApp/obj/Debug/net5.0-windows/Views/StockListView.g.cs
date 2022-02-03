﻿#pragma checksum "..\..\..\..\Views\StockListView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACDB9670E283E1B5BCAC1BD31AE55F027EEC0B6D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StockManagmentApp.ViewModels;
using StockManagmentApp.Views;
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


namespace StockManagmentApp.Views {
    
    
    /// <summary>
    /// StockListView
    /// </summary>
    public partial class StockListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer StockListScrollView;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StockListListView;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid StockFormGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PlaceComboBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ProductComboBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker LastArrivalDatePicker;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker NextArrivalDatePicker;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Views\StockListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStockButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StockManagmentApp;component/views/stocklistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\StockListView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.StockListScrollView = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.StockListListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.StockFormGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.PlaceComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ProductComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AmountTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 82 "..\..\..\..\Views\StockListView.xaml"
            this.AmountTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\..\Views\StockListView.xaml"
            this.AmountTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LastArrivalDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.NextArrivalDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.AddStockButton = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\Views\StockListView.xaml"
            this.AddStockButton.Click += new System.Windows.RoutedEventHandler(this.AddStockButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

