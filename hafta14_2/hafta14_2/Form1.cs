using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace hafta14_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=liste.accdb; Persist Security Info= false;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From liste");
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciNo"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["bolum"].ToString());
                ekle.SubItems.Add(oku["sinif"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenciNo = textBox1.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            string bolum = textBox4.Text;
            string sinif = textBox5.Text;
            OleDbCommand komut = new OleDbCommand("insert into liste(ogrenciNo,ad,soyad,bolum,sinif) values('" + ogrenciNo + "','" + ad + "','" + soyad + "','" + bolum + "','" + sinif + "')", baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = ("Select * From liste");
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["ogrenciNo"].ToString();
                    ekle.SubItems.Add(oku["ad"].ToString());
                    ekle.SubItems.Add(oku["soyad"].ToString());
                    ekle.SubItems.Add(oku["bolum"].ToString());
                    ekle.SubItems.Add(oku["sinif"].ToString());
                    listView1.Items.Add(ekle);
               
            }
            baglanti.Close();
        }
    }
}
