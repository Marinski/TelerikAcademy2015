using System;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:

//    If the score is between 1 and 3, the program multiplies it by 10.
//    If the score is between 4 and 6, the program multiplies it by 100.
//    If the score is between 7 and 9, the program multiplies it by 1000.
//    If the score is 0 or more than 9, the program prints “invalid score”

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please type number to check your bonus score :");
        int score = int.Parse(Console.ReadLine());
        //int score = 2;
        bool firstCase = score > 1 && score < 3;
        bool secondCase = score > 4 && score < 6;
        bool thirdCase = score > 7 && score < 9;

        if (firstCase)
        {
            score *= 10;
            Console.WriteLine("Your score is {0}", score);
        }
        else if (secondCase)
        {
            score *= 100;
            Console.WriteLine("Your score is {0}", score);
        }
        else if (thirdCase)
        {
            score *= 100;
            Console.WriteLine("Your score is {0}", score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
