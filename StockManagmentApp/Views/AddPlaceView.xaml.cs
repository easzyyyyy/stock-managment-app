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
    /// Interaction logic for AddPlaceView.xaml
    /// </summary>
    public partial class AddPlaceView : UserControl
    {
        public AddPlaceView()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            AddPlaceListView.ItemsSource = Place.List;
            AddPlaceScrollView.ScrollToBottom();
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

        private void AddPlaceButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string address = AddressTextBox.Text;
            string country = CountryTextBox.Text;
            string city = CityTextBox.Text;

            bool areaIsParsable = int.TryParse(AreaTextBox.Text, out int area);
            bool priceIsParsable = int.TryParse(PriceTextBox.Text, out int price);

            if (areaIsParsable && priceIsParsable)
            {
                Place place = new Place { ID = 0, Name = name, Address = address, Country = country, City = city, Area = area, Price = price };
                place.InsertInDatabase();

                Update();
            }
            else
            {
                MessageBox.Show("Don't even try, I've thought of everything.");
            }
        }
    }
}
