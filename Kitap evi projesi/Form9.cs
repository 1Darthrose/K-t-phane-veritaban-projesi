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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Visible = false;
            fr4.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle();
        }
        public void güncelle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE   Yayınevi set  [Yayınevi adı] =@prm1    where  [Yayınevi id] = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", textBox2.Text);
            komut.Parameters.AddWithValue("@prm1", textBox3.Text);
           
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
            string sql = "DELETE FROM Yayınevi WHERE [Yayınevi id] = @prm2 ";
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
            String sql = "select * from Yayınevi where [Yayınevi id]=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox2.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox3.Text = dr["Yayınevi adı"].ToString();
           



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
            string sql = "INSERT INTO Yayınevi ([Yayınevi adı]) VALUES ( '" + textBox1.Text + "'  )";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", textBox1.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Eklendi.");

            //veritabanından nilgiyi ekleyen kod
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
