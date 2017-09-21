using System;
using System.Collections.Generic;
using static System.Console;

namespace Ch04_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = new List<string>();
            for (int i = 0; i <= 3; i++)
            {
                Write("Enter a string of text: ");
                strings.Add(ReadLine());
            }
            WriteLine("Here's the list");
            foreach (string s in strings)
            {
                WriteLine($"   {s}");
            }
            Write("Enter a string to enter at index 0: ");
            strings.Insert(0, ReadLine());
            WriteLine("Here's the updated list");
            foreach (string s in strings)
            {
                WriteLine($"   {s}");
            }
            WriteLine("Now, removing index 1");
            strings.RemoveAt(1);
            WriteLine("Here's the updated list.");
            foreach (string s in strings)
            {
                WriteLine($"  {s}");
            }
        }
    }
}