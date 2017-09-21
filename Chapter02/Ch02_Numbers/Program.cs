using static System.Console;
using System;

namespace Ch02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            // using different variable types
            int population = 353_429_434;
            double weight = 184.3; // never use doubles to compare with == operator
            decimal price = 4.99M;
            string fruit = "Papaya";
            char letter = 'Z';
            bool happy = true;

            int? ICouldBeNull = null;  // declaring a null value type

            // checking for null
            if (ICouldBeNull != null)
            { // do something 
            }

            string authorName = null;
            // if authorName is null, instead of throwing an exception,
            // null is returned
            int? howManyLetters = authorName?.Length;
            authorName = "Dickens";
            howManyLetters = authorName?.Length;
            // result will be three if howManyLetters is null
            var result = howManyLetters ?? 3;
            WriteLine(result);
            /*
                        string[] names = new string[4];

                        names[0] = "Douglas";
                        names[1] = "Laura";
                        names[2] = "Rafe";
                        names[3] = "Unknown future spouse of Rafe";

                        for (int i = 0; i < names.Length; i++)
                        {
                            WriteLine(names[i]);
                        }
             */
            WriteLine($"The cost is {price:C}");
        }
    }
}