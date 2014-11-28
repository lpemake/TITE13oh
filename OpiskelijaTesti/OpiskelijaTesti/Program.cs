using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskelijaTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija antti =
                new Opiskelija("Antti",
                    "Rannanjärvi",
                    1833);
            Opiskelija antti2 =
                new Opiskelija("Antti",
                    "Isotalo",
                    1833);
            Opiskelija jaakko =
                new Opiskelija("Jaakko",
                    "Pukkila",
                    1833);

            antti.SetOpintopisteet(10);

            int ika = antti.LaskeIka(2014);
            Console.WriteLine(ika);

            Console.WriteLine(antti.ToString());
            Console.WriteLine(antti2.ToString());
            Console.WriteLine(jaakko.ToString());

            int vuodet =
                antti.LaskeIka(DateTime.Now);
            Console.WriteLine(vuodet);

            Console.WriteLine(Opiskelija.GetLaskuri());
        }
    }
}
