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


        public static void createFeedList()
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
        public static void createCategoryList()
        {
            var path2 = @"C:\Users\Kristoffer\Source\Repos\rssApplication\CSharpProjectEmpty\Data\Podcasts\categorys.xml";
            if(!File.Exists(path2))
            {
                XmlDocument doc2 = new XmlDocument();
                doc2.LoadXml("<categorys><category><name>Comedy</name></category><category><name>Politics</name></category><category><name>Fashion</name></category></categorys>");

                XmlTextWriter writer2 = new XmlTextWriter(path2, null);
                writer2.Formatting = Formatting.Indented;
                doc2.Save(writer2);

            }
            else
            {
                XmlDocument loadCurrentCategorys = new XmlDocument();
                loadCurrentCategorys.Load(path2);
            }
        }
    }
}
