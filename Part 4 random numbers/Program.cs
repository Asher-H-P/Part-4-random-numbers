using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4_random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int num1, num2, num3, num4, num5;
            string ha = "HA";
            num1 = generator.Next(1, 21);
            num2 = generator.Next(21, 41);
            num3 = generator.Next(41, 61);
            num4 = generator.Next(61, 81);
            num5 = generator.Next(81, 101);
            for (int ctr = 0; ctr < 10; ctr++)
            {
                Console.Write("{0,3}   ", generator.Next(num1, num2));
            }
            for (int ctr = 0; ctr < num5; ctr++)
            {
                Console.Write("{0,-19:R}   ", generator.NextDouble());
                if ((ctr + 1) % 3 == 0) Console.WriteLine();
            }
            
        }
    }
}
