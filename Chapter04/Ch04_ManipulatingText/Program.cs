using System;
using static System.Console;

namespace Ch04_ManipulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter a string.");
            string word1 = ReadLine();
            WriteLine($"The string \"{word1}\" is {word1.Length} characaters long.");

            //without error handling -- presuming user will enter a valid position index for now.
            WriteLine("Please enter a character position.");
            int i1 = Convert.ToInt32(ReadLine());
            WriteLine("Please enter a second character position.");
            int i2 = Convert.ToInt32(ReadLine());
            WriteLine($"The character at position {i1.ToString()} is \'{word1[i1]}\' and the character at position {i2.ToString()} is \'{word1[i2]}\'");

            WriteLine("Please enter a character to check for.");
            string checkFor1 = ReadLine();
            WriteLine("Enter a second character.");
            string checkFor2 = ReadLine();
            bool containsChar1 = word1.Contains(checkFor1);
            bool containsChar2 = word1.Contains(checkFor2);
            WriteLine($"Contains \"{checkFor1}\": {containsChar1}.  Contains \"{checkFor2}\": {containsChar2}.");

            WriteLine("Now enter a string separated by a delimeter, such as a comma.");
            string word2 = ReadLine();
            WriteLine("Enter the delimiting character.");
            char delimiter = Convert.ToChar(ReadLine()[0]);
            string[] word2Array = word2.Split(delimiter);
            WriteLine($"Here is the list split according to character \'{Convert.ToString(delimiter)}\'");
            foreach (string item in word2Array)
            {
                WriteLine(item);
            }

            WriteLine("Please enter your full name.");
            string myName = ReadLine();
            int indexOfTheSpace = myName.IndexOf(' ');
            string firstName = myName.Substring(0, indexOfTheSpace);
            string lastName = myName.Substring(indexOfTheSpace + 1);
            WriteLine($"Your first name: {firstName}");
            WriteLine($"Your last name: {lastName}");
            WriteLine($"Smashed together in reverse order: {lastName}{firstName}");
        }
    }
}