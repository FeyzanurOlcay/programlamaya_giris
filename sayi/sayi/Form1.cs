namespace sayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] sayilar = new int[10];
            int sayi;
            int sec =0;
            listBox1.Items.Clear();
            Random random = new Random();


            for (int i = 0; i < 10;)
            {
                bool durum= true;
                sayi = random.Next(1, 21);

                for (int j = 0; j < sec; j++)
                {
                    if (sayilar[j] == sayi)
                    {
                        durum = false;
                        break;
                   
                    }
                }
                if(durum) 
                {
                    sayilar[sec] = sayi;
                    listBox1.Items.Add(sayi);
                    sec++;
                    i++;
                }
             

            }
        }
    }
}