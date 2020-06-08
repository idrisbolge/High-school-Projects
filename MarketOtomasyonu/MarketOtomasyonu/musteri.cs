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
    public partial class musteri : Form
    { 

       
        public musteri()
        { 
            InitializeComponent();
        }     
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        public void listeleme()
        { 
         tablo.Clear();
         OleDbDataAdapter adptr=new OleDbDataAdapter("Select * from musteri",bag);
         adptr.Fill(tablo);
         dataGridView1.DataSource = tablo;
        }

        private void musteri_Load(object sender, EventArgs e)
        {

            listeleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle ekl = new musteriekle();
            ekl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listeleme();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update musteri set tckimlik='" + textBox1.Text + "',adi='"+textBox2.Text+"',soyadi='"+textBox3.Text+"',ceptel='"+textBox4.Text+"',evtel='"+textBox5.Text+"',adres='"+textBox6.Text+"'";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Gerekli Düzeltme Yapıldı");
            listeleme();
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
                OleDbDataAdapter adptr = new OleDbDataAdapter("select * from musteri where adi like'"+textBox7.Text+"%'",bag);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listeleme();
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "delete  from musteri where tckimlik= '"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'" ;
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
    }
}
