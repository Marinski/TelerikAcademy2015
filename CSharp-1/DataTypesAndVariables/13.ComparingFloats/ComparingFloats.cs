using System;

class ComparingFloats
{
    static void Main()
    {
        double a = 5.3; // tests 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999
        double b = 6.01; // tests 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998
        const float eps = 0.000001f;
        float c = (float)Math.Abs(a - b);

        if (c == eps)
        {
            Console.WriteLine("numbers are different");
        }
        else
        {
            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine("'a' is equal with precision(0.000001) to 'b'");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine("'b' is greater than 'a'");
                }
                else
                {
                    Console.WriteLine("'a' is greater than 'b'");
                }
            }
        }
    }
}