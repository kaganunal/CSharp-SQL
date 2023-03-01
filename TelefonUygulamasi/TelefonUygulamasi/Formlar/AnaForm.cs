using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulamasi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        private void telefonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            TelefonListele telefonListele = new TelefonListele();


            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == telefonListele.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            telefonListele.MdiParent = this;
            telefonListele.Show();
        }

        private void telefonDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
            TelefonDuzenle telefonDuzenle = new TelefonDuzenle();


            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == telefonDuzenle.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }
            telefonDuzenle.MdiParent = this;
            telefonDuzenle.Show();
        }
    }
}
