﻿using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstVar = "The \"use\" of quotations causes difficulties.";
        string secondVar = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstVar + "\n" + secondVar);
    }
}