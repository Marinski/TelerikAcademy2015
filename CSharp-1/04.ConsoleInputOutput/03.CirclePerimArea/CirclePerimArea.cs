// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class CirclePerimArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Enter circle radius: ");
        string number = Console.ReadLine();
        double radius;
        if (double.TryParse(number, out radius) && radius > 0)
        {
            double perimeter = 2 * Math.PI * radius; // circle P = 2 * PI * r
            double area = Math.PI * Math.Pow(radius, 2); // circle S = PI * r^2
            Console.WriteLine("Circle with radius {0} has perimeter {1:0.00} and area {2:0.00}", radius, perimeter, area);
        }
        else
        {
            Console.WriteLine("Invalid number: {0}", number);
        }
    }
}