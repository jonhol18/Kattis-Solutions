using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class R2
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] numbStrings = str.Split(' ');
            List<int> numberList = new List<int>();
            foreach (var num in numbStrings)
            {
              numberList.Add(Convert.ToInt32(num));
            }

            int R2 = (numberList[1] * 2) - numberList[0];
            Console.WriteLine(R2);

        }

    }
}
