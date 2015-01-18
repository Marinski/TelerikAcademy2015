// Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Threading;
using System.Globalization;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first number: ");
        string first = Console.ReadLine();
        first = first.Replace(",", ".");
        double a = double.Parse(first);

        Console.Write("Enter second number: ");
        string second = Console.ReadLine();
        second = second.Replace(",", ".");
        double b = double.Parse(second);

        Console.Write("Enter third number: ");
        string third = Console.ReadLine();
        third = third.Replace(",", ".");
        double c = double.Parse(third);

        double sum = a + b + c;
        Console.WriteLine("Sum of numbers: {0} + {1} + {2} = {3}", a, b, c, sum);
    }
}