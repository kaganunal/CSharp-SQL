using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KisiselOzellikler2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kagan oguzKagan = new Kagan
            {
                Ad = "Oguz Kagan",
                Soyad = "Unal",
                DogumTarihi = Convert.ToDateTime("21.10.1998"),
                Yas = 24,
                Kilo = 73.6,
                Boy = 183,
                BildigiDiller = new List<string> { "İngilizce B2", "Almanca A2" },
                MedeniHal = "Bekar",
                EMail = "oguzkaganu@gmail.com",
                EhliyetTipi = "B",
                Meslek = "Yıldızımsı Yazılımcı",
                BildigiProgramlar = new List<string> { "C# (Advanced)", "Microsoft SQL Server (Advanced)", "T-SQL (Advanced)", "HTML", "Cascading Style Sheets (CSS)", "JavaScript", "ASP.NET Core", "ASP.NET Web API", "AutoCAD (Advanced)", "Revit (Beginner)", "Primavera P6 (Beginner)", "Slide 2 (Beginner)", "MS Project(Beginner)", "MS Office (Advanced)" },
                TamirYapabiliyorMu = true,
                AkademikGecmis = new List<string> { "Hacettepe University, Ankara/ Turkey, August2016 - September2021\r\nB.Sc. | Engineering Department | Civil Engineering\r\nEnglish (2.89 GPA)", "Middle East Technical University, Ankara/Turkey, February 2022 - Ongoing\r\nM.Sc. | Graduate School of Natural and Applied Sciences | Civil Engineering\r\nConstruction Materials Division (3.67 GPA)" }
            };

            oguzKagan.GetKisiselBilgiler();

            Kagan.Topla();

            Console.ReadKey();


        }

    }
}
