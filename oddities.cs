using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Oddities
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine(number + " is even");
                }
                else
                {
                    Console.WriteLine(number + " is odd");
                }
            }
        }
    }
}
