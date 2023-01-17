using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kdvHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal hamPara, kdvGida, kdvYemek, kdvAlkol;


            Console.WriteLine("Lütfen ürünün ham fiyatını giriniz: ");
            hamPara = Convert.ToDecimal(Console.ReadLine());

            kdvGida = (0.01m * hamPara) + hamPara;
            kdvYemek = (0.08m * hamPara) + hamPara;
            kdvAlkol = (0.18m * hamPara) + hamPara;

            Console.WriteLine("Almış olduğunuz ürünün KDV'li fiyatı gıdaysa " + kdvGida + ", yemekse " + kdvYemek + ", alkolse " + kdvAlkol);


            Console.ReadKey();


        }
    }
}
