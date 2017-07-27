//Joshua Pickenpaugh
//July 27th, 2017
//Largest Number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numList = new List<double>();

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Enter a decimal number:");
                double dblEnteredNum = Convert.ToDouble(Console.ReadLine());
                numList.Add(dblEnteredNum);
            }

            double dblHighNum = numList.Max();

            Console.WriteLine("The largest number inputed was: {0}.", dblHighNum);
            Console.WriteLine("Hit a key to EXIT.");
            Console.ReadKey();
        }
    }
}
