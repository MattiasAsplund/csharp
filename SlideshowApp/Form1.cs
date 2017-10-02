using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideshowApp
{
    public partial class Form1 : Form
    {
        private int fileNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayFileNumber(fileNumber);
            fileNumber++;
            if (fileNumber >= openFileDialog1.FileNames.Count())
            {
                fileNumber = 0;
            }
        }
        private void DisplayFileNumber(int fileNumber)
        {
            var s = 5000000000d;
            pictureBox1.ImageLocation = openFileDialog1.FileNames[fileNumber];
            pictureBox1.Load();
        }
    }
}
