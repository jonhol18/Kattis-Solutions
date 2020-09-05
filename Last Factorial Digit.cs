using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Last_Factorial_Digit
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int ans = 1;
            for (int i = 0; i < input; i++)
            {
                int ital = int.Parse(Console.ReadLine());
              
                    for (int j = 1; j < ital; j++)
                    {

                        ans *= j + 1;
                    }
                    Console.WriteLine(" ");
                    if (ans >= 2)
                    {
                        string answer = ans.ToString();
                        Console.WriteLine(answer.Remove(0, answer.Length - 1));
                    }
                    else
                    {
                        Console.WriteLine(ans);
                    }

                    ans = 1;
            }
        }
    }
}
