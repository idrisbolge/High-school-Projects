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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.JET.Oledb.4.0;Data Source=Data.mdb");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbCommand komut1 = new OleDbCommand();
        public OleDbDataAdapter adptr;
 
      
        
        private void button21_Click(object sender, EventArgs e)
        {
            if (txttc.Text==""||txtad.Text==""||txtplk.Text==""||txtmdl.Text==""||txtcptel.Text==""||txtmrk.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanların Dolu Olduğuna Emin Olunuz...");
            }
            if (textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Aracın Gireceği Konumu Seçiniz...");
            }
            else
            {
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "insert into musbil (TcKimlik,AdSoyad,CepTel,PlakaNu,Marka,Model,Konumu,girissaati)values('" + txttc.Text + "','" + txtad.Text + "','" + txtcptel.Text + "','" + txtplk.Text + "','" + txtmrk.Text + "','" + txtmdl.Text + "','" + textBox1.Text + "','" + lblzmn.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("İşleminiz Kaydedildi..");
                bag.Close();
                textBox1.Clear();
            txtad.Clear();
            txtcptel.Clear();
            txtmdl.Clear();
            txtmrk.Clear();
            txtplk.Clear();
            txttc.Clear();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OleDbDataReader okuma;
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "select * from musbil where onay=false";
            komut.ExecuteNonQuery();
            okuma = komut.ExecuteReader();

            while (okuma.Read())
            {
               

                switch (okuma["Konumu"].ToString())
                {
                    case "A1":
                        {
                            button1.Text = okuma["Konumu"].ToString();
                            button1.BackColor = System.Drawing.Color.Red;
                            break;
                        }

                    case "A2":
                        {
                            button2.Text = okuma["Konumu"].ToString();
                            button2.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "A3":
                        {
                            button3.Text = okuma["Konumu"].ToString();
                            button3.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "A4":
                        {
                            button4.Text = okuma["Konumu"].ToString();
                            button4.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "A5":
                        {
                            button5.Text = okuma["Konumu"].ToString();
                            button5.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "B1":
                        {
                            button6.Text = okuma["Konumu"].ToString();
                            button6.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "B2":
                        {
                            button7.Text = okuma["Konumu"].ToString();
                            button7.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "B3":
                        {
                            button8.Text = okuma["Konumu"].ToString();
                            button8.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "B4":
                        {
                            button9.Text = okuma["Konumu"].ToString();
                            button9.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "B5":
                        {
                            button10.Text = okuma["Konumu"].ToString();
                            button10.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "C1":
                        {

                            button11.Text = okuma["Konumu"].ToString();
                            button11.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "C2":
                        {
                            button12.Text = okuma["Konumu"].ToString();
                            button12.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "C3":
                        {
                            button13.Text = okuma["Konumu"].ToString();
                            button13.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "C4":
                        {
                            button14.Text = okuma["Konumu"].ToString();
                            button14.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "C5":
                        {
                            button15.Text = okuma["Konumu"].ToString();
                            button15.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "D1":
                        {
                            button16.Text = okuma["Konumu"].ToString();
                            button16.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "D2":
                        {
                            button17.Text = okuma["Konumu"].ToString();
                            button17.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "D3":
                        {
                            button18.Text = okuma["Konumu"].ToString();
                            button18.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "D4":
                        {
                            button19.Text = okuma["Konumu"].ToString();
                            button19.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                    case "D5":
                        {
                            button20.Text = okuma["Konumu"].ToString();
                            button20.BackColor = System.Drawing.Color.Red;
                            break;
                        }
                }

            }
            bag.Close();
            okuma.Dispose();

    
         
            bag.Open();
            komut.Connection = bag;
            komut.CommandText = "select * from musbil ";
            komut.ExecuteNonQuery();
            okuma = komut.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();

            while (okuma.Read())
            {
                MyCollection.Add(okuma.GetString(1)); 
            }

            txttc.AutoCompleteCustomSource = MyCollection;

            bag.Close();

            okuma.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button5.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button7.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button6.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button9.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button10.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button11.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button12.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button13.Text;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button14.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button15.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button16.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button17.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button18.Text;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button19.Text;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Red)
            {
                MessageBox.Show("Seçtiğiniz Alan Dolu Durumdadır. Lütfen Yeşil Alanlardan Seçiniz..");
            }
            else
            {
                textBox1.Text = button20.Text;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblzmn.Text = DateTime.Now.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Giris_Ekrani gr = new Giris_Ekrani();
            gr.Show();
            this.Hide();
        }

        private void txttc_Enter(object sender, EventArgs e)
        {
          
                
           
        }

        private void txttc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                OleDbDataReader okuma;
                bag.Open();
                komut.Connection = bag;
                komut.CommandText = "select * from musbil where TcKimlik= '"+txttc.Text+"'" ;
                komut.ExecuteNonQuery();
                okuma = komut.ExecuteReader();
               
                while (okuma.Read())
                {
                   txtad.Text = okuma[2].ToString();
                   txtcptel.Text = okuma[3].ToString();
                   txtplk.Text = okuma[4].ToString();
                   txtmrk.Text = okuma[5].ToString();
                   txtmdl.Text = okuma[6].ToString();

                }

                bag.Close();
                okuma.Dispose();
            }
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            if (txttc.Text=="")
            {
                                textBox1.Clear();
            txtad.Clear();
            txtcptel.Clear();
            txtmdl.Clear();
            txtmrk.Clear();
            txtplk.Clear();
            txttc.Clear();
            }
        }
    }
}
