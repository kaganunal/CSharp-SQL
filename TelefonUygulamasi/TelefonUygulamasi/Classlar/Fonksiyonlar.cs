using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulamasi.Classlar
{
    static class Fonksiyonlar
    {

        public static string GetDurum(GroupBox groupBoxDurum)
        {
            string durum = "";
            foreach (RadioButton item in groupBoxDurum.Controls)
            {
                if (item.Checked)
                {
                    if (item.Text == "Satışta")
                    {
                        durum = "Satışta";
                    }
                    if (item.Text == "Kullanımda")
                    {
                        durum = "Kullanımda";
                    }
                    if (item.Text == "Hurda")
                    {
                        durum = "Hurda";
                    }
                }
            }
            return durum;
        }

    }
}
