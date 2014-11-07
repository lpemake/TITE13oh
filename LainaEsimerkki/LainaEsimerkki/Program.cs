using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LainaEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Laina autolaina = new Laina("Petteri",
                100000, 5);

            Console.WriteLine(autolaina.ToString());

            int kk = 0;
            while (autolaina.GetSaldo() > 0)
            {
                autolaina.Lyhennys(1000);
                double s = autolaina.GetSaldo();
                Console.WriteLine(kk + ": " + s);
                kk++;
            }
        }
    }
}
