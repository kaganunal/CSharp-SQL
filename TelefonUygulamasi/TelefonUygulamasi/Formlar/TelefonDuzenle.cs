using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelefonUygulamasi.Classlar;

namespace TelefonUygulamasi
{
    public partial class TelefonDuzenle : Form
    {
        public static List<Telefon> TelefonListesi = new List<Telefon>();
        public static List<Telefon> telefonlar => TelefonListesi;

        readonly TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        public TelefonDuzenle()
        {
            InitializeComponent();

            foreach (var item in TelefonListesi)
            {
                listTelefonlar.Items.Add(item.Marka + " | " + item.Model + " | " + item.Yil + " | " + item.TelefonDurum);
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listTelefonlar.Items.Remove(listTelefonlar.SelectedItem);
            Temizle();
        }

        public void Ekle()
        {
            try
            {
                string telefonMarka = txtMarka.Text.Trim();
                string telefonModel = txtModel.Text.Trim();
                int telefonYil = int.Parse(txtYil.Text);
                string durum = Fonksiyonlar.GetDurum(groupBoxDurum);

                telefonMarka = myTI.ToTitleCase(telefonMarka);
                telefonModel = myTI.ToTitleCase(telefonModel);

                Telefon telefon = new Telefon();
                telefon.Marka = telefonMarka;
                telefon.Model = telefonModel;
                telefon.Yil = telefonYil;

                foreach (RadioButton radioBtn in groupBoxDurum.Controls)
                {
                    if (radioBtn.Checked)
                    {
                        if (radioBtn.Text == "Satışta")
                        {
                            telefon.TelefonDurum = Durum.Satista;
                        }
                        if (radioBtn.Text == "Kullanımda")
                        {
                            telefon.TelefonDurum = Durum.Kullanimda;
                        }
                        if (radioBtn.Text == "Hurda")
                        {
                            telefon.TelefonDurum = Durum.Hurda;
                        }
                    }

                }
                TelefonListesi.Add(telefon);

                listTelefonlar.Items.Add(telefonMarka + " | " + telefonModel + " | " + telefonYil + " | " + durum);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        public void Guncelle()
        {
            try
            {
                int index = listTelefonlar.SelectedIndex;
                listTelefonlar.Items.RemoveAt(index);

                string telefonMarka = txtMarka.Text.Trim();
                string telefonModel = txtModel.Text.Trim();
                int telefonYil = int.Parse(txtYil.Text);
                string durum = Fonksiyonlar.GetDurum(groupBoxDurum);

                telefonMarka = myTI.ToTitleCase(telefonMarka);
                telefonModel = myTI.ToTitleCase(telefonModel);

                Fonksiyonlar.GetDurum(groupBoxDurum);

                listTelefonlar.Items.Insert(index, telefonMarka + " | " + telefonModel + " | " + telefonYil + " | " + durum);

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        public void Temizle()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtYil.Clear();
            radioBtnSatista.Checked = true;
        }


    }
}
