using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci
{
    /// <summary>
    /// Enum sınıfı sayesinde menü boylarını static olarak istediğimiz classta fiyat değerleriyle beraber kullanabiliriz.
    /// </summary>
    public static class Enum
    {
        public enum Boylar
        {
            Kucuk = 0,
            Orta = 6,
            Buyuk = 11,
        }
    }
}
