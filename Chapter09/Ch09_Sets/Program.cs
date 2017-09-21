using System.Collections.Generic; // for IEnumerable<T>
using System.Linq; // for LINQ extension methods
using static System.Console;

namespace Ch09_Sets
{
    class Program
    {
        private static void Output(IEnumerable<string> cohort, string description = "")
        {
            if (!string.IsNullOrEmpty(description))
            {
                WriteLine(description);
            }
            Write("  ");
            WriteLine(string.Join(", ", cohort.ToArray()));
        }
        static void Main(string[] args)
        {
            var cohort1 = new string[]
                { "James", "David", "Joanna", "Stephen" };
            var cohort2 = new string[]
                { "Larry", "Karen", "Kate", "Gary", "Gary" };
            var cohort3 = new string[]
                { "Gary", "Rhonda", "Mark" };
            var cohort4 = new string[]
                { "Michael", "Kevin", "Melanie", "Megan", "Kate" };

            Output(cohort1, "Cohort 1: Demick Baby Boomers");
            Output(cohort2, "Cohort 2: Ackerman Baby Boomers (with intentional duplicate)");
            Output(cohort3, "Cohort 3: Davis Baby Boomers");
            Output(cohort4, "Cohort 4: Singer Baby Boomers");
            WriteLine();

            Output(cohort2.Distinct(), "cohort2.Distinct(): removes duplicates");
            Output(cohort2.Union(cohort3), "cohort2.Union(cohort3): combines two sequences and removes any duplicates");
            Output(cohort2.Intersect(cohort4), "cohort2.Intersect(cohort4): returns items that are in both sequecnes");
            Output(cohort2.Except(cohort3), "cohort2.Except(cohort3): removes items from the first sequence that are in the second sequence");
            Output(cohort1.Zip(cohort2, (c1, c2) => $"{c1} matched with {c2}"), "cohort1.Zip(cohort2, (c1, c2) => $\"{c1} matched with {c2}\"): matches items based on position in sequence.");
        }
    }
}