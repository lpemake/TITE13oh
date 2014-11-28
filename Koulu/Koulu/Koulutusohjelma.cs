using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulu
{
    class Koulutusohjelma
    {
        public string Nimi { get; set; }
        public Opettaja Ope { get; set; }
        public List<Opiskelija> opiskelijat = new List<Opiskelija>();

        public Koulutusohjelma(string nimi)
        {
            Nimi = nimi;
        }

        public void LisaaOpiskelija(Opiskelija o)
        {
            opiskelijat.Add(o);
        }

        public override string ToString()
        {
            // tulosta yhtenä merkkijonona
            // - Koulun nimi
            // - Opettajan tiedot
            // - Kaikkien oppilaiden tiedot
            // Tee normi-merkkijonojen plussaamisella tai StringBuilderillä
            StringBuilder sb = new StringBuilder();
            sb.Append(Nimi + "\n");
            sb.Append(Ope.ToString());
            for (int i = 0; i < opiskelijat.Count; i++)
                sb.AppendLine(opiskelijat[i].ToString());

            return sb.ToString();
            
            /*string s = Nimi;
            s += Ope.ToString();            

            for (int i = 0; i < opiskelijat.Count; i++)
			{
                s += opiskelijat[i].ToString();
			}

            return s;*/
        }
    }
}
