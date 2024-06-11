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

namespace Kitap_evi_projesi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

  
        public void kitaplistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=true;");
            string sql = "select * from Kitap ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void yazarlistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from yazar ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void adreslistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from Adress ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void yayınevilistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from yayınevi ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void müşterilistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from müşteri ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void illistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from il ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void ilçelistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from ilçe ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void siparislistele()
        {


            SqlConnection bag = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=: listboxtanvtye,;Trusted_Connection=True;");
            string sql = "select * from sipariş ";
            SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yazarlistele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adreslistele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yayınevilistele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            müşterilistele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            illistele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ilçelistele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            this.Visible = false;
            fr5.ShowDialog();
            this.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            this.Visible = false;
            fr10.ShowDialog();
            this.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            this.Visible = false;
            fr7.ShowDialog();
            this.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            this.Visible = false;
            fr8.ShowDialog();
            this.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            this.Visible = false;
            fr9.ShowDialog();
            this.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form11 fr11 = new Form11();
            this.Visible = false;
            fr11.ShowDialog();
            this.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            this.Visible = false;
            fr12.ShowDialog();
            this.Visible = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string comboBox1Value = comboBox1.Text;
            if (comboBox1Value == "Sipariş")
            {

                Form13 fr13 = new Form13();
                this.Visible = false;
                fr13.ShowDialog();
                this.Visible = true;
                //dt.Rows.Count > 0


            }
            if (comboBox1Value == "Kitap")
            {
                Form14 fr14 = new Form14();
                this.Visible = false;
                fr14.ShowDialog();
                this.Visible = true;
            
            }
            else
            {
                MessageBox.Show("Yandan raporunu istediniz tabloyu seçiniz.");
            }
        }

        private void Siparişbtn_Click(object sender, EventArgs e)
        {
            siparislistele();
        }

        private void sipariseklebtn_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            this.Visible = false;
            fr15.ShowDialog();
            this.Visible = true;
        }
    }
}
