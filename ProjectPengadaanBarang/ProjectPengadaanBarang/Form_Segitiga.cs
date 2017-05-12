using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPengadaanBarang
{
    public partial class Form_Segitiga : Form
    {
        public Form_Segitiga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tinggi = Convert.ToInt32(txtAngka1.Text);
            int alas = Convert.ToInt32(txtAlas.Text);

            int hasil = alas * tinggi;
            hasil = hasil / 2;

            label3.Text = hasil.ToString();
        }
    }
}
