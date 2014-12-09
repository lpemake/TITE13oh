using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perinta11
{
    abstract class Monikulmio : Kuvio
    {
        
        public double Kanta { get; set; }
        public double Korkeus { get; set; }

        public Monikulmio(double kanta, double korkeus)
        {
            Kanta = kanta;
            Korkeus = korkeus;
            base.Nimi = "Monikulmio";
        }

    }

    class Kolmio : Monikulmio
    {
        public Kolmio(double kanta, double korkeus)
            : base(kanta, korkeus)
        {
            base.Nimi = "Kolmio";
        }

        public override double PintaAla()
        {
            return Kanta * Korkeus / 2;
        }
    }

    class Suorakaide : Monikulmio
    {
        public Suorakaide(double kanta, double korkeus)
            : base (kanta, korkeus)
        {
            base.Nimi = "Suorakaide";
        }

        public override double PintaAla()
        {
            return Kanta * Korkeus;
        }
    }
 


    class Program
    {
        static void Main(string[] args)
        {
            // Monikulmio-luokka on abstrakti, eikä siitä voi tehdä oliota
            //Monikulmio mk = new Monikulmio(4, 5);
            Kolmio k = new Kolmio(4, 5);
            Suorakaide s = new Suorakaide(4, 5);
            Ympyra y = new Ympyra(3);

            // lista kuvioista
            List<Kuvio> kuviot = new List<Kuvio>();
            //kuviot.Add(mk);
            kuviot.Add(k);
            kuviot.Add(s);
            kuviot.Add(y);
            double pintaAlojenSumma = 0;
            for (int i = 0; i < kuviot.Count; i++)
            {
                Kuvio x = kuviot[i];
                Console.WriteLine(x.ToString());
                // kutsuttava pinta-alan laskenta määräytyy
                // olion tyypin mukaan (kolmio, suorakaide, ympyrä...)                
                pintaAlojenSumma += x.PintaAla();
            }

            int valinta = 2;
            // viittausmuuttuja m on kantaluokan tyyppiä
            Monikulmio m;
            if (valinta == 1)
            {
                m = new Suorakaide(2, 2);
            }
            else
            {
                m = new Kolmio(2, 2);
            }
            // Ppinta-alan laskenta määräytyy olion tyypin mukaan,
            // ei olioviittauksen tyypin mukaan
            double pintaAla = m.PintaAla();
            Console.WriteLine(pintaAla);
        }
    }

    public class Ympyra : Kuvio
    {
        // säde
        public double Sade { get; set; }
        // konstruktori
        public Ympyra(double sade) //: base()
        {
            this.Sade = sade;
            base.Nimi = "Ympyrä";
        }
        // pinta-alan laskenta
        public override double PintaAla()
        {
            return Math.PI * Sade * Sade;
        }
    }

    public abstract class Kuvio
    {
        public string Nimi { get; protected set; }

        public Kuvio()
        {
            Nimi = "Pelkkä kuvio";
        }

        public abstract double PintaAla();

        public override string ToString()
        {
            return Nimi + ": " + PintaAla();
        }
    }
}
