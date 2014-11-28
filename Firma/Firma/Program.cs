using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo hemmo = new Henkilo("eka", "vekara", 1933);
            Tyontekija mikki = new Tyontekija("Mikki", "Hiiri", 1923, 1000);
            Tyontekija hessu = new Tyontekija("Hessu", "Hopo", 1923, 1000);
            Paallikko simo = new Paallikko("Simo", "Sisu", 1920,
                1000, "Poliisimestari");

            // oliot voidaan laittaa kantaluokan tyyppiseen listaan
            List<Henkilo> henkilot = new List<Henkilo>();
            henkilot.Add(hemmo);
            henkilot.Add(mikki);
            henkilot.Add(hessu);
            henkilot.Add(simo);
            for (int i = 0; i < henkilot.Count; i++)
            {
                Henkilo h = henkilot[i];                
                Console.WriteLine(h.ToString());
            }

            Console.WriteLine("-----------------------------------");
            List<Tyontekija> tyontekijat = new List<Tyontekija>();
            tyontekijat.Add(mikki);
            tyontekijat.Add(hessu);
            tyontekijat.Add(simo);
            for (int i = 0; i < tyontekijat.Count; i++)
            {
                Tyontekija h = tyontekijat[i];
                h.PalkanKorotus(10);
                Console.WriteLine(h.ToString());
            }
        }
    }
}
