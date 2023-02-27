using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using RadioButton = System.Windows.Forms.RadioButton;

namespace OOPHamburgerci
{
    /// <summary>
    /// Sipariş oluştur formu üzerinden istenen menü, menü boyu, ekstra soslar ve menü adedi kullanıcıdan istenebilir ve toplam tutar, sipariş listesi değerleri ekrana yazdırılabilir.
    /// </summary>
    public partial class SiparisOlustur : Form
    {

        public SiparisOlustur()
        {
            InitializeComponent();
        }

        // Globalde gerekli değerleri tanımlayıp sıfır değeri atanmıştır.
        decimal toplamTutar = 0;
        decimal sonTutar = 0;
        decimal ekstraTutar = 0;
        int satilanUrunAdedi = 0;
        decimal toplamEkstraTutar = 0;
        decimal boyTutar = 0;
        readonly Fonksiyonlar fonksiyonlar = new Fonksiyonlar();

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            fonksiyonlar.GetMenuAdi(comboBoxMenuSecim); // Form yüklendiğinde menü isimlerini Combo Box'a yazdırabilmek için kullanılmaktadır.
            fonksiyonlar.GetSosAdi(panelSoslar); // Form yüklendiğinde sos isimlerini Check Box'lara yazdırabilmek için kullanılmaktadır.
        }
        public void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (int.Parse(numericAdet.Text) > 0)
            {
                
                satilanUrunAdedi += fonksiyonlar.GetSatilanUrunAdedi(panelSoslar, numericAdet); // Satılan ürün adedini listeye eklemek için çağırılmaktadır.



                toplamTutar = fonksiyonlar.GetMenuGeliri(comboBoxMenuSecim); // Toplam tutarın hesaplanması önce menü gelirlerinin eklenmesiyle başlamaktadır.

                boyTutar = fonksiyonlar.GetBoyGeliri(panelBoy); // Toplam tutara eklemek için boy seçimlerinden elde edilen gelirler çağırılmıştır.

                toplamTutar += boyTutar;

                ekstraTutar = fonksiyonlar.GetEkstraMalzemeGeliri(panelSoslar);// Toplam tutara eklemek için soslardan elde edilen gelirler çağırılmıştır.

                toplamEkstraTutar += ekstraTutar * Convert.ToInt32(numericAdet.Text); // Sipariş Bilgileri formunda bulunan ekstra malzeme gelirlerine değer göndermek için kullanılmıştır.
                
                toplamTutar += ekstraTutar;

                toplamTutar *= Convert.ToInt32(numericAdet.Text);

                sonTutar += toplamTutar;

                listSiparis.Items.Add(comboBoxMenuSecim.Text + " x " + numericAdet.Text + " Adet, " + fonksiyonlar.GetBoy(panelBoy) + ", (" + fonksiyonlar.GetSos(panelSoslar) + ") Tutar: " + toplamTutar); // Sipariş listesine ürünleri yazdırmak için kullanılmaktadır.

                // Aşağıda bulunan kod parçaları sipariş Ekle butonu tetiklendiğinde bazı verilerin sıfırlanması için kullanılmıştır.
                comboBoxMenuSecim.SelectedIndex = 0;
                radioBtnKucuk.Checked = true;
                radioBtnOrta.Checked = false;
                radioBtnBuyuk.Checked = false;

                foreach (CheckBox item in panelSoslar.Controls) 
                {
                    if (item.Text == "Ketçap" || item.Text == "Mayonez") // Bu if statement sayesinde ketçap ve mayonez her seferinde ekrana default olarak seçilip gönderilecektir. 
                    {
                        item.Checked = true;
                    }
                    else
                    {
                        item.Checked = false;
                    }
                }
                numericAdet.Value = 0;

            }
            else
            {
                MessageBox.Show("Lütfen adet seçiniz!");
            }

            lblToplamTutar.Text = "₺" + Convert.ToString(sonTutar); //Toplam tutarın yazdırılması için kullanılmıştır.
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //Aşağıda bulunan kod parçaları Siparişi Temizle butonu tetiklendiğinde verilerin sıfırlanması için kullanılmıştır.
            comboBoxMenuSecim.SelectedIndex = 0;
            radioBtnKucuk.Checked = true;
            radioBtnOrta.Checked = false;
            radioBtnBuyuk.Checked = false;
            numericAdet.Value = 0;
            listSiparis.Items.Clear();
            lblToplamTutar.Text = "₺0,00";
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            //Siparişi Tamamla butonu tetiklendiğinde ekrana onay kutusu göndermektedir, eğer onay verilirse kullanıcıyı Sipariş Bilgileri kısmına yönlendirir ve istenen bilgileri instance kullanarak yollar.
            DialogResult res = MessageBox.Show("Toplam Sipariş Tutarı: ₺" + sonTutar + "\nSatın almayı tamamlamak ister misiniz?", "Sipariş Onayı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
                siparisBilgileri.ciro = lblToplamTutar.Text;
                siparisBilgileri.siparisSayisi = Convert.ToString(listSiparis.Items.Count);
                siparisBilgileri.ekstraMalzemeGeliri = Convert.ToString(toplamEkstraTutar);
                siparisBilgileri.satilanUrunAdedi = Convert.ToString(satilanUrunAdedi);
                siparisBilgileri.listTumSiparisler.Items.Clear();
                siparisBilgileri.listTumSiparisler.Items.AddRange(listSiparis.Items);
                siparisBilgileri.MdiParent = ActiveForm;
                siparisBilgileri.Show();
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("İptal Edildi!");
            }
        }

    }
}
