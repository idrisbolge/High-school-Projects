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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        public void kod()
        {
            bag.Open();
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from satis where trh like '%" + dateTimePicker1.Text + "%'", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }
        private void btnMusIslem_Click(object sender, EventArgs e)
        {
            musteri mus = new musteri();
            mus.Show();
        }

        private void btnUrunIslem_Click(object sender, EventArgs e)
        {
            urun ur = new urun();
            ur.Show();
        }

        private void btnKasiyerIslem_Click(object sender, EventArgs e)
        {
            kasiyer ks = new kasiyer();
            ks.Show();
        }

        private void btnStokIslem_Click(object sender, EventArgs e)
        {
            stok stk = new stok();
            stk.Show();
        }

        private void btnSatisIslem_Click(object sender, EventArgs e)
        {
            satıs sts = new satıs();
            sts.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            kod();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSatisGoster_Click(object sender, EventArgs e)
        {
            kod();
        }
    }
}
