﻿using StockManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockManagmentApp.Views
{
    /// <summary>
    /// Interaction logic for StockListView.xaml
    /// </summary>
    public partial class StockListView : UserControl
    {
        public StockListView()
        {
            Database database = new Database();
            database.Open();

            InitializeComponent();
            DisplayStockList(database);

            database.Close();
        }
        private void DisplayStockList(Database database)
        {
            StockList.Read(database);
            StockListListView.ItemsSource = StockList.List;
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Clear();
        }
    }
}
