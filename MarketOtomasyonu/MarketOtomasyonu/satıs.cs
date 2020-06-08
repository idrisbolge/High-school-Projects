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
    public partial class satıs : Form
    {
        public satıs()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=data.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataTable tablo = new DataTable();
        public void barkod()
        {
            bag.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select urunkodu,urunadi,satisf,kategori from urun where urunkodu like '%" + textBox4.Text + "%'", bag);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bag.Close();
        }
        private void satıs_Load(object sender, EventArgs e)
        {
           
            numericUpDown1.Value = 1;
            add.Text = musteriseç.ad;
            soyadd.Text = musteriseç.soyad;
            tc.Text = musteriseç.tc;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].HeaderText = "Barkod No";
            dataGridView1.Columns[1].HeaderText = "Ürün Adı";
            dataGridView1.Columns[2].HeaderText = "Tutar ";
            dataGridView1.Columns[3].HeaderText = "Adet";
            dataGridView1.Columns[4].HeaderText = "Kategori";
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            musteriseç sec = new musteriseç();
            sec.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
int miktar;
        private void button4_Click(object sender, EventArgs e)
        {
            barkod();
            double Topla = 0;

         
            miktar = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                Topla += (miktar*(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value))); 
            }
        label7.Text = Topla.ToString();

            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double alınan, toplam;
            alınan = Convert.ToDouble(textBox5.Text);
            toplam = Convert.ToDouble(label7.Text);
            textBox6.Text = (alınan - toplam).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add.Clear();
            soyadd.Clear();
            tc.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            label7.Text = "00,00";
            dataGridView1.Columns.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            
            komut.Connection = bag;
            komut.CommandText = "insert into satis (musadi,mussoyadi,tckimlik,tutar,trh)values('"+add.Text+"','"+soyadd.Text+"','"+tc.Text+"','"+label7.Text+"','"+dateTimePicker1.Value+"')";

            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                komut.CommandText = "update stok set adet=adet-'" + miktar + "' where urunnu='" + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) + "'";
            komut.ExecuteNonQuery();
            }   

            
            MessageBox.Show("başarılı");            
            bag.Close();
        }
    }
}

