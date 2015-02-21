//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

//Example:
// input 	
// 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3
// result
// 4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int [] array = new int[size];

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write("Enter element[{0}]: ", index);
                array[index] = int.Parse(Console.ReadLine());
            }

            //check input
            Console.Write("Array is [");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");

            //logic
            int currNumber = 0;
            int number = 0;
            int maxSequence = 0;
            int currSequence = 1;

            for (int j = 0; j < array.Length; j++)
            {
                currNumber = array[j];
                for (int i = 1; i < array.Length; i++)
                {
                    if (currNumber == array[i])
                    {
                        currSequence++;
                    }
                    if (currSequence > maxSequence)
                    {
                        maxSequence = currSequence;
                        number = currNumber;
                    }
                }
                currSequence = 0;
            }
            //output
            Console.WriteLine("Most frequent number is: {0}({1} times)", number, maxSequence);
        }
    }
}
