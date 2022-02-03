﻿#pragma checksum "..\..\..\..\Views\AddPlaceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27BA1EEC098E7DCE88DFF63223F69DA7A731C834"
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
    /// AddPlaceView
    /// </summary>
    public partial class AddPlaceView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer StockListScrollView;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView StockListListView;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PlaceFormGrid;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountryTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityTextBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AreaTextBox;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\AddPlaceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPlaceButton;
        
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
            System.Uri resourceLocater = new System.Uri("/StockManagmentApp;component/views/addplaceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddPlaceView.xaml"
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
            this.PlaceFormGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\Views\AddPlaceView.xaml"
            this.NameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\..\Views\AddPlaceView.xaml"
            this.NameTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddressTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\Views\AddPlaceView.xaml"
            this.AddressTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\..\Views\AddPlaceView.xaml"
            this.AddressTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CountryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\Views\AddPlaceView.xaml"
            this.CountryTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\..\Views\AddPlaceView.xaml"
            this.CountryTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CityTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 72 "..\..\..\..\Views\AddPlaceView.xaml"
            this.CityTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\..\Views\AddPlaceView.xaml"
            this.CityTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AreaTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\..\Views\AddPlaceView.xaml"
            this.AreaTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\Views\AddPlaceView.xaml"
            this.AreaTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\..\Views\AddPlaceView.xaml"
            this.PriceTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 74 "..\..\..\..\Views\AddPlaceView.xaml"
            this.PriceTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddPlaceButton = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\Views\AddPlaceView.xaml"
            this.AddPlaceButton.Click += new System.Windows.RoutedEventHandler(this.AddPlaceButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

