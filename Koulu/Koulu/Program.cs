using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Program
    {
        static void Main(string[] args)
        {
            Opettaja ope = new Opettaja("Hannu", "Hanhi",
                2000, 1953);
            //ope.etunimi = "";
            Console.WriteLine(ope.GetSukunimi());

            ope.Palkka = 1234;
            Console.WriteLine(ope.Syntymavuosi);

            Opiskelija aku = new Opiskelija("Aku", "Ankka", 100);
            Opiskelija mikki = new Opiskelija("Mikki", "Hiiri", 100);
            Opiskelija hessu = new Opiskelija("Hessu", "Hopo", 100);

            Koulutusohjelma koulu = new Koulutusohjelma("Alakoulu");
            koulu.Ope = ope;
            koulu.LisaaOpiskelija(aku);
            koulu.LisaaOpiskelija(mikki);
            koulu.LisaaOpiskelija(hessu);

            Console.WriteLine(koulu.ToString());
        }
    }
}
