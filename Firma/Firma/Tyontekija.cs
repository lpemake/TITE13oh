using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Tyontekija : Henkilo
    {
        public double Palkka { get; set; }

        public Tyontekija(string etunimi, string sukunimi,
            int syntymavuosi, double palkka)
            : base(etunimi, sukunimi, syntymavuosi)
        {
            this.Palkka = palkka;            
        }

        public override string ToString()
        {
            return base.ToString() + " " + Palkka;
        }

        // tämä metodi voidaan korvata perityssä luokassa
        public virtual void PalkanKorotus(double prosentti)
        {
            Palkka += Palkka * prosentti / 100.0;
        }
    }
}
