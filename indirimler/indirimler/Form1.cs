namespace indirimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double para = Convert.ToDouble(textBox1.Text);

            if (radioButton1.Checked) 
            {
                para = para * 0.90;
                label3.Text = para.ToString(); 
            }
            if (radioButton3.Checked)
            {
                para = para * 0.75;
                label3.Text = para.ToString();
            }
            if (radioButton2.Checked)
            {
                para = para * 0.50;
                label3.Text = para.ToString();
            }
        }
    }
}