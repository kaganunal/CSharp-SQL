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

namespace Curriculum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string ad = txtAd.Text;
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        }

        private void listBoxKalan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad.Length == 0)
            {

                System.Console.WriteLine("Empty String");
            }
            else if (ad.Length == 1)
            {

                System.Console.WriteLine(char.ToUpper(ad[0]));
            }
            else
            {

                System.Console.WriteLine(char.ToUpper(ad[0]) + ad.Substring(1));
            }

            if (rdBtnGecti.Checked)
            {

                listBoxGecen.Items.Add(txtAd.Text + " " + txtSoyad.Text);
                txtAd.Clear();
                txtSoyad.Clear();
            }
            else if (rdBtnKaldi.Checked)
            {
                listBoxKalan.Items.Add(txtAd.Text + " " + txtSoyad.Text);
                txtAd.Clear();
                txtSoyad.Clear();
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            string soyad = txtSoyad.Text.Trim();
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
