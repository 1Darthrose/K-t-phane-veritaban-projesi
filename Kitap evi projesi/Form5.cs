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

namespace Kitap_evi_projesi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        public void ekle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "INSERT INTO İl ( [İl adı]) VALUES ( '" + textBox1.Text + "'  )";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox1.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
        }

     

      
        public void Sil()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "DELETE FROM İl WHERE [İl id] = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", textBox2.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
        }
        public void getir()
        {
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            String sql = "select * from İl where [İl id]=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox2.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr["İl adı"].ToString();
                


            }
            else
            {
                MessageBox.Show("Bu ID'de veri yok. ");
            }
            bag.Close();
            //MessageBox.Show("Kayıt Getirildi");



        }
        public void güncelle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE   il set  [İl adı] =@prm1    where  [İl id] = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", textBox2.Text);
            komut.Parameters.AddWithValue("@prm1", textBox3.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }


    

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Visible = false;
            fr4.ShowDialog();
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sil();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            güncelle();

        }
    }
}
