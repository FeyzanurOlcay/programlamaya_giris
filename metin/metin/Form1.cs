using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace metin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void dosyaEkle()
        {
            string dosyayolu = @"taslak.txt";
            string  metin = textBox2.Text;
            File.WriteAllText( dosyayolu, metin );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"taslak.txt";
            string metin = File.ReadAllText(dosyaYolu);
            textBox1.Text = metin;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string metin = textBox1.Text;
            string duzeltilmis = "";

            int i = 0;
            while (i < metin.Length)
            {
                if (metin[i] == ' ' && i + 1 < metin.Length && metin[i + 1] == ' ')
                {
                    i++;
                }

                else
                {
                    duzeltilmis += metin[i];
                    i++;
                }

            }
            textBox2.Text = duzeltilmis;
            dosyaEkle();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dosyaYolu = @"taslak.txt";
            string metin = File.ReadAllText(dosyaYolu);
            textBox1.Text = metin;

            string yeniMetin = Regex.Replace(metin, @"\.\s*\w", m => m.Value.ToUpper());

            textBox2.Text = yeniMetin;
            dosyaEkle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] kelimeler = metin.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (kelimeler[i].ToLower() == "eda")
                {
                    kelimeler[i] = "seda";
                }
            }
            textBox2.Text = string.Join(" ", kelimeler);
            dosyaEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string[] kelimeler = metin.Split(' ');
            int adet = 0;
            for (int i = 0; i < kelimeler.Length; i++)
            {
                adet++;
            }
            MessageBox.Show(adet.ToString());
            dosyaEkle();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string yeniMetin = "";

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == '.' && (i == metin.Length - 1 || metin[i + 1 ]!= ' '))
                {
                    yeniMetin += metin[i] + " ";
                }
                else
                {
                    yeniMetin += metin[i];
                }
            }
            textBox2.Text = yeniMetin;
            dosyaEkle();
            // HEPSÝ BÝRBÝRÝNE GÝRDÝ HOCAM YAPAMADIM.
        }
    }
}
