using System;

namespace CalculateAge
{
    class CalculateAge
    {
        static void Main()
        {
            Console.WriteLine("Please type your age: ");
            byte str = byte.Parse(Console.ReadLine());
            Console.WriteLine("After 10 years you will be " + (str + 10) + " years old.");
        }
    }
}
