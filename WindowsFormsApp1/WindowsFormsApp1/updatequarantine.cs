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
    public partial class updatequarantine : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public updatequarantine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        private void updatequarntineform2(object formiso)
        {
            if (this.Updateiso.Controls.Count > 0)
                this.Updateiso.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.Updateiso.Controls.Add(f1);
            this.Updateiso.Tag = f1;
            f1.Show();
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
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            updatequarntineform2(new updatequarantine2());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updateiso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
