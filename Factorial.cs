using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorials
{
    class Factorial  
    {
        public static int cast(string stringNnumber)
        {
            int number;
            if (Int32.TryParse(stringNnumber, out number))
            {
                return number;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int numberCount = cast(numberString);

            for (int i = 0; i < numberCount; i++)
            {
                string input = Console.ReadLine();
                int actualNumber = cast(input);
                if (actualNumber != -1)
                {
                    int result = 0;
                    for (int p = 5; p <= actualNumber; p *= 5)
                    {
                        result += actualNumber / p;
                    }
                    Console.WriteLine("{0}", result);
                }
            }
        }
    }
}
