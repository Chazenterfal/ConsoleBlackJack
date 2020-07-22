using System;

namespace ConsoleBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Blackjack - Welcome! Write /'s/' for start. (Any other letter for quit)");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            if (s == "s")
            {
                Console.WriteLine("Nice Work");
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
