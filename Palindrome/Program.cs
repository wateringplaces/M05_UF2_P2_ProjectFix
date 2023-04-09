using System;
using System.Text;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(Palindrome(response));
        }
        public static string Palindrome(string text)
        {
            string reversedText = " ";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return text + reversedText;
        }
    }
}

