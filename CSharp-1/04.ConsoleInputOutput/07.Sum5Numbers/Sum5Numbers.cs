// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
using System;

class Sum5Numbers
{
    static void Main()
    {
        Console.Write("Enter five numbers (separated by a space): ");
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine("\nSum of all numbers: {0}\n", sum);
    }
}