using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis2
{
    class LicenseToLaunch
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string[] NumbersInput = Console.ReadLine().Split(' ');
            int[] NewArray = new int[lines];

            NewArray = Array.ConvertAll(NumbersInput, int.Parse);

            int MinNumbers = NewArray.Min();
            int IndexOF = Array.IndexOf(NewArray, MinNumbers);
            Console.WriteLine(IndexOF);

        }
    }
}
