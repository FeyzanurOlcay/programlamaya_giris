namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        string[,] soruCevap =
        {
            {"10+5 Ka�t�r?","15","20","10","15"},
            {"Atat�rk ka� y�l�nda do�mu�tur?","1883","1938","1881","1881"},
            {"Romeo ve Juliet adl� eserin yazar� kimdir?","Goethe","Sheakspeare","�ehov","Sheakspeare"},
            {"�stiklal Mar�� ka� k�tadan olu�maktad�r?","12","8","10","10"},
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
            button1.Text = "SONRAK�";


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

                string sat�r = soruCevap[soru, 1];
                soruCevap[soru, 1] = soruCevap[soru, 2];
                soruCevap[soru, 2] = soruCevap[soru, 3];
                soruCevap[soru, 3] = sat�r;
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
                MessageBox.Show("Tebrikler! T�m sorular� cevaplad�n�z.");
                groupBox1.Visible = false;
                button1.Text = "BA�LA";
                button1.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {

                string s�klar = radioButton1.Checked ? radioButton1.Text :
                                radioButton2.Checked ? radioButton2.Text :
                                radioButton3.Text;
                if (s�klar == soruCevap[soru, 4])
                {
                    MessageBox.Show("Do�ru Cevap!");
                    cvp = true;
                }
                else
                {
                    MessageBox.Show("Yanl�� Cevap!");
                    cvp = false;

                }


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
