using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Numerics;


namespace _1._2_4_8
{
    class Program
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            BigInteger a = int.Parse(Console.ReadLine());
            BigInteger b = int.Parse(Console.ReadLine());
            BigInteger c = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            BigInteger r = 0;

            if (b == 2)
            {
                r = a % c;
            }
            else if (b == 4)
            {
                r = a + c;
            }
            else if (b == 8)
            {
                r = a * c;
            }

            if (r % 4 == 0)
            {
                result = r / 4;
            }
            else
            {
                result = r % 4;
            }
            Console.WriteLine(result);
            Console.WriteLine(r);
        }
    }
}
