using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜçSayıToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen üç sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            double ortalama = Convert.ToDouble(sayi1+sayi2+ sayi3) /3 ;
            double ortalama2 = (sayi1+sayi2+ sayi3) /3d ;
            double ortalama3 =  (sayi1+sayi2+ sayi3) /3.0 ;

            Console.WriteLine("Girdiğiniz üç sayının ortalaması: " + ortalama); 
            Console.WriteLine("Girdiğiniz üç sayının ortalaması: " + ortalama2); 
            Console.WriteLine("Girdiğiniz üç sayının ortalaması: " + ortalama3); 

            Console.ReadKey();  
        }
    }
}
