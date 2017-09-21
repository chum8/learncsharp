using System;
using static System.Console;
using System.Collections.Generic;

namespace Ch06_MathMethods
{
    class Program
    {
        public class CardinalToOrdinal
        {
            public string makeConversion(int myInput)
            {
                var cardN = myInput.ToString();
                var ordN = new System.Text.StringBuilder();
                ordN.Append(cardN);
                switch (cardN.Substring(cardN.Length - 1, 1))
                {
                    case "1":
                        ordN.Append("st");
                        break;
                    case "2":
                        ordN.Append("nd");
                        break;
                    case "3":
                        ordN.Append("rd");
                        break;
                    default:
                        ordN.Append("th");
                        break;
                }
                return ordN.ToString();
            }
        }
        static int Triangulate(int num, int total = 0)
        {
            return num == 0 ? total : Triangulate(num - 1, total + num);
        }
        public class PrimeFactors 
        {
            private List<int> primesList = new List<int>();
            private List<int> primesFactorsList = new List<int>();
            private bool isPrime(int original, int factor)
            {
                return original == factor ? true : (original % factor == 0) & (factor >= 2) ? false : isPrime(original, factor + 1);
            }
            
            private void populatePrimes(int uBound)
            {
                while (uBound >= 1)
                {
                    if (isPrime(uBound, 1))
                    {
                        primesList.Add(uBound);
                    }
                    --uBound;
                }
            }
            public void findPrimeFactors(int num)
            {
                populatePrimes(num);
                foreach (int prime in primesList)
                {
                    if (num % prime == 0)
                    {
                        primesFactorsList.Add(prime);
                    }
                }
            }
            public void printFactors()
            {
                foreach (int factor in primesFactorsList)
                {
                    WriteLine(factor);
                }
            }
            public void printPrimes()
            {
                foreach (int prime in primesList)
                {
                    WriteLine(prime);
                }

            }
        }
        static void Main(string[] args)
        {
            WriteLine("Math functions exercise, written by Douglas Singer, September 1, 2017.");
            Write("\nInput a number to convert to ordinal : "); 
            var myNumber = new CardinalToOrdinal();
            WriteLine($"The ordinal is {myNumber.makeConversion(Convert.ToInt32(ReadLine()))}.");

            Write("\nInput a number to triangulate: ");
            int num = Convert.ToInt32(ReadLine());
            WriteLine($"The triangulate of {num} is {Triangulate(num)}.");


            Write("\nInput a number to calculate prime factors : ");
            num = Convert.ToInt32(ReadLine());
            var myPrimeFactorSet = new PrimeFactors();
            myPrimeFactorSet.findPrimeFactors(num);
            WriteLine($"\nHere are the prime numbers less than or equal to {num}.");
            myPrimeFactorSet.printPrimes();
            WriteLine($"\nHere are the prime factors of {num}.");
            myPrimeFactorSet.printFactors();
            WriteLine();
        }
    }
}