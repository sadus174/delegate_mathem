using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate_mathem
{
    public partial class Form1 : Form
    {

        delegate double Operation(int x, int y);
        Math math = new Math();


        public Form1()
        {
            InitializeComponent();
        }

        class Math
        {
            public double sum(int x, int y)
            {
                return x + y;
            }
            public double vich(int x, int y)
            {
                return x - y;
            }
            public double del(int x, int y)
            {
                return x - y;
            }
            public double proizv(int x, int y)
            {
                return x * y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation sum = math.sum;
            label1.Text = sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation vich = math.vich;
            label1.Text = vich(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation proizv = math.proizv;
            label1.Text = proizv(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operation del = math.del;
            label1.Text = del(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
