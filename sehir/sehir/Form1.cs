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
            comboBox1.Items.Add("�stanbul");
            comboBox1.Items.Add("Ni�de");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("�zmir");
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string il =comboBox1.SelectedItem.ToString();
            listBox1.Items.Clear();

            if (il == "Ankara")
            {
                listBox1.Items.Add("�ankaya");
                listBox1.Items.Add("Yeni Mahalle");
                listBox1.Items.Add("Sincan");
                listBox1.Items.Add("Etimesgut");
                listBox1.Items.Add("Ke�i�ren");
            }
            if (il == "�stanbul")
            {
                listBox1.Items.Add("Kad�k�y");
                listBox1.Items.Add("Avc�lar");
                listBox1.Items.Add("Ba�c�lar");
                listBox1.Items.Add("Ata�ehir");
                listBox1.Items.Add("Esenyurt");
            }
            if (il == "Ni�de")
            {
                listBox1.Items.Add("Bor");
                listBox1.Items.Add("Altunhisar");
                listBox1.Items.Add("�iftlik");
                listBox1.Items.Add("�amard�");
                listBox1.Items.Add("Uluk��la");
            }
            if (il == "Adana")
            {
                listBox1.Items.Add("�ukurova");
                listBox1.Items.Add("Seyhan");
                listBox1.Items.Add("Alada�");
                listBox1.Items.Add("Pozant�");
                listBox1.Items.Add("Ceyhan");

            }
            if (il == "�zmir")
            {
                listBox1.Items.Add("Buca");
                listBox1.Items.Add("�e�me");
                listBox1.Items.Add("Fo�a");
                listBox1.Items.Add("�demi�");
                listBox1.Items.Add("Menemen");
            }
        }
    }
}