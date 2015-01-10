using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstVal = null;
        double? secondVal = null;
        Console.WriteLine("Integer: {0};\nDouble: {1};\n", firstVal, secondVal);
        firstVal += 2;
        secondVal += 2.222;
        Console.WriteLine("Integer: {0};\nDouble: {1};\n", firstVal, secondVal);
        firstVal = 421;
        secondVal = 231.222;
        Console.WriteLine("Integer: {0};\nDouble: {1};\n", firstVal, secondVal);
    }
}