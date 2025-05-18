namespace sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string sifrelenmis = "";

            for (int i = 0; i < metin.Length; i++)
            {
                char karakter = metin[i];

                if (char.IsLetter(metin[i]))
                {
                    char yeni = (char)(karakter + 2);
                    if (yeni > 'z')
                        yeni = (char)(yeni - 26);
                    sifrelenmis += yeni;

                    label3.Text = sifrelenmis;
                }
                else
                {
                    sifrelenmis += metin;
                }
            }
        }
    }
}