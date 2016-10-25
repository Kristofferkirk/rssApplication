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
    public partial class addSettingsForm : Form
    {
        public addSettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form1 addSett = new Form1())
            {
                var getCategory = categoryBox1.SelectedItem.ToString();
                var newCategory = newCategoryBox.Text;
                if (addSett.ShowDialog() == DialogResult.OK)
                {
                    
                }
        }
        }
        public string getCategory()
        {
            var getCategory = categoryBox1.SelectedItem.ToString();
            var newCategory = newCategoryBox.Text;
           
            if(getCategory == "") //Kom på ett bättre sätt att kolla hur listboxen är tom
            {
                return newCategory;
                
            }
            else
            {
                return getCategory;
            }
        }
        public string getPodcastName()
        {
            var podcastName = newPodcastName.Text;
            return podcastName;
        }
    }
}
