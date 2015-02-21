//Problem 6. Maximal K sum

//    Write a program that reads two integer numbers N and K and an array of N elements from the console.
//    Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.MaximalKsum
{
    class MaxKsum
    {
        static int[] nums = { 1, 2, 5, 3, 6, -1, -2, 10, 11, 12 }; // Array of N elements
        static int sum = nums.Max(); // Finds maximum value in array[N], this is also the max possible sum in this array
        static int maxNums = 3;// int.Parse(Console.ReadLine());// Declare K elements to find the sum max sum while using K elements

        static void Main(string[] args)
        {
            int[] arr = new int[nums.Length];
            CurrentSum(0, 0, 0, arr);
        }

        public static void Print(int[] arr)
        {
            Console.Write("{ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    Console.Write(arr[i] + " ");
            }
            Console.WriteLine("}");
        }

        public static void CurrentSum(int sumSoFar, int numsUsed, int startIndex, int[] selectedNums)
        {
            if (startIndex >= nums.Length || numsUsed > maxNums)
            {
                if (sumSoFar == sum && numsUsed <= maxNums)
                {
                    Print(selectedNums);
                }
                return;
            }

            //Include the next number and check the sum
            selectedNums[startIndex] = nums[startIndex];
            CurrentSum(sumSoFar + nums[startIndex], numsUsed + 1, startIndex + 1, selectedNums);

            //Dont include the next number
            selectedNums[startIndex] = 0;
            CurrentSum(sumSoFar, numsUsed, startIndex + 1, selectedNums);
        }
    }
}
