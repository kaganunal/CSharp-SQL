using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonUygulamasi.Classlar;

namespace TelefonUygulamasi
{
    public partial class TelefonListele : Form
    {
        public List<Telefon> TelefonListesi = new List<Telefon>();

        public TelefonListele()
        {
            InitializeComponent();

            TelefonListesi = TelefonDuzenle.TelefonListesi;

            foreach (var item in TelefonListesi)
            {
                comboBoxTelefonlar.Items.Add(item.Marka + " " + item.Model + " " + item.Yil);
            }
        }

        private void comboBoxTelefonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxTelefonlar.SelectedIndex;
            lblMarka.Text = TelefonListesi[index].Marka;
            lblModel.Text = TelefonListesi[index].Model;
            lblYil.Text = Convert.ToString(TelefonListesi[index].Yil);
            lblDurum.Text = Convert.ToString(TelefonListesi[index].TelefonDurum);

            if (Convert.ToString(TelefonListesi[index].TelefonDurum) == "Satışta")
            {
                lblDurum.BackColor = Color.LawnGreen;
            }
            if (Convert.ToString(TelefonListesi[index].TelefonDurum) == "Kullanımda")
            {
                lblDurum.BackColor = Color.Gold;
            }
            if (Convert.ToString(TelefonListesi[index].TelefonDurum) == "Hurda")
            {
                lblDurum.BackColor = Color.Crimson;
            }

        }
    }
}
