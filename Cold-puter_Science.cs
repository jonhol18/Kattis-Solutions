using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Cold_Puter_science
    {
        public static void Main(string[] args)
        {

            int ital = int.Parse(Console.ReadLine());

                string temp = Console.ReadLine();
                string[] newTemp = temp.Split(' ');
                int[] intTemp = Array.ConvertAll(newTemp, int.Parse);

                int icount = 0;

                foreach (var i in intTemp)
                {
                    if (i < 0)
                    {
                        icount += 1;
                    }
                }
                Console.WriteLine(icount);
        }
    }
}
