namespace WindowsFormsApp1
{
    partial class deleteiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteiso));
            this.Updateiso = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Updateiso.SuspendLayout();
            this.SuspendLayout();
            // 
            // Updateiso
            // 
            this.Updateiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Updateiso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Updateiso.BackgroundImage")));
            this.Updateiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Updateiso.Controls.Add(this.button1);
            this.Updateiso.Controls.Add(this.Delete);
            this.Updateiso.Controls.Add(this.textBox1);
            this.Updateiso.Location = new System.Drawing.Point(0, 0);
            this.Updateiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updateiso.Name = "Updateiso";
            this.Updateiso.Size = new System.Drawing.Size(700, 523);
            this.Updateiso.TabIndex = 2;
            this.Updateiso.Paint += new System.Windows.Forms.PaintEventHandler(this.Updateiso_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(395, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Delete.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(173, 188);
            this.Delete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(309, 23);
            this.Delete.TabIndex = 13;
            this.Delete.Text = "Enter Isolation Ward Number to delete : ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Indigo;
            this.textBox1.Location = new System.Drawing.Point(213, 233);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 29);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 523);
            this.Controls.Add(this.Updateiso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "deleteiso";
            this.Text = "deleteiso";
            this.Updateiso.ResumeLayout(false);
            this.Updateiso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Updateiso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Delete;
        private System.Windows.Forms.TextBox textBox1;
    }
}