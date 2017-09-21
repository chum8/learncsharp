using System;
using static System.Console;
using System.Linq;

namespace Ch09_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Wade", "Marjorie", "Martin", "Molly", "Wilbur", "Leora", "James", "Marilyn", "Michael", "Rhonda", "Douglas", "Laura", "David", "Karen", "Edmund", "Lavinia", "Rosamund", "Rafe", "Nathan", "Chandra", "Cora", "Vera", "James", "Emily", "Alanna", "Louisa", "Keith", "Claudia", "Karina" };
            // var query = names.Where(new Func<string, bool>(NameLongerThanFour));
            // this alias is going to call a function that takes a string and returns a boolean, so that if it is true, the string is added to the result tally
            // this accomplishes the same thing in a shorter way
            // var query = names.Where(NameLongerThanFour);
            // => is the "goes to" symbol
            // now, accomplish the same thing with a lambda
            // a lambda needs
            // -- the names of input parameters
            // -- a return value expression
            // the lambda can infer that name is a string value and the function after => returns a boolean value
            Write("Enter an integer, where the integer equals the max length of a string: ");
            var myLength = Convert.ToInt16(ReadLine());
            // var query = names.Where(name => name.Length > myLength);
            var query = names
                .ProcessSequence()
                .Where(name => name.Length > myLength)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);

            WriteLine($"These names have more than {myLength} character(s).");
            foreach (var n in query)
            {
                WriteLine(n); 
            }
        }
        static bool NameLongerThanFour (string name)
        {
            return name.Length > 4;
        }
    }
}