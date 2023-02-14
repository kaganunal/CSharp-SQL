using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            string ad = txtAd.Text.Trim();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            ad = textInfo.ToTitleCase(ad);


            
            string soyad = txtSoyad.Text.Trim().ToUpper();
            try
            {
                double not1 = Convert.ToDouble(txtNot1.Text);
                double not2 = Convert.ToDouble(txtNot2.Text);
                double not3 = Convert.ToDouble(txtNot3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
            }

            if ((Convert.ToDouble(txtNot1.Text) < 0 || Convert.ToDouble(txtNot1.Text) > 100) || (Convert.ToDouble(txtNot2.Text) < 0 || Convert.ToDouble(txtNot2.Text) > 100) || (Convert.ToDouble(txtNot3.Text) < 0 || Convert.ToDouble(txtNot3.Text) > 100))
            {
                MessageBox.Show("Lütfen 0-100 arasında bir değer giriniz!");
            }

            else
            {
                double ortalama = (Convert.ToDouble(txtNot1.Text) + Convert.ToDouble(txtNot2.Text) + Convert.ToDouble(txtNot3.Text)) / 3;
                if (ortalama >= 50)
                {
                    string basari = "Geçtiniz";
                    Form2 form2 = new Form2();
                    form2.lblAdSoyad.Text = ad + " " + soyad;
                    form2.lblOrtalama.Text = Convert.ToString(ortalama);
                    form2.lblBasariDurumu.Text = Convert.ToString(basari);
                    form2.ShowDialog();

                }
                else if (ortalama < 50)
                {
                    string basarisiz = "Kaldınız!";
                    Form2 form2 = new Form2();
                    form2.lblAdSoyad.Text = ad + " " + soyad;
                    form2.lblOrtalama.Text = Convert.ToString(ortalama);
                    form2.lblBasariDurumu.Text = Convert.ToString(basarisiz);
                    form2.ShowDialog();
                }
            }

        }

    }
}
