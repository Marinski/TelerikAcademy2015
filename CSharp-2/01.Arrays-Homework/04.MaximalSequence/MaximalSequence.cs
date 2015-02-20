//Problem 4. Maximal sequence

//    Write a program that finds the maximal sequence of equal elements in an array.

//Example:
//input 	
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 
//result
//2, 2, 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            var seq = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int[] max = seq.Select((n, i) => new { Value = n, Index = i })
                .OrderBy(s => s.Value)
                .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
                .GroupBy(s => new { s.Value, s.Diff })
                .OrderByDescending(g => g.Count())
                .First()
                .Select(f => f.Value)
                .ToArray();

            Console.Write("Maximal sequence is: ");
            foreach (var item in max)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
