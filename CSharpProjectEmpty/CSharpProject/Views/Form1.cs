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
        
        getItemXML one = new getItemXML();
        xmlRetriever retRiver = new xmlRetriever();

        public Form1()
        {
            InitializeComponent();
           
            

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
                string urlInput = urlBox1.Text;
                string podName = nameField1.Text;
                string title = retRiver.getXML(urlInput);
                listBox1.Items.Add(title);
            }
            catch(Exception someExc)
            {
                MessageBox.Show(someExc.Message, "Some title",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSettingsForm addWin1 = new addSettingsForm();
            if(addWin1.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(addWin1.getPodcastName());
                listBox3.Items.Add(addWin1.getCategory());
               
            }
            listBox1.Refresh();
            listBox3.Refresh();
            addWin1.Close();
            addWin1.Dispose();
            
        }
    }
}
