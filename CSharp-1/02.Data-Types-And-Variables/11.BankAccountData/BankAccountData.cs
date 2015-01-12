using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Marin";
        string secondName = "Dimitrov";
        string lastName = "Stoyanov";
        decimal balance = 12323212123.21213M;
        string bankName = "Cheat Bank";
        string IBAN = "MS89CBBF91293173293121";
        ulong firstCard = 2341354632871239;
        ulong secondCard = 1242237627374198;
        ulong thirdCard = 7652345612348764;

        Console.WriteLine("First Name: {0}\nSecond Name: {1}\nLast Name: {2}\nBalance: {3}\nbankName: {4}\nIBAN: {5}\nfirstCard: {6}\nsecondCard: {7}\nthirdCard: {8}", firstName, secondName, lastName, balance, bankName, IBAN, firstCard, secondCard, thirdCard);
    }
}