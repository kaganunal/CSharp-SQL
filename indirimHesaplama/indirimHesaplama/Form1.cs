using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimHesaplama
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tutar;
            decimal indirim = 0m;

            tutar = Convert.ToDecimal(txtTutar.Text);

            if (chck5Indirim.Checked == true)
            {
                indirim = 5m;
            }
            if (chck10Indirim.Checked == true)
            {
                indirim = indirim + 10m;
            }
            if (chck10Indirim.Checked == true)
            {
                indirim = indirim + 10m;
            }

            tutar = tutar - (indirim * tutar / 100m);
            txtIndirimli.Text = Convert.ToDecimal(tutar) + "₺";
        }
    }
}
