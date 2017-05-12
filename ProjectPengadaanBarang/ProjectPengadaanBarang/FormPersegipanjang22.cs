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
    public partial class FormPersegipanjang22 : Form
    {
        public FormPersegipanjang22()
        {
            InitializeComponent();
        }

        void bersih()
        {
            txtHasil.Text = "";

            txtLebar.Text = "";

            txtPanjang.Text = "";
        }
        private void FormPersegipanjang22_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bersih();
        }
    }
}
