using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter number to check if third digit (RTL) is 7 : ");
        int a = int.Parse(Console.ReadLine());

        if (a < 100)
        {
            Console.WriteLine("Number you have entered has no 3rd digit");
        }
        else
        {
            if ( (a / 100) % 10 != 7)
            {
                Console.WriteLine("Third digit from right-to-left IS NOT 7.");
            }
            else
            {
                Console.WriteLine("Third digit from right-to-left IS 7.");
            }
        }
    }
}