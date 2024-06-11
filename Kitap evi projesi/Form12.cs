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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
        public void güncelle()
        {
            //update urunler set fiyat = @prm1 and stok = @prm3 where id = @prm2
            string sqlFormattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "UPDATE   kitap set Kitap_adı =@prm3 , Fiyatı=@prm1,Stok=@prm4 ,ISBN=@prm5 ,Yayın_tarihi=@prm6 ,Sayfa_sayısı=@prm7 ,Yayınevi_id=@prm8 ,Reyon=@prm9 where  Kitap_Id = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", getirıdg.Text);
            komut.Parameters.AddWithValue("@prm3", textBoxkitapg.Text);
            komut.Parameters.AddWithValue("@prm1", textBoxfiyatg.Text);
            komut.Parameters.AddWithValue("@prm4", textBoxstokg.Text);
            komut.Parameters.AddWithValue("@prm5", textBoxısbng.Text);
          
            komut.Parameters.AddWithValue("@prm6", sqlFormattedDate);
            komut.Parameters.AddWithValue("@prm7", textBoxssayısıg.Text);
            komut.Parameters.AddWithValue("@prm8", textBoxyayınevig.Text);
            komut.Parameters.AddWithValue("@prm9", reyontx.Text);
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
            string sql = "DELETE FROM kitap WHERE Kitap_Id = @prm2 ";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm2", getirıdg.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Müşteri Bilgileri Silindi.");

            //veritabanından nilgiyi getiren kod
        }
        public void getir()
        {
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            String sql = "select * from kitap where Kitap_Id=@prm1";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", getirıdg.Text);
            bag.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBoxkitapg.Text = dr["Kitap_adı"].ToString();
                textBoxfiyatg.Text = dr["Fiyatı"].ToString();
                textBoxstokg.Text = dr["Stok"].ToString();
                textBoxısbng.Text = dr["ISBN"].ToString();
                dateTimePicker2.Text = dr["Yayın_tarihi"].ToString();
                textBoxssayısıg.Text = dr["Sayfa_sayısı"].ToString();
                textBoxyayınevig.Text = dr["Yayınevi_id"].ToString();
                reyontx.Text = dr["Reyon"].ToString();




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
            string sql = "INSERT INTO kitap (Kitap_adı,Fiyatı,stok,ISBN,Yayın_tarihi,Sayfa_sayısı,Yayınevi_id,Reyon) VALUES ( '" + kitaptex.Text + "',' " + fiyattex.Text + "',' " + texboxstok.Text + "',' " + textBoxısbn.Text + "', @prm2 ,' " + sayfasayısıtex.Text + "','"  +yayınevitex.Text+ "','"  +reyontx.Text+ "' )";
            SqlCommand komut = new SqlCommand(sql, bag);
            komut.Parameters.AddWithValue("@prm1", kitaptex.Text);
            komut.Parameters.AddWithValue("@prm2", dateTimePicker1.Value);
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
