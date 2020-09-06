using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class SimonSays
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> newList = new List<string>();

            for (int i = 0; i < input; i++)
            {
                
                string simon = Console.ReadLine();
                var word = simon.Split(' ');

                if (simon.Contains("Simon says"))
                {
                   foreach (var X in word)
                   {
                       newList.Add(X);
                   } 
                }
                for (int j = 2; j < newList.Count; j++)
                {
                    Console.Write(newList[j]+ " ");
                }

                newList.Clear();
            }
        }
    }
}
