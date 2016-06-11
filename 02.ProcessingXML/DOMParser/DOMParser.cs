using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class DOMParser
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();

        doc.Load("../../../XML/cataloge.xml");
        XmlNode rootNode = doc.DocumentElement; // cataloge

        var artistsCollection = new Dictionary<string, int>();

        foreach (XmlNode node in rootNode.ChildNodes[0]) // ChildNodes[0] : cataloge -> albums
        {
            var currentArtist = node["artist"].InnerText;
            
            if (artistsCollection.ContainsKey(currentArtist))
            {
                artistsCollection[currentArtist]++;
            }
            else
            {
                artistsCollection.Add(node["artist"].InnerText , 1);
            }
        }
        foreach (var artist in artistsCollection)
        {
            Console.WriteLine("{0} have {1} {2}.", artist.Key, artist.Value, (artist.Value == 1) ? "album" : "albums");
        }
    }
}