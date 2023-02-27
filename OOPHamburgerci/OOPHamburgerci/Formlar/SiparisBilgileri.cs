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
    /// Sipariş Bilgileri Formu üzerinden ciro, sipariş sayısı, ekstra malzeme geliri, satılan ürün adedi gibi bilgilere erişilebilir. Ayrıca önceden eklenen menülerin üzerine yeni menüler eklenerek listede gösterilir.
    /// </summary>
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        public string ciro, siparisSayisi, ekstraMalzemeGeliri, satilanUrunAdedi, tumSiparisler;

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            //Sipariş Oluştur kısmından elde edilen veriler burada yazdırılır.
            lblCiro.Text = ciro;
            lblSiparisSayisi.Text = siparisSayisi;
            lblEkstraMalzemeGelir.Text = "₺" + ekstraMalzemeGeliri;
            lblSatilanUrunAdet.Text = satilanUrunAdedi;
            listTumSiparisler.Text = tumSiparisler;
        }



    }
}
