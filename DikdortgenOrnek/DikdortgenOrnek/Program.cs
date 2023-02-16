using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d1 = new Dikdortgen("Dikdörtgen 1", 0, 15, 10, 0);
            Dikdortgen d2 = new Dikdortgen("Dikdörtgen 2", 0, 8, 12, 0);

            Dikdortgen buyukOlan = d1.BuyukOlan(d2);
            buyukOlan.Yaz();
            d1.BuyukOlan(d2).Yaz();
            d2.BuyukOlan(d1).Yaz();

            Dikdortgen d3 = new Dikdortgen("Dikdörtgen 3", 0, 8, 12, 0);
            d1.Yaz();
            d2.Yaz();
            d3.Yaz();
            d1.KareYap();
            d2.KareYap();
            d3.KareYap();
            d1.Yaz();
            d2.Yaz();
            d3.Yaz();
        }
    }
}
