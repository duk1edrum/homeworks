using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string s1;
        string s2;
        int a1;
        int a2;
        int b;
        int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s1 = textBox1.Text;
            a1 = int.Parse(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString((a1 + a2)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sum = a1 + a2;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s2 = textBox2.Text;
            a2 = int.Parse(textBox1.Text);
        }
    }
}
