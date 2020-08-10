public static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '<')
                {
                    if (stack.Any())  // Make sure the stack isn't empty
                        stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            string output = new string(stack.Reverse().ToArray());
            Console.WriteLine(output);
            
        }
            
