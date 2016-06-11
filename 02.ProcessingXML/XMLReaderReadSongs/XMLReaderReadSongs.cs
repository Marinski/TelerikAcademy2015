using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class XMLReaderReadSongs
{
    static void Main()
    {
        XmlReader reader = XmlReader.Create("../../../XML/cataloge.xml");
        using (reader)
        {
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                {
                    Console.WriteLine("Song name: {0}", reader.ReadElementString());
                }
            }
        }
    }
}