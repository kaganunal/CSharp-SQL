using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mailYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtIsim.BackColor = Color.Azure;
            txtIsim.ForeColor = Color.Firebrick;
            txtIsim.Font = new Font("Georgia", 16);

            txtSoyIsim.BackColor = Color.Azure;
            txtSoyIsim.ForeColor = Color.Firebrick;
            txtSoyIsim.Font = new Font("Georgia", 16);

            txtEMail.BackColor = Color.Azure;
            txtEMail.ForeColor = Color.Firebrick;
            txtEMail.Font = new Font("Georgia", 16);

            btnEMail.BackColor = Color.Azure;
            btnEMail.ForeColor = Color.Firebrick;

            string email = isim+ SoyIsim + ".bilgeadam.com";
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEMail_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text;
            string SoyIsim = txtSoyIsim.Text;
            string email = isim+ SoyIsim + ".bilgeadam.com";
            MessageBox.Show(email);
            string txtEMail = Convert.ToString(txtIsim.Text + txtSoyIsim.Text + ".bilgeadam.com");
        }

        private void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtIsim.Clear();
            txtSoyIsim.Clear();
            txtEMail.Clear();

        }
    }
}
