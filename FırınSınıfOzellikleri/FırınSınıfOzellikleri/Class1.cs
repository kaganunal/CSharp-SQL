using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FırınSınıfOzellikleri
{
    internal class Firin
    {
        public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public double Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public DateTime GarantiTarihi { get; set; }
        public bool GarantiVarMi { get; set; }
        public double MaxDerecesi { get; set; }

        public Firin()
        {
            Console.WriteLine("Fırın oluşturuldu!");
        }
        public void GarantiUzat()
        {
            GarantiTarihi = GarantiTarihi.AddYears(3);
        }

        public void BilgiYazdir()
        {

            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Fiyat: " + Fiyat + "₺") ;
            Console.WriteLine("Güç: " + Guc + "W");
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Garanti süresi: " + GarantiSuresi + "yıl");
            Console.WriteLine("Garanti tarihi: " + GarantiTarihi.ToShortDateString());
            Console.WriteLine("Garantisi var mı: " + GarantiVarMi);
            Console.WriteLine("Max derecesi: " + MaxDerecesi + "°C");
        }
    }
}
