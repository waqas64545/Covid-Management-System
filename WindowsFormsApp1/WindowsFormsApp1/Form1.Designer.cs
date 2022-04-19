namespace WindowsFormsApp1
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconminimize = new System.Windows.Forms.PictureBox();
            this.iconmaximize = new System.Windows.Forms.PictureBox();
            this.iconreset = new System.Windows.Forms.PictureBox();
            this.iconclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.isolation = new System.Windows.Forms.Button();
            this.panelform = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconreset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(0, -72);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 270);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.UseWaitCursor = true;
            // 
            // paneltop
            // 
            this.paneltop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneltop.BackgroundImage")));
            this.paneltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.iconminimize);
            this.paneltop.Controls.Add(this.iconmaximize);
            this.paneltop.Controls.Add(this.iconreset);
            this.paneltop.Controls.Add(this.iconclose);
            this.paneltop.Controls.Add(this.logo);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(851, 116);
            this.paneltop.TabIndex = 4;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint_1);
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(262, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "COVID’19 and CURE Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconminimize
            // 
            this.iconminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconminimize.BackgroundImage")));
            this.iconminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconminimize.Location = new System.Drawing.Point(795, 2);
            this.iconminimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconminimize.Name = "iconminimize";
            this.iconminimize.Size = new System.Drawing.Size(15, 16);
            this.iconminimize.TabIndex = 11;
            this.iconminimize.TabStop = false;
            this.iconminimize.Click += new System.EventHandler(this.iconminimize_Click);
            // 
            // iconmaximize
            // 
            this.iconmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconmaximize.BackgroundImage")));
            this.iconmaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconmaximize.Location = new System.Drawing.Point(814, 2);
            this.iconmaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconmaximize.Name = "iconmaximize";
            this.iconmaximize.Size = new System.Drawing.Size(15, 16);
            this.iconmaximize.TabIndex = 12;
            this.iconmaximize.TabStop = false;
            this.iconmaximize.Click += new System.EventHandler(this.iconmaximize_Click);
            // 
            // iconreset
            // 
            this.iconreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconreset.BackgroundImage")));
            this.iconreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconreset.Location = new System.Drawing.Point(814, 2);
            this.iconreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconreset.Name = "iconreset";
            this.iconreset.Size = new System.Drawing.Size(15, 16);
            this.iconreset.TabIndex = 10;
            this.iconreset.TabStop = false;
            this.iconreset.Click += new System.EventHandler(this.iconreset_Click);
            // 
            // iconclose
            // 
            this.iconclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconclose.BackgroundImage")));
            this.iconclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconclose.Location = new System.Drawing.Point(834, 2);
            this.iconclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(15, 16);
            this.iconclose.TabIndex = 12;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.isolation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 498);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quarantine Ward";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "Symptoms, Preventing Measure and Treatment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 384);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 71);
            this.button2.TabIndex = 7;
            this.button2.Text = " Patient Record";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // isolation
            // 
            this.isolation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isolation.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.isolation.FlatAppearance.BorderSize = 0;
            this.isolation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isolation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isolation.ForeColor = System.Drawing.Color.White;
            this.isolation.Location = new System.Drawing.Point(0, 49);
            this.isolation.Margin = new System.Windows.Forms.Padding(0);
            this.isolation.Name = "isolation";
            this.isolation.Size = new System.Drawing.Size(216, 63);
            this.isolation.TabIndex = 0;
            this.isolation.Text = "Isolaton Ward";
            this.isolation.UseVisualStyleBackColor = false;
            this.isolation.Click += new System.EventHandler(this.isolation_Click);
            // 
            // panelform
            // 
            this.panelform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelform.BackgroundImage")));
            this.panelform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelform.Location = new System.Drawing.Point(218, 116);
            this.panelform.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(633, 498);
            this.panelform.TabIndex = 6;
            this.panelform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelform_Paint);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 614);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconreset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconreset;
        private System.Windows.Forms.PictureBox iconminimize;
        private System.Windows.Forms.PictureBox iconclose;
        private System.Windows.Forms.PictureBox iconmaximize;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button isolation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelform;
        private System.Windows.Forms.Label label1;
    }
}

