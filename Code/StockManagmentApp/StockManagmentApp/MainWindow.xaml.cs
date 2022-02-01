using StockManagmentApp.Model;
using System.Windows;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            Database database = new Database();
            database.Open();

            InitializeComponent();
            DisplayStockList(database);
        }

        private void DisplayStockList(Database database)
        {
            StockList.Read(database);
            StockListView.ItemsSource = StockList.List;
        }
    }
}
