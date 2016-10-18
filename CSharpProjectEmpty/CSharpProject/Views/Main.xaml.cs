using System;
using System.Windows;

namespace CSharpProject.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void addPodcastButton_Click(object sender, RoutedEventArgs e)
        {
            var addPodcast = new Form1();
            addPodcast.Show();
        }
    }
}
