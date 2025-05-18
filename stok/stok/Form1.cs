namespace stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            double oran = Convert.ToDouble(textBox1.Text) / 100;
            double yeme = Convert.ToDouble(textBox2.Text) / 100;
            double tekno = Convert.ToDouble(textBox3.Text) / 100;
            double esya = Convert.ToDouble(textBox4.Text) / 100;
            double hafta = 0;


            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                double stok = Convert.ToDouble(listBox3.Items[i]);
                double normal = stok - (stok * oran);

                if (listBox1.Items[i].ToString() == "Yeme - Ýçme")
                {
                    hafta = normal - (stok * yeme);
                }
                if (listBox1.Items[i].ToString() == "Ev Eþyasý")
                {
                    hafta = normal - (stok * esya);
                }
                if (listBox1.Items[i].ToString() == "Teknoloji")
                {
                    hafta = normal - (stok * tekno);
                }


                listBox4.Items.Add(Convert.ToInt32(hafta));

            }
        }
    }
}
