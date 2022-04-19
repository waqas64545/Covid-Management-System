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
    public partial class ISOLATION : Form
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public ISOLATION()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;initial catalog=dbproject;Integrated Security=True");
        private void AddIsolationform(object formiso)
        {
            if (this.panelISOLATION.Controls.Count > 0)
                this.panelISOLATION.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelISOLATION.Controls.Add(f1);
            this.panelISOLATION.Tag = f1;
            f1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            AddIsolationform(new Addisolation());
        }
        private void searchisoform(object formiso)
        {
            if (this.panelISOLATION.Controls.Count > 0)
                this.panelISOLATION.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelISOLATION.Controls.Add(f1);
            this.panelISOLATION.Tag = f1;
            f1.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            searchisoform(new Searchisolation());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void updateisoform(object formiso)
        {
            if (this.panelISOLATION.Controls.Count > 0)
                this.panelISOLATION.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelISOLATION.Controls.Add(f1);
            this.panelISOLATION.Tag = f1;
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            updateisoform(new updateiso1());
        }
        private void deleteisoform(object formiso)
        {
            if (this.panelISOLATION.Controls.Count > 0)
                this.panelISOLATION.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelISOLATION.Controls.Add(f1);
            this.panelISOLATION.Tag = f1;
            f1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            deleteisoform(new deleteiso());

        }

        private void panelISOLATION_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        private void showisoform(object formiso)
        {
            if (this.panelISOLATION.Controls.Count > 0)
                this.panelISOLATION.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelISOLATION.Controls.Add(f1);
            this.panelISOLATION.Tag = f1;
            f1.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            showisoform(new showiso());
        }
    }
}
