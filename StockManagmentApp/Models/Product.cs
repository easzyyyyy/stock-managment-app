using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Models
{
    class Product
    {
        public int ID { get; init; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(MySqlDataReader reader)
        {
            ID = reader.GetInt32(13);
            Type = reader.GetString(14);
            Name = reader.GetString(15);
            Price = reader.GetInt32(16);
        }

        public static List<Product> List()
        {
            List<Product> list = new List<Product>();

            MySqlDataReader reader = Database.Command("SELECT * FROM Products");

            while (reader.Read())
            {
                list.Add(new Product(reader));
            }

            reader.Close();

            return list;
        }
    }
}
