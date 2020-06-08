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
    public partial class musteriseç : Form
    {
        public musteriseç()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();

        public void listeleme()
        {
            tablo.Clear();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from musteri", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        public static string ad, soyad, tc;
        private void musteriseç_Load(object sender, EventArgs e)
        {
            listeleme();
            tc = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satıs sts = new satıs();
            sts.Show();
        }
    }
}
