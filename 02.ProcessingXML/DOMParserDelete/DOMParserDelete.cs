using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class DOMParserDelete
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("../../../XML/cataloge.xml");
        XmlNode cataloge = doc.DocumentElement; // returns 'cataloge'

        var artistsCollection = new Dictionary<string, int>();

        string xPath = "albums/album";
        XmlNodeList albums = cataloge.SelectNodes(xPath);

        foreach (XmlNode album in albums)
        {
            double currentAlbumPrice = double.Parse(album["price"].InnerText);
            bool isTrue = (currentAlbumPrice > 20);
            if (isTrue)
            {
                cataloge.ChildNodes[0].RemoveChild((album["price"]).ParentNode);
            }
        }

        doc.Save("../../../XML/new-cat.xml");
        Console.WriteLine("Catalog successfully updated!");

    }
}