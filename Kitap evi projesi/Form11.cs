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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
        public void güncelle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE   yazar set [Yazar adı] =@prm3 , [Yazar Soyadı]=@prm1    where  [Yazar id] = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", textBox2.Text);
            komut.Parameters.AddWithValue("@prm3", textBox3.Text);
            komut.Parameters.AddWithValue("@prm1", textBox5.Text);

            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
        }
        public void sil()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "DELETE FROM yazar WHERE [Yazar id] = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", textBox2.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Silindi.");

            //veritabanından nilgiyi getiren kod
        }
        public void getir()
        {
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            String sql = "select * from yazar where [Yazar id]=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox2.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr["Yazar adı"].ToString();
                textBox5.Text = dr["Yazar Soyadı"].ToString();




            }
            else
            {
                MessageBox.Show("Bu ID'de veri yok. ");
            }
            bag.Close();
            //MessageBox.Show("Kayıt Getirildi");



        }
        public void ekle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "INSERT INTO yazar ([Yazar adı],[Yazar Soyadı]) VALUES ( '" + textBox1.Text + "',' " + textBox4.Text + "'  )";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox1.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Eklendi.");

            //veritabanından nilgiyi ekleyen kod
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Visible = false;
            fr4.ShowDialog();
            this.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
