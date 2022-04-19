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
    public partial class updatepatient2 : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public updatepatient2()
        {
            InitializeComponent();
            Displayvalue();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM patienttable WHERE paientid=@paientid", con);
            cmd.Parameters.AddWithValue("@paientid", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                con.Close();
                con.Open();
                SqlCommand cmnd = new SqlCommand(" UPDATE patienttable set patientname='" + textBox13.Text + "', age='" + textBox4.Text + "', gender='" + textBox2.Text + "', address='" + textBox7.Text + "', contact='" + textBox9.Text + "', bedno='" + textBox12.Text + "', hospitalid='" + textBox3.Text + "', isowardno='" + textBox5.Text + "', qwardno='" + textBox6.Text + "', testno='" + textBox10.Text + "', coronastatus='" + textBox8.Text + "', patientcondition='" + textBox11.Text + "' where paientid='" + textBox1.Text + "'", con);
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
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM patienttable WHERE paientid=@paientid", con);
            cmd.Parameters.AddWithValue("@paientid", textBox14.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                dt = new DataTable();
                SqlDataAdapter adptt = new SqlDataAdapter("select * from patienttable where paientid like " + int.Parse(textBox14.Text), con);
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
        public void Displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select *from patienttable", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void paneladdiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
