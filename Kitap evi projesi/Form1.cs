using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitap_evi_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string textBox2Value = textBox2.Text;
            string textBox1Value = textBox1.Text;
            //SqlConnection bag = new SqlConnection(@"server=ROSE\SQLEXPRESS; initial catalog=deneme; integrated security=true");
            //string sql = "Select * from user where kadi=@kadi and Sifre=@Sifre";
            //SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            //da.SelectCommand.Parameters.AddWithValue("@kadi", textBox1.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Sifre", textBox2.Text);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            if (textBox1Value == "1" & textBox2Value == "1")
            {

                Form2 fr2 = new Form2();
                this.Visible = false;
                fr2.ShowDialog();
                this.Visible = true;
                //dt.Rows.Count > 0


            }
            if (textBox1Value == "2" & textBox2Value == "2")
            {
                Form4 fr4 = new Form4();
                this.Visible = false;
                fr4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textBox2Value = textBox2.Text;
            string textBox1Value = textBox1.Text;
            //SqlConnection bag = new SqlConnection(@"server=ROSE\SQLEXPRESS; initial catalog=deneme; integrated security=true");
            //string sql = "Select * from user where kadi=@kadi and Sifre=@Sifre";
            //SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            //da.SelectCommand.Parameters.AddWithValue("@kadi", textBox1.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Sifre", textBox2.Text);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            if (textBox1Value == "1" & textBox2Value == "1")
            {

                Form2 fr2 = new Form2();
                this.Visible = false;
                fr2.ShowDialog();
                this.Visible = true;
                //dt.Rows.Count > 0


            }
            if (textBox1Value == "2" & textBox2Value == "2")
            {
                Form4 fr4 = new Form4();
                this.Visible = false;
                fr4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string textBox2Value = textBox2.Text;
            string textBox1Value = textBox1.Text;
            //SqlConnection bag = new SqlConnection(@"server=ROSE\SQLEXPRESS; initial catalog=deneme; integrated security=true");
            //string sql = "Select * from user where kadi=@kadi and Sifre=@Sifre";
            //SqlDataAdapter da = new SqlDataAdapter(sql, bag);
            //da.SelectCommand.Parameters.AddWithValue("@kadi", textBox1.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Sifre", textBox2.Text);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            if (textBox1Value == "1" & textBox2Value == "1")
            {

                Form2 fr2 = new Form2();
                this.Visible = false;
                fr2.ShowDialog();
                this.Visible = true;
                //dt.Rows.Count > 0


            }
            if (textBox1Value == "2" & textBox2Value == "2")
            {
                Form4 fr4 = new Form4();
                this.Visible = false;
                fr4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }
    }
}
