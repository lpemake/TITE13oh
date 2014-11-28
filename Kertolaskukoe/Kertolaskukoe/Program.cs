using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertolaskukoe
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Kysymys k = new Kysymys();
                Console.WriteLine(k.KysyLaskutoimitus());
                int vastaus = int.Parse(Console.ReadLine());

                if (k.TarkistaVastaus(vastaus))
                    Console.WriteLine("oikein");
                else
                    Console.WriteLine("väärin");
            }
        }
    }
}
