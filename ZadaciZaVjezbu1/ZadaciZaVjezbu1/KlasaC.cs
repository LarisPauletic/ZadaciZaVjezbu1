using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu1
{
    class KlasaC
    {
        public int Zbroj(int[] upis)
        {
            int sum = 0;
            for (int i = 0; i < upis.Length; i++)
                sum += upis[i];
            return sum;
        }
        public double Prosjek(int[] upis)
        {
            int sum = 0;
            for (int i = 0; i < upis.Length; i++)
                sum += upis[i];
            return (double)sum / upis.Length;
        }
    }
}
