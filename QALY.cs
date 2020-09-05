using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class QALY
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            double ital1 = 0;
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] NewArray = input.Split(' ');

                double ital0 = double.Parse(NewArray[0]);
                double ital02 = double.Parse(NewArray[1]);

                ital1 += ital0 * ital02;

                Array.Clear(NewArray, 0, NewArray.Length);              
            }

            Console.WriteLine(ital1);
        }
    }
}
