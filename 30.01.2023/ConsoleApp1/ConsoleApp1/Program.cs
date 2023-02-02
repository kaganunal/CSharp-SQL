using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region "Soru 1"
            Random rnd = new Random();
            int[] sayilar = new int[30];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 10000);
            }

            Array.Sort(sayilar);

            int count = 0;
            Console.WriteLine("-Oluşturulan sayılar \n");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("-İkiye tam bölünenler \n ");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }

            Console.WriteLine("\n-Hem ikiye hemde üçe tam bölünenler \n ");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0 && item % 3 == 0)
                {
                    Console.Write(item + " ");
                    count++;
                }
            }
            Console.WriteLine("\n-İkiye ve üçe bölünen sayısı => " + count + "\n");

            Console.ReadKey();

            #endregion
            

            #region"Soru 2"
            {
                int[] sayilar = new int[10];

                Random rnd = new Random();

                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(1, 10);
                }
                foreach (var item in sayilar)
                {
                    Console.WriteLine(item + " ");
                }
                int sayac = 0;
                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i] == 2)
                    {
                        Console.WriteLine(i + 1);
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("2 değeri bulunamamıştır.");
                }
                Console.WriteLine($"Dizi içerisinde 2 rakamı {sayac} kere geçmektedir.");
                Console.ReadLine();
            }

            #endregion
            

            #region "Soru 3"
            {
                int[] sayilar = new int[10];
                Random rnd = new Random();

                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(1, 10);
                }

                Console.WriteLine("\nKopyalanacak dizi ");
                foreach (var item in sayilar)
                {
                    Console.Write(item + " ");
                }

                int[] sayilar2 = new int[sayilar.Length];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar2[i] = sayilar[i];
                }
                Console.WriteLine("\nKopyalanan dizi Copy kullanılmadan:");
                foreach (var item in sayilar2)
                {
                    Console.Write(item + " ");
                }

                int[] sayilar3 = new int[sayilar.Length];
                Array.Copy(sayilar, sayilar3, sayilar.Length);

                Console.WriteLine("\nKopyalanan dizi Copy ve Lengthe göre:");
                foreach (var item in sayilar3)
                {
                    Console.Write(item + " ");
                }

                int[] sayilar4 = new int[10];
                Array.Copy(sayilar, sayilar4, 10);

                Console.WriteLine("\nKopyalanan dizi Copy ile:");
                foreach (var item in sayilar4)
                {
                    Console.Write(item + " ");
                }


                int[] sayilar5 = (int[])sayilar.Clone();

                Console.WriteLine("\nKopyalanan dizi Clone ile:");
                foreach (var item in sayilar5)
                {
                    Console.Write(item + " ");
                }

                int[] sayilar6 = new int[10];
                sayilar.CopyTo(sayilar6, 0);

                Console.WriteLine("\nKopyalanan dizi Copy To ile:");

                foreach (var item in sayilar6)
                {
                    Console.Write(item + " ");
                }

                Console.ReadKey();
        }

            #endregion
            

            #region "Soru 4"
            {
                int[] sayilar = new int[10];
                Random rnd = new Random();

                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(1, 10);
                }

                Console.WriteLine("Dizi elemanları :");
                foreach (var item in sayilar)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\nSayıların toplamı :" + sayilar.Sum());
                Console.WriteLine("Sayıların en büyüğü: " + sayilar.Max());
                Console.WriteLine("Sayıların en küçüğü: " + sayilar.Min());
                Console.WriteLine("Sayıların ortalaması: " + sayilar.Average());
                Console.WriteLine("Sayıların ilki: " + sayilar.First());
                Console.WriteLine("Sayıların sonuncusu: " + sayilar.Last());

                Console.ReadKey();
            
            }
            #endregion
            
            #region "Soru 5"
            {
                int[] sayilar = new int[5];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    Console.WriteLine("Lütfen sayı giriniz: ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Dizi elemanları :");
                foreach (var item in sayilar)
                {
                    Console.Write(item + " ");
                }
                int sayac = 0;

                foreach (int item in sayilar)
                {
                    if (item % 10 == 0)
                    {
                        sayac++;
                    }
                }
                Console.WriteLine("\nDizide sonu '0' ile biten toplam sayı: " + sayac);
                Console.ReadKey();
            }
            #endregion
            

            #region "Soru 6"
            {
                int[] sayilar = new int[10];

                Random rnd = new Random();

                for (int i = 0; i < sayilar.Length; i++)
                {
                    sayilar[i] = rnd.Next(1, 1000);
                }
                Console.WriteLine("Dizi elemanları :");
                foreach (var item in sayilar)
                {
                    Console.Write(item + " ");
                }
                int total = 0;
                int sayac = 0;
                foreach (var item in sayilar)
                {
                    if (item <= 600 && item > 500)
                    {
                        total += item;
                    }
                    else if (item <= 500 && item >= 100)
                    {
                        sayac++;
                    }
                }

                Console.WriteLine("\n500 ile 600 arasındaki rastgele sayıların toplamı: " + total);
                Console.WriteLine("100 ile 500 arasındaki rastgele sayıların toplamı: " + sayac);
                Console.ReadLine();
            }
            #endregion

            
            #region "Soru 7"
            {
                string[] isimler = new string[5];

                for (int i = 0; i < isimler.Length; i++)
                {
                    Console.WriteLine($"Lütfen {i+1}. ismi giriniz: ");
                    isimler[i] = Convert.ToString(Console.ReadLine());
                }

                Console.WriteLine("Dizi elemanları :");
                foreach (var item in isimler)
                {
                    Console.Write(item + " ");
                }
 
                Array.Sort(isimler);
                Console.WriteLine("\nDizinin alfabetik sıralanmış elemanları :");
                foreach (string item in isimler)
                {
                    Console.Write(item + " ");
                }

                Console.ReadKey();
            }
            #endregion
            */
            #region
            {
                Random rnd = new Random();



                for (int i = 0;i < 50; i++)
                {

                }
                string mustafa = Guid.NewGuid().ToString();
                Console.WriteLine(mustafa);
                Console.ReadKey();
            }
            #endregion

            #region
            {

            }
            #endregion

            #region
            {

            }
            #endregion
        }
    }
}
