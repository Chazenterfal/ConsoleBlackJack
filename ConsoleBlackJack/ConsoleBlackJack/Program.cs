using System;

namespace ConsoleBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Blackjack - Welcome! Write 's' for start. (Any other key for quit)");
            string s = Console.ReadLine();
            int raz = 0;
            int EXIT = 0;
            int sum1 = 0;
            Random num = new Random();
            for (int i = 1; i<3; i++)
            {
                int Card1 = num.Next(2,11);
                sum1 = sum1 + Card1;
                Console.WriteLine($"Card Value - {Card1}");
            }

            while (EXIT != 1)
            {
                Console.WriteLine("Write S for cards, else write Y.");
                string S = Console.ReadLine();
                if (S == "S")
                {
                    int Card1 = num.Next(2, 11);
                    sum1 = sum1 + Card1;
                    Console.WriteLine($"Card Value - {Card1}");
                }
                else
                {
                    EXIT = 1;
                }
            }
            int sum2 = 0;
            for (int i = 1; i<3; i++)
                {
                    int Card1 = num.Next(2, 11);  
                    sum2 = sum2 + Card1;
                }

            while (raz != 0)
            {
                raz -= 1;
                int Card1 = num.Next(2, 11);
                sum2 = sum2 + Card1;
            }
            string question = (sum1 > sum2 && sum1 <= 21) ? $"The banker have {sum2} and it means you won!" : $"The banker have {sum2} and it means you lose!";
            Console.WriteLine(question);

        
        }
    }
}
