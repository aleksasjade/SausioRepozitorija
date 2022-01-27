using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Skaiciuotuvas
    {
        public int skaicius1;
        public int skaicius2;

        public Skaiciuotuvas(int spirmasSkaicius, int antrasSkaicius)
        {
            skaicius1 = spirmasSkaicius;
            skaicius2 = antrasSkaicius;
        }

        public void Suma()
        {
            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        }
        public void Skirtumas()
        {
            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        }
        public void Sandauga()
        {
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        }
        public void Dalyba()
        {
            Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2}");
        }

    }
}
