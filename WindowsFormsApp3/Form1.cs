using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            getAnswer mdAnswer = new getAnswer(Class1.getSum);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdAnswer(num1,num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAnswer mdAnswer = new getAnswer(Class1.getDifference);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdAnswer(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getAnswer mdAnswer = new getAnswer(Class1.getProduct);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdAnswer(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getAnswer mdAnswer = new getAnswer(Class1.getQuotient);
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(mdAnswer(num1, num2).ToString());
        }
    }
}
