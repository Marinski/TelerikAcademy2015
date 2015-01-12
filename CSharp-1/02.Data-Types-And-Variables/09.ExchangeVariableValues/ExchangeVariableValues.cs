using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        string intro = "The values of 'a' and 'b' ";

        Console.WriteLine(intro + "BEFORE exchange are: a = {0}, b = {1}", a, b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine(intro + "AFTER exchange are: a = {0}, b = {1}", a, b);
    }
}