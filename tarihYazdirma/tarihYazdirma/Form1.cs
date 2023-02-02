using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarihYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            txtTarih1.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtTarih2.Text = DateTime.Now.ToString("dddd MM dd");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
