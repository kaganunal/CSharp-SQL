using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerci
{
    /// <summary>
    /// Fonksiyonlar metodu içinde bulunan metotlar ana formlarda bulunan işlem sayısını azaltmak için kullanılmıştır.
    /// </summary>
    public class Fonksiyonlar

    {
        /// <summary>
        /// Bu metod sayesinde enum kullanarak menülerin boy seçimlerinden elde edilecek geliri hesaplıyoruz.
        /// </summary>
        /// <param name="panelBoy"> Boy panelinin içinde bulundurduğu radio buttonlara ulaşbilmek için istiyoruz. </param>
        /// <returns> boyTutar </returns>
        public decimal GetBoyGeliri(GroupBox panelBoy)
        {
            decimal boyTutar = 0.00m;
            foreach (RadioButton item in panelBoy.Controls)
            {
                if (item.Checked)
                {
                    if (item.Text == "Küçük") 
                    {
                        boyTutar = Convert.ToDecimal(Enum.Boylar.Kucuk);
                    }
                    if (item.Text == "Orta")
                    {
                        boyTutar = Convert.ToDecimal(Enum.Boylar.Orta);
                    }
                    if (item.Text == "Büyük")
                    {
                        boyTutar = Convert.ToDecimal(Enum.Boylar.Buyuk);
                    }
                }
            }
            return boyTutar;
        }

        /// <summary>
        /// Ekstra malzemelerden elde edilen geliri bulmak için panelSoslar'da bulunan checboxları kontrol edip işaretli olanların value değerlerini topluyor.
        /// </summary>
        /// <param name="panelSoslar"> Panel içerisinde bulunan Check Box'lara erişebilmemizi sağlıyor. </param>
        /// <returns> ekstraTutar </returns>
        public decimal GetEkstraMalzemeGeliri(FlowLayoutPanel panelSoslar)
        {
            decimal ekstraTutar = 0.00m;
            foreach (CheckBox checkedBox in panelSoslar.Controls)
            {
                if (checkedBox.Checked)
                {
                    ekstraTutar += Soslar.sosDictionary[checkedBox.Text];
                }

            }
            return ekstraTutar;
        }

        /// <summary>
        /// Bu metod Combo Box'ta bulunan menülerden seçilen değeri bulup dictionarynin value değerini bularak menülerden elde edilen geliri döndürüyor.
        /// </summary>
        /// <param name="comboBoxMenuSecim"> comboBox içerisinde bulunan menülere erişmemizi sağlıyor. </param>
        /// <returns> toplamTutar </returns>
        public decimal GetMenuGeliri(ComboBox comboBoxMenuSecim)
        {
            decimal toplamTutar = 0.00m;
            foreach (var item in Menuler.menuDictionary.Keys)
            {
                if (comboBoxMenuSecim.Text == item)
                {
                    toplamTutar += Menuler.menuDictionary[comboBoxMenuSecim.Text];
                }
            }

            return toplamTutar;
        }

        /// <summary>
        /// Program ilk başlatıldığı anda Soslar dictionarysinde bulunan değerlere erişip bu değerleri panele yazdırmamızı sağlıyor.
        /// </summary>
        /// <param name="panelSoslar"> Panel içerisinde bulunan Check Box'lara erişebilmemizi sağlıyor. </param>
        public void GetSosAdi(FlowLayoutPanel panelSoslar)
        {

            foreach (var item in Soslar.sosDictionary.Keys)
            {
                CheckBox cbx = new CheckBox();
                cbx.Text = item;

                if (cbx.Text == "Ketçap" || cbx.Text == "Mayonez")
                {
                    cbx.Checked = true;
                }

                panelSoslar.Controls.Add(cbx);
            }
        }

        /// <summary>
        /// Program ilk başlatıldığı anda Menüler dictionarysinde bulunan değerlere erişip bu değerleri Combo Boxa ekliyor.
        /// </summary>
        /// <param name="comboBoxMenuSecim"> comboBox içerisinde bulunan menülere erişmemizi sağlıyor. </param>
        public void GetMenuAdi(ComboBox comboBoxMenuSecim)
        {
            foreach (var item in Menuler.menuDictionary.Keys)
            {
                comboBoxMenuSecim.Items.Add(item);
            }
        }

        /// <summary>
        /// Sipariş Ekle butonuna tıklandığında tüm siparişlerin bulunduğu listeye seçilen sosları sırayla yazdırmamızı sağlıyor.
        /// </summary>
        /// <param name="panelSoslar"> Panel içerisinde bulunan Check Box'lara erişebilmemizi sağlıyor. </param>
        /// <returns> soslar.ToString() </returns>
        public string GetSos(Panel panelSoslar)
        {

            StringBuilder sbCheckBox = new StringBuilder();

            foreach (CheckBox checkedBox in panelSoslar.Controls)
            {
                if ((checkedBox is CheckBox box) && box.Checked)
                {
                    sbCheckBox.Append(checkedBox.Text + ", ");
                }
            }
            string soslar = sbCheckBox.ToString();

            if (soslar.Length > 0)
            {
                soslar = soslar.Trim().Substring(0, soslar.Length - 2);
            }
            else
            {
                soslar = "Sos Girilmedi!";
            }

            return soslar.ToString();
        }

        /// <summary>
        /// Sipariş Ekle butonuna tıklandığında tüm siparişlerin bulunduğu listeye seçilen boyu yazdırmamızı sağlıyor.
        /// </summary>
        /// <param name="panelBoy"> Boy panelinin içinde bulundurduğu radio buttonlara ulaşbilmek için istiyoruz. </param>
        /// <returns> boylar.ToString() </returns>
        public string GetBoy(GroupBox panelBoy)
        {
            StringBuilder sbRadioButton = new StringBuilder();

            foreach (Control radioButton in panelBoy.Controls)
            {
                if ((radioButton is RadioButton) && ((RadioButton)radioButton).Checked)
                {
                    sbRadioButton.Append(radioButton.Text + ", ");
                }
            }
            string boylar = sbRadioButton.ToString();
            boylar = boylar.Trim().Substring(0, boylar.Length - 2);

            return boylar.ToString();
        }

        /// <summary>
        /// Satılan ürün adedine ulaşabilmek için panelSoslar'da bulunan sos sayısını ve bir adet hamnurgeri toplayıp işaretlenen adet sayısıyla çarpar ve değer döndürür.
        /// </summary>
        /// <param name="panelSoslar"> Panel içerisinde bulunan Check Box'lara erişebilmek için isteniyor. </param>
        /// <param name="numericAdet"> Toplam adet sayısını bulabilmek için menü adediyle çarpmak için isteniyor. </param>
        /// <returns></returns>
        public int GetSatilanUrunAdedi(FlowLayoutPanel panelSoslar, NumericUpDown numericAdet)
        {
            int i = 0;

            foreach (Control checkedBox in panelSoslar.Controls)
            {
                if ((checkedBox is CheckBox box) && box.Checked)
                {
                    i++;
                }
            }
            return (i + 1) * Convert.ToInt32(numericAdet.Text); //+1 hamburger için ;
        }
    }

}

