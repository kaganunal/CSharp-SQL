using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KarakterSınırlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int sinir = rchText.TextLength;
            lblSinir.Text = "Kalan Karakter Sayısı: " + (255 - rchText.TextLength).ToString();
            if (sinir == 255)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!");
            }

            if (sinir <= 50)
            {
                lblSinir.ForeColor = Color.Black;
            }
            if (sinir <= 100 && sinir > 50)
            {
                lblSinir.ForeColor = Color.DarkRed;
            }
            if (sinir <= 150 && sinir > 100 )
            {
                lblSinir.ForeColor = Color.Firebrick;
            }
            if (sinir <= 200 && sinir > 150)
            {
                lblSinir.ForeColor = Color.Crimson;
            }
            if (sinir <= 255 && sinir >200)
            {
                lblSinir.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rchText.MaxLength = 255;
        }


    }
}
