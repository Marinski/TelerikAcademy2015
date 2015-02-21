//Problem 10. Find sum in array

//    Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example:
// array 4, 3, 1, 4, 2, 5, 8
// S 11
// result 4, 2, 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Enter check sum S= ");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

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
            int currSum = 0;
            int start = 0;
            int tempStart = 0;
            int sequence = 0;
            int currSequence = 0;
            bool isSum = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (currSum + array[i] == sum)
                {
                    start = tempStart;
                    sequence = currSequence;
                    isSum = true;
                    break;
                }
                else if (currSum + array[i] < sum)
                {
                    currSum += array[i];
                    currSequence++;
                }
                else if (currSum + array[i] > sum)
                {
                    if (i != array.Length - 1)
                    {
                        tempStart = i;
                        currSum = array[i];
                        currSequence = 1;
                    }
                    else
                    {
                        tempStart = array.Length - 2;
                        currSum = array[i - 1];
                        currSequence = 1;
                        i = array.Length - 2;
                    }
                }
            }
            if (isSum == false)
            {
                sequence = 0;
            }
            else
            {
                sequence++;
            }
            //output
            Console.WriteLine("The needed sum is present in the array ----> {0}", isSum);
            Console.WriteLine("For sum S={0}", sum);
            Console.Write("The sequence of elements is: { ");
            for (int i = start; i < start + sequence; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine();
            //other method
            currSum = 0;
            start = 0;
            sequence = 0;
            isSum = false;
            for (int k = 0; k < array.Length; k++)
            {
                for (int l = k; l < array.Length; l++)
                {
                    currSum += array[l];
                    if (currSum == sum)
                    {
                        start = k;
                        sequence = l - k;
                        isSum = true;
                    }
                }
                currSum = 0;
            }
            if (isSum == false)
            {
                sequence = 0;
            }
            else
            {
                sequence++;
            }
            //output
            Console.WriteLine("The needed sum is present in the array ----> {0}", isSum);
            Console.WriteLine("For sum S={0}", sum);
            Console.Write("The sequence of elements is: { ");
            for (int i = start; i < start + sequence; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
}
