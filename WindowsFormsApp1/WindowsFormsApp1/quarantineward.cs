using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class quarantineward : Form
    {
        public quarantineward()
        {
            InitializeComponent();
        }
        private void Addquarantineform(object formiso)
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
            button5.Visible = false;
            button4.Visible = false;
            Addquarantineform(new addquarantine());
        }
        private void searchquarantineform(object formiso)
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
            searchquarantineform(new searchquarantine());
        }
        private void updatequarantineform(object formiso)
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
            updatequarantineform(new updatequarantine());
        }
        private void deletequarantineform(object formiso)
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
            deletequarantineform(new deletequarantine());
        }
        private void showquarantineform(object formiso)
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
            showquarantineform(new showquarantine());
        }

        private void panelISOLATION_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
