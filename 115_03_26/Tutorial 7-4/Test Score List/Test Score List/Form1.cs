using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

       

        private void readScoresButton_Click(object sender, EventArgs e)
        {
           string filePath="TextScores.txt";
            try
            {
               using(StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Add each line to the ListBox.
                        scoresListBox.Items.Add(line);
                    }
                }
            }
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
