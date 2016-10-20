using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProject.Views
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var xmlGet = new xmlRetriever();
            
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string urlInput = textBox1.Text;
                xmlRetriever.getXML(urlInput);

            }
            catch(Exception error1)
            {
                Console.WriteLine(error1);
            }


        }
    }
}
