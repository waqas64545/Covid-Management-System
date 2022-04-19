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
    public partial class death : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public death()
        {
            InitializeComponent();
            Displayvalue();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-242IIU9\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
        public void Displayvalue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select death from statistic", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void showisopanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
