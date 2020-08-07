static void Main(string[] args)
        {

            string Input = Console.ReadLine();

            string[] NumberStrings = Input.Split(' '); //Split the string where blankspace is.
            string Number1 = NumberStrings[0];
            string Number2 = NumberStrings[1];

           int iTal1 = int.Parse(Number1);
           int iTal2 = int.Parse(Number2);

             int Reverse1 = ReverseNumbers(iTal1);
             int Reverse2 = ReverseNumbers(iTal2);
   
             if (Reverse1 > Reverse2)
             {
                 Console.WriteLine(Reverse1);
             }
             else
             {
                 Console.WriteLine(Reverse2);
             } 
        }

       static int ReverseNumbers(int iTal)
        {
            int rev_num = 0;
            while (iTal > 0)
            {
                rev_num = rev_num * 10 + iTal % 10;
                iTal = iTal / 10;
            }

            return rev_num;
        } 
