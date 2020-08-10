 public static void Main(string[] args)

        {
            int iLoops = int.Parse(Console.ReadLine());
            for (int i = 0; i < iLoops; i++)
            {
                string word = Console.ReadLine();
                string missingLetters = getMissingLetters(word);
                if (string.IsNullOrEmpty(missingLetters))
                {
                    Console.WriteLine("pangram");
                }
                else
                {
                    Console.WriteLine("missing " + missingLetters);
                }
            }

        }

        public static string getMissingLetters(string sentence)
        {
            string sAlphabet = "abcdefghijklmnopqrstuvwxyz";
            sentence = sentence.ToLower();
            for (int i = 0; i <= sentence.Length - 1; i++)
            {
                int j = sAlphabet.IndexOf(sentence[i]);
                if (j != -1)
                {
                    sAlphabet = sAlphabet.Remove(j, 1);
                }
            }

            return sAlphabet;
        }
