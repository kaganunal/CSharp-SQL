using System;
using System.Text;

namespace IntroductiontoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Merhaba Bilge Adam Boost12 Sınıfı'na hoşgeldiniz! İsminizi öğrenebilir miyiz?");

            string isim = Console.ReadLine();
            
            Console.WriteLine(isim);
          
            Console.WriteLine("Merhaba " + isim + " hoşgeldin!");


            Console.WriteLine("Merhaba {0}", isim);

            Console.WriteLine("Merhaba {0} Bey", isim);

            Console.WriteLine($"Merhaba {isim}");

            Console.WriteLine("Lütfen soyisminizi giriniz: ");

            string soyisim = Console.ReadLine();

            Console.WriteLine("Merhaba " + isim +" "+ soyisim + " hoşgeldin!"); //{0} iilk girilen değeri temsil ediyor(isim)  {1} ikinci girilen değeri temsil ediyor

            Console.WriteLine("Merhaba {0} {1}" + isim, soyisim);

            Console.WriteLine($"Merhaba {isim +" " +soyisim}");


            Console.ReadKey();
        }
    }


}
