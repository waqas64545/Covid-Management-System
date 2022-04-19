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
    public partial class deletequarantine : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public deletequarantine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM quarantinetable WHERE qwardno=@qwardno", con);
            cmd.Parameters.AddWithValue("@qwardno", textBox1.Text.ToLower());
            con.Open();
            SqlDataReader drr = cmd.ExecuteReader();
            if (drr.HasRows)
            {
                drr.Close();
                SqlCommand cmnd = new SqlCommand("delete quarantinetable where qwardno='" + textBox1.Text + "'", con);
                cmnd.ExecuteNonQuery();
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

        private void Updateiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
