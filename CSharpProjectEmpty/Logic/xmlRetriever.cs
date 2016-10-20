using System;
using System.Text;


namespace CSharpProject
{

    public class xmlRetriever
    {

        public static void getXML(string url)
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);

            }
            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                Console.WriteLine(title.InnerText);
            }

        }



    }
}

