//Problem 3. Compare char arrays
//    Write a program that compares two char arrays lexicographically (letter by letter).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);
            Console.WriteLine("Enter first array size: ");
            int firstArrSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second array size: ");
            int secondArrSize = int.Parse(Console.ReadLine());
            int[] firstArray = new int[firstArrSize];
            int[] secondArray = new int[secondArrSize];

            Console.WriteLine("First array : ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
                Console.WriteLine(firstArray[i]);
            }

            Console.WriteLine("Second array : ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
                Console.WriteLine(secondArray[i]);
            }

            foreach (char item in firstArray)
            {
                foreach (char anotherItem in secondArray)
                {
                    Comparer(item, anotherItem);
                }
            }

        }

        private static void Comparer(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("{0} = {1}", (char)a, (char)b);
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("{0} > {1}", (char)a, (char)b);
                }
                else
                {
                    Console.WriteLine("{1} > {0}", (char)a, (char)b);
                }
            }
        }
    }
}
