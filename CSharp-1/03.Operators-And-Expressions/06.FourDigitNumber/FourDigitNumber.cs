using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter four-digit number in format abcd (e.g. 2011) : ");
        string a = Console.ReadLine();

        int val1 = (int)Char.GetNumericValue(a[0]);
        int val2 = (int)Char.GetNumericValue(a[1]);
        int val3 = (int)Char.GetNumericValue(a[2]);
        int val4 = (int)Char.GetNumericValue(a[3]);
        Console.Write("The sum of the digits : ");
        Console.WriteLine(val1 + val2 + val3 + val4);

        string fval = val1.ToString();
        string sval = val2.ToString();
        string tval = val3.ToString();
        string foval = val4.ToString();
        Console.WriteLine("The number in reversed order : " + foval + tval + sval + fval);
        Console.WriteLine("The last digit in the first position : " + foval + fval + sval + tval);
        Console.WriteLine("Exchange the second and the third digits : " + fval + tval + sval + foval);
    }
}