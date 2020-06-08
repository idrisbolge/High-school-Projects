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
    public partial class personel_ekle : Form
    {
        public personel_ekle()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataAdapter adptr;
        public static string DosyaYolu;


        public string GenerateNewPassword(int size)
        {
            char[] cr = "0123456789".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seçiniz";
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.png|  Tüm Dosyalar |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                textBox5.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = textBox5.Text ;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tc,ad, dgmyeri, dgmtrh, baba, durumu;
            ad = textBox1.Text;
            dgmyeri = textBox4.Text;
            tc = textBox2.Text;
            baba = textBox3.Text;
            dgmtrh = dateTimePicker1.Value.ToString();
            durumu = "Aktif";


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanların Dolu Olduğuna Emin Olunuz...");
            }
            if (textBox5.Text == "")
            {
                pictureBox1.ImageLocation = "imag.png";
            }
            else
            {

                string parola;
                parola=GenerateNewPassword(4);
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "insert into personel (tckimlik,adsoyad,dogumtarihi,dogumyeri,babaadi,durumu,resim,mevki)values('" + tc + "','" + ad + "','" + dgmtrh + "','" + dgmyeri + "','" + baba + "','" + durumu + "','" + textBox5.Text +"','"+comboBox1.Text+"')";
                komut.ExecuteNonQuery();
                komut.CommandText = "insert into kullanici (adsoyad,sifre,mevki)values('"+textBox1.Text+"','"+parola+"','"+comboBox1.Text+"')";
                MessageBox.Show("Personel Şifresi : "+parola);
                komut.ExecuteNonQuery();

                MessageBox.Show("İşleminiz Kaydedildi..");
                bag.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                
            }
            yonetici yn = new yonetici();
            yn.Show();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            yonetici yn = new yonetici();
            yn.Show();
            this.Close();
        }

        private void personel_ekle_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            dateTimePicker1.TabIndex = 4;
            textBox4.TabIndex = 5;
            comboBox1.TabIndex = 6;
        }
    }
}
