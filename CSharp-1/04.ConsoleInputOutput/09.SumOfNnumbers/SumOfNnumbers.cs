using System;

class SumOfNnumbers
{
    static void Main()
    {
        Console.Write("How many numbers you want to sum: ");
        int checkNumber;
        while (!int.TryParse(Console.ReadLine(), out checkNumber) || checkNumber <= 0)
        {
            Console.Write("Invalid number! Enter number > 0: ");
        }
        double number;
        double sum = 0;
        for (int i = 1; i <= checkNumber; i++)
        {
            Console.Write("Enter number  {0} = ", i);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid parameter! Enter numbers: {0} = ", i);
            }
            sum += number;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}