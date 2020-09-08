using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class MissingNumbers
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> NumbersList = new List<int>();
            List<int> controllList = new List<int>();

            for (int i = 0; i < input; i++)
            {
                NumbersList.Add(int.Parse(Console.ReadLine()));
            }

            int ilength = NumbersList[NumbersList.Count - 1];

            for (int i = 1; i <= ilength; i++)
            {
                controllList.Add(i);
            }
            NumbersList.Sort();

            bool isEqual = NumbersList.SequenceEqual(controllList);
            if (isEqual)
            {
                Console.WriteLine("good job");
            }
            else
            {
                foreach (var a1 in NumbersList)
                {
                    var a2 = a1;
                    controllList.RemoveAll(e => e == a2);
                }

                foreach (var put in controllList)
                {
                    Console.WriteLine(put);
                }
            }
        }
    }
}
