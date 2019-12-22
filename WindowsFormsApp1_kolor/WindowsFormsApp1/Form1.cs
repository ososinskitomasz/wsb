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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBok_TextChanged(object sender, EventArgs e)
        {
            double bok;

            if (double.TryParse(txtBok.Text, out bok) && bok > 0)
            {
                txtPole.Text = Math.Pow(bok, 2).ToString();
                txtObwód.Text = (bok * 4).ToString();
                lblKomunikat.Text = string.Empty;
            }
            else
            {
                lblKomunikat.Text = "Wpisz dodatnią liczbę";
                txtPole.Text = string.Empty;
                txtObwód.Text = string.Empty;
            }
        }

        private void txtObwód_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnWyczyść_Click(object sender, EventArgs e)
        {
            txtBok.Text = string.Empty;
            txtPole.Text = string.Empty;
            txtObwód.Text = string.Empty;
            lblKomunikat.Text = "Wprowadź prawidłowe dane";
        }

        private void bttnColor_Click(object sender, EventArgs e)
        {
            var formColor = new Color();
            formColor.Show();
        }
    }
}
