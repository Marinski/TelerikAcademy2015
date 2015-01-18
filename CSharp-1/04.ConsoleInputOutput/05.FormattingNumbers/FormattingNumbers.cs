using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            float c = float.Parse(Console.ReadLine());

            // a in hex
            // a in binary padded by zeros
            // b print with 2 digits after decimal point, right aligned
            // c print with 3 digits after the decimal poitn, left aligned

            Console.WriteLine("{0,-10:X} | {1} | {2,10:F2} | {3,-10:F3} |", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        }
    }
}
