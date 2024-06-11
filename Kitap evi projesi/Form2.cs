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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.ShowDialog();
            this.Visible = true;
        }
        //public void agerit()
        //{
        //    SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");

        //    string sql = "update urunler set fiyat=@prm1 where id=@prm2";
        //    SqlCommand komut = new SqlCommand(sql, bag);
        //    komut.Parameters.AddWithValue("@prm1", textBox2.Text);
        //    komut.Parameters.AddWithValue("@prm2", textBox1.Text);
        //    bag.Open();
        //    komut.ExecuteNonQuery();
        //    bag.Close();
        //    MessageBox.Show("Müşteri Bilgileri Güncellendi.");

        //    //veritabanından nilgiyi getiren kod
        //}
        //public void getir()
        //{
        //    SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
        //    String sql = "select * from urunler where id=@prm1";
        //    SqlCommand komut = new SqlCommand(sql, bag);
        //    komut.Parameters.AddWithValue("@prm1", textBox1.Text);
        //    bag.Open();
        //    SqlDataReader dr = komut.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        textBox2.Text = dr["fiyat"].ToString();


        //    }
        //    bag.Close();
        //    //MessageBox.Show("Kayıt Getirildi");



        //}

 


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void aramaad()
        {
           // reyon 1 den hem kitap adı hemde reyon numrası ile arama yapmaya imsak sağlayan kod dizisi.
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "SELECT * FROM kitap WHERE Kitap_adı LIKE '%'+@prm1+'%' OR reyon LIKE '%'+@prm1+'%'  ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", textBox3.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public void listele()
        {


            //Veri tabanından kitap tablosunu dataGridView1 de gösteren kod dizisi.
            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from kitap ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //griden textbox getiren kod
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            aramaad();
        }


   

   

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            this.Visible = false;
            fr3.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.ShowDialog();
            this.Visible = true;
        }
    }
}
