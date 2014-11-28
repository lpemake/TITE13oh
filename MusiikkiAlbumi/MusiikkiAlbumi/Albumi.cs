using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusiikkiAlbumi
{
    class Albumi
    {
        private string nimi;
        // lista kappaleista
        private List<Kappale> kappaleet
            = new List<Kappale>();

        public Albumi(string nimi)
        {
            this.nimi = nimi;
        }

        public void Lisaa(Kappale k)
        {
            // lisätään uusi kappale
            // listan perään
            kappaleet.Add(k);
        }

        public override string ToString()
        {
            // Palautetaan albumin nimi
            // ja kappaleiden tiedot yhdessä
            // merkkijonossa
            string s = this.nimi + "\n";
            for (int i = 0; i < kappaleet.Count; i++)
            {
                Kappale k = kappaleet[i];
                s += k.ToString() + "\n";
                // StringBuilder olisi parempi
            }
            return s;
        }
    }
}
