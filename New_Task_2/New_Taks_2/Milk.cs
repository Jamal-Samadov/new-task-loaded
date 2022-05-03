using System;
using System.Collections.Generic;
using System.Text;

namespace New_Taks_2
{
    internal class Milk: Product
    {
        public Milk(string name, int price, int count, int totalincome) : base(name, price, count, totalincome)
        {
        }

        public static void Volume()
        {
            Console.WriteLine("Volume: We have 120 liters of milk ");
        }


        public static void FatRate()
        {
            Console.WriteLine("Fatrate: The fat content of milk is moderate \n");
        }

    }

}
