public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<string> inputNames = new List<string>();
            List<string> ascList = new List<string>();
            List<string> descList = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string inputName = Console.ReadLine();
                inputNames.Add(inputName);
            }

            ascList = inputNames.OrderBy(i => i).ToList();
            descList = inputNames.OrderByDescending(x => x).ToList();

            if (inputNames.SequenceEqual(ascList))
            {
                Console.WriteLine("INCREASING");
            }
            else if(inputNames.SequenceEqual(descList))
            {
                Console.WriteLine("DECREASING");
            }
            else
            {
                Console.WriteLine("NEITHER");
            }
        }
