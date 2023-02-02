using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullaniciAdiSifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSifre.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (txtSifre.Text == "1234" && txtKullaniciAdi.Text == "bilge.adam") 
            {
                MessageBox.Show("Giriş başarılı");  
            }
            else
            {
                MessageBox.Show("Tekrardan giriş yapınız");
            }
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Gizle";
            }
            else 
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Göster";
            }
        }
    }
}
