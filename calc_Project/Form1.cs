using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_Project
{
    public partial class Form1 : Form
    {
       public string operation;
        public double number1=0;
        public double number2=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
           
        }

        private void button_Click(object sender, EventArgs e)
        {

           
                textBox1.Text += ((Button)sender).Text;
            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = "/";
            if (textBox1.Text != null)
                number1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = "*";
            if (textBox1.Text != null)
                number1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "+";
            if (textBox1.Text != null)
                number1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operation = "-"; 
            if (textBox1.Text != null)
            number1 = double.Parse(textBox1.Text);
            textBox1.Text = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operation = "Log";
            textBox1.Text = null;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            operation = "Cos";
            textBox1.Text = null;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            operation = "Sin";
            textBox1.Text = null;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            operation = "Tan";
            textBox1.Text = null;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                if (textBox1.Text != null)
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (number1 + number2).ToString();
                
            }
            if (operation == "*")
            {
                if (textBox1.Text != null)
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (number1 * number2).ToString();

            }
            if (operation == "/")
            {
                if (textBox1.Text != null)
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (number1 / number2).ToString();

            }
            if (operation == "-")
            {
                if (textBox1.Text != null)
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (number1 - number2).ToString();

            }
            if(operation=="Log")
            {
                number1 = 0;
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (Math.Log10(number2)).ToString();

            }
           if (operation == "Cos")
            {
                    number1 = 0;
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (Math.Cos((number2*3.14)/180)).ToString();

            }
            if (operation == "Sin")
            {
                number1 = 0;
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (Math.Sin((number2 * 3.14) / 180)).ToString();

            }
            if (operation == "Tan")
            {
                number1 = 0;
                    number2 = double.Parse(textBox1.Text);
                textBox1.Text = (Math.Tan((number2 * 3.14) / 180)).ToString();

            }
        }

        
    }
}
