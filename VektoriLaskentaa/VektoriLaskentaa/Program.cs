using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektoriLaskentaa
{
    class Program
    {
        static void Main(string[] args)
        {
            Vektori a = new Vektori(2, 3, 0);
            Vektori b = new Vektori(6, 4, 0);

            a.Lisaa(b);
            Console.WriteLine(a.ToString());

            Vektori c = Vektori.Summa(a, b);
            Console.WriteLine(c.ToString());

            double d = c.Pituus();
            Console.WriteLine(d);

            // vektori CD
            Vektori cc = new Vektori(2, 2, 0);
            Vektori dd = new Vektori(6, 4, 0);

            Vektori cd = Vektori.Erotus(dd, cc);
            Console.WriteLine(cd.ToString());

            //Vektori c = a + b;
        }
    }
}
