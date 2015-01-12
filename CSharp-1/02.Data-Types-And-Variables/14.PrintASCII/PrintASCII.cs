using System;

class PrintASCII
{
    static void Main()
    {
        Console.WriteLine("ASCII Table:");
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}