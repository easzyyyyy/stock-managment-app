using StockManagmentApp.Models;
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
    /// Interaction logic for AddProductView.xaml
    /// </summary>
    public partial class AddProductView : UserControl
    {
        public AddProductView()
        {
            InitializeComponent();
            Update();
        }

        private void Update()
        {
            AddProductListView.ItemsSource = Product.List;
            AddProductScrollView.ScrollToBottom();
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

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string type = TypeTextBox.Text;
            string name = NameTextBox.Text;

            bool priceIsParsable = int.TryParse(PriceTextBox.Text, out int price);

            if (priceIsParsable)
            {
                Product product = new Product { ID = 0, Type = type, Name = name, Price = price };
                product.InsertInDatabase();

                Update();
            }
            else
            {
                MessageBox.Show("Don't even try, I've thought of everything.");
            }
        }
    }
}
