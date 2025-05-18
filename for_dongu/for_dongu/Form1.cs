namespace for_dongu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int buyuk = -100;
            int kucuk = 100;
            listBox1.Items.Clear();


            for (int i = 1; i < 10; i++)
            {
                Random rastgele = new Random();
                sayi = rastgele.Next(-100, 100);
                listBox1.Items.Add(sayi);
                if (sayi < kucuk) kucuk = sayi;
                if (sayi > buyuk) buyuk = sayi;
            }
            label3.Text = buyuk.ToString();
            label5.Text = kucuk.ToString();


        }
    }
}