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
        public static List<Product> List
        {
            get
            {
                List<Product> list = new List<Product>();

                MySqlDataReader reader = Database.Command("SELECT * FROM Products");

                while (reader.Read())
                {
                    list.Add(new Product { ID = reader.GetInt32(0), Type = reader.GetString(1), Name = reader.GetString(2), Price = reader.GetInt32(3) });
                }

                reader.Close();

                return list;
            }
        }

        public Product() {}

        public Product(MySqlDataReader reader)
        {
            ID = reader.GetInt32(13);
            Type = reader.GetString(14);
            Name = reader.GetString(15);
            Price = reader.GetInt32(16);
        }

        public void InsertInDatabase()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@type", Type));
            parameters.Add(new MySqlParameter("@name", Name));
            parameters.Add(new MySqlParameter("@price", Price));

            MySqlDataReader reader = Database.Command($"INSERT INTO Products VALUES (NULL, @type, @name, @price)", parameters);

            reader.Close();
        }
    }
}
