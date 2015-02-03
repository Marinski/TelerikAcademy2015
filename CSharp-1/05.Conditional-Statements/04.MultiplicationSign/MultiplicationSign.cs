using System;

// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

class MultiplicationSign
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sign = 0;

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The sign ot the product of your numbers is 0");
        }
        else
        {
            Console.WriteLine("The sign ot the products of your number is {0}", sign);
        }
    }
}