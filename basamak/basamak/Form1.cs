using System.Windows.Forms;

namespace basamak
{
    public partial class Form1 : Form
    {

        int yuzler;
        int onlar;
        int birler;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            yuzler = (int)numericUpDown1.Value;
            numericUpDown1.Minimum = 1; numericUpDown1.Maximum = 9; ;
            label4.Text = Convert.ToString(yuzler * 100);
            label4.Text = Convert.ToString(yuzler * 100 + onlar * 10 + birler * 1);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            onlar = (int)numericUpDown2.Value;
            numericUpDown2.Minimum = 0; numericUpDown2.Maximum = 9; ;
            label4.Text = Convert.ToString(onlar * 10);
            label4.Text = Convert.ToString(yuzler * 100 + onlar * 10 + birler * 1);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            birler = (int)numericUpDown3.Value;
            numericUpDown3.Minimum = 0; numericUpDown3.Maximum = 9; ;
            label4.Text = Convert.ToString(birler * 1);
            label4.Text = Convert.ToString(yuzler * 100 + onlar * 10 + birler * 1);
        }
    }
}