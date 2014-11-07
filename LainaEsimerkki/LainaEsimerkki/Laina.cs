using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LainaEsimerkki
{
    class Laina
    {
        private double saldo;
        private string tilinomistaja;
        private double korkoPros;

        public Laina(string nimi, double lainamaara,
            double korkoPros)
        {
            this.tilinomistaja = nimi;
            this.saldo = lainamaara;
            this.korkoPros = korkoPros;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void Lyhennys(double kuukausiEra)
        {
            // maksetaan kuukausierästä ensin
            // korko ja lyhennetään lainaa lopulla
            double korkoEuroissa =
                saldo * korkoPros / 12.0 / 100.0;

            double lyhennys = kuukausiEra - korkoEuroissa;

            this.saldo -= lyhennys;
        }

        public override string ToString()
        {
            return tilinomistaja + " " + saldo;
        }
    }
}
