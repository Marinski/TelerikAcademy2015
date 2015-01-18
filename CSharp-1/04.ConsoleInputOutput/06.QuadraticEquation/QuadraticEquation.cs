using System;
using System.Text;
using System.Threading;
using System.Globalization;

class QuadraticEquation
{
    // quadratic equation is a second order of polynomial equation in a single variable
    // x = [ -b +/- sqrt(b^2 - 4ac) ] / 2a

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = float.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        SolveQuadratic(a, b, c);
    }

    public static void SolveQuadratic(double a, double b, double c)
    {
        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2, img;

        if (sqrtpart > 0)
        {
            x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Real Solutions: x1 = {0:f2} or x2 = {1:f2}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -b / (2 * a);
            img = System.Math.Sqrt(sqrtpart) / (2 * a);
            Console.WriteLine("Two Imaginary Solutions: x1 = {0:f2} + {1:f2} i or x2 = {2:f2} + {3:f2} i", x, img, x, img);
        }
        else
        {
            x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("One Real Solution: x1 = x2 = {0:f2}", x);
        }
    }

}