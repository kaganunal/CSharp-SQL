using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci
{
    /// <summary>
    /// Static menüler classı içinde oluşturduğumuz dictionary sayesinde ürünlerin hem ismini hem de fiyatını istediğimiz formda kullanabiliriz.
    /// </summary>
    public static class Menuler
    {
        public static Dictionary<string, decimal> menuDictionary = new Dictionary<string, decimal>();
        /// <summary>
        /// Elimizdeki default menüleri menuDictionary'sine eklemek için bu constructoru kullanıyoruz. Daha sonra yeni menü eklemek istediğimizde direkt bu dictionarye ekleyebileceğiz.
        /// </summary>
        static Menuler()
        {
            menuDictionary.Add("Big King Menü", 95.00m);
            menuDictionary.Add("Double King Chicken Menü", 89.00m);
            menuDictionary.Add("Steakhouse Menü", 119.00m);
            menuDictionary.Add("Whooper Menü", 99.00m);
            menuDictionary.Add("Whooper Jr. Menü", 75.00m);
            menuDictionary.Add("Chicken Royale Menü", 84.00m);
        }
    }
}



