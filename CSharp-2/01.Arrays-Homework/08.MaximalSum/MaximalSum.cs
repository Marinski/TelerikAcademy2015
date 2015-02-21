//Problem 8. Maximal sum

//    Write a program that finds the sequence of maximal sum in given array.

//Example:
// input 	
// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8
// result	
// 2, -1, 6, 4

//    Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);
            //input
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine(size);// adds better visualisation while using StreamReader

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Enter element[{0}]: ", index);
                array[index] = int.Parse(Console.ReadLine());
                Console.WriteLine(array[index]);// adds better visualisation while using StreamReader
            }

            //check input
            Console.Write("Array is [");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");

            //logic
            int currSum = array[0];
            int subSum = 0;
            int maxSum = 0;
            int currSequence = 1;
            int maxSequence = 1;
            int start = 0;
            int tempStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                //subSum = currSum + array[i];
                if (currSum + array[i] > array[i])
                {
                    currSum += array[i];
                    currSequence++;
                }
                else
                {
                    currSum = array[i];
                    tempStart = i;
                    currSequence = 1;
                }
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    start = tempStart;
                    maxSequence = currSequence;
                }
            }

            //output
            Console.WriteLine("Maximal sequence sum is: {0}", maxSum);
            Console.Write("Seqence consists: ");
            for (int i = start; i < start + maxSequence; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
