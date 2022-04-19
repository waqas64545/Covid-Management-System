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
    public partial class STP : Form
    {
        public STP()
        {
            InitializeComponent();
        }
        private void STPform(object formiso)
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
            button4.Visible = false;
            STPform(new symptoms());
        }
        private void preventingform(object formiso)
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
            button4.Visible = false;
            preventingform(new preventions());
        }
        private void treatmentform(object formiso)
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
            button4.Visible = false;
            treatmentform(new treatment());
        }

        private void panelISOLATION_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
