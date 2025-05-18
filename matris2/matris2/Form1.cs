using System.Threading;

namespace matris2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] adPozisyon =
        {
          {"Ahmet Yýlmazlar","Büro Personeli" },
          {"Merve Çelikdar","Yazýlým Geliþtirici"},
          {"Fatma Korkmaz","Mühendis" },
          {"Tayfun Görmez","Yazýlým Geliþtirici" },
          {"Selçuk Korkmaz","Pazarlama Uzmaný" },
          {"Büþra Kýlýçatar","Yönetici" },
          {"Ferdi Can Saðlam","Mühendis" },
        };



        private void button1_Click(object sender, EventArgs e)
        {
            string satýr;
            for (int i = 0; i < 7; i++)
            {
                satýr = "";

                for (int j = 0; j < 2; j++)
                {
                    satýr += adPozisyon[i, j] + "       ";
                }
                listBox1.Items.Add(satýr);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();

            listBox2.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                if (adPozisyon[i, 1] == secilen)
                {
                    listBox2.Items.Add(adPozisyon[i, 0]);
                }

            }

        }
    }
}
