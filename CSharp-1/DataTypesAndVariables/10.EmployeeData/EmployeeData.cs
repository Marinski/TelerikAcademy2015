using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Marin";
        string lastName = "Stoyanov";
        byte age = 26;
        string gender = "m";
        ulong personalID = 8901020304;
        uint uniqueNum = 27899999;

        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}", firstName, lastName, age, gender, personalID, uniqueNum);
    }
}