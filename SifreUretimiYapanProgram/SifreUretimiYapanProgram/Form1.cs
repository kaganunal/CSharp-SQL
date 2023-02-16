using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretimiYapanProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rndSifre = new Random();
        const string kucukHarf = "qwertyupasdfghjklizxcvbnm";
        const string buyukHarf = "QWERTYUOPASDFGHJKLZXCVBNMI";
        const string rakam = "0123456789";
        const string ozelKarakter = "\"'^_=)({}[].*?+#&!é/-\\";

        private void btnUret_Click(object sender, EventArgs e)
        {
            try
            {
                if (chckKucukHarf.Checked == false && chckBuyuk.Checked == false && chckRakam.Checked == false && chckOzelKarakter.Checked == false)
                {
                    MessageBox.Show("Lütfen şifre oluşturmak için bir parametre seçiniz!");
                }
                int sifreSayisi = Convert.ToInt32(numericUpDownSifreSayisi.Text);
                int sifreUzunluk = Convert.ToInt32(numericUpDownSifreUzunlugu.Text);
                for (int j = 0; j < sifreSayisi; j++)
                {
                    char[] sifreKarakteri = new char[sifreUzunluk];

                    StringBuilder sb = new StringBuilder();

                    if (chckKucukHarf.Checked == true)
                    {
                        sb.Append(kucukHarf);
                    }

                    if (chckBuyuk.Checked == true)
                    {
                        sb.Append(buyukHarf);
                    }

                    if (chckRakam.Checked == true)
                    {
                        sb.Append(rakam);
                    }

                    if (chckOzelKarakter.Checked == true)
                    {
                        sb.Append(ozelKarakter);
                    }

                    for (int i = 0; i < sifreUzunluk; i++)
                    {
                        sifreKarakteri[i] = sb[rndSifre.Next(sb.Length - 1)];
                    }

                    lstSifreler.Items.Add($"{j + 1}-)    " + string.Join(null, sifreKarakteri));

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }
    }
}

