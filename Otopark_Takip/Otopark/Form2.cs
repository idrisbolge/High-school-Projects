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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            arama();
        }


        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand("select * from musbil where onay=false");
        public OleDbDataAdapter adptr;

        public void arama()
        {            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From musbil where onay=false";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                coll.Add(oku[4].ToString());
            }
            comboBox1.AutoCompleteCustomSource = coll;
            bag.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            timer1.Enabled = true;
            //DateTime suanki = DateTime.Now;
            //label9.Text = suanki.ToString();

            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From musbil where onay=false";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[4]);
            }
            bag.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From musbil where PlakaNu='"+comboBox1.Text+"'";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
               textBox1.Text = oku[5].ToString();
               textBox2.Text = oku[6].ToString();
               textBox3.Text = oku[1].ToString();
               textBox4.Text = oku[2].ToString();
               textBox5.Text = oku[3].ToString();
               textBox6.Text = oku[7].ToString();
               textBox7.Text = oku[8].ToString();
               label12.Text  = oku[0].ToString();
            }
            bag.Close();
            
            TimeSpan sonuc = Convert.ToDateTime(label9.Text) - Convert.ToDateTime(textBox7.Text);
            double sayi = Convert.ToDouble(sonuc.TotalHours.ToString());
            label11.Text = Math.Floor(sayi).ToString();
            int zaman = int.Parse(label11.Text);
    
            if (zaman==0 && zaman<1)
            {
                textBox8.Text = "5"; 
            }

            if (zaman<0)
            {
                MessageBox.Show("Yönetici Hatası . Zaman Geriye Akmıyor. :)");  
            }


            if (zaman>1)
            {
                int ucret;
                ucret = zaman*5;
                textBox8.Text = ucret.ToString();
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            komut.Connection = bag;
            bag.Open();
            komut.CommandText = "update musbil set onay=true,cıkıssaati='" + label9.Text + "',ucret='" + textBox8.Text + "' where id="+label12.Text;
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("İşleminiz Kaydedildi" + Environment.NewLine + "Ücretiniz :"+textBox8.Text+" TL."+ Environment.NewLine + ""+ Environment.NewLine +"Yine Bekleriz..");
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
