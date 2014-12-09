using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaalitTiedosto
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Lista ehdokkaista
            List<Ehdokas> ehdokkaat = new List<Ehdokas>();

            // Read the file and display it line by line.
            System.IO.StreamReader file = null;
            try
            {
                file =
                   new System.IO.StreamReader("c:\\tmp\\ehdokkaat.txt");
                while ((line = file.ReadLine()) != null)
                {
                    // poimitaan rivillä olevat tiedot erilleen
                    string[] palaset = line.Split();

                    try
                    {
                        // luodaan Ehdokas-olio                    
                        Ehdokas e = new Ehdokas(palaset[0], palaset[1], palaset[2],
                            int.Parse(palaset[3]));

                        // lisätään ehdokas listaan
                        ehdokkaat.Add(e);

                        counter++;
                    }
                    catch { }
                }
                for (int i = 0; i < ehdokkaat.Count; i++)
                {
                    Console.WriteLine(ehdokkaat[i].ToString());
                }
            }
                /*
            catch (FormatException)
            {
                Console.WriteLine("Virhe äänimäärässä");
            }*/
            catch (System.IO.IOException)
            {
                Console.WriteLine("Virhe tiedoston käsittelyssä");
            }
            finally
            {
                if (file != null)
                    file.Close();
            }


        }
    }
}
