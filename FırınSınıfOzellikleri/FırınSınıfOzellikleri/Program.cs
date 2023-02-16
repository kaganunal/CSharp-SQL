using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FırınSınıfOzellikleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firin firin1 = new Firin();

            firin1.Marka = "Bosch";
            firin1.Fiyat = 13999m;
            firin1.Guc = 1500;
            firin1.Model = "HBF514BB0T";
            firin1.GarantiSuresi = 2;
            firin1.GarantiTarihi = Convert.ToDateTime("15.02.2025");
            firin1.GarantiVarMi = true;
            firin1.MaxDerecesi = 260;

            firin1.GarantiUzat();

            firin1.BilgiYazdir();

            Console.WriteLine();

            Firin firin2 = new Firin();

            firin2.Marka = "Arçelik";
            firin2.Fiyat = 10999m;
            firin2.Guc = 900;
            firin2.Model = "MF 30 QBB";
            firin1.GarantiSuresi = 3;
            firin2.GarantiTarihi = Convert.ToDateTime("15.02.2026");
            firin2.GarantiVarMi = true;
            firin2.MaxDerecesi = 240;



            firin2.BilgiYazdir();

            Console.ReadKey();
        }
    }
}
