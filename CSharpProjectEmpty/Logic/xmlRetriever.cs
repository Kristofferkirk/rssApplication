using System;
using System.Text;
using System.Xml;


namespace CSharpProject
{

    public class xmlRetriever
    {
        public xmlRetriever()
        {
            
        }
        public string getXML(string url)
        {
            var xml = "";
            string nameOfPDC = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(url);

            }
            //Skapa en objektrepresentation.
            var dom = new XmlDocument();
            dom.LoadXml(xml);

            XmlTextWriter writer = new XmlTextWriter("data.xml", null);
            writer.Formatting = Formatting.Indented;
            dom.Save(writer);

            //Iterera igenom elementet item.
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                nameOfPDC = title.ToString();
            }
            return nameOfPDC;
            

        }
      



    }
}

