using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt16(textBox1.Text);
            double num2 = Convert.ToInt16(textBox2.Text);
            double divide = num1 / num2;
            textBox3.Text = divide.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int multiply = num1 * num2;
            textBox3.Text = multiply.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int subtract = num1 - num2;
            textBox3.Text = subtract.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt16(textBox1.Text);
            int num2 = Convert.ToInt16(textBox2.Text);
            int addition = num1 + num2;
            textBox3.Text = addition.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
