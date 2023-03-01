using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonUygulamasi.Classlar
{
    public class Telefon
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public Durum TelefonDurum { get; set; }

    }
}
