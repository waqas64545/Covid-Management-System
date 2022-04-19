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
    public partial class addquarantine : Form
    {
        public addquarantine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM quarantinetable WHERE qwardno=@qwardno", con);
            cmd.Parameters.AddWithValue("@qwardno", textBox1.Text.ToLower());
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
                SqlCommand cmnd = new SqlCommand("insert into quarantinetable values('" + textBox1.Text + "','" + textBox3.Text + "'," + textBox4.Text + ", " + textBox5.Text + " ," + textBox2.Text + ", " + textBox6.Text + ", " + textBox7.Text + ")", con);
                int o = cmnd.ExecuteNonQuery();
                MessageBox.Show("Record has been inserted");
                con.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void paneladdiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
