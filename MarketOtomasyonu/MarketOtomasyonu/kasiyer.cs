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

namespace MarketOtomasyonu
{
    public partial class kasiyer : Form
    {
        public kasiyer()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        public void listeleme()
        {
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from kasiyer", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void kasiyer_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ksekle ks = new ksekle();
            ks.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeleme();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update kasiyer set kasadi='" + textBox1.Text + "',kassoyad='" + textBox2.Text + "',tckimlik='" + textBox3.Text + "',telefon='" + textBox4.Text + "',adres='" + textBox5.Text + "',maas='" + textBox6.Text + "',gorevlikasa='" + textBox7.Text + "' where tckimlik='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Gerekli Düzeltme Yapıldı");
            listeleme();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeleme();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "delete  from kasiyer where tckimlik= '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme Yapıldı");
            listeleme();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                listeleme();
            }
            else
            {

                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("select * from kasiyer where kasadi like'" + textBox8.Text + "%'", bag);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
    }
}
