using System.Threading;

namespace matris2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] adPozisyon =
        {
          {"Ahmet Y�lmazlar","B�ro Personeli" },
          {"Merve �elikdar","Yaz�l�m Geli�tirici"},
          {"Fatma Korkmaz","M�hendis" },
          {"Tayfun G�rmez","Yaz�l�m Geli�tirici" },
          {"Sel�uk Korkmaz","Pazarlama Uzman�" },
          {"B��ra K�l��atar","Y�netici" },
          {"Ferdi Can Sa�lam","M�hendis" },
        };



        private void button1_Click(object sender, EventArgs e)
        {
            string sat�r;
            for (int i = 0; i < 7; i++)
            {
                sat�r = "";

                for (int j = 0; j < 2; j++)
                {
                    sat�r += adPozisyon[i, j] + "       ";
                }
                listBox1.Items.Add(sat�r);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();

            listBox2.Items.Clear();

            for (int i = 0; i < 7; i++)
            {
                if (adPozisyon[i, 1] == secilen)
                {
                    listBox2.Items.Add(adPozisyon[i, 0]);
                }

            }

        }
    }
}
