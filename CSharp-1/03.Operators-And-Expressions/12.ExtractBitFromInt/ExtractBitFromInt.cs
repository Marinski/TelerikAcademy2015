using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("Enter integer for the test : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter integer to set bit position : ");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int nAndMask = num & mask;
        int bit = nAndMask >> pos;
        Console.WriteLine("bit @ position {0} in number {1} --> {2}", pos, num, bit);
    }
}