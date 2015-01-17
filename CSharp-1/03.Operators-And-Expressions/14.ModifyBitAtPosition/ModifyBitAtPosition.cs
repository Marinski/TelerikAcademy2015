using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer number n : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position p : ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter bit value v (can be 0 or 1): ");
        uint v = uint.Parse(Console.ReadLine());

        if (v == 1 || v == 0)
        {
            if (v == 1)
            {
                // Set the bit at position p to 1
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
            else
            {
                // Set the bit at position p to 0
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Error. Bit can't be different that 0 or 1");
        }
    }
}