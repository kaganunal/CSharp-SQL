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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace personelEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string sehir = txtSehir.Text.Trim();

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            ad = myTI.ToTitleCase(ad);
            sehir = myTI.ToTitleCase(sehir);
            soyad = myTI.ToUpper(soyad);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string sehir = txtSehir.Text;

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            ad = myTI.ToTitleCase(ad);
            sehir = myTI.ToTitleCase(sehir);
            soyad = myTI.ToUpper(soyad);

            //listIsim.Items.Add(ad.Substring(0, 1).ToUpper() + txtAd.Text.Substring(1).ToLower() + " " + txtSoyad.Text + " | " + txtSehir.Text.Substring(0, 1).ToUpper() + txtSehir.Text.Substring(1).ToLower());

            listIsim.Items.Add(ad + " " + soyad + " | " + sehir);
            txtAd.Clear();
            txtSoyad.Clear();
            txtSehir.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listIsim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek bir veri seçiniz!");
            }
            else
            {
                listIsim.Items.Remove(listIsim.SelectedItem);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string sehir = txtSehir.Text.Trim();

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            ad = myTI.ToTitleCase(ad);
            sehir = myTI.ToTitleCase(sehir);
            soyad = myTI.ToUpper(soyad);

            if (listIsim.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir veri seçiniz!");
            }
            else
            {
                int index = listIsim.SelectedIndex;
                listIsim.Items.Remove(listIsim.SelectedItem);
                listIsim.Items.Insert(index, ad + " " + soyad + " | " + sehir);
            }

        }
    }
}
