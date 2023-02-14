using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreZorlukDerecesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string ozelKarakterler = "\"'^_=)({}[].*?+#&!é/-\\";
            bool ozelKarakter = false;
            bool harf = false;
            bool sayi = false;


            foreach (char item in txtSifre.Text)
            {
                if (char.IsLetter(item))
                {
                    harf = true;
                }
                else if (char.IsDigit(item))
                {
                    sayi = true;
                }
                else if (ozelKarakterler.Contains(item))
                {
                    ozelKarakter = true;
                }

            }

            if (txtSifre.TextLength < 6)
            {
                lblZorluk.ForeColor = Color.Red;
                lblZorluk.Text = "Düşük";
            }

            else if (ozelKarakter == true && harf == true && sayi == true)
            {
                lblZorluk.ForeColor = Color.Green;
                lblZorluk.Text = "Yüksek";
            }

            else if ((sayi == true && ozelKarakter == true) || (harf == true && ozelKarakter == true) || (sayi == true && harf == true))
            {
                lblZorluk.ForeColor = Color.Blue;
                lblZorluk.Text = "Orta";
            }

            else
            {
                lblZorluk.ForeColor = Color.Red;
                lblZorluk.Text = "Düşük";
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                MessageBox.Show("Hesabınız oluşturuldu!");
                
            }
        }
    }
}
