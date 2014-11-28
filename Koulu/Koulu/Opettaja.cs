using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Opettaja
    {
        private string etunimi;
        private string sukunimi;
        private double palkka;

        public Opettaja(string etunimi, string sukunimi, double palkka,
            int syntymaVuosi)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.palkka = palkka;
            this.Syntymavuosi = syntymaVuosi;
        }

        // getteri perinteisellä tyylillä
        public string GetEtunimi()
        {
            return etunimi;
        }
        public string GetSukunimi()
        {
            return sukunimi;
        }
        // Property-tyylillä
        public double Palkka
        {
            get
            {
                return palkka;
            }
            set
            {
                palkka = value;
            }
        }
        // kokonaan Propertyna
        public int Syntymavuosi
        {
            get;
            private set; 
        }

        public override string ToString()
        {
            return sukunimi;
        }

    }
}
