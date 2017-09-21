using System;
using Packt.CS7;
using static System.Console;

namespace Ch07_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var baby1 = harry.Procreate(mary);
            var baby2 = harry * mary;
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\".");
            Write("Enter a number to compute a factorial (n!) : ");
            var myNum = ReadLine();
            WriteLine($"{myNum}! is {harry.Factorial(Convert.ToInt32(myNum))}");
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Snooze += Harry_Snooze;
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();
            harry.Sedate();

            Person[] people =
            {
                new Person { Name = "Douglas" },
                new Person { Name = "Laura" },
                new Person { Name = "Edmund" },
                new Person { Name = "Lavinia" },
                new Person { Name = "Rosamund" },
                new Person { Name = "Rafe" }
            };
            WriteLine("\nInitial list of people");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("\nUse Person's sort implementation:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("\nUse PersonComparer's sort implementation:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            var dv1 = new DisplacementVector(3, 4);
            var dv2 = new DisplacementVector(-24, 83);
            var dv3 = dv1 + dv2;
            WriteLine($"\n({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            Employee e1 = new Employee
            {
                Name = "Phil Zach",
                DateOfBirth = new DateTime(1991, 12, 6),
                EmployeeCode = "PZ001",
                HireDate = new DateTime(2013, 08, 19)
            };
            e1.WriteToConsole();
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");
            WriteLine(e1.ToString());

            Employee aliceInEmployee = new Employee
            {
                Name = "Alice",
                EmployeeCode = "AA1492"
            };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee e2 = (Employee)aliceInPerson;
                // do something with e2
            }

            Employee e3 = aliceInPerson as Employee;
            if (e3 != null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
                // do something with e3
            }

            try
            {
                e1.TimeTravel(new DateTime(1996, 3, 3));
                e1.TimeTravel(new DateTime(1912, 3, 2));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            string email1 = "burgundy@mywines.com";
            string email2 = "lager#mybeers.com";

            WriteLine($"{email1} is valid : {email1.IsValidEmail()}");
            WriteLine($"{email2} is valid : {email2.IsValidEmail()}");


        }


        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} has an anger level of {p.AngerLevel} anger units.");
        }
        private static void Harry_Snooze(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is now asleep with a sleep value of {p.TiredLevel}.");
        }
    }
}