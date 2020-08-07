using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class I_ve_Been_Everywhere_Man
    {
        static void Main(string[] args)
        {
            List<string> Cities = new List<string>();
            List<String> uniqueList = new List<string>();

            int TestCase = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < TestCase; i++)
            {
                int Trips = int.Parse(Console.ReadLine());
                for (int j = 0; j < Trips; j++)
                {
                    Cities.Add(Console.ReadLine());

                }
                uniqueList = Cities.Distinct().ToList();
                Console.WriteLine(uniqueList.Count);
                Cities.Clear();
                uniqueList.Clear();
            }


        }
    }
}
