using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));

        }

        /// <summary>
        /// This 
        /// <param name="number"></param>
        /// <returns></returns>
        // public static char LetterNIF(int number)


        static Random random = new Random();
        public static char LetterNIF(int number)
        {
            // This method returns a random lowercase letter
            // ... Between 'a' and 'z' inclusize.
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('A' + num);
            return let;
        }
    }
}
