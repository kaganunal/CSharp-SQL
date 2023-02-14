using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.Up:
                    YukariCik();
                    break;
                case Keys.Down:
                    AsagiIn();
                    break;
                case Keys.Right:
                    SagaGit();
                    break;
                case Keys.Left:
                    SolaGit();
                    break;

            }
            OyunBittiMi();

        }
        int kazanSayac = 0;
        int kaybetSayac = 0;
        private void OyunBittiMi()
        {
            bool kazandiMi = pnlKutu.Bounds.IntersectsWith(lblBitis.Bounds);
            bool kaybettiMi = pnlKutu.Bounds.IntersectsWith(lbl1D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl2D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl3D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl4D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl5D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl6D.Bounds) || pnlKutu.Bounds.IntersectsWith(lbl7D.Bounds);
            if (kazandiMi)
            {
                kazanSayac++;
                lblKazan.Text = kazanSayac.ToString();
                DialogResult dr = MessageBox.Show("Tekrar Deneyiniz!", "Kazandınız!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(162, 250);
                }
                else
                {
                    Application.Exit();
                }

            }
            if (kaybettiMi)
            {
                kaybetSayac++;
                lblKaybet.Text = kaybetSayac.ToString();
                DialogResult dr = MessageBox.Show("Tekrar Deneyiniz!", "Kaybettiniz!", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    pnlKutu.Location = new Point(162, 250);
                }
                else
                {
                    Application.Exit();
                }

            }
        }
        private void SolaGit()
        {
            pnlKutu.Left -= 10;
        }

        private void SagaGit()
        {
            pnlKutu.Left += 10;
        }

        private void AsagiIn()
        {
            pnlKutu.Top += 10;
        }

        private void YukariCik()
        {
            pnlKutu.Top -= 10;
        }
    }
}
