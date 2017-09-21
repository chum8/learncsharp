using System.Collections.Generic;

namespace System.Linq
{
    public static class MyLINQExtensions
    {
        // this is a chainable LINQ extension method
        public static IEnumerable<T> ProcessSequence<T>(
            this IEnumerable<T> sequence)
        {
            return sequence;
        }
        public static long SummarizeSequence<T>(
            this IEnumerable<T> sequence)
        {
            return sequence.LongCount();
        }
    }
}