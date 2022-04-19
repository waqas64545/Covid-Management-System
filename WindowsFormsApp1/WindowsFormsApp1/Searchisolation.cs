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
    public partial class Searchisolation : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public Searchisolation()
        {
            InitializeComponent();
            Displayvalue();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        public void Displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select *from isolationtable", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void Searchisolation_Load(object sender, EventArgs e)
        {

        }

        private void searchiso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM isolationtable WHERE isowardno=@isowardno", con);
            cmd.Parameters.AddWithValue("@isowardno", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                dt = new DataTable();
                SqlDataAdapter adptt = new SqlDataAdapter("select * from isolationtable where isowardno like " + int.Parse(textBox1.Text), con);
                adptt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                con.Close();
                con.Open();
                MessageBox.Show("Record not found");
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
         
        }
        

     
    }
}
