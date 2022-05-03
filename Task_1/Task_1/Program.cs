using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Extension> sentence = new List<Extension>();

            string word = "Bu bir custom contains methodudur.";

            bool result = sentence.Contains("custom");

            if (result == true)
            {
                Console.WriteLine(true);
            }

            Console.WriteLine(result);

        }
    }
}
