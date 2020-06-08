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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();

        public void listeleme()
        {
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from urun", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        public void listelemestk()
        {
            tablo2.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from stok", bag);
            adptr.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
        }
        private void stok_Load(object sender, EventArgs e)
        {
            listeleme();
            listelemestk();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "insert into stok (urunnu,urunadi,birimfiyat,kdv,adet)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show(" Stok İşlemi Başarılı");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int toplam;
            int eskiadet;
            int adet;
            eskiadet = int.Parse(textBox7.Text);       
            adet = int.Parse(textBox6.Text);
            toplam = (eskiadet + adet);
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "update stok set adet='" + toplam.ToString() + "'where urunnu='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'";
            komut.ExecuteNonQuery();
            bag.Close();
            
            MessageBox.Show(" Stok Yenileme İşlemi Başarılı");
                listelemestk();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox7.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
