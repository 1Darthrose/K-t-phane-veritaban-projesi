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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            this.Visible = false;
            fr4.ShowDialog();
            this.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekle();
        }
    
        public void sil()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "DELETE FROM sipariş WHERE Sipariş_id = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", gıdtex.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Silindi.");

            //veritabanından nilgiyi getiren kod
        }
        public void getir()
        {
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            String sql = "select * from sipariş where Sipariş_id=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", gıdtex.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                dateTimePicker2.Text = dr["Sipariş_Tarihi"].ToString();
                gtoplamtex.Text = dr["Toplam_Tutarı"].ToString();
                gmüşteritex.Text = dr["Müşteri_id"].ToString();
              




            }
            else
            {
                MessageBox.Show("Bu ID'de veri yok. ");
            }
            bag.Close();
            //MessageBox.Show("Kayıt Getirildi");



        }
        string date = "dateTimePicker1";
        public void ekle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2

            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "INSERT INTO sipariş (Sipariş_Tarihi ,Toplam_Tutarı ,Müşteri_id) VALUES (  @prm2, @prm1, '" + müsteridı.Text + "' )";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", tutartex.Text);
            komut.Parameters.AddWithValue("@prm2", dateTimePicker1.Value);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Eklendi.");

            //veritabanından nilgiyi ekleyen kod
        }
        public void güncelle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2
            string sqlFormattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE   sipariş set Sipariş_Tarihi=@prm4 , Toplam_Tutarı=@prm2,Müşteri_id=@prm3  where  Sipariş_id = @prm1 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", gıdtex.Text);
            
            komut.Parameters.AddWithValue("@prm4", sqlFormattedDate);
            komut.Parameters.AddWithValue("@prm2", gtoplamtex.Text);
            komut.Parameters.AddWithValue("@prm3", gmüşteritex.Text);
        
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

            //veritabanından nilgiyi getiren kod
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
