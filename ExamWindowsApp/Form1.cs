using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWindowsApp
{
    public partial class Form1 : Form
    {
        private Exam anExam = new Exam("CSharp");
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIG_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text);
            anExam.Assign(student);
            comboBox1.Items.Add(student);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anExam.Grade((Student)comboBox1.SelectedItem, 
                comboBox2.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gradeCountDictionary = anExam.GenerateStatistics();
            var ig = gradeCountDictionary["IG"];
            var g = gradeCountDictionary["G"];
            var vg = gradeCountDictionary["VG"];
            lblIG.Text = $"IG: {ig}";
            lblG.Text = $"G: {g}";
            lblVG.Text = $"VG: {vg}";
        }
    }
}
