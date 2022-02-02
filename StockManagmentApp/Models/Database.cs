using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace StockManagmentApp.Models
{
    class Database
    {
        public MySqlConnection Connection = new MySqlConnection("server=localhost;database=stock_managment_app;user id=root;password=;");

        public void Open()
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

        public void Close()
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

        public MySqlDataReader Command(string commandText)
        {
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = commandText;

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
