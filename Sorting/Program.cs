using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unordered list: ");
            List<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next(100));
                Console.WriteLine(list[i]);
            }

            list = Sort(list);
            Console.WriteLine("Ordered list: ");
            for (int i = 100 - 1; i >= 0; i--)
            {
                list.Sort();
                Console.WriteLine(list[i]);
            }
        }

        static public List<int> Sort(List<int> list)
        {
            return list;
        }
    }
}



