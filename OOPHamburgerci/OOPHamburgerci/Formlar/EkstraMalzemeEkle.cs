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

namespace OOPHamburgerci
{
    /// <summary>
    /// Ekstra Malzeme Ekle Formu kullanıcının sipariş oluşturma listesine istediği bir sosu ve fiyatını eklemesi için kullanılır.
    /// </summary>
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        public void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            string ekstraAd = txtEkstraMalzeme.Text.Trim();

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            ekstraAd = myTI.ToTitleCase(ekstraAd); //Eklenen sosun ilk harflerini büyük yapmak için ToTitleCase() metodu kullanılmıştır.

            try
            {
                if (ekstraAd == string.Empty)
                {
                    MessageBox.Show("Sos için bir ad giriniz!"); // Sos adı kısmı boş bırakılırsa kullanıcıyı bilgilendirir.
                }
                else if (numericEkstraFiyat.Value == 0)
                {
                    MessageBox.Show("Menü için geçerli bir fiyat giriniz!"); // Sos fiyatı kısmı sıfır veya sıfırdan küçük olursa kullanıcıyı bilgilendirir.
                }
                else
                {
                    Soslar.sosDictionary.Add(ekstraAd, numericEkstraFiyat.Value); //Eğer statementlar doğru girilirse Ekstra sınıfında hazırlanan sosDictionary'sine sos adını ve sos fiyatını ekler.
                    MessageBox.Show($"{ekstraAd} sos eklendi!");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Bu isimde bir sos zaten mevcut!"); // Aynı isimde bir değer girildiğinde ekrana uyarı gönderir.
            }
            catch (Exception hata)
            {
                MessageBox.Show(Convert.ToString(hata)); // Argument Exception hatası dışındaki diğer hataları yakalayarak kullanıcıyı bilgilendirir.
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

