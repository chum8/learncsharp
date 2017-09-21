using System;

namespace Ch03_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] divisibleBy = new int[2];
            divisibleBy[0] = 3;
            divisibleBy[1] = 5;

            string[] divisibleByMessage = new string[2];
            divisibleByMessage[0] = "Fizzzz";
            divisibleByMessage[1] = "Buzzzzz";
            string message = "";
            Console.WriteLine($"We are going to detect numbers ranging from 1 to n divisible by {divisibleBy[0]} and {divisibleBy[1]}.");
            Console.WriteLine($"Numbers divisible by {divisibleBy[0]} will trigger the message \"{divisibleByMessage[0]}\" and numbers divisible by {divisibleBy[1]} will trigger the message \"{divisibleByMessage[1]}\".");
            Console.WriteLine("What number shall we count to?");
            int maxCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= maxCount; i++)
            {

                message = "";
                if (i % divisibleBy[0] == 0)                    
                {
                    message += divisibleByMessage[0];
                }
                if (i % divisibleBy[1] == 0)
                {
                    message += divisibleByMessage[1];
                }
                if (message == "")
                {
                    message = i.ToString();
                }
                Console.Write(message + myDelimiter(i, maxCount));
            }                                 
        }
        static string myDelimiter(int num, int maxCount)
        {
            if (num < maxCount)
            {
                return ", ";
            }
            else
            {
                return "\n";
            }
        }
        
    }
}