using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.CodeStreet
{
    class CodeStreet
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            string input = Console.ReadLine();
            long oddSum = 0;
            long oddAmount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    // odds
                    // int y = int.Parse(input[i].ToString());

                    if (input[i] >= '0' && input[i] <= '9')
                    {
                        int y = input[i] - '0';
                        oddSum += y;
                        oddAmount += 1;
                    }
                }
            }
            Console.WriteLine("{0} {1}", oddAmount, oddSum);
        }
    }
}
