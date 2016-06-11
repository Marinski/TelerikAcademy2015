using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class XDocumentLINQ
{
    static void Main()
    {
        XDocument xmlDoc = XDocument.Load("../../../XML/cataloge.xml");

        var songs =
            from song in xmlDoc.Descendants("song")
            where song.Element("title").Value.Contains("")
            select new
                {
                    SongTitle = song.Element("title").Value
                };

        Console.WriteLine("Found {0} songs:", songs.Count());

        foreach (var song in songs)
        {
            Console.WriteLine("{0}", song.SongTitle);
        }

    }
}