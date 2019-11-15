using System;
using System.Collections.Generic;

namespace Binary_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bin = new List<int>(100);

            Console.Write("Enter a number to convert to binary: ");
            int dec = -1;
            while (dec == -1 && dec < 0)
            {
                try
                {
                    dec = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
            }

            int n = dec;
            int i = 1;
            while (n > 0)
            {
                bin.Add(n % 2);
                n /= 2;
                i++;
            }

            bin.Reverse();

            bin.ForEach(Console.Write);
            
            Console.ReadLine();
        }
    }
}
