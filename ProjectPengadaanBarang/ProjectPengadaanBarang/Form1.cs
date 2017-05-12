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
    public partial class Form1 : Form
    {    public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPersegipanjang22 x = new FormPersegipanjang22();
      
            
            x.Visible = true;

        }
    }
}
