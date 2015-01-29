using System;

// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write
// a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

class CheckTask
{
    static void Main()
    {
        string _2 = "2", _3 = "3", _4 = "4", _5 = "5", _6 = "6", _7 = "7", _8 = "8", _9 = "9", _10 = "10", J = "J", Q = "Q", K = "K", A = "A";
        Console.WriteLine("Please type something in the console to check if it is valid card number:");
        string num = Console.ReadLine();

        if (num == "2" || num == "3" || num == "4" || num == "5" || num == "6" || num == "7" || num == "8" || num == "9" || num == "10" || num == "J" || num == "Q" || num == "K" || num == "A")
        {
            Console.WriteLine("{0} is valid card sign", num);
        }
        else {
            Console.WriteLine("{0} is invalid card sign", num);
        }
    }
}