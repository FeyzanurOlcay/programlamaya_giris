using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayiTahmini
{
    public partial class Form1 : Form

    {
        int rastgeleSayi;
        int tahminHakki = 3; // Formun tamamında kullanabilmek için 2 tane değişken tanımladık.
        Random rastgele = new Random(); // Rastgele sayı seçebilmek için random atadık.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rastgeleSayi = rastgele.Next(1, 11); // İstenen aralıktan sayı seçtirdik.
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int kullaniciTahmini = Convert.ToInt32(textBox1.Text);// Kullanıcıdan değeri aldık.


            if (kullaniciTahmini == rastgeleSayi) // Eğer kullanıcı tahmini doğruysa bu if bloğu çalışacak ve sıfırlanacak.
            {
                MessageBox.Show("Tebrikler! Sayıyı doğru tahmin ettiniz.");
                label3.Text = rastgeleSayi.ToString();
                ResetGame();
            }
            else // Eğer kullanıcı hatalı tahminde bulunduysa bu bloğa geçecek.
            {
                if (kullaniciTahmini > rastgeleSayi) // Kullanıcının tahmin ettiği sayı seçilen sayıdan büyük ise bulunduğu aralık değişecek ve tahmin hakkı azalacak.
                {
                    label5.Text = kullaniciTahmini.ToString();
                    tahminHakki--;
                    label7.Text = tahminHakki.ToString();
                }
                else // Eğer tam tersiyse aralık aynı kalacak ama tahmin hakkı azalacak.
                {
                    tahminHakki--;
                    label7.Text = tahminHakki.ToString();
                }

                if (tahminHakki == 0) // Tahmin hakkı bittiğinde doğru sayıyı gösterecek ve sıfırlanacak.
                {
                    MessageBox.Show("Tahmin hakkınız bitti! Doğru sayı: " + rastgeleSayi);
                    ResetGame();
                }
            }
        }
        private void ResetGame() // Tekrar en başa döndürüyor.
        {
            tahminHakki = 3;
            label7.Text = tahminHakki.ToString();
            rastgeleSayi = rastgele.Next(1, 11);
            label5.Text = "11";
            label3.Text = "?";
            textBox1.Text = "";


        }

    }
}
