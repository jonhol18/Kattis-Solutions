using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Kattis2
{
    class SimpleAddition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();

           BigInteger big = BigInteger.Parse(input);
           BigInteger big2 = BigInteger.Parse(input2);

           Console.WriteLine(big + big2);

        }
    }
}
