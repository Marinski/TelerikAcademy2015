// Problem 1. Allocate array

//    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//    Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AllocateArray
{
    class AllocateArrays
    {
        static void Main()
        {
            int count = 20;
            int[] nums = new int[count];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 5 * i;
                Console.WriteLine("arr[{0}] = {1}", i, nums[i]);
            }
        }
    }
}
