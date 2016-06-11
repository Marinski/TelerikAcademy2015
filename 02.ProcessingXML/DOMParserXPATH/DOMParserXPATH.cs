using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

class DOMParserXPATH
{
    static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("../../../XML/cataloge.xml");
        XmlNode rootNode = doc.DocumentElement; // returns 'cataloge'
        var artistsCollection = new Dictionary<string, int>();

        string xPath = "albums/album/artist";
        XmlNodeList albums = rootNode.SelectNodes(xPath);

        foreach (XmlNode node in albums)
        {
            string currentArtist = node.InnerText;
            if (artistsCollection.ContainsKey(currentArtist))
            {
                artistsCollection[currentArtist]++;
            }
            else
            {
                artistsCollection.Add(currentArtist, 1);
            }
        }

        foreach (var artist in artistsCollection)
        {
            Console.WriteLine("{0} have {1} {2}.", artist.Key, artist.Value, (artist.Value == 1) ? "album" : "albums");
        }
    }
}
