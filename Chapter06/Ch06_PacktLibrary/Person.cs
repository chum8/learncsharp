using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.CS7
{
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate;
    }
    public partial class Person : object
    {
        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialname)
        {
            Name = initialname;
            Instantiated = DateTime.Now;
        }
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>(); // I still don't completely understand this, but it appears to be essentially creating a recursive way to make a class within a class.

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM yyyy}");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruitCS7()
        {
            return ("Apples", 5);
        }       

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Cherries", Number: 201);
        }

        public void OptionalParameters(string command = "Run!", double number = 0.0, bool active = true)
        {
            WriteLine($"command is {command}, number is {number}, active is {active}");
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;

            x++;
            y++;
            ++z;
        }
    }
}

