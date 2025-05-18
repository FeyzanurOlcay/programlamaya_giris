using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleİndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text);// Kullanıcıdan boy ve kilo değerlerini aldık.
            double kilo = Convert.ToDouble(textBox2.Text);

            double boyMetre = boy / 100; // Boy uzunluğunu metreye çevirdik.

            double endeks = kilo / (boyMetre * boyMetre);// Endeks hesaplama formülünü yazdık.
            label5.Text = endeks.ToString();// Çıkan sonucu endeks kısmına yazdırdık.

            if (endeks <= 18.5) // Çıkan endeks sonucuna göre durumları belirttik.
            {
                label6.Text = "İdeal kilonun altında";
            }
            if (endeks > 18.5 && endeks <= 24.9)
            {
                label6.Text = "İdeal Kiloda";
            }
            if (endeks >= 25 && endeks <= 29.9)
            {
                label6.Text = "İdeal kilonun üstünde";
            }
            if (endeks >= 30 && endeks <= 39.9)
            {
                label6.Text = "İdeal kilonun çok üstünde (Obez)";
            }
            if (endeks >= 40)
            {
                label6.Text = "İdeal kilonun çok üstünde (Morbid Obez)";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
