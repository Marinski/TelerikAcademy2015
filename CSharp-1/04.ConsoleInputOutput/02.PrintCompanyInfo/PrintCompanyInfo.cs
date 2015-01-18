// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class PrintCompanyInfo
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;
        // Company info
        Console.Write("Add Company Name...");
        string coName = Console.ReadLine();
        Console.Write("Add Company Address...");
        string coAddress = Console.ReadLine();
        Console.Write("Add Company Phone...");
        string coPhone = Console.ReadLine();
        Console.Write("Add Company Fax...");
        string coFax = Console.ReadLine();
        Console.Write("Add Company Website...");
        string coWeb = Console.ReadLine();
        // Manager info
        Console.Write("Add Company Manager First Name...");
        string mngrFirstName = Console.ReadLine();
        Console.Write("Add Company Manager Last Name...");
        string mngrLastName = Console.ReadLine();
        Console.Write("Add Company Manager Age...");
        string mngrAge = Console.ReadLine();
        Console.Write("Add Company Manager Phone...");
        string mngrPhone = Console.ReadLine();

        Console.WriteLine("Your contact card looks good:\n");
        Console.WriteLine(coName);
        Console.WriteLine("Address: {0}", coAddress);
        Console.WriteLine("Tel. {0}", coPhone);
        Console.WriteLine("Fax: {0}", coFax);
        Console.WriteLine("Web site: {0}", coWeb);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", mngrFirstName, mngrLastName, mngrAge, mngrPhone);
    }
}