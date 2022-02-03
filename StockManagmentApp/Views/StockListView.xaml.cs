using StockManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            StockListListView.ItemsSource = Stock.List;
            StockListScrollView.ScrollToBottom();

            PlaceComboBox.ItemsSource = Place.List;
            PlaceComboBox.SelectedItem = PlaceComboBox.Items[0];

            ProductComboBox.ItemsSource = Product.List;
            ProductComboBox.SelectedItem = ProductComboBox.Items[0];
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Name.Substring(0, textBox.Name.Length - 7))
            {
                textBox.Clear();
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == String.Empty)
            {
                textBox.Text = textBox.Name.Substring(0, textBox.Name.Length - 7);
            }
        }

        private void AddStockButton_Click(object sender, RoutedEventArgs e)
        {
            Place place = (Place)PlaceComboBox.SelectedItem;
            Product product = (Product)ProductComboBox.SelectedItem;

            bool amountIsParsable = int.TryParse(AmountTextBox.Text, out int amount);

            DateTime lastArrival = (DateTime)LastArrivalDatePicker.SelectedDate;
            DateTime nextArrival = (DateTime)NextArrivalDatePicker.SelectedDate;

            if (amountIsParsable)
            {
                Stock stock = new Stock { ID = 0, Place = place, Product = product, Amount = amount, LastArrival = lastArrival, NextArrival = nextArrival };
                stock.InsertInDatabase();

                Update();
            }
            else
            {
                MessageBox.Show("Don't even try, I've thought of everything.");
            }
        }
    }
}
