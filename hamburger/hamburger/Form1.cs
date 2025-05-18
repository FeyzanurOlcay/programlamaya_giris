namespace hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            string firma = comboBox1.Text;
            listBox1.Items.Add("Firma Tercihi : " + firma);
            string hamburger = "";
            string sos = "";


            if (radioButton1.Checked)
            {
                hamburger = radioButton1.Text;
                listBox1.Items.Add("Hamburger Tercihi : " + hamburger);

            }
            if (radioButton2.Checked)
            {
                hamburger = radioButton2.Text;
                listBox1.Items.Add("Hamburger Tercihi : " + hamburger);
            }
            if (checkBox1.Checked)
            {
                sos = checkBox1.Text;
                listBox1.Items.Add("Sos Tercihi : " + sos);
            }
            if (checkBox2.Checked)
            {
                sos = checkBox2.Text;
                listBox1.Items.Add("Sos Tercihi : " + sos);
            }







        }
    }
}