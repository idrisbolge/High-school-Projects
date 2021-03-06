﻿using System;
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
    public partial class araclar : Form
    {
        public araclar()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand("select* from musbil where onay=false");
        public OleDbDataAdapter adptr;
        DataTable tablo = new DataTable();


        void listele()
        {
            tablo.Clear();
            bag.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select Adsoyad,PlakaNu,Marka,Model,girissaati From musbil ", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();
            bag.Close();


        }

        private void araclar_Load(object sender, EventArgs e)
        {
            textBox1.TabIndex = 1; 
            listele();
            label1.Text = "Şuana Kadar Otoparkınızı " + dataGridView1.RowCount + " Araç Ziyaret Etmiştir";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                listele();
            }
            else
            {
                tablo.Clear();
                adptr = new OleDbDataAdapter("SELECT * FROM musbil WHERE AdSoyad like'" + textBox1.Text + "%'", bag);
                adptr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                if (dataGridView1.RowCount == 1)
                {
                    tablo.Clear();
                    adptr = new OleDbDataAdapter("SELECT * FROM musbil WHERE PlakaNu like'" + textBox1.Text + "%'", bag);
                    adptr.Fill(tablo);
                    dataGridView1.DataSource = tablo;


                    if (dataGridView1.RowCount == 1)
                    {
                        tablo.Clear();
                        adptr = new OleDbDataAdapter("SELECT * FROM musbil WHERE Marka like'" + textBox1.Text + "%'", bag);
                        adptr.Fill(tablo);
                        dataGridView1.DataSource = tablo;

                        if (dataGridView1.RowCount == 1)
                        {
                            tablo.Clear();
                            adptr = new OleDbDataAdapter("SELECT * FROM musbil WHERE Model like'" + textBox1.Text + "%'", bag);
                            adptr.Fill(tablo);
                            dataGridView1.DataSource = tablo;

                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetici yn = new yonetici();
            yn.Show();
            this.Hide();
        }
    }
}
