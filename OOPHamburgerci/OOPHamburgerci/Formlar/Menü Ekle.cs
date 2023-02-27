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
    /// Menü Ekleme formu kullanıcının menüye istediği bir menüyü ve fiyatını eklemesi için kullanılır.
    /// </summary>
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            string menuAd = txtMenuEkle.Text.Trim();

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            menuAd = myTI.ToTitleCase(menuAd); //Eklenen menünün ilk harflerini büyük yapmak için ToTitleCase() metodu kullanılmıştır.

            try
            {
                if (Convert.ToString(numericYeniMenuFiyat.Value) == "0")
                {
                    MessageBox.Show("Menü için geçerli bir fiyat giriniz!"); //Menü fiyatı kısmı sıfır veya sıfırdan küçük olursa kullanıcıyı bilgilendirir.
                }
                else if (menuAd == string.Empty)
                {
                    MessageBox.Show("Menü için bir ad giriniz!"); // Menü Adı kısmı boş bırakılırsa kullanıcıyı bilgilendirir.
                }
                else
                {
                    Menuler.menuDictionary.Add(menuAd, numericYeniMenuFiyat.Value); //Eğer statementlar doğru girilirse Menuler sınıfında hazırlanan menuDictionary'sine menü adını ve menü fiyatını ekler.
                    MessageBox.Show($"{menuAd} menüsü eklendi!");
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

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
