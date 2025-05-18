namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        string[,] soruCevap =
        {
            {"10+5 Kaçtýr?","15","20","10","15"},
            {"Atatürk kaç yýlýnda doðmuþtur?","1883","1938","1881","1881"},
            {"Romeo ve Juliet adlý eserin yazarý kimdir?","Goethe","Sheakspeare","Çehov","Sheakspeare"},
            {"Ýstiklal Marþý kaç kýtadan oluþmaktadýr?","12","8","10","10"},
        };
        int soru = 0;
        bool cvp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button1.Text = "SONRAKÝ";


            if (cvp)
            {
                soru++;
                cvp = false;
            }
            else if (!cvp)
            {
                radioButton1.Text = soruCevap[soru, 1];
                radioButton2.Text = soruCevap[soru, 2];
                radioButton3.Text = soruCevap[soru, 3];

                string satýr = soruCevap[soru, 1];
                soruCevap[soru, 1] = soruCevap[soru, 2];
                soruCevap[soru, 2] = soruCevap[soru, 3];
                soruCevap[soru, 3] = satýr;
            }


            if (soru < soruCevap.GetLength(0))
            {
                label1.Text = soruCevap[soru, 0];
                radioButton1.Text = soruCevap[soru, 1];
                radioButton2.Text = soruCevap[soru, 2];
                radioButton3.Text = soruCevap[soru, 3];

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

            }
            else
            {
                MessageBox.Show("Tebrikler! Tüm sorularý cevapladýnýz.");
                groupBox1.Visible = false;
                button1.Text = "BAÞLA";
                button1.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {

                string sýklar = radioButton1.Checked ? radioButton1.Text :
                                radioButton2.Checked ? radioButton2.Text :
                                radioButton3.Text;
                if (sýklar == soruCevap[soru, 4])
                {
                    MessageBox.Show("Doðru Cevap!");
                    cvp = true;
                }
                else
                {
                    MessageBox.Show("Yanlýþ Cevap!");
                    cvp = false;

                }


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
