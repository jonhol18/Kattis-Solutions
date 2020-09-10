using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis2
{
    class Server
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            int iTime = int.Parse(input.Last());

            var sTask = Console.ReadLine().Split(' ');

            List<int> Tasks = sTask.Select(int.Parse).ToList();
            int iMax = 0;
            int icount = 0;
            foreach (var time in Tasks)
            {
                iMax += time;

                if (iMax > iTime)
                {
                    break;
                }

                icount += 1;
            }
            Console.WriteLine(icount);
        }
    }
}
