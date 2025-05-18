using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(101);
            label1.Text = sayi.ToString();


            int sayi2 = rastgele.Next(101);
            label3.Text = sayi2.ToString();

            int sonuc = sayi + sayi2;
            label5.Text = sonuc.ToString();
        }
    }
}
