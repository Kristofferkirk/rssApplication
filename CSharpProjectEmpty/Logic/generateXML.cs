using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CSharpProject
{
    /*
        A class that creates a new xml file containing the structure for a feed xml document, checks if it exists and
        if it does not exist, it adds a new file. Otherwise it loads the last one genereated.
        ****Note: change the path so its able to read on every computer with the program ****
    */
    public class generateXML
    {


        public static void Main()
        {
            var path = @"C:\Users\Kristoffer\Source\Repos\rssApplication\CSharpProjectEmpty\Data\Podcasts\feeds.xml";
            if (!File.Exists(path))
            {
                //Create the XmlDocument
                XmlDocument doc = new XmlDocument();
                doc.LoadXml("<feeds><feed><name></name><update></update><feeditem><name></name></feeditem></feed></feeds>");

                // Save the document to a file and auto-indent the output.
                XmlTextWriter writer = new XmlTextWriter(path, null);
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
            }
            else
            {
                XmlDocument loadCurrent = new XmlDocument();
                loadCurrent.Load(path);
            }
        }
    }
}
