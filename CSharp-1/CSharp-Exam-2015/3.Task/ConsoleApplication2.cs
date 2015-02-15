using System;
using System.Numerics;

class ConsoleApplication2
{
    static void Main()
    {
        int counter = -1;
        int newCounter = -1;
        int con = 1;

        BigInteger result = 1;
        BigInteger newResult = 1;
        BigInteger lastResult = 1;

        BigInteger finalResult = 1;
        BigInteger newFinalResult = 1;
        BigInteger newLastResult = 1;

        while (true)
        {
            string line = Console.ReadLine();
            if (int.Parse(line) < 100)
            {
                break;
            }

            if (con < 2)
            {
                break;
            }
            con++;
            ++counter;
            

            if (line == "END")
            {
                break;
            }
            if (counter == 0 || counter % 2 == 0)
            {
                foreach (char symbol in line)
                {
                    int digit = symbol - '0';
                    if (digit == 0)
                    {
                        digit = 1;
                    }
                    result *= digit;
                    finalResult *= result;
                    result = 1;
                }
                foreach (char secondsymbol in line)
                {
                    ++newCounter;
                    int secondDigit = secondsymbol - '0';
                    if (secondDigit == 0)
                    {
                        secondDigit = 1;
                    }
                    if (newCounter < 15)
                    {
                        newResult *= secondDigit;
                        newFinalResult *= newResult;
                        newResult = 1;
                    }
                    else
                    {
                        lastResult *= secondDigit;
                        newLastResult *= lastResult;
                        lastResult = 1;
                    }
                }
            }
        }
        if (counter <= 10)
        {
            Console.WriteLine(finalResult);
        }
        if (counter > 10)
        {
            Console.WriteLine(newFinalResult);
            Console.WriteLine(newLastResult);
        }
    }
}