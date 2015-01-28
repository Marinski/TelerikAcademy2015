using System;

// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
// than the second one. As a result print the values a and b, separated by a space.
class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please type a number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Now type another number and press ENTER to arrange both numbers ascending:");
        double b = Convert.ToDouble(Console.ReadLine());
        bool greaterA = a > b;

        if (greaterA)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}