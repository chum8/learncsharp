using System;
using Packt.CS7;
using static System.Console;

namespace Ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Douglas Singer";
            p1.DateOfBirth = new DateTime(1982, 3, 8);
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");

            var p2 = new Person { Name = "Laura Singer", DateOfBirth = new DateTime(1983, 6, 19) };
            WriteLine($"{p2.Name} was born on {p2.DateOfBirth:dddd, d MMMM yyyy}");

            p1.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine($"{p1.Name}'s favourite wonder is {p1.FavouriteAncientWonder}");

            p1.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
            // p1.BucketList = (WondersOfTheAncientWorld)18;
            WriteLine($"{p1.Name}'s bucket list is {p1.BucketList}");

            p2.BucketList = WondersOfTheAncientWorld.ColossusOfRhodes | WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.LighthouseOfAlexandria | WondersOfTheAncientWorld.MausoleumAtHalicarnassus | WondersOfTheAncientWorld.StatueOfZeusAtOlympia | WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;
            WriteLine($"{p2.Name}'s bucket list is {p2.BucketList}");

            p1.Children.Add(new Person());
            p1.Children.Add(new Person());
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");

            BankAccount.InterestRate = 0.012M;
            var ba1 = new BankAccount();
            ba1.AccountName = "Mrs. Demick";
            ba1.Balance = 28314;
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest.");
            var ba2 = new BankAccount();
            ba2.AccountName = "Mr. Battles";
            ba2.Balance = 14.22M;
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");

            var p3 = new Person();
            WriteLine($"{p3.Name} was instantiated at  {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, d MMMM yyyy}");

            var p4 = new Person("Davis");
            WriteLine($"{p4.Name} was instantiated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, d MMMM yyyy}"); ;

            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            (string, int) fruit4 = p1.GetFruitCS7();
            WriteLine($"There are {fruit4.Item2} {fruit4.Item1}.");

            (string, int) fruit7 = p1.GetFruitCS7();
            WriteLine($"{fruit7.Item1}, {fruit7.Item2} there are.");

            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");

            (string fruitName, int fruitNumber) = p1.GetNamedFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            p1.OptionalParameters();
            p1.OptionalParameters("freeze!", 38);
            p1.OptionalParameters(active: false, command: "charge!", number: 339);

            int a = 392;
            int b = 22_483_429;
            int c = 1;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            p1.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b:N0}, c = {c}");

            int d = 483_3;
            int e = 2;
            WriteLine($"Before: d = {d:C}, e = {e}, f doesn't exist yet!");
            p1.PassingParameters(d, ref e, out int f);
            WriteLine($"After:  d = {d:C}, e = {e}, f = {f}");

            var edmund = new Person
            {
                Name = "Edmund",
                DateOfBirth = new DateTime(2009, 11, 26)
            };
            var douglas = new Person
            {
                Name = "Douglas",
                DateOfBirth = new DateTime(1982, 3, 8)
            };
            WriteLine(edmund.Origin);
            WriteLine(edmund.Greeting);
            WriteLine(edmund.Age);
            WriteLine(douglas.Origin);
            WriteLine(douglas.Greeting);
            WriteLine(douglas.Age);

            douglas.FavoriteIceCream = "Cherry Vanilla";
            douglas.FavoritePrimaryColor = "Blue";
            WriteLine($"Douglas's favorite ice-cream flavor is {douglas.FavoriteIceCream}.");
            WriteLine($"Douglas's favorite primary color is {douglas.FavoritePrimaryColor}.");

            douglas.Children.Add(new Person { Name = "Edmund" });
            douglas.Children.Add(new Person { Name = "Lavinia" });
            douglas.Children.Add(new Person { Name = "Rosamund" });
            douglas.Children.Add(new Person { Name = "Rafe" });
            WriteLine($"Douglas's third child is {douglas.Children[2].Name}");
            WriteLine($"Douglas's second child is {douglas.Children[1].Name}");
        }
    }
}