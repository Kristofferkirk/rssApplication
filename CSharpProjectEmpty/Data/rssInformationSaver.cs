using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class rssInformationSaver
    {
        // På något sätt skall det vara en klass här som lagrar informationen som går från GUI till Logic till hit, men har ej kommit på hur detta funkar än
        private string title;
        private string url;
        private string dateAdded;
       rssInformationSaver(string title, string url, string dateAdded)
        {
            this.title = title;
            this.url = url;
            this.dateAdded = dateAdded;

        }
          }
}
