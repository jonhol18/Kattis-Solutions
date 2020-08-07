static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputList1 = new List<string>(input.Split(' '));
            inputList1 = inputList1.ConvertAll(d => d.ToLower());

            var Duplicate = inputList1.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();

            if (Duplicate.Any())    
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }

        }
