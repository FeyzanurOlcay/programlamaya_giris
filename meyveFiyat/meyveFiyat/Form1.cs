using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meyveFiyat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string meyve = textBox1.Text;
            int kilo = Convert.ToInt32(textBox2.Text);
            if (meyve == "Elma" && kilo < 5)
            {
                int ücret = kilo * 25;
                label4.Text = Convert.ToString(ücret);
            }
            if (meyve == "Elma" && kilo >= 5)
            {
                int ücret = kilo * 21;
                label4.Text = Convert.ToString(ücret);
            }
            if (meyve == "Armut" && kilo < 5)
            {
                int ücret = kilo * 40;
                label4.Text = Convert.ToString(ücret);
            }

            if (meyve == "Armut" && kilo >= 5)
            {
                int ücret = kilo * 33;
                label4.Text = Convert.ToString(ücret);
            }

            if (meyve == "Portakal" && kilo < 5)
            {
                int ücret = kilo * 35;
                label4.Text = Convert.ToString(ücret);
            }

            if (meyve == "Portakal" && kilo >= 5)
            {
                int ücret = kilo * 28;
                label4.Text = Convert.ToString(ücret);
            }
            if (meyve == "Ayva" && kilo < 5)
            {
                int ücret = kilo * 50;
                label4.Text = Convert.ToString(ücret);
            }
            if (meyve == "Ayva" && kilo >= 5)
            {
                int ücret = kilo * 45;
                label4.Text = Convert.ToString(ücret);
            }

        }
    }
}
