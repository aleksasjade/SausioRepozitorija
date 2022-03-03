using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11
{
    internal class Skaicius : IMatematika
    {
        public readonly int skaicius1;

        public Skaicius(int Skaicius1)
        {
            skaicius1 = Skaicius1;
        }

        public int Atimti(int Skaicius1)
        {
            return skaicius1 - Skaicius1;
        }

        public double Padalinti(double Skaicius1)
        {
            return skaicius1 / Skaicius1;
        }

        public int Padauginti(int Skaicius1)
        {
            return skaicius1 * Skaicius1;
        }

        public int PakeltiKubu()
        {
            return skaicius1 * skaicius1 * skaicius1;
        }


        public int PakeltiKvadratu()
        {
            return skaicius1 * skaicius1;
        }

        public int Prideti(int Skaicius1)
        {
            return skaicius1 + Skaicius1;
        }
    }
}
