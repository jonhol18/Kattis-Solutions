using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Planina
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

           double answer = 0;
           double iteration1 = Math.Pow(4, input);
            double iteration2 = Math.Pow(2, (input + 1)) + 1;
            answer += iteration1 + iteration2;

            Console.WriteLine(answer);
        }
    }
}
