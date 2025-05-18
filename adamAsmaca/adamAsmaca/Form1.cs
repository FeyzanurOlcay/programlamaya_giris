namespace adamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] kelimeler =
        {
            {"Þehir","kastamonu","niðde","samsun","kütahya","yalova" ,"elazýð"},
            {"Ülke","fransa","portekiz","almanya","rusya","azerbaycan","Türkiye"},
            {"Meslek","doktor","mühendis","hemþire","pilot","öðretmen","çiftçi"},

        };
        string secilenKelime;
        string tur;
        int tahminHakki = 6;

        private void kelimebelirle()
        {
            Random rnd = new Random();
            int türsec = rnd.Next(kelimeler.GetLength(0));
            int kelimesec = rnd.Next(1, kelimeler.GetLength(1));

            tur = kelimeler[türsec, 0];
            secilenKelime = kelimeler[türsec, kelimesec];

            label1.Text = " KONU: " + tur;
            label2.Text = secilenKelime.Length + "  harfli bir kelime";

            label3.Text = "";
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                label3.Text += "_ ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            kelimebelirle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char tahminHarfi = textBox1.Text.ToLower()[0];
            textBox1.Clear();

            if (secilenKelime.Contains(tahminHarfi))
            {
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == tahminHarfi)
                    {
                        label3.Text = label3.Text.Substring(0, i * 2) + tahminHarfi + " " + label3.Text.Substring((i * 2) + 2);
                    }
                }
            }
            else
            {

                tahminHakki--;
                switch (tahminHakki)
                {
                    case 5:
                        pictureBox1.Image = Properties.Resources.adam1;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.adam2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.adam3;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.adam4;
                        break;
                    case 1:
                        pictureBox1.Image = Properties.Resources.adam5;
                        break;
                    case 0:
                        pictureBox1.Image = Properties.Resources.adam6;
                        MessageBox.Show("Adamýnýz asýldý!! Doðru kelime:  " + secilenKelime);
                        button2.Enabled = false;
                        break;
                }

            }

            if (label3.Text.Replace(" ", "") == secilenKelime)
            {
                MessageBox.Show("Tebrikler! Kazandýnýz!");
                button2.Enabled = false;
            }

            textBox1.Text = "";
        }
    }
}
