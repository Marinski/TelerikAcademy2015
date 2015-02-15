using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.Enigmanation
{
    class Enigmanation
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            string input = Console.ReadLine();

            decimal result = 0;
            decimal currentBracketResult = 0;

            char currentOperator = '+';
            char currentBracketOperator = '+';

            bool inBracket = false;

            foreach (char symbol in input)
            {
                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    inBracket = false;
                    switch (currentOperator)
                    {
                        case '+': result += currentBracketResult; break;
                        case '-': result -= currentBracketResult; break;
                        case '*': result *= currentBracketResult; break;
                        case '%': result %= currentBracketResult; break;
                        default: break;
                    }
                    currentBracketResult = 0;
                    currentBracketOperator = '+';
                }

                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '%')
                {
                    if (inBracket)
                    {
                        currentBracketOperator = symbol;
                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }

                if (Char.IsDigit(symbol))
                {
                    int currentNumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketResult += currentNumber; break;
                            case '-': currentBracketResult -= currentNumber; break;
                            case '*': currentBracketResult *= currentNumber; break;
                            case '%': currentBracketResult %= currentNumber; break;
                            default: break;
                        }
                    }
                    else
                    {
                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '%': result %= currentNumber; break;
                            default: break;
                        }
                    }
                }
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}
