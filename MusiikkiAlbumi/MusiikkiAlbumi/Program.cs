using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusiikkiAlbumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi a
                = new Albumi("We created the world");

            Kappale yellowhouse =
                new Kappale("Yellow house", "Topi",
                    new TimeSpan(0, 3, 19));
            Kappale b =
                new Kappale("B", "Henkka",
                    new TimeSpan(0, 2, 50));

            a.Lisaa(yellowhouse);
            a.Lisaa(b);

            a.Lisaa(new Kappale("The sirens",
                "Joku",
                new TimeSpan(0, 4, 5)));

            Console.WriteLine(a.ToString());
        }
    }
}
