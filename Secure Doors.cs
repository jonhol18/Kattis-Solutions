using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis2
{
    class SecureDoors
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            List<string> newList = new List<string>();
 
            for (int i = 0; i < input; i++)
            {
                var Name = Console.ReadLine().Split(' ');
                if (Name.First() == "entry")
                {
                    string NewEntry = Name.Last() + " entered";

                    if (newList.Contains(NewEntry))
                    {
                        Console.WriteLine(NewEntry + " (ANOMALY)");

                    }
                    else if(newList.Contains(NewEntry) == false)
                    {
                        Console.WriteLine(NewEntry);
                        newList.Add(Name.Last() + " entered");
                    }
                    
                }
                else if (Name.First() == "exit")
                {
                    string NewEntry = Name.Last() + " entered";
                    if (newList.Contains(NewEntry))
                    {
                          Console.WriteLine(Name.Last() + " exited");
                    newList.RemoveAll(e => e == NewEntry);
                    
                    }
                    else if (newList.Contains(NewEntry) == false)
                    {
                        Console.WriteLine(Name.Last() + " exited (ANOMALY)");
                        newList.Remove(NewEntry);

                    }
                }

            }
        }
    }
}
