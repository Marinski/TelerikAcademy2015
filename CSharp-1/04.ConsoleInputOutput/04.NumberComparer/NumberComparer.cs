//  Write a program that gets two numbers from the console and prints the greater of them.

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter first number: ");
        string a = Console.ReadLine();
        Console.Write("Enter second number: ");
        string b = Console.ReadLine();

        // Try to implement this without if statements
        var max = Math.Max(Double.Parse(a), Double.Parse(b));
        Console.WriteLine(max);

        // Implement find bigger with if-else loop
        // if (a != b)
        // {
        //     if (a > b)
        //     {
        //         Console.WriteLine("{0} > {1}", a, b);
        //     }
        //     else
        //     {
        //         Console.WriteLine("{0} < {1}", a, b);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("{0} = {1}", a, b);
        // }
    }
}