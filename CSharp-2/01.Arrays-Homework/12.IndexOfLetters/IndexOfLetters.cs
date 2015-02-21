//Problem 12. Index of letters

//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine("In the A-Z range: ");
            foreach (char letter in word.ToLower())
            {
                if (((int)letter - (int)('a' - 1)) < 0)
                {
                    Console.WriteLine("Symbol ->{0}<- is outside A-Z array.", letter);
                }
                else
                {
                    Console.WriteLine("Letter {0} is at position {1}.", letter, ((int)letter - (int)('a' - 1)));
                }
            }
        }
    }
}
