using System;
using System.Collections.Generic;
using System.Text;

namespace New_Taks_2
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalIncome { get; set; }

        public Product(string name, int price, int count, int totalincome)
        {
            name = Name;
            price = Price;
            count = Count;
            totalincome = TotalIncome;

        }

        public static void Sell()
        {
            Console.WriteLine("How many liters of milk do you want? \n");
        }

    }
}
