using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr a, int b, int c, int d);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconreset.Visible = true;
            iconmaximize.Visible = false;
        }

        private void iconminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconreset_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconreset.Visible = false;
            iconmaximize.Visible = true;
        }

        private void paneltop_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void STPFORM(object formiso)
        {

            if (this.panelform.Controls.Count > 0)
                this.panelform.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelform.Controls.Add(f1);
            this.panelform.Tag = f1;
            f1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            STPFORM(new STP());
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Isolationform(object formiso)
        {
            
            if (this.panelform.Controls.Count > 0)
                this.panelform.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelform.Controls.Add(f1);
            this.panelform.Tag = f1;
            f1.Show();
        }
        private void isolation_Click(object sender, EventArgs e)
        {
            Isolationform(new ISOLATION());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void quarantineform(object formiso)
        {

            if (this.panelform.Controls.Count > 0)
                this.panelform.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelform.Controls.Add(f1);
            this.panelform.Tag = f1;
            f1.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            quarantineform(new quarantineward());
        }
        private void patientform(object formiso)
        {

            if (this.panelform.Controls.Count > 0)
                this.panelform.Controls.RemoveAt(0);
            Form f1 = formiso as Form;
            f1.TopLevel = false;
            f1.Dock = DockStyle.Fill;
            this.panelform.Controls.Add(f1);
            this.panelform.Tag = f1;
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            patientform(new patientrecord());
        }

        private void panelform_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
