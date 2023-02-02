using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zamHesaplamaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GroupBox GetGroupDiller()
        {
            return groupDiller;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(txtMaas.Text);
            double zam = 0;

            if (rdBtnEvli.Checked == true)
            {
                zam = 10;
            }
            if (rdBtnBekar.Checked == true)
            {
                zam = zam + 0;
            }
            if (rdBtn0Cocuk.Checked == true)
            {
                zam = zam + 0;
            }
            if (rdBtn1Cocuk.Checked == true)
            {
                zam = zam + 5;
            }
            if (rdBtn2Cocuk.Checked == true)
            {
                zam = zam + 10;
            }
            if (rdBtn3Cocuk.Checked == true)
            {
                zam = zam + 20;
            }
            if (checkIngilizce.Checked == true)
            {
                zam = zam + 5;
            }
            if (checkAlmanca.Checked == true)
            {
                zam = zam + 5;
            }
            if (checkFransizca.Checked == true)
            {
                zam = zam + 5;
            }
            if (checkYunanca.Checked == true)
            {
                zam = zam + 5;
            }
            if (checkItalyanca.Checked == true)
            {
                zam = zam + 5;
            }
            if (checkArapca.Checked == true)
            {
                zam = zam + 5;
            }



            maas = (maas) + (zam * maas / 100) ;
            maas = maas + (maas * (0.3492));
            txtZamli.Text = Convert.ToDecimal(maas) + "₺";
        }
    }
}
