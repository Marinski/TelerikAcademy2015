using System;
using System.IO;
using System.Numerics;

namespace _2.Task
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("..\\..\\input.txt");
            Console.SetIn(reader);

            int secretNumber = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            if (text.Length < 10000 && (secretNumber >= 1 || secretNumber <= 10))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    char currentChar = text[i];
                    int charCode = (int)currentChar;

                    if (currentChar == '@')
                    {
                        break;
                    }
                    if (Char.IsLetter(currentChar))
                    {
                        charCode *= secretNumber;
                        charCode += 1000;
                    }
                    if (Char.IsDigit(currentChar))
                    {
                        charCode += secretNumber;
                        charCode += 500;
                    }
                    if (!Char.IsDigit(currentChar) && !Char.IsLetter(currentChar) && currentChar != '@' && !Char.IsSymbol(currentChar))
                    {
                        charCode -= secretNumber;
                    }

                    if (text.IndexOf(text[i]) % 2 == 0)
                    {
                        // charCode = charCode / 100;
                        decimal finalVal = 0;
                        finalVal = Convert.ToDecimal(charCode) / 100;
                        Console.WriteLine("{0:F2}", finalVal);
                    }
                    else
                    {
                        if (i != 0)
                        {
                            // charCode = charCode * 100;
                            decimal finalVal = Convert.ToDecimal(charCode) * 100;
                            Console.WriteLine("{0}", finalVal);
                        }
                        else
                        {
                            Console.WriteLine(charCode);
                        }
                    }

                }
            }
        }
    }
}
