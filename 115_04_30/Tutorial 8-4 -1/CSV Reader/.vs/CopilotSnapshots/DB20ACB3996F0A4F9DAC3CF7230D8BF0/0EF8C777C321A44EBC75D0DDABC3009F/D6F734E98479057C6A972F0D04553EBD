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

namespace CSV_Reader
{

    struct Student
    {
        public string Class;
        public string Name;
        public string Id;
        public int[] Scores;
    }
    public partial class Form1 : Form
    {   
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            char[] delimiters = { ',' };
            gradeBook.Clear();
            averagesListBox.Items.Clear();

            using(inputFile = File.OpenText("Grades.csv"))
            {
                string line;
                while(!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();
                    string[] fields = line.Split(delimiters);
                    if(fields.Length==5)
                    {
                        Student student = new Student();
                        student.Class = fields[0];
                        student.Name = fields[1];
                        student.Id = fields[2];
                        student.Scores = new int[2];
                        student.Scores[0] = int.Parse(fields[3]);
                        student.Scores[1] = int.Parse(fields[4]);

                        gradeBook.Add(student);

                        int total = student.Scores[0] + student.Scores[1];
                        double average = (double)total / student.Scores.Length;
                        averagesListBox.Items.Add(student.Name + " 平均成績: " + average.ToString("F2"));
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤: " + line);
                    }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
