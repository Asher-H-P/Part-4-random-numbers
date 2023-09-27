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
            int min, max;
            min = generator.Next(0, (50 +- 1));
            max = generator.Next(0, (50 +- 1));
            Console.WriteLine(generator.NextDouble());
            Console.WriteLine(generator.Next());
            Console.WriteLine(generator.Next(0, 11));
            Console.WriteLine(generator.Next(10, 21));
            Console.WriteLine(generator.Next(min, max));
            //If min > max it creates an error.
            Console.WriteLine(generator.Next(-10, -5));
            //You can include negative numbers.
        }
    }
}
