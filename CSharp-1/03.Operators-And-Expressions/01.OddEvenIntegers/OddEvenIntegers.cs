using System;

class OddEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter number to check if EVER or ODD : ");
        
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("The number {0} is EVEN", a);
        }
        else
        {
            Console.WriteLine("The number {0} is ODD", a);
        }
    }
}