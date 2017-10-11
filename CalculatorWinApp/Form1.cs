using CalculatorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinApp
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aButton = (Button)sender;
            calculator.Press(aButton.Text);
            label1.Text = calculator.Display.ToString();
        }
    }
}
