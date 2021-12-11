using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] upis = new int[5];

            Console.WriteLine("Upišite 5 cijelih brojeva:");
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                upis[i] = Convert.ToInt32(s);
            }
            KlasaC x = new KlasaC();
            Console.Write("Zbroj upisanih brojeva je: ");
            int zbroj = x.Zbroj(upis);
            Console.WriteLine(zbroj);

            Console.Write("Prosjek upisanih brojeva je:");
            double prosjek = x.Prosjek(upis);
            
            Console.WriteLine(prosjek);

            Console.ReadKey();
        }
    }
}
