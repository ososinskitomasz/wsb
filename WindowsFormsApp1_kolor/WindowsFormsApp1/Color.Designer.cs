namespace WindowsFormsApp1
{
    partial class Color
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
            this.bttnZamknij = new System.Windows.Forms.Button();
            this.bttnZamknijAplikację = new System.Windows.Forms.Button();
            this.lblBokKolor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttnPokaz = new System.Windows.Forms.Button();
            this.bttnKolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            //
            // bttnZamknij
            //
            this.bttnZamknij.Location = new System.Drawing.Point(147, 346);
            this.bttnZamknij.Name = "bttnZamknij";
            this.bttnZamknij.Size = new System.Drawing.Size(75, 23);
            this.bttnZamknij.TabIndex = 0;
            this.bttnZamknij.Text = "Zamknij";
            this.bttnZamknij.UseVisualStyleBackColor = true;
            this.bttnZamknij.Click += new System.EventHandler(this.button1_Click);
            //
            // bttnZamknijAplikację
            //
            this.bttnZamknijAplikację.Location = new System.Drawing.Point(228, 346);
            this.bttnZamknijAplikację.Name = "bttnZamknijAplikację";
            this.bttnZamknijAplikację.Size = new System.Drawing.Size(192, 23);
            this.bttnZamknijAplikację.TabIndex = 1;
            this.bttnZamknijAplikację.Text = "Zamknij aplikację";
            this.bttnZamknijAplikację.UseVisualStyleBackColor = true;
            this.bttnZamknijAplikację.Click += new System.EventHandler(this.button2_Click);
            //
            // lblBokKolor
            //
            this.lblBokKolor.AutoSize = true;
            this.lblBokKolor.Location = new System.Drawing.Point(12, 80);
            this.lblBokKolor.Name = "lblBokKolor";
            this.lblBokKolor.Size = new System.Drawing.Size(32, 17);
            this.lblBokKolor.TabIndex = 2;
            this.lblBokKolor.Text = "Bok";
            this.lblBokKolor.Click += new System.EventHandler(this.lblBokKolor_Click);
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(50, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            //
            // bttnPokaz
            //
            this.bttnPokaz.Location = new System.Drawing.Point(50, 103);
            this.bttnPokaz.Name = "bttnPokaz";
            this.bttnPokaz.Size = new System.Drawing.Size(100, 23);
            this.bttnPokaz.TabIndex = 4;
            this.bttnPokaz.Text = "Pokaż/ukryj";
            this.bttnPokaz.UseVisualStyleBackColor = true;
            this.bttnPokaz.Click += new System.EventHandler(this.button1_Click_1);
            //
            // bttnKolor
            //
            this.bttnKolor.Location = new System.Drawing.Point(50, 132);
            this.bttnKolor.Name = "bttnKolor";
            this.bttnKolor.Size = new System.Drawing.Size(100, 23);
            this.bttnKolor.TabIndex = 5;
            this.bttnKolor.Text = "Zmień kolor";
            this.bttnKolor.UseVisualStyleBackColor = true;
            this.bttnKolor.Click += new System.EventHandler(this.bttnKolor_Click);
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(220, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            //
            // lblKomunikat
            //
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKomunikat.Location = new System.Drawing.Point(12, 55);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 17);
            this.lblKomunikat.TabIndex = 7;
            //
            // Color
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 395);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttnKolor);
            this.Controls.Add(this.bttnPokaz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBokKolor);
            this.Controls.Add(this.bttnZamknijAplikację);
            this.Controls.Add(this.bttnZamknij);
            this.Name = "Color";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kolor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnZamknij;
        private System.Windows.Forms.Button bttnZamknijAplikację;
        private System.Windows.Forms.Label lblBokKolor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttnPokaz;
        private System.Windows.Forms.Button bttnKolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
