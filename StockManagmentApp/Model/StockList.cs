using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Model
{
    static class StockList
    {
        public static List<Stock> List = new List<Stock>();

        public static void Read(Database database)
        {
            MySqlDataReader reader = database.Command("SELECT * FROM Stocks INNER JOIN Places ON Stocks.id_place = Places.id_place INNER JOIN Products ON Stocks.id_product = Products.id_product;");

            while (reader.Read())
            {
                int id = reader.GetInt32(0);

                Place place = new Place(reader);
                Product product = new Product(reader);

                int amount = reader.GetInt32(3);
                DateTime lastArrival = reader.GetDateTime(4);
                DateTime nextArrival = reader.GetDateTime(5);

                List.Add(new Stock { ID = id, Place = place, Product = product, Amount = amount, LastArrival = lastArrival, NextArrival = nextArrival });
            }
        }
    }
}
