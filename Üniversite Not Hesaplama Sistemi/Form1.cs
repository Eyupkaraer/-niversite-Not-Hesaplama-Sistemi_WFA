using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üniversite_Not_Hesaplama_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int vize = int.Parse(txtVize.Text);
            int final = int.Parse(txtFinal.Text);

            double ortalama = vize * 0.4 + final * 0.6;

            txtOrtalama.Text = ortalama.ToString();

            if (ortalama >= 87 && ortalama <= 100)
            {
                txtHarfNotu.Text= "AA";
            }

            if (ortalama >= 81 && ortalama <= 87)
            {
                txtHarfNotu.Text = "BA";
            }

            if (ortalama >= 74 && ortalama <= 80)
            {
                txtHarfNotu.Text = "BB";
            }

            if (ortalama >= 67 && ortalama <= 73)
            {
                txtHarfNotu.Text = "CB";
            }

            if (ortalama >= 60 && ortalama <= 66)
            {
                txtHarfNotu.Text = "CC";
            }

            if (ortalama >= 53 && ortalama <= 59)
            {
                txtHarfNotu.Text = "DC";
            }

            if (ortalama >= 46 && ortalama <= 52)
            {
                txtHarfNotu.Text = "DD";
            }

            if (ortalama >= 39 && ortalama <= 45)
            {
                txtHarfNotu.Text = "FD";
            }

            if (ortalama >= 0 && ortalama <= 38)
            {
                txtHarfNotu.Text = "FF";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVize.Text = string.Empty;
            txtFinal.Text = string.Empty;
            txtOrtalama.Text = string.Empty;
            txtHarfNotu.Text= string.Empty;
        }
    }
}
