using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class GenerateXMLfromTextFile
{
    static void Main(string[] args)
    {
        string[] data = File.ReadAllLines("../../persons-data.txt");
        string[] personDataFields = { "name", "address", "phone" };

        XElement root = new XElement("persons");

        for (int personIndex = 0; personIndex < data.Length; personIndex += personDataFields.Length)
        {
            var person = new XElement("person");

            for (int dataFieldIndex = 0; dataFieldIndex < personDataFields.Length; dataFieldIndex++)
            {
                person.Add(new XElement(personDataFields[dataFieldIndex], data[personIndex + dataFieldIndex]));
            }

            root.Add(person);
        }

        string resultFilename = "result.xml";

        Console.WriteLine("The final result is recoreded in {0}", resultFilename);
        root.Save(string.Format("../../{0}", resultFilename));
    }
}