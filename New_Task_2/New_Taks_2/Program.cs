using System;

namespace New_Taks_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    *    Welcome to my Milk Factory   *   ");

            Console.WriteLine();
            Console.Write("You are right Adress! We have delicios Milk \n");
            Console.Write("Remember! You have 60$ dollars \n");
            int quantity = 50;
            int userBudget = 60;

            Product product = new Product("Milk", 120, 50, 600);

            product.Name = "Milk";
            product.Count = 120;
            product.Price = 50;
            product.TotalIncome = 600;
            quantity = product.Price;

            Console.WriteLine();
            Milk.Volume();
            Milk.FatRate();
            Product.Sell();

            Console.WriteLine("******************");
            
            while(quantity!= -1)
            {
                Console.WriteLine("Please write quantity");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < userBudget)
                {
                    
                    Console.WriteLine("Factory budget: " + (quantity + product.TotalIncome) + "$");
                    Console.WriteLine("User budget: " + (userBudget - quantity) + "$");
                    Console.WriteLine("Milk quantity: " + (product.Count - quantity) + "L");
                    Console.WriteLine("Bon appetite :) Have nice day");
                    break;
                }

                else if (quantity == userBudget)
                {
                    
                    Console.WriteLine("Factory budget: " + (quantity + product.TotalIncome) + "$");
                    Console.WriteLine("User budget: " + (userBudget - quantity) + "$");
                    Console.WriteLine("Milk quantity: " + (product.Count - quantity) + "L");
                    Console.WriteLine("Bon appetite :) Have nice day");
                    break;
                }
                else if(quantity >= userBudget)
                {
                    Console.WriteLine("Sorry, you have not enough money");
                    Console.WriteLine("Factory budget: " + product.TotalIncome + "$");
                    Console.WriteLine("User budget: " + userBudget + "$");
                    Console.WriteLine("Milk quantity: " + product.Count + "L");
                    break;
                }

            }

        }
    }
}
