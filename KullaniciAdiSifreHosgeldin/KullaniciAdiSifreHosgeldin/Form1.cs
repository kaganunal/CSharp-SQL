using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifreHosgeldin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "admin" && txtSifre.Text == "123")
            {
                Form2 form2 = new Form2();
                form2.label1.Text = "Hoşgeldiniz " + txtKullanici.Text;
                form2.ShowDialog();
                this.Hide();
            }
        }
    }

}
