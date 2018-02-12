using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString(int.Parse(textBox1.Text)% int.Parse(textBox2.Text));
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Text = Convert.ToString(Math.Pow((int.Parse(textBox1.Text)), (int.Parse(textBox2.Text))));
            }
            if (radioButton3.Checked == true)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if (radioButton4.Checked == true)
            {
                textBox3.Text = Convert.ToString(int.Parse(textBox1.Text)/int.Parse(textBox2.Text));
            }

        }
    }
}
