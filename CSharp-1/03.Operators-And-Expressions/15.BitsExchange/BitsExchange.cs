using System;

class BitsExchange
{
    static void Main()
    {
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        // Original source code by: https://github.com/zmihaylov/CSharp-PartOne-Homework/blob/master/OperatorsAndExpressions/15.BitsExchange/BitsExchange.cs
        Console.Write("Enter unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());
        int positionOne = 3;
        int positionTwo = 24;
        int maskOne = 7 << positionOne;
        int maskTwo = 7 << positionTwo;
        int getNumbersOne = (int)(n & maskOne);
        int getNumbersTwo = (int)(n & maskTwo);
        int change = (int)((n & ~maskOne) & ~maskTwo);
        int maskThree = (getNumbersOne >> positionOne) << positionTwo;
        int maskFour = (getNumbersTwo >> positionTwo) << positionOne;
        int result = (change | maskThree) | maskFour;
        Console.WriteLine("Number with changed bits: {0}", result);
    }
}