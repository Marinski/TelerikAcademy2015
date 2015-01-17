using System;

class ExtractThirdBit
{
    static void Main()
    {

        int pos = 3;
        Console.Write("Enter positive integer to check 3rd bit value : ");
        uint n = Convert.ToUInt32(Console.ReadLine());  // 15 --> 00000000 00001111
        int mask = 1 << pos;                                   // 00000000 01111000
        uint nAndMask = (uint)(n & mask);                      // 00000000 01111111
        uint bit = (uint)nAndMask >> pos;                      // 00000000 00001111
        Console.WriteLine("3rd bit is --> {0}", bit);          // 1
    }
}