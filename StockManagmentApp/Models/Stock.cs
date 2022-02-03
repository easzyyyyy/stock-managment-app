using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Models
{
    class Stock
    {
        public int ID { get; init; }
        public Place Place { get; init; }
        public Product Product { get; init; }
        public int Amount { get; init; }
        public DateTime LastArrival { get; init; }
        public DateTime NextArrival { get; init; }

        public static List<Stock> List()
        {
            List<Stock> list = new List<Stock>();

            MySqlDataReader reader = Database.Command("SELECT * FROM Stocks INNER JOIN Places ON Stocks.id_place = Places.id_place INNER JOIN Products ON Stocks.id_product = Products.id_product;");

            while (reader.Read())
            {
                int id = reader.GetInt32(0);

                Place place = new Place(reader);
                Product product = new Product(reader);

                int amount = reader.GetInt32(3);
                DateTime lastArrival = reader.GetDateTime(4);
                DateTime nextArrival = reader.GetDateTime(5);

                list.Add(new Stock { ID = id, Place = place, Product = product, Amount = amount, LastArrival = lastArrival, NextArrival = nextArrival });
            }

            reader.Close();

            return list;
        }
    }
}
