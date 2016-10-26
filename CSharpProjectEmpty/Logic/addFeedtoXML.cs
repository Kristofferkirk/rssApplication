using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Logic
{
    class addFeedtoXML
    {
        public void addFeed(string newPod)
        {
            var path = @"C:\Users\Kristoffer\Source\Repos\rssApplication\CSharpProjectEmpty\Data\Podcasts\feeds.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Create
            XmlElement elem = doc.GetElementById("<name>");
            XmlText text = doc.CreateTextNode(newPod);
            doc.DocumentElement.AppendChild(elem);
            doc.DocumentElement.LastChild.AppendChild(text);
        }
    }
}
