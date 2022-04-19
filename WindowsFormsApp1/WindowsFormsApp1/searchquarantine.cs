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
    public partial class searchquarantine : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public searchquarantine()
        {
            InitializeComponent();
            Displayvalue();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        public void Displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select *from quarantinetable", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM quarantinetable WHERE qwardno=@qwardno", con);
            cmd.Parameters.AddWithValue("@qwardno", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                dt = new DataTable();
                SqlDataAdapter adptt = new SqlDataAdapter("select * from quarantinetable where qwardno like " + int.Parse(textBox1.Text), con);
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
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
