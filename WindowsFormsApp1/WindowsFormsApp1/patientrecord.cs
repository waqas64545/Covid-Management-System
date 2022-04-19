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
    public partial class patientrecord : Form
    {
        public patientrecord()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panelISOLATION_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addpatientform(object formiso)
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
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            addpatientform(new addpatient());
        }
        private void searchpatientform(object formiso)
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
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            searchpatientform(new searchpatient());
        }
        private void updatepatientform(object formiso)
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
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            updatepatientform(new updatepatient());
        }
        private void deletepatientform(object formiso)
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
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            deletepatientform(new deletepatient());
        }
        private void activeform(object formiso)
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
        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            activeform(new active());
        }
        private void deathform(object formiso)
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
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            deathform(new death());
        }
        private void showpatientform(object formiso)
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
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            showpatientform(new showpatient());
        }
        private void recoveredform(object formiso)
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
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            recoveredform(new recovered());
        }
    }
}
