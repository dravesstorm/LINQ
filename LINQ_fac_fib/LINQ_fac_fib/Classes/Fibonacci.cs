using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_fac_fib.Classes
{
    public static class Fibonacci
    {
        public static IEnumerable<int> Fib(int n)
        {
            List<int> fibs = new List<int>();
            Enumerable.Range(0, n)
                .ToList()
                .ForEach(f => fibs.Add((f <= 1 ? 1 : fibs[f - 2] + fibs[f - 1])));
            return fibs;
        }
    }
}
