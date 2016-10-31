using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CSharpProject;

namespace CSharpProject.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        getItemXML one = new getItemXML();
        xmlRetriever retRiver = new xmlRetriever();
        MainWindow first = new MainWindow();
        
        public Window1()
        {
            InitializeComponent();
        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                string urlInput = rssInput.Text;
                
                string nameOfFeed = nameBox.Text;
                string title = retRiver.getXML(urlInput, nameOfFeed);
                Console.WriteLine(title);
                
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Empty",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                
                
            }
            catch(IndexOutOfRangeException ex2)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex2);
                throw ex2;
            }
            
            
            
        }
       
    }
}
