using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Graphics g;
        string operation = "";
        Font drawFont = new Font("Arial", 16);
        SolidBrush brush = new SolidBrush(Color.Pink);
        RadioButton radioButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = "+";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = "-";
            }
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = "/";
            }
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operation = "*";
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text),
                b = Convert.ToDouble(textBox2.Text);
            double result = 0;

            switch(operation) { 
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                    case "-":
                    {
                        result = a - b;
                        break;
                    }
                    case "/":
                    {
                        result = a / b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;
                    }

            }
            
            g = CreateGraphics();
            Refresh();
            g.DrawString(result.ToString(), drawFont, brush, 150, 300);
        }
    }
}
