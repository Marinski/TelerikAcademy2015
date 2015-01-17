using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer for the test : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter integer to set bit position : ");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int numAndMask = num & mask;
        int bit = numAndMask >> pos;
        Console.Write("Is bit at position {0} in number {1} equal to 1 : ", pos, num);
        Console.WriteLine(bit == 1 ? "true" : "false");
    }
}