using StockManagmentApp.Models;
using System.Windows;
using MySql.Data;
using MySql.Data.MySqlClient;
using StockManagmentApp.ViewModels;
using System.Windows.Data;

// MySQL libraries added in references

namespace StockManagmentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Database.Open();

            InitializeComponent();

            DataContext = new StockListViewModel();
        }

        private void SeeStockListButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new StockListViewModel();
        }

        private void AddPlaceButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddPlaceViewModel();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddProductViewModel();
        }
    }
}
