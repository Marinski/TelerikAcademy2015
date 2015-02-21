//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length]; //unsorted data set
            for (int index = 0; index < length; index++)
            {
                Console.Write("Enter value for {0} : ", index + 1);
                arr[index] = int.Parse(Console.ReadLine());
            }

            selectsort(arr, length); //sorting process using selection sort
            int i;
            for (i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " "); //after sorting
            }
            Console.WriteLine();
        }

        ///selection sort
        static void selectsort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                int min = i;
                for (j = i + 1; j < n; j++)
                    if (dataset[j] < dataset[min]) min = j; //find min value
                //then swap it with the beginning item of the unsorted list
                int temp = dataset[i];
                dataset[i] = dataset[min];
                dataset[min] = temp;
            }
        }
    }
}
