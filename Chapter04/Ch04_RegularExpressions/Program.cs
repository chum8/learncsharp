using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace Ch04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();
            // Regex ageChecker = new Regex(@"\d"); //@ prefix switches off escape characters.  This evaluates if there is one digit.
            // Regex ageChecker = new Regex(@"^\d$"); //Only allows one digit
            Regex ageChecker = new Regex(@"^\d+$"); //Now, any number of digits
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}");
            }

            Write("Enter some things.  Checking for characters that hackers are likely to use: ");
            input = ReadLine();
            Regex hackerChecker = new Regex(@"[^<>/]");
            if (hackerChecker.IsMatch(input))
            {
                WriteLine("That was clean input.  Thank you!");
            }
            else
            {
                WriteLine("You filthy hacker.");
            }
        }
    }
}