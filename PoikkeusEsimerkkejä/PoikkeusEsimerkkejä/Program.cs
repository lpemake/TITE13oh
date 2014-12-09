using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoikkeusEsimerkkejä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku:");
            string s = Console.ReadLine();
            int luku;
            if (int.TryParse(s, out luku))
            {
                double x = luku * luku;
            }

            try
            {
                luku = int.Parse(s);
                double x = luku * luku;
            }
            catch (Exception e)
            {
                Console.WriteLine("virheellinen syöte");
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }

            int a = 4;
            int b = 0;
            int c = -1;

            if (b != 0)
                c = a / b;

            try
            {
                c = a / b;
            }
            catch (Exception)
            {

            }

            int[] t = new int[5];
            c = t[5];
        }
    }
}
