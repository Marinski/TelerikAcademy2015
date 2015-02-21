//Problem 2. Compare arrays
//
//    Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            //int[] number = Enumerable.Range(1, 10).ToArray();
            Console.WriteLine("Enter first array size: ");
            int firstArrSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second array size: ");
            int secondArrSize = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstArrSize];
            int[] secondArray = new int[secondArrSize];

            Console.WriteLine("First array : ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(firstArray[i]);
            }

            Console.WriteLine("Second array : ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(secondArray[i]);
            }

            Console.WriteLine("Compare element by element: ");
            int compare = firstArrSize.CompareTo(secondArrSize);
            if (compare < 0)
            {
                Console.WriteLine("First array has smaller lenth than second array");
                for (int i = 0; i < firstArrSize; i++)
                {
                    IntToStringComparer(firstArray[i], secondArray[i]);
                }
            }
            else
            {
                Console.WriteLine("First array has equal length as second array");
                if (compare == 0)
                {

                    Console.WriteLine("=");
                    for (int i = 0; i < firstArrSize; i++)
                    {
                        IntToStringComparer(firstArray[i], secondArray[i]);
                    }
                }
                else
                {
                    Console.WriteLine("First array has greater length than second array");
                    for (int i = 0; i < secondArrSize; i++)
                    {
                        IntToStringComparer(firstArray[i], secondArray[i]);
                    }
                }
            }

        }


        private static void IntToStringComparer(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("{0} = {1}", a.ToString(), b.ToString());
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("{0} > {1}", a.ToString(), b.ToString());
                }
                else
                {
                    Console.WriteLine("{1} > {0}", a.ToString(), b.ToString());
                }
            }
        }
    }
}
