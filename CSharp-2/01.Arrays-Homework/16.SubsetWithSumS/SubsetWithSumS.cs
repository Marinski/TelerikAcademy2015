//Problem 16.* Subset with sum S

//    We are given an array of integers and a number S.
//    Write a program to find if there exists a subset of the elements of the array that has a sum S.

//Example:
// input array 2, 1, 2, 4, 3, 5, 2, 6
// S 14
// result yes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main(string[] args)
        {
            //input
            int[] arrayOfNumbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
            int maxi = (int)Math.Pow(2, arrayOfNumbers.Length) - 1;
            Console.Write("Enter sum: ");
            int S = int.Parse(Console.ReadLine());
            List<int> tmpElements = new List<int>();
            int hasSum = 0;
            //logic
            for (int i = 1; i <= maxi; i++)
            {
                int currentSum = 0;
                tmpElements.Clear();
                for (int j = 1; j <= arrayOfNumbers.Length; j++)
                {
                    if ( ( ( i >> (j - 1) ) & 1 ) == 1)
                    {
                        currentSum += arrayOfNumbers[j - 1];
                        tmpElements.Add(arrayOfNumbers[j - 1]);
                    }
                    if (currentSum == S)
                    {
                        hasSum++;
                        Console.Write("Elements are ");
                        foreach (var item in tmpElements)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            if (hasSum == 0)
            {
                Console.WriteLine("No sum.");
            }
            else
            {
                Console.WriteLine("Number of subsets: {0}", hasSum);
            }
        }
    }
}
