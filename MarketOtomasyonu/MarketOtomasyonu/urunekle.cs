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
    public partial class urunekle : Form
    {
        public urunekle()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void urunekle_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "insert into urun (urunkodu,urunadi,firma,alisf,satisf,kategori)values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show(" Kaydetme Başarılı");
        }
    }
}
