using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daireninAlanı
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(textBox1.Text);
            double pi = 3.14;
            double c = pi * (a * a);
            double d = 2 * pi * a;
            label4.Text = Convert.ToString(c);
            label5.Text = Convert.ToString(d);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
