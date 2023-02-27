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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }



        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            SiparisOlustur siparisOlustur = new SiparisOlustur();


            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == siparisOlustur.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            siparisOlustur.MdiParent = this;
            siparisOlustur.Show();


        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            SiparisBilgileri siparisBilgileri = new SiparisBilgileri();

            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == siparisBilgileri.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            siparisBilgileri.MdiParent = this;
            siparisBilgileri.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            MenuEkle menuEkle = new MenuEkle();

            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == menuEkle.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            menuEkle.MdiParent = this;
            menuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            EkstraMalzemeEkle ekstraMalzemeEkle = new EkstraMalzemeEkle();

            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == ekstraMalzemeEkle.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            ekstraMalzemeEkle.MdiParent = this;
            ekstraMalzemeEkle.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
