using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace Kitap_evi_projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void agerit()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE kitap SET fiyatı = @prm1, stok = @prm3 WHERE [kitap id] = @prm2;";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox2.Text);
            komut.Parameters.AddWithValue("@prm2", textBox1.Text);
            komut.Parameters.AddWithValue("@prm3", textBox3.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
        }
      
        public void getir()
        {
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            String sql = "select * from kitap where [kitap id]=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox1.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["fiyatı"].ToString();
                textBox3.Text = dr["stok"].ToString();



            }
            bag.Close();
            //MessageBox.Show("Kayıt Getirildi");

        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            agerit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            this.Visible = false;
            fr2.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.ShowDialog();
            this.Visible = true;
        }
    }
}
