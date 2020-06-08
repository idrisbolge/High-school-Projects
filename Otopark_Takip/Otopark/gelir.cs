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
    public partial class gelir : Form
    {
        public gelir()
        {
            InitializeComponent();
        }


        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand("select* from musbil  ");
        public OleDbDataAdapter adptr;
        DataTable tablo = new DataTable();
        mevcut m = new mevcut();

        void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select  TcKimlik,Adsoyad,CepTel,girissaati,cıkıssaati,ucret From musbil where onay=true", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();


        }
        private void gelir_Load(object sender, EventArgs e)
        {
           listele();
           long Topla = 0;
           for (int i = 0; i < dataGridView1.Rows.Count; ++i)
           {
               Topla += Convert.ToInt64(dataGridView1.Rows[i].Cells[5].Value);
           }
           label5.Text = "Bugüne Kadar Toplam Gelir  : " + Topla.ToString()+" TL";  
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yonetici yn = new yonetici();
            yn.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
