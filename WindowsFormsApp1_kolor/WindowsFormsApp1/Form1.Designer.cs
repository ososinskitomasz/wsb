namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBok = new System.Windows.Forms.Label();
            this.lblPole = new System.Windows.Forms.Label();
            this.lblObwód = new System.Windows.Forms.Label();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.txtBok = new System.Windows.Forms.TextBox();
            this.txtPole = new System.Windows.Forms.TextBox();
            this.txtObwód = new System.Windows.Forms.TextBox();
            this.bttnWyczyść = new System.Windows.Forms.Button();
            this.bttnZamknij = new System.Windows.Forms.Button();
            this.bttnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblBok
            //
            this.lblBok.AutoSize = true;
            this.lblBok.Location = new System.Drawing.Point(12, 45);
            this.lblBok.Name = "lblBok";
            this.lblBok.Size = new System.Drawing.Size(32, 17);
            this.lblBok.TabIndex = 0;
            this.lblBok.Text = "Bok";
            //
            // lblPole
            //
            this.lblPole.AutoSize = true;
            this.lblPole.Location = new System.Drawing.Point(12, 94);
            this.lblPole.Name = "lblPole";
            this.lblPole.Size = new System.Drawing.Size(36, 17);
            this.lblPole.TabIndex = 1;
            this.lblPole.Text = "Pole";
            //
            // lblObwód
            //
            this.lblObwód.AutoSize = true;
            this.lblObwód.Location = new System.Drawing.Point(12, 139);
            this.lblObwód.Name = "lblObwód";
            this.lblObwód.Size = new System.Drawing.Size(52, 17);
            this.lblObwód.TabIndex = 2;
            this.lblObwód.Text = "Obwód";
            //
            // lblKomunikat
            //
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKomunikat.Location = new System.Drawing.Point(70, 9);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(0, 17);
            this.lblKomunikat.TabIndex = 3;
            this.lblKomunikat.Click += new System.EventHandler(this.label4_Click);
            //
            // txtBok
            //
            this.txtBok.Location = new System.Drawing.Point(73, 40);
            this.txtBok.Name = "txtBok";
            this.txtBok.Size = new System.Drawing.Size(100, 22);
            this.txtBok.TabIndex = 4;
            this.txtBok.TextChanged += new System.EventHandler(this.txtBok_TextChanged);
            //
            // txtPole
            //
            this.txtPole.Location = new System.Drawing.Point(73, 89);
            this.txtPole.Name = "txtPole";
            this.txtPole.ReadOnly = true;
            this.txtPole.Size = new System.Drawing.Size(100, 22);
            this.txtPole.TabIndex = 5;
            //
            // txtObwód
            //
            this.txtObwód.Location = new System.Drawing.Point(73, 134);
            this.txtObwód.Name = "txtObwód";
            this.txtObwód.ReadOnly = true;
            this.txtObwód.Size = new System.Drawing.Size(100, 22);
            this.txtObwód.TabIndex = 6;
            this.txtObwód.TextChanged += new System.EventHandler(this.txtObwód_TextChanged);
            //
            // bttnWyczyść
            //
            this.bttnWyczyść.Location = new System.Drawing.Point(73, 197);
            this.bttnWyczyść.Name = "bttnWyczyść";
            this.bttnWyczyść.Size = new System.Drawing.Size(100, 23);
            this.bttnWyczyść.TabIndex = 7;
            this.bttnWyczyść.Text = "Wyczyść";
            this.bttnWyczyść.UseVisualStyleBackColor = true;
            this.bttnWyczyść.Click += new System.EventHandler(this.bttnWyczyść_Click);
            //
            // bttnZamknij
            //
            this.bttnZamknij.Location = new System.Drawing.Point(73, 226);
            this.bttnZamknij.Name = "bttnZamknij";
            this.bttnZamknij.Size = new System.Drawing.Size(100, 23);
            this.bttnZamknij.TabIndex = 8;
            this.bttnZamknij.Text = "Zamknij";
            this.bttnZamknij.UseVisualStyleBackColor = true;
            this.bttnZamknij.Click += new System.EventHandler(this.bttnZamknij_Click);
            //
            // bttnColor
            //
            this.bttnColor.Location = new System.Drawing.Point(73, 168);
            this.bttnColor.Name = "bttnColor";
            this.bttnColor.Size = new System.Drawing.Size(100, 23);
            this.bttnColor.TabIndex = 9;
            this.bttnColor.Text = "Kolor";
            this.bttnColor.UseVisualStyleBackColor = true;
            this.bttnColor.Click += new System.EventHandler(this.bttnColor_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 284);
            this.Controls.Add(this.bttnColor);
            this.Controls.Add(this.bttnZamknij);
            this.Controls.Add(this.bttnWyczyść);
            this.Controls.Add(this.txtObwód);
            this.Controls.Add(this.txtPole);
            this.Controls.Add(this.txtBok);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.lblObwód);
            this.Controls.Add(this.lblPole);
            this.Controls.Add(this.lblBok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pole i obwód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBok;
        private System.Windows.Forms.Label lblPole;
        private System.Windows.Forms.Label lblObwód;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.TextBox txtBok;
        private System.Windows.Forms.TextBox txtPole;
        private System.Windows.Forms.TextBox txtObwód;
        private System.Windows.Forms.Button bttnWyczyść;
        private System.Windows.Forms.Button bttnZamknij;
        private System.Windows.Forms.Button bttnColor;
    }
}

