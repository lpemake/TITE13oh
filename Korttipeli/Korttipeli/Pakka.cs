using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipeli
{
    class Pakka
    {
        private List<Kortti> kortit =
            new List<Kortti>();

        // shuffle

        public Pakka()
        {
            // luodaan kortit
            string[] maat = { "Hertta", "Ruutu", "Risti", "Pata" };

            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    // luodaan uusi kortti
                    Kortti k = new Kortti(maat[j], i);
                    // lisätään kortti pakkaan
                    kortit.Add(k);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < kortit.Count; i++)
            {
                sb.AppendLine(kortit[i].ToString());
            }

            return sb.ToString();
        }
    }
}
