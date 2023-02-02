using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace merhabaMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIsimGoster_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;

            MessageBox.Show("Merhaba " + isim);
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
