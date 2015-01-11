using System;

class MoonGravitation
{
    static void Main()
    {
        float gravField = 17 / 100f;
        float testVal = 86f;
        Console.WriteLine("Weight on Earth {0} = Weight on Moon {1}", testVal, testVal * gravField);
        testVal = 74.6f;
        Console.WriteLine("Weight on Earth {0} = Weight on Moon {1}", testVal, testVal * gravField);
        testVal = 53.7f;
        Console.WriteLine("Weight on Earth {0} = Weight on Moon {1}", testVal, testVal * gravField);
    }
}