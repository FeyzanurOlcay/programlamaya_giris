using System.Windows.Forms;

namespace matris1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[,] matris = new int[4, 4];
            listBox1.Items.Clear();
            string satir;
            for (int i = 0; i < 4; i++)
            {
                satir = " ";
                for (int j = 0; j < 4; j++)
                {
                    matris[i, j] = random.Next(0, 10);
                    satir += matris[i, j] + "     ";
                }
                listBox1.Items.Add(satir);

                
                int enBuyuk = matris[i, 0];
                int enKucuk = matris[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (matris[i, j] > enBuyuk)
                        enBuyuk = matris[i, j];

                    if (matris[i, j] < enKucuk)
                        enKucuk = matris[i, j];

                }
                Label[] kucukler = {label3,label4,label5,label6};
                Label[] buyukler = {label7,label8,label9, label10};
                buyukler[i].Text=enBuyuk.ToString();
                kucukler[i].Text = enKucuk.ToString();

                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
