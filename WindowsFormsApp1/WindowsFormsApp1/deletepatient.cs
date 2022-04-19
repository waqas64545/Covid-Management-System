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
    public partial class deletepatient : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public deletepatient()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM patienttable WHERE paientid=@paientid", con);
            cmd.Parameters.AddWithValue("@paientid", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                SqlCommand cmndd = new SqlCommand(" UPDATE patienttable set coronastatus='" + textBox2.Text + "'where paientid='" + textBox1.Text + "'", con);
                cmndd.ExecuteNonQuery();
                SqlCommand cmde = new SqlCommand("delete patienttable where paientid='" + textBox1.Text + "'", con);
                cmde.ExecuteNonQuery();
                MessageBox.Show("Record has been deleted");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updateiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
