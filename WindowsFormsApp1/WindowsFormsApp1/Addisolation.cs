using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Addisolation : Form
    {
        public Addisolation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void paneladdiso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM isolationtable WHERE isowardno=@isowardno", con);
            cmd.Parameters.AddWithValue("@isowardno", textBox8.Text.ToLower());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Record already exist");
                con.Close();
            }
            else
            {
                con.Close();
                con.Open();
                SqlCommand cmnd = new SqlCommand("insert into isolationtable values('" + textBox8.Text + "','" + textBox10.Text + "'," + textBox9.Text + ", " + textBox14.Text + " ," + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + ")", con);
                int o = cmnd.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted");
                con.Close();
            }
             textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
        }
        public void displaydata()
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select *from Table11", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
