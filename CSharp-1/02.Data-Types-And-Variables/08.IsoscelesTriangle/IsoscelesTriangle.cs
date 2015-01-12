using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copy = '\u00a9';

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("    " + copy + "\n");
        Console.WriteLine("   " + copy + " " + copy + "\n");
        Console.WriteLine("  " + copy + "   " + copy + "\n");
        Console.WriteLine(" " + copy + " " + copy + " " + copy + " " + copy + "\n");
    }
}