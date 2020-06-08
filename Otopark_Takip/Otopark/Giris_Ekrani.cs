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
    public partial class Giris_Ekrani : Form
    {
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand("select * from kullanici");
        public OleDbDataAdapter adptr;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==label4.Text)
            {
                if (label3.Text == "Yönetici")
                {
                    yonetici yn = new yonetici();
                    yn.Show();
                    this.Hide();
                }

                if (label3.Text == "Personel")
                {
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                }

               
            }
            else
            {
                MessageBox.Show("Lütfen Girdiğiniz Verilerin Doğru Olduğuna Emin Olunuz..");
            }
        
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void Giris_Ekrani_Load(object sender, EventArgs e)
        {
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From kullanici";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[1]);
            }
            bag.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader oku;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "Select * From kullanici where adsoyad='"+comboBox1.Text+"'";
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                label3.Text=(oku[3].ToString());
                label4.Text = (oku[2].ToString());
            }
            bag.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == label4.Text)
                {
                    if (label3.Text == "Yönetici")
                    {
                        yonetici yn = new yonetici();
                        yn.Show();
                        this.Hide();
                    }

                    if (label3.Text == "Personel")
                    {
                        Form1 fr = new Form1();
                        fr.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Lütfen Girdiğiniz Verilerin Doğru Olduğuna Emin Olunuz..");
                }
            }
        }
    }
}
