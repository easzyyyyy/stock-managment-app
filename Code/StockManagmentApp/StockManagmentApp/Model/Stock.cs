using System;
using System.Collections.Generic;
using System.Text;

namespace StockManagmentApp.Model
{
    class Stock
    {
        public int ID { get; init; }
        public Place Place { get; init; }
        public Product Product { get; init; }
        public int Amount { get; init; }
        public DateTime LastArrival { get; init; }
        public DateTime NextArrival { get; init; }
    }
}
