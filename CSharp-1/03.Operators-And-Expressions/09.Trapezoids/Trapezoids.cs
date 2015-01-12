using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side 'a' value : ");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Enter side 'b' value : ");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Enter height 'h' value : ");
        double h = Double.Parse(Console.ReadLine());
        // Trapezoid's area = (a + b) / 2 * h
        Console.Write("Trapezoid's Area : ");
        Console.WriteLine((a + b) / 2 * h);
    }
}
