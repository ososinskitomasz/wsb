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
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBokKolor_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int bok;

            if (int.TryParse(textBox1.Text, out bok) && bok <= 200)
            {
                panel1.Width = bok;
                panel1.Height = bok;
                lblKomunikat.Text = string.Empty;
            }
            else
            {
                lblKomunikat.Text = "Wprowadź prawidłowe dane gnojku";
            }
        }

        private void bttnKolor_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
