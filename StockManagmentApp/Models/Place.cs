using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Models
{
    class Place
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public string Address { get; init; }
        public string Country { get; init; }
        public string City { get; init; }
        public int Area { get; init; }
        public int Price { get; init; }

        public Place()
        {

        }

        public Place(MySqlDataReader reader)
        {
            ID = reader.GetInt32(6);
            Name = reader.GetString(7);
            Address = reader.GetString(8);
            Country = reader.GetString(9);
            City = reader.GetString(10);
            Area = reader.GetInt32(11);
            Price = reader.GetInt32(12);
        }

        public static List<Place> List()
        {
            List<Place> list = new List<Place>();

            MySqlDataReader reader = Database.Command("SELECT * FROM Places");

            while (reader.Read())
            {
                list.Add(new Place { ID = reader.GetInt32(0), Name = reader.GetString(1), Address = reader.GetString(2), Country = reader.GetString(3), City = reader.GetString(4), Area = reader.GetInt32(5), Price = reader.GetInt32(6) });
            }

            reader.Close();

            return list;
        }

        public void InsertInDatabase()
        {
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@name", Name));
            parameters.Add(new MySqlParameter("@address", Address));
            parameters.Add(new MySqlParameter("@country", Country));
            parameters.Add(new MySqlParameter("@city", City));
            parameters.Add(new MySqlParameter("@area", Area));
            parameters.Add(new MySqlParameter("@price", Price));

            MySqlDataReader reader = Database.Command($"INSERT INTO Places VALUES (NULL, @name, @address, @country, @city, @area, @price)", parameters);

            reader.Close();
        }
    }
}
