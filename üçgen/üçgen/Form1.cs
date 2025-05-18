namespace üçgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ucgen = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Clear();

            for (int i = 0; i < ucgen; i++)
            {
                string nokta = " . ";
                for (int j = 1; j <= i; j++)
                {
                    nokta = nokta + " . ";
                }
                listBox1.Items.Add(nokta);

            }

        }
    }
}