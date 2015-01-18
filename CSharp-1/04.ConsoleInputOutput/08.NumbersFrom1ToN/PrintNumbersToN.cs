// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
// each on a single line.
using System;

class PrintNumbersToN
{
    static void Main()
    {
        Console.Write("Enter number 'n' to print numbers from 1 to n: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}