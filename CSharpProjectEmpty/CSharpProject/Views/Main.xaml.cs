using System;
using System.Windows;

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
           // obj.UserName = "";
           // obj.Subscribed = "";
           // DisplayUi(obj);
           
        }
        /*private void DisplayUi(User o)
        {


        }
        */
        private void addPodcastButton_Click(object sender, RoutedEventArgs e)
        {
            var addPodcast = new Window1();
            var thisWindow = new MainWindow();

            addPodcast.Show();
            
        }
    }
}
