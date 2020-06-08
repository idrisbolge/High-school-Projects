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
    public partial class ksekle : Form
    {
        public ksekle()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "insert into kasiyer (kasadi,kassoyad,tckimlik,telefon,adres,maas,gorevlikasa)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show(" Kaydetme Başarılı");
        }
    }
}
