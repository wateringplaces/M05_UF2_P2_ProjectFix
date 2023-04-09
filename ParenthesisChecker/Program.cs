using System;
using System.Linq;

namespace ParenthesisChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            int open = response.Count(x => x == '(');
            int close = response.Count(x => x == ')');
            if (open != close)
            {
                Console.WriteLine("The parenthesis don't close");
            }
            else
            {
                Console.WriteLine("The parenthesis close");
            }
        }
    }
}