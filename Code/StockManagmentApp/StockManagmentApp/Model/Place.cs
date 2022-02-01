using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Model
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
    }
}
