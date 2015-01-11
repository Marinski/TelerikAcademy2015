using System;

class BooleanDivider
{
    static void Main()
    {
        Console.Write("Enter number to check is it divided by 5 and 7 (without remainder): ");
        int a = int.Parse(Console.ReadLine());
        if (a % 5 == 0 && a % 7 == 0)
        {
            Console.WriteLine("{0} IS divided by 5 and 7 (without remainder)", a);
        }
        else
        {
            Console.WriteLine("{0} IS NOT divided by 5 and 7 (without remainder)", a);
        }
    }
}