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
    public partial class updatequarantine2 : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public updatequarantine2()
        {
            InitializeComponent();
            Displayvalue();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM quarantinetable WHERE qwardno=@qwardno", con);
            cmd.Parameters.AddWithValue("@qwardno", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                con.Close();
                con.Open();
                SqlCommand cmnd = new SqlCommand(" UPDATE quarantinetable set qwardname='" + textBox3.Text + "', hospitalid='" + textBox4.Text + "', qnoofdoctors='" + textBox5.Text + "', qnoofbeds='" + textBox2.Text + "', qavaliblebed='" + textBox6.Text + "', qnoofventilator='" + textBox7.Text + "' where qwardno='" + textBox1.Text + "'", con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Record has been updated");
                con.Close();
                Displayvalue();
            }
            else
            {
                MessageBox.Show("Record not found");

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        public void Displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select *from quarantinetable", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM quarantinetable WHERE qwardno=@qwardno", con);
            cmd.Parameters.AddWithValue("@qwardno", textBox8.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                dt = new DataTable();
                SqlDataAdapter adptt = new SqlDataAdapter("select * from quarantinetable where qwardno like " + int.Parse(textBox8.Text), con);
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

        private void paneladdiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
