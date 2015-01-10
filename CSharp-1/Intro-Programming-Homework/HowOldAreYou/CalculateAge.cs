using System;

class CalculateAge
{
    static void Main()
    {
        Console.WriteLine("Please type your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be " + (age + 10) + " years old.");
    }
}