using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstVar = "Hello";
        string secondVar = "World";
        object concatenated = firstVar + " " + secondVar;
        string thirdVar = (string)concatenated;

        Console.WriteLine("{0} is now object type", concatenated);
        Console.WriteLine("{0} is now string type", thirdVar);
    }
}