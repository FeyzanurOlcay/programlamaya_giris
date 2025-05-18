namespace sehir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Ýstanbul");
            comboBox1.Items.Add("Niðde");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("Ýzmir");
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string il =comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();

            if (il == "Ankara")
            {
                listBox1.Items.Add("Çankaya");
                listBox1.Items.Add("Yeni Mahalle");
                listBox1.Items.Add("Sincan");
                listBox1.Items.Add("Etimesgut");
                listBox1.Items.Add("Keçiören");
            }
            if (il == "Ýstanbul")
            {
                listBox1.Items.Add("Kadýköy");
                listBox1.Items.Add("Avcýlar");
                listBox1.Items.Add("Baðcýlar");
                listBox1.Items.Add("Ataþehir");
                listBox1.Items.Add("Esenyurt");
            }
            if (il == "Niðde")
            {
                listBox1.Items.Add("Bor");
                listBox1.Items.Add("Altunhisar");
                listBox1.Items.Add("Çiftlik");
                listBox1.Items.Add("Çamardý");
                listBox1.Items.Add("Ulukýþla");
            }
            if (il == "Adana")
            {
                listBox1.Items.Add("Çukurova");
                listBox1.Items.Add("Seyhan");
                listBox1.Items.Add("Aladað");
                listBox1.Items.Add("Pozantý");
                listBox1.Items.Add("Ceyhan");

            }
            if (il == "Ýzmir")
            {
                listBox1.Items.Add("Buca");
                listBox1.Items.Add("Çeþme");
                listBox1.Items.Add("Foça");
                listBox1.Items.Add("Ödemiþ");
                listBox1.Items.Add("Menemen");
            }
        }
    }
}