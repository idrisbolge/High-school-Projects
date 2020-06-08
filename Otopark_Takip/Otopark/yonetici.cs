using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otopark
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adptr;


        private void yonetici_Load(object sender, EventArgs e)
        {
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From personel";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[2]);
            }
            bag.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From personel where adsoyad='" + comboBox1.Text + "'";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text = oku[1].ToString();
                textBox2.Text = oku[5].ToString();
                textBox3.Text = oku[4].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(oku[3].ToString());
                comboBox2.Text = "";
                comboBox2.SelectedText = oku[6].ToString();
                textBox4.Text = oku[7].ToString();
                pictureBox1.ImageLocation = textBox4.Text;
                label7.Text=oku[0].ToString();

            }
            bag.Close();
            if (textBox4.Text=="")
            {
                pictureBox1.ImageLocation ="imag.png" ; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Lütfen Açılır Kutudan Bir Personel Seçiniz");
            }
            else
            {

            
            int id;
            id = int.Parse(label7.Text);
            string tc, baba, dgmyeri, durumu;
            DateTime trh;

            tc = textBox1.Text;
            baba = textBox2.Text;
            dgmyeri = textBox3.Text;
            durumu = comboBox2.Text;
            trh = Convert.ToDateTime(dateTimePicker1.Value.ToString());



            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update personel set tckimlik='" + tc + "',dogumtarihi='"+trh+"',dogumyeri='"+dgmyeri+"',babaadi='"+baba+"',durumu='"+durumu+"',resim='"+textBox4.Text+"' where id="+id;
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Çok Başarılı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel_ekle ek=new personel_ekle ();
            ek.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mevcut mv = new mevcut();
            mv.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris_Ekrani gr = new Giris_Ekrani();
            gr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            araclar ar = new araclar();
            ar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musbilgi ms = new musbilgi();
            ms.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gelir c = new gelir();
            c.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçiniz";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.png|  Tüm Dosyalar |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox4.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = textBox4.Text;
            }
        }
    }
}
