using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace StockManagmentApp.Models
{
    static class Database
    {
        public static MySqlConnection Connection = new MySqlConnection("server=localhost;database=stock_managment_app;user id=root;password=;");

        public static void Open()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
        }

        public static void Close()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }
        }

        public static MySqlDataReader Command(string commandText, List<MySqlParameter> parameters = null)
        {
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = commandText;

            if (parameters != null)
            {
                foreach (MySqlParameter p in parameters)
                {
                    command.Parameters.Add(p);
                }
            }

            MySqlDataReader result = null;

            try
            {
                result = command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(0);
            }

            return result;
        }
    }
}
