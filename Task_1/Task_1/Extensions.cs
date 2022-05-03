using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public static class Extensions
    {
        private static bool isLower;
        private static bool isDigit;
        private static bool isUpper;
        private static char letter;

        public static void customContains(this string sentence, string search)
        {
            string[] strArr = sentence.Split();

            if (strArr.Length == 0)
            {
                bool isUpper = false;
                bool isLower = false;
                bool isSplit = false;
            }

            foreach (var item in strArr)
            {
                if (item == search)
                {
                    Console.WriteLine(item == search);
                }

                if (char.IsDigit(letter))
                {
                    isDigit = true;
                    continue;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                    continue;

                }


                if (char.IsLower(letter))
                {
                    isLower = true;
                }

                bool result = isDigit && isUpper && isLower;
            }

        }
}   }
