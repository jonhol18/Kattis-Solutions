using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis2
{
    class UnBearAble
    {
        static void Program1(string[] args)
        {
            List<string> animalList = new List<string>();
            Dictionary<string, int> AnimalNumber = new Dictionary<string, int>();
            int stop = 1;
            int count = 1;
            int input = int.Parse(Console.ReadLine());
                while (stop != 0)
                {
                    for (int i = 0; i < input; i++)
                    {
                        string Animal = Console.ReadLine().ToLower();
                      try
                      {
                          var newAnimal = Animal.Split(' ');
                          animalList.Add(newAnimal.Last());
                      }
                      catch (Exception)
                      {
                          animalList.Add(Animal);
                      }
                  
                    }
                    animalList.Sort();
                    while (animalList.Count != 0)
                    {
                        string Animal1 = animalList[0];
                        int Occurence = animalList.Count(e => e == Animal1);

                        AnimalNumber.Add(Animal1, Occurence);
                        animalList.RemoveAll(e => e == Animal1);
                    }
                    Console.WriteLine("List " + count + ":");
                    foreach (var Z in AnimalNumber)
                    {
                        
                        Console.WriteLine(Z.Key + " | " + Z.Value);
                    }
                    int NewRound = int.Parse(Console.ReadLine());
                    if (NewRound == 0)
                    {
                        stop = 0;
                    }
                    else
                    {
                        input = NewRound;
                    }
                    AnimalNumber.Clear();
                    count += 1;
                }
        }
    }
}
