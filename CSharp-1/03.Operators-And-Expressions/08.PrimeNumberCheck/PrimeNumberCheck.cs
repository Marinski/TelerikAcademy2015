using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number to check if is prime : ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine("Number {0} IS prime.", number);
        }
        else
        {
            Console.WriteLine("Number {0} IS NOT prime.", number);
        }
    }

    private static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        for (int i = 2; i <= (int)Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}