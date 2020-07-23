using System;

namespace ConsoleBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Blackjack - Welcome! Write /'s/' for start. (Any other letter for quit)");
            string s = Console.ReadLine();
            int raz = 0;
            int a = 0;
            int sum1 = 0;
            for (int i = 1; i<3; i++)
            {
                Random num = new Random();
                int brosok1 = num.Next(2,11);
                sum1 = sum1 + brosok1;
                Console.WriteLine("Card Value - ");
                Console.WriteLine(brosok1);
            }

            while (a != 1)
            {
                Console.WriteLine("Write S for cards, else write Y.");
                string S = Console.ReadLine();
                if (S == "Y")
                {
                    Random num = new Random();
                    int brosok1 = num.Next(2, 11);
                    sum1 = sum1 + brosok1;
                    Console.WriteLine("Card Value - ");
                    Console.WriteLine(brosok1);
                }
                else
                {
                    a = 1;
                }
            }
            int sum2 = 0;
            for (int i = 1; i<3; i++)
                {
                    Random num = new Random();
                    int brosok1 = num.Next(2, 11);  
                    sum2 = sum2 + brosok1;
                }

            while (raz != 0)
            {
                raz -= 1;
                Random num = new Random();
                int brosok1 = num.Next(2, 11);
                sum2 = sum2 + brosok1;
            }
            if (sum1 > sum2 && sum1<= 21)
            {
                Console.WriteLine("You won!");
            }
            else if (sum1 == sum2)
            {
                Console.WriteLine("The banker won!");
            }
            else
            {
                Console.WriteLine("The banker won!");
            }
        
        }
    }
}
