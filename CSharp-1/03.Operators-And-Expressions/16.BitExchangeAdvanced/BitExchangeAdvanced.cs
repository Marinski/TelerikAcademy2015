using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        // Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
        // Original source code: https://gist.github.com/dentia/db13a4187d303169c619
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Exchange bits starting from 'p': ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("With bits starting from 'q': ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("How many bits to exchange, or 'k': ");
        int k = int.Parse(Console.ReadLine());

        for (int exchangeFromStartBit = p, exchangeWithStartBit = q, bitsLen = k;
        (exchangeFromStartBit <= 32 && exchangeWithStartBit <= 32) && bitsLen > 0;
        exchangeFromStartBit++, exchangeWithStartBit++, bitsLen--)
        {
            if (((n >> exchangeFromStartBit) & 1) != ((n >> exchangeWithStartBit) & 1))
            {
                n = changeBits(n, exchangeFromStartBit, exchangeWithStartBit);
            }
        }
        Console.WriteLine("Result: " + n);
    }

    private static uint changeBits(uint number, int firstposition, int secondPosition)
    {
        number ^= (uint)(1 << firstposition);
        return number ^ (uint)(1 << secondPosition);
    }
}