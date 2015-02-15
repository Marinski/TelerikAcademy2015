using System;
using System.IO;

namespace _4.Task
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

        }
    }
}
