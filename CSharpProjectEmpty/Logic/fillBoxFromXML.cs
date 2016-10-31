using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Data;
using System.Windows;
using CSharpProject;


namespace Logic
{
    class fillBoxFromXML
    {

        //Någon användning för att fylla comboboxen
        public static void fillComboBox(String e) //Försökte referera en combobox, men går inte (Hur löser man detta?)
        {
            var path = @"C:\Users\Kristoffer\Source\Repos\rssApplication\CSharpProjectEmpty\Data\Podcasts\categorys.xml";
            XmlDocument catXML = new XmlDocument();
            catXML.LoadXml(path);
            XmlNodeList nameList = catXML.SelectNodes("Categorys/Category/Name");
            foreach(XmlNode name in nameList)
            {
                
            }
        }
    }
}
