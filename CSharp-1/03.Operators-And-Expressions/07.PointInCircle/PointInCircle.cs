using System;

class PointInCircle
{
    static void Main()
    {
        int radius = 2;
        int Kx = 0;
        int Ky = 0;

        Console.WriteLine("Enter 'x' and 'y' to see if your point (x, y) is inside a circle K({0, 0}, 2).");

        Console.Write("Enter X : ");
        double x = Double.Parse(Console.ReadLine());
        Console.Write("Enter Y : ");
        double y = Double.Parse(Console.ReadLine());

        double condition = Math.Pow((x - Kx), (x - Kx)) + Math.Pow((y - Ky), (y - Ky));
        double test = Math.Pow(radius, radius);

        if (condition < test)
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is INSIDE circle K", x, y);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is OUTSIDE circle K", x, y);
        }
    }
}