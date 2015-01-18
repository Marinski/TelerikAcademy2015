// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Print Fibonacci sequence from 0 to number ==> ");
        uint num = uint.Parse(Console.ReadLine());
        for (int i = 0; i <= num; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
    public static int Fibonacci(int n)
    {
        int a = 0;
        int b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

}