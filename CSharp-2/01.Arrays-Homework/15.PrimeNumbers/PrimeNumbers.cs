//Problem 15. Prime numbers

//    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Input range final member N = ");
            int number = int.Parse(Console.ReadLine());
            //def the array
            bool[] array = new bool[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }
            //check the array
            //Console.WriteLine(string.Join(",", array));
            //logic
            int max = (int)Math.Sqrt(array.Length);
            Console.Write("{0} prime numbers in range ", max);
            for (int i = 2; i < max; i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j < array.Length; j += i)
                    {
                        array[j] = false;
                    }
                }
            }
            //output
            Console.Write("[ ");
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("]");
        }
    }
}
