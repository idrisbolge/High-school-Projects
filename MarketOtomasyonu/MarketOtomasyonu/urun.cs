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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        public void listeleme()
        {
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from urun", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void urun_Load(object sender, EventArgs e)
        {
            listeleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunekle ekle = new urunekle();
            ekle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeleme();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update urun set urunkodu='" + textBox1.Text + "',urunadi='" + textBox2.Text + "',firma='" + textBox3.Text + "',alisf='" + textBox4.Text + "',satisf='" + textBox5.Text + "',kategori='" + textBox6.Text + "' where urunkodu='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
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
            komut.CommandText = "delete  from urun where urunkodu= '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silme Yapıldı");
            listeleme();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                listeleme();
            }
            else
            {

                tablo.Clear();
                OleDbDataAdapter adptr = new OleDbDataAdapter("select * from urun where urunadi like'" + textBox7.Text + "%'", bag);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
    }
}
