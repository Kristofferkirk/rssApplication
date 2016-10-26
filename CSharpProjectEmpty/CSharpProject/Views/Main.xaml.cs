using System;
using System.Windows;
using System.Data;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace CSharpProject.Views
{
    public partial class MainWindow : Window
    {
        // private User obj = new User(); // Create a user object class
        
        public void PassValue(string strValue)
        {
            rssName1.Text = strValue;
        }

        public MainWindow()
        {
           InitializeComponent();
            xmlStartUp();
            
           
           
        }
        private void xmlStartUp()
        {
            generateXML.Main();
        }
        private void addPodcastButton_Click(object sender, RoutedEventArgs e)
        {
            var addPodcast = new Window1();
            var thisWindow = new MainWindow();

            addPodcast.Show();
            
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            rssName1.Text = Path.GetFileNameWithoutExtension(@"C: \Users\Kristoffer\Source\Repos\rssApplication\CSharpProjectEmpty\CSharpProject\bin\Debug\data.xml").ToUpper();
        }
        
        public TextBox rssname1
        {
            get
            {
                return rssname1;
            }
        }
    }
}
